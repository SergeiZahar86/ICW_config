/**
 * Autogenerated by Thrift Compiler (0.13.0)
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


#if !SILVERLIGHT
[Serializable]
#endif
public partial class ICWException : TException, TBase
{
  private string _message;
  private int _error_code;

  public string Message
  {
    get
    {
      return _message;
    }
    set
    {
      __isset.message = true;
      this._message = value;
    }
  }

  public int Error_code
  {
    get
    {
      return _error_code;
    }
    set
    {
      __isset.error_code = true;
      this._error_code = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool message;
    public bool error_code;
  }

  public ICWException() {
  }

  public void Read (TProtocol iprot)
  {
    iprot.IncrementRecursionDepth();
    try
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
              Message = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Error_code = iprot.ReadI32();
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
    finally
    {
      iprot.DecrementRecursionDepth();
    }
  }

  public void Write(TProtocol oprot) {
    oprot.IncrementRecursionDepth();
    try
    {
      TStruct struc = new TStruct("ICWException");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Message != null && __isset.message) {
        field.Name = "message";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Message);
        oprot.WriteFieldEnd();
      }
      if (__isset.error_code) {
        field.Name = "error_code";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Error_code);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("ICWException(");
    bool __first = true;
    if (Message != null && __isset.message) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Message: ");
      __sb.Append(Message);
    }
    if (__isset.error_code) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Error_code: ");
      __sb.Append(Error_code);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

