// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: user_authentication.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Pb {

  /// <summary>Holder for reflection information generated from user_authentication.proto</summary>
  public static partial class UserAuthenticationReflection {

    #region Descriptor
    /// <summary>File descriptor for user_authentication.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserAuthenticationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chl1c2VyX2F1dGhlbnRpY2F0aW9uLnByb3RvEgJwYiJPChVDdHNVc2VyQXV0",
            "aGVudGljYXRpb24SDgoGdXNlcklkGAEgASgFEg0KBXRva2VuGAIgASgMEhcK",
            "D3Rva2VuRXhwaXJlVGltZRgDIAEoAyJKChVTdGNVc2VyQXV0aGVudGljYXRp",
            "b24SDgoGc3RhdHVzGAEgASgIEg4KBnJlc3VsdBgCIAEoCRIRCglzZXNzaW9u",
            "SWQYAyABKANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.CtsUserAuthentication), global::Pb.CtsUserAuthentication.Parser, new[]{ "UserId", "Token", "TokenExpireTime" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.StcUserAuthentication), global::Pb.StcUserAuthentication.Parser, new[]{ "Status", "Result", "SessionId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CtsUserAuthentication : pb::IMessage<CtsUserAuthentication> {
    private static readonly pb::MessageParser<CtsUserAuthentication> _parser = new pb::MessageParser<CtsUserAuthentication>(() => new CtsUserAuthentication());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CtsUserAuthentication> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.UserAuthenticationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CtsUserAuthentication() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CtsUserAuthentication(CtsUserAuthentication other) : this() {
      userId_ = other.userId_;
      token_ = other.token_;
      tokenExpireTime_ = other.tokenExpireTime_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CtsUserAuthentication Clone() {
      return new CtsUserAuthentication(this);
    }

    /// <summary>Field number for the "userId" field.</summary>
    public const int UserIdFieldNumber = 1;
    private int userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 2;
    private pb::ByteString token_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tokenExpireTime" field.</summary>
    public const int TokenExpireTimeFieldNumber = 3;
    private long tokenExpireTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TokenExpireTime {
      get { return tokenExpireTime_; }
      set {
        tokenExpireTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CtsUserAuthentication);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CtsUserAuthentication other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (Token != other.Token) return false;
      if (TokenExpireTime != other.TokenExpireTime) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0) hash ^= UserId.GetHashCode();
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      if (TokenExpireTime != 0L) hash ^= TokenExpireTime.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UserId);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Token);
      }
      if (TokenExpireTime != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(TokenExpireTime);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UserId);
      }
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Token);
      }
      if (TokenExpireTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TokenExpireTime);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CtsUserAuthentication other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
      }
      if (other.TokenExpireTime != 0L) {
        TokenExpireTime = other.TokenExpireTime;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            UserId = input.ReadInt32();
            break;
          }
          case 18: {
            Token = input.ReadBytes();
            break;
          }
          case 24: {
            TokenExpireTime = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class StcUserAuthentication : pb::IMessage<StcUserAuthentication> {
    private static readonly pb::MessageParser<StcUserAuthentication> _parser = new pb::MessageParser<StcUserAuthentication>(() => new StcUserAuthentication());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StcUserAuthentication> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.UserAuthenticationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StcUserAuthentication() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StcUserAuthentication(StcUserAuthentication other) : this() {
      status_ = other.status_;
      result_ = other.result_;
      sessionId_ = other.sessionId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StcUserAuthentication Clone() {
      return new StcUserAuthentication(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private bool status_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 2;
    private string result_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Result {
      get { return result_; }
      set {
        result_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sessionId" field.</summary>
    public const int SessionIdFieldNumber = 3;
    private long sessionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long SessionId {
      get { return sessionId_; }
      set {
        sessionId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StcUserAuthentication);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StcUserAuthentication other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (Result != other.Result) return false;
      if (SessionId != other.SessionId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != false) hash ^= Status.GetHashCode();
      if (Result.Length != 0) hash ^= Result.GetHashCode();
      if (SessionId != 0L) hash ^= SessionId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != false) {
        output.WriteRawTag(8);
        output.WriteBool(Status);
      }
      if (Result.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Result);
      }
      if (SessionId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(SessionId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != false) {
        size += 1 + 1;
      }
      if (Result.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Result);
      }
      if (SessionId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SessionId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StcUserAuthentication other) {
      if (other == null) {
        return;
      }
      if (other.Status != false) {
        Status = other.Status;
      }
      if (other.Result.Length != 0) {
        Result = other.Result;
      }
      if (other.SessionId != 0L) {
        SessionId = other.SessionId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Status = input.ReadBool();
            break;
          }
          case 18: {
            Result = input.ReadString();
            break;
          }
          case 24: {
            SessionId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
