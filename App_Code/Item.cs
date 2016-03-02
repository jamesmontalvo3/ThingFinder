using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for Item
/// </summary>
public class Item
{

    public int ID { get; private set; }

    public System.Nullable<int> ID_PARENT { get; private set; }

    public string PART_NUMBER { get; private set; }

    public string S_N { get; private set; }

    public string CAGE { get; private set; }

    public string ACRONYM { get; private set; }

    public string R_OPS { get; private set; }

    public string E_OPS { get; private set; }

    public string BARCODE { get; private set; }

    public string LABEL { get; private set; }

    public string LOCATION_CODE { get; private set; }

    public System.Nullable<decimal> QPU { get; private set; }

    public System.Nullable<decimal> WIDTH { get; private set; }

    public System.Nullable<decimal> HEIGHT { get; private set; }

    public System.Nullable<decimal> LENGTH { get; private set; }

    public System.Nullable<decimal> VOLUME { get; private set; }

    public System.Nullable<decimal> DIAMETER { get; private set; }

    public System.Nullable<decimal> WEIGHT { get; private set; }

    //public System.Nullable<System.DateTime> EXPIRE_DATE { get; private set; }

    //public string ITEM_SCHEMA { get; private set; }

    //public string NOMER { get; private set; }

    public string LAUNCH { get; private set; }

    public string NOTES { get; private set; }

    //public string TYPE { get; private set; }

    //public string HAZARD { get; private set; }

    //public string STATE { get; private set; }

    //public string STATUS { get; private set; }

    //public bool CONTAINER { get; private set; }

    //public bool MOVEABLE { get; private set; }

    //public string BACKGROUND { get; private set; }

    //public string ICON { get; private set; }

    //public bool SHOW_ICON { get; private set; }

    //public System.Nullable<int> IMAGE_X { get; private set; }

    //public System.Nullable<int> IMAGE_Y { get; private set; }

    //public System.Nullable<int> IMAGE_W { get; private set; }

    //public System.Nullable<int> IMAGE_H { get; private set; }

    //public string SYSTEM { get; private set; }

    //public string SUBSYSTEM { get; private set; }

    //public string HOMELOCATION { get; private set; }

    //public string INUSENAME { get; private set; }

    //public System.Nullable<System.DateTime> ACT_DATE { get; private set; }

    //public System.Nullable<System.DateTime> MOVE_DATE { get; private set; }

    //public string USERNAME { get; private set; }

    public string LOCATION_PART { get; private set; }

    //public System.Nullable<System.DateTime> AUDIT_DATE { get; private set; }

    //public System.Nullable<int> AUDIT_STATUS { get; private set; }

    //public string AUDIT_LOCATION { get; private set; }

    //public string FILL_STATUS { get; private set; }

    //public System.Nullable<decimal> EMPTY_SPACE { get; private set; }

    //public string DISPOSE { get; private set; }

    //public string AUDIT_DBNAME { get; private set; }

    //public System.Nullable<int> AUDIT_ID { get; private set; }

    //public string AUDIT_COMMENT { get; private set; }

    //public System.Nullable<bool> RFID_TAG_PRESENT { get; private set; }

    public Dictionary<string, Item> CHILDREN { get; private set; }


    public Item()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Item(ITEMTREE itemtree)
    {
        ID = itemtree.ID;

        ID_PARENT = itemtree.ID_PARENT;

        PART_NUMBER = itemtree.PART_NUMBER;

        S_N = itemtree.S_N;

        CAGE = itemtree.CAGE;

        ACRONYM = itemtree.ACRONYM;

        R_OPS = itemtree.R_OPS;

        E_OPS = itemtree.E_OPS;

        BARCODE = itemtree.BARCODE;

        LABEL = itemtree.LABEL;

        LOCATION_CODE = itemtree.LOCATION_CODE;

        NOTES = itemtree.NOTES;

        LOCATION_PART = itemtree.LOCATION_PART;

        QPU = itemtree.QPU;

        WIDTH = itemtree.WIDTH;

        HEIGHT = itemtree.HEIGHT;

        LENGTH = itemtree.LENGTH;

        VOLUME = itemtree.VOLUME;

        DIAMETER = itemtree.DIAMETER;

        WEIGHT = itemtree.WEIGHT;

        LAUNCH = itemtree.LAUNCH;

        CHILDREN = new Dictionary<string, Item>();
    }

    public void addChild(Item child)
    {
        CHILDREN.Add(child.ID.ToString(), child);
    }

}