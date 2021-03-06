﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="IMS3")]
public partial class IMSDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertITEMTREE(ITEMTREE instance);
  partial void UpdateITEMTREE(ITEMTREE instance);
  partial void DeleteITEMTREE(ITEMTREE instance);
  #endregion
	
	public IMSDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["IMS3ConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public IMSDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public IMSDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public IMSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public IMSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<ITEMTREE> ITEMTREEs
	{
		get
		{
			return this.GetTable<ITEMTREE>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ITEMTREE")]
public partial class ITEMTREE : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private System.Nullable<int> _ID_PARENT;
	
	private string _PART_NUMBER;
	
	private string _S_N;
	
	private string _CAGE;
	
	private string _ACRONYM;
	
	private string _R_OPS;
	
	private string _E_OPS;
	
	private string _BARCODE;
	
	private string _LABEL;
	
	private string _LOCATION_CODE;
	
	private System.Nullable<decimal> _QPU;
	
	private System.Nullable<decimal> _WIDTH;
	
	private System.Nullable<decimal> _HEIGHT;
	
	private System.Nullable<decimal> _LENGTH;
	
	private System.Nullable<decimal> _VOLUME;
	
	private System.Nullable<decimal> _DIAMETER;
	
	private System.Nullable<decimal> _WEIGHT;
	
	private System.Nullable<System.DateTime> _EXPIRE_DATE;
	
	private string _ITEM_SCHEMA;
	
	private string _NOMER;
	
	private string _LAUNCH;
	
	private string _NOTES;
	
	private string _TYPE;
	
	private string _HAZARD;
	
	private string _STATE;
	
	private string _STATUS;
	
	private bool _CONTAINER;
	
	private bool _MOVEABLE;
	
	private string _BACKGROUND;
	
	private string _ICON;
	
	private bool _SHOW_ICON;
	
	private System.Nullable<int> _IMAGE_X;
	
	private System.Nullable<int> _IMAGE_Y;
	
	private System.Nullable<int> _IMAGE_W;
	
	private System.Nullable<int> _IMAGE_H;
	
	private string _SYSTEM;
	
	private string _SUBSYSTEM;
	
	private string _HOMELOCATION;
	
	private string _INUSENAME;
	
	private System.Nullable<System.DateTime> _ACT_DATE;
	
	private System.Nullable<System.DateTime> _MOVE_DATE;
	
	private string _USERNAME;
	
	private string _LOCATION_PART;
	
	private System.Nullable<System.DateTime> _AUDIT_DATE;
	
	private System.Nullable<int> _AUDIT_STATUS;
	
	private string _AUDIT_LOCATION;
	
	private string _FILL_STATUS;
	
	private System.Nullable<decimal> _EMPTY_SPACE;
	
	private string _DISPOSE;
	
	private string _AUDIT_DBNAME;
	
	private System.Nullable<int> _AUDIT_ID;
	
	private string _AUDIT_COMMENT;
	
	private System.Nullable<bool> _RFID_TAG_PRESENT;
	
	private EntitySet<ITEMTREE> _ITEMTREEs;
	
	private EntityRef<ITEMTREE> _ITEMTREE1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnID_PARENTChanging(System.Nullable<int> value);
    partial void OnID_PARENTChanged();
    partial void OnPART_NUMBERChanging(string value);
    partial void OnPART_NUMBERChanged();
    partial void OnS_NChanging(string value);
    partial void OnS_NChanged();
    partial void OnCAGEChanging(string value);
    partial void OnCAGEChanged();
    partial void OnACRONYMChanging(string value);
    partial void OnACRONYMChanged();
    partial void OnR_OPSChanging(string value);
    partial void OnR_OPSChanged();
    partial void OnE_OPSChanging(string value);
    partial void OnE_OPSChanged();
    partial void OnBARCODEChanging(string value);
    partial void OnBARCODEChanged();
    partial void OnLABELChanging(string value);
    partial void OnLABELChanged();
    partial void OnLOCATION_CODEChanging(string value);
    partial void OnLOCATION_CODEChanged();
    partial void OnQPUChanging(System.Nullable<decimal> value);
    partial void OnQPUChanged();
    partial void OnWIDTHChanging(System.Nullable<decimal> value);
    partial void OnWIDTHChanged();
    partial void OnHEIGHTChanging(System.Nullable<decimal> value);
    partial void OnHEIGHTChanged();
    partial void OnLENGTHChanging(System.Nullable<decimal> value);
    partial void OnLENGTHChanged();
    partial void OnVOLUMEChanging(System.Nullable<decimal> value);
    partial void OnVOLUMEChanged();
    partial void OnDIAMETERChanging(System.Nullable<decimal> value);
    partial void OnDIAMETERChanged();
    partial void OnWEIGHTChanging(System.Nullable<decimal> value);
    partial void OnWEIGHTChanged();
    partial void OnEXPIRE_DATEChanging(System.Nullable<System.DateTime> value);
    partial void OnEXPIRE_DATEChanged();
    partial void OnITEM_SCHEMAChanging(string value);
    partial void OnITEM_SCHEMAChanged();
    partial void OnNOMERChanging(string value);
    partial void OnNOMERChanged();
    partial void OnLAUNCHChanging(string value);
    partial void OnLAUNCHChanged();
    partial void OnNOTESChanging(string value);
    partial void OnNOTESChanged();
    partial void OnTYPEChanging(string value);
    partial void OnTYPEChanged();
    partial void OnHAZARDChanging(string value);
    partial void OnHAZARDChanged();
    partial void OnSTATEChanging(string value);
    partial void OnSTATEChanged();
    partial void OnSTATUSChanging(string value);
    partial void OnSTATUSChanged();
    partial void OnCONTAINERChanging(bool value);
    partial void OnCONTAINERChanged();
    partial void OnMOVEABLEChanging(bool value);
    partial void OnMOVEABLEChanged();
    partial void OnBACKGROUNDChanging(string value);
    partial void OnBACKGROUNDChanged();
    partial void OnICONChanging(string value);
    partial void OnICONChanged();
    partial void OnSHOW_ICONChanging(bool value);
    partial void OnSHOW_ICONChanged();
    partial void OnIMAGE_XChanging(System.Nullable<int> value);
    partial void OnIMAGE_XChanged();
    partial void OnIMAGE_YChanging(System.Nullable<int> value);
    partial void OnIMAGE_YChanged();
    partial void OnIMAGE_WChanging(System.Nullable<int> value);
    partial void OnIMAGE_WChanged();
    partial void OnIMAGE_HChanging(System.Nullable<int> value);
    partial void OnIMAGE_HChanged();
    partial void OnSYSTEMChanging(string value);
    partial void OnSYSTEMChanged();
    partial void OnSUBSYSTEMChanging(string value);
    partial void OnSUBSYSTEMChanged();
    partial void OnHOMELOCATIONChanging(string value);
    partial void OnHOMELOCATIONChanged();
    partial void OnINUSENAMEChanging(string value);
    partial void OnINUSENAMEChanged();
    partial void OnACT_DATEChanging(System.Nullable<System.DateTime> value);
    partial void OnACT_DATEChanged();
    partial void OnMOVE_DATEChanging(System.Nullable<System.DateTime> value);
    partial void OnMOVE_DATEChanged();
    partial void OnUSERNAMEChanging(string value);
    partial void OnUSERNAMEChanged();
    partial void OnLOCATION_PARTChanging(string value);
    partial void OnLOCATION_PARTChanged();
    partial void OnAUDIT_DATEChanging(System.Nullable<System.DateTime> value);
    partial void OnAUDIT_DATEChanged();
    partial void OnAUDIT_STATUSChanging(System.Nullable<int> value);
    partial void OnAUDIT_STATUSChanged();
    partial void OnAUDIT_LOCATIONChanging(string value);
    partial void OnAUDIT_LOCATIONChanged();
    partial void OnFILL_STATUSChanging(string value);
    partial void OnFILL_STATUSChanged();
    partial void OnEMPTY_SPACEChanging(System.Nullable<decimal> value);
    partial void OnEMPTY_SPACEChanged();
    partial void OnDISPOSEChanging(string value);
    partial void OnDISPOSEChanged();
    partial void OnAUDIT_DBNAMEChanging(string value);
    partial void OnAUDIT_DBNAMEChanged();
    partial void OnAUDIT_IDChanging(System.Nullable<int> value);
    partial void OnAUDIT_IDChanged();
    partial void OnAUDIT_COMMENTChanging(string value);
    partial void OnAUDIT_COMMENTChanged();
    partial void OnRFID_TAG_PRESENTChanging(System.Nullable<bool> value);
    partial void OnRFID_TAG_PRESENTChanged();
    #endregion
	
	public ITEMTREE()
	{
		this._ITEMTREEs = new EntitySet<ITEMTREE>(new Action<ITEMTREE>(this.attach_ITEMTREEs), new Action<ITEMTREE>(this.detach_ITEMTREEs));
		this._ITEMTREE1 = default(EntityRef<ITEMTREE>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_PARENT", DbType="Int")]
	public System.Nullable<int> ID_PARENT
	{
		get
		{
			return this._ID_PARENT;
		}
		set
		{
			if ((this._ID_PARENT != value))
			{
				if (this._ITEMTREE1.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnID_PARENTChanging(value);
				this.SendPropertyChanging();
				this._ID_PARENT = value;
				this.SendPropertyChanged("ID_PARENT");
				this.OnID_PARENTChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PART_NUMBER", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
	public string PART_NUMBER
	{
		get
		{
			return this._PART_NUMBER;
		}
		set
		{
			if ((this._PART_NUMBER != value))
			{
				this.OnPART_NUMBERChanging(value);
				this.SendPropertyChanging();
				this._PART_NUMBER = value;
				this.SendPropertyChanged("PART_NUMBER");
				this.OnPART_NUMBERChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_S_N", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
	public string S_N
	{
		get
		{
			return this._S_N;
		}
		set
		{
			if ((this._S_N != value))
			{
				this.OnS_NChanging(value);
				this.SendPropertyChanging();
				this._S_N = value;
				this.SendPropertyChanged("S_N");
				this.OnS_NChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CAGE", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
	public string CAGE
	{
		get
		{
			return this._CAGE;
		}
		set
		{
			if ((this._CAGE != value))
			{
				this.OnCAGEChanging(value);
				this.SendPropertyChanging();
				this._CAGE = value;
				this.SendPropertyChanged("CAGE");
				this.OnCAGEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ACRONYM", DbType="VarChar(56)")]
	public string ACRONYM
	{
		get
		{
			return this._ACRONYM;
		}
		set
		{
			if ((this._ACRONYM != value))
			{
				this.OnACRONYMChanging(value);
				this.SendPropertyChanging();
				this._ACRONYM = value;
				this.SendPropertyChanged("ACRONYM");
				this.OnACRONYMChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_R_OPS", DbType="VarChar(80)")]
	public string R_OPS
	{
		get
		{
			return this._R_OPS;
		}
		set
		{
			if ((this._R_OPS != value))
			{
				this.OnR_OPSChanging(value);
				this.SendPropertyChanging();
				this._R_OPS = value;
				this.SendPropertyChanged("R_OPS");
				this.OnR_OPSChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_E_OPS", DbType="VarChar(56)")]
	public string E_OPS
	{
		get
		{
			return this._E_OPS;
		}
		set
		{
			if ((this._E_OPS != value))
			{
				this.OnE_OPSChanging(value);
				this.SendPropertyChanging();
				this._E_OPS = value;
				this.SendPropertyChanged("E_OPS");
				this.OnE_OPSChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BARCODE", DbType="VarChar(9)")]
	public string BARCODE
	{
		get
		{
			return this._BARCODE;
		}
		set
		{
			if ((this._BARCODE != value))
			{
				this.OnBARCODEChanging(value);
				this.SendPropertyChanging();
				this._BARCODE = value;
				this.SendPropertyChanged("BARCODE");
				this.OnBARCODEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LABEL", DbType="VarChar(46)")]
	public string LABEL
	{
		get
		{
			return this._LABEL;
		}
		set
		{
			if ((this._LABEL != value))
			{
				this.OnLABELChanging(value);
				this.SendPropertyChanging();
				this._LABEL = value;
				this.SendPropertyChanged("LABEL");
				this.OnLABELChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOCATION_CODE", DbType="VarChar(40)")]
	public string LOCATION_CODE
	{
		get
		{
			return this._LOCATION_CODE;
		}
		set
		{
			if ((this._LOCATION_CODE != value))
			{
				this.OnLOCATION_CODEChanging(value);
				this.SendPropertyChanging();
				this._LOCATION_CODE = value;
				this.SendPropertyChanged("LOCATION_CODE");
				this.OnLOCATION_CODEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QPU", DbType="Decimal(5,0)")]
	public System.Nullable<decimal> QPU
	{
		get
		{
			return this._QPU;
		}
		set
		{
			if ((this._QPU != value))
			{
				this.OnQPUChanging(value);
				this.SendPropertyChanging();
				this._QPU = value;
				this.SendPropertyChanged("QPU");
				this.OnQPUChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WIDTH", DbType="Decimal(17,5)")]
	public System.Nullable<decimal> WIDTH
	{
		get
		{
			return this._WIDTH;
		}
		set
		{
			if ((this._WIDTH != value))
			{
				this.OnWIDTHChanging(value);
				this.SendPropertyChanging();
				this._WIDTH = value;
				this.SendPropertyChanged("WIDTH");
				this.OnWIDTHChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HEIGHT", DbType="Decimal(17,5)")]
	public System.Nullable<decimal> HEIGHT
	{
		get
		{
			return this._HEIGHT;
		}
		set
		{
			if ((this._HEIGHT != value))
			{
				this.OnHEIGHTChanging(value);
				this.SendPropertyChanging();
				this._HEIGHT = value;
				this.SendPropertyChanged("HEIGHT");
				this.OnHEIGHTChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LENGTH", DbType="Decimal(17,5)")]
	public System.Nullable<decimal> LENGTH
	{
		get
		{
			return this._LENGTH;
		}
		set
		{
			if ((this._LENGTH != value))
			{
				this.OnLENGTHChanging(value);
				this.SendPropertyChanging();
				this._LENGTH = value;
				this.SendPropertyChanged("LENGTH");
				this.OnLENGTHChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VOLUME", DbType="Decimal(17,5)")]
	public System.Nullable<decimal> VOLUME
	{
		get
		{
			return this._VOLUME;
		}
		set
		{
			if ((this._VOLUME != value))
			{
				this.OnVOLUMEChanging(value);
				this.SendPropertyChanging();
				this._VOLUME = value;
				this.SendPropertyChanged("VOLUME");
				this.OnVOLUMEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIAMETER", DbType="Decimal(17,5)")]
	public System.Nullable<decimal> DIAMETER
	{
		get
		{
			return this._DIAMETER;
		}
		set
		{
			if ((this._DIAMETER != value))
			{
				this.OnDIAMETERChanging(value);
				this.SendPropertyChanging();
				this._DIAMETER = value;
				this.SendPropertyChanged("DIAMETER");
				this.OnDIAMETERChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WEIGHT", DbType="Decimal(17,5)")]
	public System.Nullable<decimal> WEIGHT
	{
		get
		{
			return this._WEIGHT;
		}
		set
		{
			if ((this._WEIGHT != value))
			{
				this.OnWEIGHTChanging(value);
				this.SendPropertyChanging();
				this._WEIGHT = value;
				this.SendPropertyChanged("WEIGHT");
				this.OnWEIGHTChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EXPIRE_DATE", DbType="DateTime")]
	public System.Nullable<System.DateTime> EXPIRE_DATE
	{
		get
		{
			return this._EXPIRE_DATE;
		}
		set
		{
			if ((this._EXPIRE_DATE != value))
			{
				this.OnEXPIRE_DATEChanging(value);
				this.SendPropertyChanging();
				this._EXPIRE_DATE = value;
				this.SendPropertyChanged("EXPIRE_DATE");
				this.OnEXPIRE_DATEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ITEM_SCHEMA", DbType="VarChar(40)")]
	public string ITEM_SCHEMA
	{
		get
		{
			return this._ITEM_SCHEMA;
		}
		set
		{
			if ((this._ITEM_SCHEMA != value))
			{
				this.OnITEM_SCHEMAChanging(value);
				this.SendPropertyChanging();
				this._ITEM_SCHEMA = value;
				this.SendPropertyChanged("ITEM_SCHEMA");
				this.OnITEM_SCHEMAChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMER", DbType="VarChar(20)")]
	public string NOMER
	{
		get
		{
			return this._NOMER;
		}
		set
		{
			if ((this._NOMER != value))
			{
				this.OnNOMERChanging(value);
				this.SendPropertyChanging();
				this._NOMER = value;
				this.SendPropertyChanged("NOMER");
				this.OnNOMERChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LAUNCH", DbType="VarChar(20)")]
	public string LAUNCH
	{
		get
		{
			return this._LAUNCH;
		}
		set
		{
			if ((this._LAUNCH != value))
			{
				this.OnLAUNCHChanging(value);
				this.SendPropertyChanging();
				this._LAUNCH = value;
				this.SendPropertyChanged("LAUNCH");
				this.OnLAUNCHChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOTES", DbType="VarChar(1024)")]
	public string NOTES
	{
		get
		{
			return this._NOTES;
		}
		set
		{
			if ((this._NOTES != value))
			{
				this.OnNOTESChanging(value);
				this.SendPropertyChanging();
				this._NOTES = value;
				this.SendPropertyChanged("NOTES");
				this.OnNOTESChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TYPE", DbType="VarChar(6)")]
	public string TYPE
	{
		get
		{
			return this._TYPE;
		}
		set
		{
			if ((this._TYPE != value))
			{
				this.OnTYPEChanging(value);
				this.SendPropertyChanging();
				this._TYPE = value;
				this.SendPropertyChanged("TYPE");
				this.OnTYPEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HAZARD", DbType="VarChar(10)")]
	public string HAZARD
	{
		get
		{
			return this._HAZARD;
		}
		set
		{
			if ((this._HAZARD != value))
			{
				this.OnHAZARDChanging(value);
				this.SendPropertyChanging();
				this._HAZARD = value;
				this.SendPropertyChanged("HAZARD");
				this.OnHAZARDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATE", DbType="VarChar(2)")]
	public string STATE
	{
		get
		{
			return this._STATE;
		}
		set
		{
			if ((this._STATE != value))
			{
				this.OnSTATEChanging(value);
				this.SendPropertyChanging();
				this._STATE = value;
				this.SendPropertyChanged("STATE");
				this.OnSTATEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATUS", DbType="VarChar(6)")]
	public string STATUS
	{
		get
		{
			return this._STATUS;
		}
		set
		{
			if ((this._STATUS != value))
			{
				this.OnSTATUSChanging(value);
				this.SendPropertyChanging();
				this._STATUS = value;
				this.SendPropertyChanged("STATUS");
				this.OnSTATUSChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONTAINER", DbType="Bit NOT NULL")]
	public bool CONTAINER
	{
		get
		{
			return this._CONTAINER;
		}
		set
		{
			if ((this._CONTAINER != value))
			{
				this.OnCONTAINERChanging(value);
				this.SendPropertyChanging();
				this._CONTAINER = value;
				this.SendPropertyChanged("CONTAINER");
				this.OnCONTAINERChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MOVEABLE", DbType="Bit NOT NULL")]
	public bool MOVEABLE
	{
		get
		{
			return this._MOVEABLE;
		}
		set
		{
			if ((this._MOVEABLE != value))
			{
				this.OnMOVEABLEChanging(value);
				this.SendPropertyChanging();
				this._MOVEABLE = value;
				this.SendPropertyChanged("MOVEABLE");
				this.OnMOVEABLEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BACKGROUND", DbType="VarChar(80)")]
	public string BACKGROUND
	{
		get
		{
			return this._BACKGROUND;
		}
		set
		{
			if ((this._BACKGROUND != value))
			{
				this.OnBACKGROUNDChanging(value);
				this.SendPropertyChanging();
				this._BACKGROUND = value;
				this.SendPropertyChanged("BACKGROUND");
				this.OnBACKGROUNDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ICON", DbType="VarChar(80)")]
	public string ICON
	{
		get
		{
			return this._ICON;
		}
		set
		{
			if ((this._ICON != value))
			{
				this.OnICONChanging(value);
				this.SendPropertyChanging();
				this._ICON = value;
				this.SendPropertyChanged("ICON");
				this.OnICONChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SHOW_ICON", DbType="Bit NOT NULL")]
	public bool SHOW_ICON
	{
		get
		{
			return this._SHOW_ICON;
		}
		set
		{
			if ((this._SHOW_ICON != value))
			{
				this.OnSHOW_ICONChanging(value);
				this.SendPropertyChanging();
				this._SHOW_ICON = value;
				this.SendPropertyChanged("SHOW_ICON");
				this.OnSHOW_ICONChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMAGE_X", DbType="Int")]
	public System.Nullable<int> IMAGE_X
	{
		get
		{
			return this._IMAGE_X;
		}
		set
		{
			if ((this._IMAGE_X != value))
			{
				this.OnIMAGE_XChanging(value);
				this.SendPropertyChanging();
				this._IMAGE_X = value;
				this.SendPropertyChanged("IMAGE_X");
				this.OnIMAGE_XChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMAGE_Y", DbType="Int")]
	public System.Nullable<int> IMAGE_Y
	{
		get
		{
			return this._IMAGE_Y;
		}
		set
		{
			if ((this._IMAGE_Y != value))
			{
				this.OnIMAGE_YChanging(value);
				this.SendPropertyChanging();
				this._IMAGE_Y = value;
				this.SendPropertyChanged("IMAGE_Y");
				this.OnIMAGE_YChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMAGE_W", DbType="Int")]
	public System.Nullable<int> IMAGE_W
	{
		get
		{
			return this._IMAGE_W;
		}
		set
		{
			if ((this._IMAGE_W != value))
			{
				this.OnIMAGE_WChanging(value);
				this.SendPropertyChanging();
				this._IMAGE_W = value;
				this.SendPropertyChanged("IMAGE_W");
				this.OnIMAGE_WChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMAGE_H", DbType="Int")]
	public System.Nullable<int> IMAGE_H
	{
		get
		{
			return this._IMAGE_H;
		}
		set
		{
			if ((this._IMAGE_H != value))
			{
				this.OnIMAGE_HChanging(value);
				this.SendPropertyChanging();
				this._IMAGE_H = value;
				this.SendPropertyChanged("IMAGE_H");
				this.OnIMAGE_HChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SYSTEM", DbType="VarChar(20)")]
	public string SYSTEM
	{
		get
		{
			return this._SYSTEM;
		}
		set
		{
			if ((this._SYSTEM != value))
			{
				this.OnSYSTEMChanging(value);
				this.SendPropertyChanging();
				this._SYSTEM = value;
				this.SendPropertyChanged("SYSTEM");
				this.OnSYSTEMChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SUBSYSTEM", DbType="VarChar(20)")]
	public string SUBSYSTEM
	{
		get
		{
			return this._SUBSYSTEM;
		}
		set
		{
			if ((this._SUBSYSTEM != value))
			{
				this.OnSUBSYSTEMChanging(value);
				this.SendPropertyChanging();
				this._SUBSYSTEM = value;
				this.SendPropertyChanged("SUBSYSTEM");
				this.OnSUBSYSTEMChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOMELOCATION", DbType="VarChar(40)")]
	public string HOMELOCATION
	{
		get
		{
			return this._HOMELOCATION;
		}
		set
		{
			if ((this._HOMELOCATION != value))
			{
				this.OnHOMELOCATIONChanging(value);
				this.SendPropertyChanging();
				this._HOMELOCATION = value;
				this.SendPropertyChanged("HOMELOCATION");
				this.OnHOMELOCATIONChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_INUSENAME", DbType="VarChar(20)")]
	public string INUSENAME
	{
		get
		{
			return this._INUSENAME;
		}
		set
		{
			if ((this._INUSENAME != value))
			{
				this.OnINUSENAMEChanging(value);
				this.SendPropertyChanging();
				this._INUSENAME = value;
				this.SendPropertyChanged("INUSENAME");
				this.OnINUSENAMEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ACT_DATE", DbType="DateTime")]
	public System.Nullable<System.DateTime> ACT_DATE
	{
		get
		{
			return this._ACT_DATE;
		}
		set
		{
			if ((this._ACT_DATE != value))
			{
				this.OnACT_DATEChanging(value);
				this.SendPropertyChanging();
				this._ACT_DATE = value;
				this.SendPropertyChanged("ACT_DATE");
				this.OnACT_DATEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MOVE_DATE", DbType="DateTime")]
	public System.Nullable<System.DateTime> MOVE_DATE
	{
		get
		{
			return this._MOVE_DATE;
		}
		set
		{
			if ((this._MOVE_DATE != value))
			{
				this.OnMOVE_DATEChanging(value);
				this.SendPropertyChanging();
				this._MOVE_DATE = value;
				this.SendPropertyChanged("MOVE_DATE");
				this.OnMOVE_DATEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USERNAME", DbType="VarChar(20)")]
	public string USERNAME
	{
		get
		{
			return this._USERNAME;
		}
		set
		{
			if ((this._USERNAME != value))
			{
				this.OnUSERNAMEChanging(value);
				this.SendPropertyChanging();
				this._USERNAME = value;
				this.SendPropertyChanged("USERNAME");
				this.OnUSERNAMEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOCATION_PART", DbType="VarChar(40)")]
	public string LOCATION_PART
	{
		get
		{
			return this._LOCATION_PART;
		}
		set
		{
			if ((this._LOCATION_PART != value))
			{
				this.OnLOCATION_PARTChanging(value);
				this.SendPropertyChanging();
				this._LOCATION_PART = value;
				this.SendPropertyChanged("LOCATION_PART");
				this.OnLOCATION_PARTChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AUDIT_DATE", DbType="DateTime")]
	public System.Nullable<System.DateTime> AUDIT_DATE
	{
		get
		{
			return this._AUDIT_DATE;
		}
		set
		{
			if ((this._AUDIT_DATE != value))
			{
				this.OnAUDIT_DATEChanging(value);
				this.SendPropertyChanging();
				this._AUDIT_DATE = value;
				this.SendPropertyChanged("AUDIT_DATE");
				this.OnAUDIT_DATEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AUDIT_STATUS", DbType="Int")]
	public System.Nullable<int> AUDIT_STATUS
	{
		get
		{
			return this._AUDIT_STATUS;
		}
		set
		{
			if ((this._AUDIT_STATUS != value))
			{
				this.OnAUDIT_STATUSChanging(value);
				this.SendPropertyChanging();
				this._AUDIT_STATUS = value;
				this.SendPropertyChanged("AUDIT_STATUS");
				this.OnAUDIT_STATUSChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AUDIT_LOCATION", DbType="VarChar(40)")]
	public string AUDIT_LOCATION
	{
		get
		{
			return this._AUDIT_LOCATION;
		}
		set
		{
			if ((this._AUDIT_LOCATION != value))
			{
				this.OnAUDIT_LOCATIONChanging(value);
				this.SendPropertyChanging();
				this._AUDIT_LOCATION = value;
				this.SendPropertyChanged("AUDIT_LOCATION");
				this.OnAUDIT_LOCATIONChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FILL_STATUS", DbType="VarChar(20)")]
	public string FILL_STATUS
	{
		get
		{
			return this._FILL_STATUS;
		}
		set
		{
			if ((this._FILL_STATUS != value))
			{
				this.OnFILL_STATUSChanging(value);
				this.SendPropertyChanging();
				this._FILL_STATUS = value;
				this.SendPropertyChanged("FILL_STATUS");
				this.OnFILL_STATUSChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMPTY_SPACE", DbType="Decimal(17,5)")]
	public System.Nullable<decimal> EMPTY_SPACE
	{
		get
		{
			return this._EMPTY_SPACE;
		}
		set
		{
			if ((this._EMPTY_SPACE != value))
			{
				this.OnEMPTY_SPACEChanging(value);
				this.SendPropertyChanging();
				this._EMPTY_SPACE = value;
				this.SendPropertyChanged("EMPTY_SPACE");
				this.OnEMPTY_SPACEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISPOSE", DbType="VarChar(20)")]
	public string DISPOSE
	{
		get
		{
			return this._DISPOSE;
		}
		set
		{
			if ((this._DISPOSE != value))
			{
				this.OnDISPOSEChanging(value);
				this.SendPropertyChanging();
				this._DISPOSE = value;
				this.SendPropertyChanged("DISPOSE");
				this.OnDISPOSEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AUDIT_DBNAME", DbType="VarChar(20)")]
	public string AUDIT_DBNAME
	{
		get
		{
			return this._AUDIT_DBNAME;
		}
		set
		{
			if ((this._AUDIT_DBNAME != value))
			{
				this.OnAUDIT_DBNAMEChanging(value);
				this.SendPropertyChanging();
				this._AUDIT_DBNAME = value;
				this.SendPropertyChanged("AUDIT_DBNAME");
				this.OnAUDIT_DBNAMEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AUDIT_ID", DbType="Int")]
	public System.Nullable<int> AUDIT_ID
	{
		get
		{
			return this._AUDIT_ID;
		}
		set
		{
			if ((this._AUDIT_ID != value))
			{
				this.OnAUDIT_IDChanging(value);
				this.SendPropertyChanging();
				this._AUDIT_ID = value;
				this.SendPropertyChanged("AUDIT_ID");
				this.OnAUDIT_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AUDIT_COMMENT", DbType="VarChar(100)")]
	public string AUDIT_COMMENT
	{
		get
		{
			return this._AUDIT_COMMENT;
		}
		set
		{
			if ((this._AUDIT_COMMENT != value))
			{
				this.OnAUDIT_COMMENTChanging(value);
				this.SendPropertyChanging();
				this._AUDIT_COMMENT = value;
				this.SendPropertyChanged("AUDIT_COMMENT");
				this.OnAUDIT_COMMENTChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RFID_TAG_PRESENT", DbType="Bit")]
	public System.Nullable<bool> RFID_TAG_PRESENT
	{
		get
		{
			return this._RFID_TAG_PRESENT;
		}
		set
		{
			if ((this._RFID_TAG_PRESENT != value))
			{
				this.OnRFID_TAG_PRESENTChanging(value);
				this.SendPropertyChanging();
				this._RFID_TAG_PRESENT = value;
				this.SendPropertyChanged("RFID_TAG_PRESENT");
				this.OnRFID_TAG_PRESENTChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ITEMTREE_ITEMTREE", Storage="_ITEMTREEs", ThisKey="ID", OtherKey="ID_PARENT")]
	public EntitySet<ITEMTREE> ITEMTREEs
	{
		get
		{
			return this._ITEMTREEs;
		}
		set
		{
			this._ITEMTREEs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ITEMTREE_ITEMTREE", Storage="_ITEMTREE1", ThisKey="ID_PARENT", OtherKey="ID", IsForeignKey=true)]
	public ITEMTREE ITEMTREE1
	{
		get
		{
			return this._ITEMTREE1.Entity;
		}
		set
		{
			ITEMTREE previousValue = this._ITEMTREE1.Entity;
			if (((previousValue != value) 
						|| (this._ITEMTREE1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._ITEMTREE1.Entity = null;
					previousValue.ITEMTREEs.Remove(this);
				}
				this._ITEMTREE1.Entity = value;
				if ((value != null))
				{
					value.ITEMTREEs.Add(this);
					this._ID_PARENT = value.ID;
				}
				else
				{
					this._ID_PARENT = default(Nullable<int>);
				}
				this.SendPropertyChanged("ITEMTREE1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_ITEMTREEs(ITEMTREE entity)
	{
		this.SendPropertyChanging();
		entity.ITEMTREE1 = this;
	}
	
	private void detach_ITEMTREEs(ITEMTREE entity)
	{
		this.SendPropertyChanging();
		entity.ITEMTREE1 = null;
	}
}
#pragma warning restore 1591
