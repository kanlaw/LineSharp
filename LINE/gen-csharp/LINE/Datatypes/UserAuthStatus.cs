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
  public partial class UserAuthStatus : TBase
  {
    private bool _phoneNumberRegistered;
    private List<SnsIdType> _registeredSnsIdTypes;

    public bool PhoneNumberRegistered
    {
      get
      {
        return _phoneNumberRegistered;
      }
      set
      {
        __isset.phoneNumberRegistered = true;
        this._phoneNumberRegistered = value;
      }
    }

    public List<SnsIdType> RegisteredSnsIdTypes
    {
      get
      {
        return _registeredSnsIdTypes;
      }
      set
      {
        __isset.registeredSnsIdTypes = true;
        this._registeredSnsIdTypes = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool phoneNumberRegistered;
      public bool registeredSnsIdTypes;
    }

    public UserAuthStatus() {
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
              PhoneNumberRegistered = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                RegisteredSnsIdTypes = new List<SnsIdType>();
                TList _list81 = iprot.ReadListBegin();
                for( int _i82 = 0; _i82 < _list81.Count; ++_i82)
                {
                  SnsIdType _elem83 = (SnsIdType)0;
                  _elem83 = (SnsIdType)iprot.ReadI32();
                  RegisteredSnsIdTypes.Add(_elem83);
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
      TStruct struc = new TStruct("UserAuthStatus");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.phoneNumberRegistered) {
        field.Name = "phoneNumberRegistered";
        field.Type = TType.Bool;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(PhoneNumberRegistered);
        oprot.WriteFieldEnd();
      }
      if (RegisteredSnsIdTypes != null && __isset.registeredSnsIdTypes) {
        field.Name = "registeredSnsIdTypes";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I32, RegisteredSnsIdTypes.Count));
          foreach (SnsIdType _iter84 in RegisteredSnsIdTypes)
          {
            oprot.WriteI32((int)_iter84);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("UserAuthStatus(");
      sb.Append("PhoneNumberRegistered: ");
      sb.Append(PhoneNumberRegistered);
      sb.Append(",RegisteredSnsIdTypes: ");
      sb.Append(RegisteredSnsIdTypes);
      sb.Append(")");
      return sb.ToString();
    }

  }

}