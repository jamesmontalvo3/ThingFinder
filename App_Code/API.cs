using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

/// <summary>
/// Summary description for WebService
/// </summary>
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
[System.Web.Script.Services.ScriptService]
public class API : System.Web.Services.WebService
{

    public API()
    {

        //Uncomment the following line if using designed components
        //InitializeComponent();
    }

    [WebMethod]
    [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
    public void GetFullTreeByPartNumber(string PartNumber)
    {

        Context.Response.Clear();
        Context.Response.ContentType = "application/json";

        Dictionary<string, Item> obj = GetFullTreeFromDb(PartNumber);


        var jss = new JavaScriptSerializer();
        string output = jss.Serialize(obj);
        //string output = JsonConvert.SerializeObject(obj);

        Context.Response.Write(output);

    }

    [WebMethod]
    [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
    public void GetFullTreeByPartNumberJSONP(string PartNumber, string Callback)
    {

        Context.Response.Clear();
        Context.Response.ContentType = "application/javascript";

        Dictionary<string, Item> obj = GetFullTreeFromDb(PartNumber);


        var jss = new JavaScriptSerializer();
        string output = jss.Serialize(obj);
        output = Callback + "(" + output + ");";

        Context.Response.Write(output);

    }


    [WebMethod]
    [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
    public void GetFullTreeByCagePartSerial(string CageCode, string PartNumber, string SerialNumber)
    {
        Context.Response.Clear();
        Context.Response.ContentType = "application/json";

        Dictionary<string, Item> obj = GetFullTreeFromDb(CageCode, PartNumber, SerialNumber);

        var jss = new JavaScriptSerializer();
        string output = jss.Serialize(obj);

        Context.Response.Write(output);
    }


    [WebMethod]
    [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
    public void GetFullTreeByCagePartSerialJSONP(string CageCode, string PartNumber, string SerialNumber, string Callback)
    {
        Context.Response.Clear();
        Context.Response.ContentType = "application/javascript";

        Dictionary<string, Item> obj = GetFullTreeFromDb(CageCode, PartNumber, SerialNumber);

        var jss = new JavaScriptSerializer();
        string output = jss.Serialize(obj);
        output = Callback + "(" + output + ");";

        Context.Response.Write(output);
    }

    public List<Item> GetFlatFromDb()
    {

        IMSDataContext db = new IMSDataContext();
        IEnumerable<ITEMTREE> results = db.ExecuteQuery<ITEMTREE>
            (@"	WITH myTree (Id, ParentId, LocPart)
	            AS (
	            -- anchor member declaration
	            SELECT ID, ID_PARENT, LOCATION_PART FROM ITEMTREE WHERE PART_NUMBER='some-part-number'
	            UNION ALL
	            -- recursive member declaration
	            SELECT ITEMTREE.ID, ITEMTREE.ID_PARENT, ITEMTREE.LOCATION_PART FROM ITEMTREE
	            INNER JOIN myTree ON myTree.ParentId = ITEMTREE.ID
	            )
	            SELECT DISTINCT * FROM ITEMTREE INNER JOIN myTree ON myTree.Id = ITEMTREE.ID"
            );

        List<Item> items = new List<Item>();

        foreach (ITEMTREE itemtree in results)
        {
            items.Add(new Item(itemtree));
        }


        return items;
    }


    public Dictionary<string, Item> GetFullTreeFromDb(string PartNumber)
    {

        IMSDataContext db = new IMSDataContext();

        IEnumerable<ITEMTREE> results = db.ExecuteQuery<ITEMTREE>
        (@"	WITH ancestors (Id, ParentId)
            AS (
            -- anchor member declaration
            SELECT ID, ID_PARENT FROM ITEMTREE WHERE PART_NUMBER = {0}

            UNION ALL

            -- recursive member declaration
            SELECT ITEMTREE.ID, ITEMTREE.ID_PARENT FROM ITEMTREE
            INNER JOIN ancestors ON ancestors.ParentId = ITEMTREE.ID
            ),

            descendants (Id, ParentId)
            AS (
            -- anchor member declaration
            SELECT ID, ID_PARENT FROM ITEMTREE WHERE PART_NUMBER = {1}

            UNION ALL

            -- recursive member declaration
            SELECT ITEMTREE.ID, ITEMTREE.ID_PARENT FROM ITEMTREE
            INNER JOIN descendants ON descendants.Id = ITEMTREE.ID_PARENT
            )

            SELECT DISTINCT * FROM ITEMTREE RIGHT JOIN ancestors ON ancestors.Id = ITEMTREE.ID

            UNION

            SELECT DISTINCT * FROM ITEMTREE RIGHT JOIN descendants ON descendants.Id = ITEMTREE.ID", PartNumber, PartNumber
        );


        Dictionary<string, Item> items = new Dictionary<string, Item>();

        List<string> IDs = new List<string>();

        foreach (ITEMTREE itemtree in results)
        {
            items.Add(itemtree.ID.ToString(), new Item(itemtree));
            IDs.Add(itemtree.ID.ToString());
        }

        int id_parent;

        foreach (string id in IDs)
        {

            if (items[id].ID_PARENT != null)
            {
                id_parent = items[id].ID_PARENT.GetValueOrDefault();
                items[id_parent.ToString()].addChild(items[id]);

            }

        }

        // clear out non-root items (non-root items now contained
        // within parent-child structure below root items)
        foreach (string id in IDs)
        {
            if (items[id].ID_PARENT != null)
            {
                items.Remove(id);
            }
        }

        return items;
    }




    public Dictionary<string, Item> GetFullTreeFromDb(string CageCode, string PartNumber, string SerialNumber)
    {

        IMSDataContext db = new IMSDataContext();

        IEnumerable<ITEMTREE> results = db.ExecuteQuery<ITEMTREE>
        (@"	WITH ancestors (Id, ParentId)
            AS (
            -- anchor member declaration
            SELECT ID, ID_PARENT FROM ITEMTREE WHERE CAGE = {0} AND PART_NUMBER = {1} AND S_N = {2}

            UNION ALL

            -- recursive member declaration
            SELECT ITEMTREE.ID, ITEMTREE.ID_PARENT FROM ITEMTREE
            INNER JOIN ancestors ON ancestors.ParentId = ITEMTREE.ID
            ),

            descendants (Id, ParentId)
            AS (
            -- anchor member declaration
            SELECT ID, ID_PARENT FROM ITEMTREE WHERE CAGE = {0} AND PART_NUMBER = {1} AND S_N = {2}

            UNION ALL

            -- recursive member declaration
            SELECT ITEMTREE.ID, ITEMTREE.ID_PARENT FROM ITEMTREE
            INNER JOIN descendants ON descendants.Id = ITEMTREE.ID_PARENT
            )

            SELECT DISTINCT * FROM ITEMTREE RIGHT JOIN ancestors ON ancestors.Id = ITEMTREE.ID

            UNION

            SELECT DISTINCT * FROM ITEMTREE RIGHT JOIN descendants ON descendants.Id = ITEMTREE.ID", CageCode, PartNumber, SerialNumber
        );


        Dictionary<string, Item> items = new Dictionary<string, Item>();

        List<string> IDs = new List<string>();

        foreach (ITEMTREE itemtree in results)
        {
            items.Add(itemtree.ID.ToString(), new Item(itemtree));
            IDs.Add(itemtree.ID.ToString());
        }

        int id_parent;

        foreach (string id in IDs)
        {

            if (items[id].ID_PARENT != null)
            {
                id_parent = items[id].ID_PARENT.GetValueOrDefault();
                items[id_parent.ToString()].addChild(items[id]);

            }

        }

        // clear out non-root items (non-root items now contained
        // within parent-child structure below root items)
        foreach (string id in IDs)
        {
            if (items[id].ID_PARENT != null)
            {
                items.Remove(id);
            }
        }

        return items;
    }

}