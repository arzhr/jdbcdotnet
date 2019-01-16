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
  public partial class ArrayVal : TBase
  {
    private int _sqlType;
    private List<RawVal> _elements;

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

    public List<RawVal> Elements
    {
      get
      {
        return _elements;
      }
      set
      {
        __isset.elements = true;
        this._elements = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool sqlType;
      public bool elements;
    }

    public ArrayVal() {
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
            if (field.Type == TType.I32) {
              SqlType = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                Elements = new List<RawVal>();
                TList _list4 = iprot.ReadListBegin();
                for( int _i5 = 0; _i5 < _list4.Count; ++_i5)
                {
                  RawVal _elem6;
                  _elem6 = new RawVal();
                  _elem6.Read(iprot);
                  Elements.Add(_elem6);
                }
                iprot.ReadListEnd();
              }
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
      TStruct struc = new TStruct("ArrayVal");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.sqlType) {
        field.Name = "sqlType";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SqlType);
        oprot.WriteFieldEnd();
      }
      if (Elements != null && __isset.elements) {
        field.Name = "elements";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Elements.Count));
          foreach (RawVal _iter7 in Elements)
          {
            _iter7.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("ArrayVal(");
      bool __first = true;
      if (__isset.sqlType) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SqlType: ");
        __sb.Append(SqlType);
      }
      if (Elements != null && __isset.elements) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Elements: ");
        __sb.Append(Elements);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}