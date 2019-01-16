/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace jdbcrpc.thrift
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class RValueSQL : TBase
  {
    private bool _isnull;
    private RawVal _val;
    private int _sqlType;

    public bool Isnull
    {
      get
      {
        return _isnull;
      }
      set
      {
        __isset.isnull = true;
        this._isnull = value;
      }
    }

    public RawVal Val
    {
      get
      {
        return _val;
      }
      set
      {
        __isset.val = true;
        this._val = value;
      }
    }

    public int SqlType
    {
      get
      {
        return _sqlType;
      }
      set
      {
        __isset.sqlType = true;
        this._sqlType = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool isnull;
      public bool val;
      public bool sqlType;
    }

    public RValueSQL() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Bool) {
              Isnull = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              Val = new RawVal();
              Val.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              SqlType = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("RValueSQL");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.isnull) {
        field.Name = "isnull";
        field.Type = TType.Bool;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Isnull);
        oprot.WriteFieldEnd();
      }
      if (Val != null && __isset.val) {
        field.Name = "val";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        Val.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.sqlType) {
        field.Name = "sqlType";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SqlType);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("RValueSQL(");
      bool __first = true;
      if (__isset.isnull) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Isnull: ");
        __sb.Append(Isnull);
      }
      if (Val != null && __isset.val) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Val: ");
        __sb.Append(Val== null ? "<null>" : Val.ToString());
      }
      if (__isset.sqlType) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SqlType: ");
        __sb.Append(SqlType);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
