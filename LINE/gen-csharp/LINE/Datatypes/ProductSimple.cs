/**
 * Autogenerated by Thrift Compiler (0.9.1)
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

namespace LINE.Datatypes
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ProductSimple : TBase
  {
    private string _productId;
    private long _packageId;
    private int _version;
    private bool _onSale;
    private long _validUntil;

    public string ProductId
    {
      get
      {
        return _productId;
      }
      set
      {
        __isset.productId = true;
        this._productId = value;
      }
    }

    public long PackageId
    {
      get
      {
        return _packageId;
      }
      set
      {
        __isset.packageId = true;
        this._packageId = value;
      }
    }

    public int Version
    {
      get
      {
        return _version;
      }
      set
      {
        __isset.version = true;
        this._version = value;
      }
    }

    public bool OnSale
    {
      get
      {
        return _onSale;
      }
      set
      {
        __isset.onSale = true;
        this._onSale = value;
      }
    }

    public long ValidUntil
    {
      get
      {
        return _validUntil;
      }
      set
      {
        __isset.validUntil = true;
        this._validUntil = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool productId;
      public bool packageId;
      public bool version;
      public bool onSale;
      public bool validUntil;
    }

    public ProductSimple() {
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
            if (field.Type == TType.String) {
              ProductId = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I64) {
              PackageId = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Version = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Bool) {
              OnSale = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I64) {
              ValidUntil = iprot.ReadI64();
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
      TStruct struc = new TStruct("ProductSimple");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ProductId != null && __isset.productId) {
        field.Name = "productId";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ProductId);
        oprot.WriteFieldEnd();
      }
      if (__isset.packageId) {
        field.Name = "packageId";
        field.Type = TType.I64;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(PackageId);
        oprot.WriteFieldEnd();
      }
      if (__isset.version) {
        field.Name = "version";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Version);
        oprot.WriteFieldEnd();
      }
      if (__isset.onSale) {
        field.Name = "onSale";
        field.Type = TType.Bool;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(OnSale);
        oprot.WriteFieldEnd();
      }
      if (__isset.validUntil) {
        field.Name = "validUntil";
        field.Type = TType.I64;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(ValidUntil);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ProductSimple(");
      sb.Append("ProductId: ");
      sb.Append(ProductId);
      sb.Append(",PackageId: ");
      sb.Append(PackageId);
      sb.Append(",Version: ");
      sb.Append(Version);
      sb.Append(",OnSale: ");
      sb.Append(OnSale);
      sb.Append(",ValidUntil: ");
      sb.Append(ValidUntil);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
