// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Protos.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GAM {

  /// <summary>Holder for reflection information generated from Protos.proto</summary>
  public static partial class ProtosReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtosReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxQcm90b3MucHJvdG8SBWFjdG9yIh8KA1BJRBIMCgRIb3N0GAEgASgJEgoK",
            "AklkGAIgASgJIgwKClJlc3RhcnRpbmciCgoIU3RvcHBpbmciCQoHU3RvcHBl",
            "ZCIMCgpQb2lzb25QaWxsIgkKB1N0YXJ0ZWQiJAoFV2F0Y2gSGwoHd2F0Y2hl",
            "chgBIAEoCzIKLmFjdG9yLlBJRCImCgdVbndhdGNoEhsKB3dhdGNoZXIYASAB",
            "KAsyCi5hY3Rvci5QSUQiJQoKVGVybWluYXRlZBIXCgN3aG8YASABKAsyCi5h",
            "Y3Rvci5QSURCBqoCA0dBTWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GAM.PID), global::GAM.PID.Parser, new[]{ "Host", "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GAM.Restarting), global::GAM.Restarting.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GAM.Stopping), global::GAM.Stopping.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GAM.Stopped), global::GAM.Stopped.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GAM.PoisonPill), global::GAM.PoisonPill.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GAM.Started), global::GAM.Started.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GAM.Watch), global::GAM.Watch.Parser, new[]{ "Watcher" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GAM.Unwatch), global::GAM.Unwatch.Parser, new[]{ "Watcher" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GAM.Terminated), global::GAM.Terminated.Parser, new[]{ "Who" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PID : pb::IMessage<PID> {
    private static readonly pb::MessageParser<PID> _parser = new pb::MessageParser<PID>(() => new PID());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PID> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GAM.ProtosReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PID() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PID(PID other) : this() {
      host_ = other.host_;
      id_ = other.id_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PID Clone() {
      return new PID(this);
    }

    /// <summary>Field number for the "Host" field.</summary>
    public const int HostFieldNumber = 1;
    private string host_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Host {
      get { return host_; }
      set {
        host_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PID);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PID other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Host != other.Host) return false;
      if (Id != other.Id) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Host.Length != 0) hash ^= Host.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Host.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Host);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Host.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Host);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PID other) {
      if (other == null) {
        return;
      }
      if (other.Host.Length != 0) {
        Host = other.Host;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
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
          case 10: {
            Host = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// user messages
  /// </summary>
  public sealed partial class Restarting : pb::IMessage<Restarting> {
    private static readonly pb::MessageParser<Restarting> _parser = new pb::MessageParser<Restarting>(() => new Restarting());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Restarting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GAM.ProtosReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Restarting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Restarting(Restarting other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Restarting Clone() {
      return new Restarting(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Restarting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Restarting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Restarting other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class Stopping : pb::IMessage<Stopping> {
    private static readonly pb::MessageParser<Stopping> _parser = new pb::MessageParser<Stopping>(() => new Stopping());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Stopping> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GAM.ProtosReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stopping() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stopping(Stopping other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stopping Clone() {
      return new Stopping(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Stopping);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Stopping other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Stopping other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class Stopped : pb::IMessage<Stopped> {
    private static readonly pb::MessageParser<Stopped> _parser = new pb::MessageParser<Stopped>(() => new Stopped());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Stopped> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GAM.ProtosReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stopped() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stopped(Stopped other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stopped Clone() {
      return new Stopped(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Stopped);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Stopped other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Stopped other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class PoisonPill : pb::IMessage<PoisonPill> {
    private static readonly pb::MessageParser<PoisonPill> _parser = new pb::MessageParser<PoisonPill>(() => new PoisonPill());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PoisonPill> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GAM.ProtosReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PoisonPill() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PoisonPill(PoisonPill other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PoisonPill Clone() {
      return new PoisonPill(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PoisonPill);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PoisonPill other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PoisonPill other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class Started : pb::IMessage<Started> {
    private static readonly pb::MessageParser<Started> _parser = new pb::MessageParser<Started>(() => new Started());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Started> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GAM.ProtosReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Started() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Started(Started other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Started Clone() {
      return new Started(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Started);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Started other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Started other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  /// <summary>
  /// system messages
  /// </summary>
  public sealed partial class Watch : pb::IMessage<Watch> {
    private static readonly pb::MessageParser<Watch> _parser = new pb::MessageParser<Watch>(() => new Watch());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Watch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GAM.ProtosReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Watch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Watch(Watch other) : this() {
      Watcher = other.watcher_ != null ? other.Watcher.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Watch Clone() {
      return new Watch(this);
    }

    /// <summary>Field number for the "watcher" field.</summary>
    public const int WatcherFieldNumber = 1;
    private global::GAM.PID watcher_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GAM.PID Watcher {
      get { return watcher_; }
      set {
        watcher_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Watch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Watch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Watcher, other.Watcher)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (watcher_ != null) hash ^= Watcher.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (watcher_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Watcher);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (watcher_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Watcher);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Watch other) {
      if (other == null) {
        return;
      }
      if (other.watcher_ != null) {
        if (watcher_ == null) {
          watcher_ = new global::GAM.PID();
        }
        Watcher.MergeFrom(other.Watcher);
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
          case 10: {
            if (watcher_ == null) {
              watcher_ = new global::GAM.PID();
            }
            input.ReadMessage(watcher_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Unwatch : pb::IMessage<Unwatch> {
    private static readonly pb::MessageParser<Unwatch> _parser = new pb::MessageParser<Unwatch>(() => new Unwatch());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Unwatch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GAM.ProtosReflection.Descriptor.MessageTypes[7]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Unwatch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Unwatch(Unwatch other) : this() {
      Watcher = other.watcher_ != null ? other.Watcher.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Unwatch Clone() {
      return new Unwatch(this);
    }

    /// <summary>Field number for the "watcher" field.</summary>
    public const int WatcherFieldNumber = 1;
    private global::GAM.PID watcher_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GAM.PID Watcher {
      get { return watcher_; }
      set {
        watcher_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Unwatch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Unwatch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Watcher, other.Watcher)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (watcher_ != null) hash ^= Watcher.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (watcher_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Watcher);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (watcher_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Watcher);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Unwatch other) {
      if (other == null) {
        return;
      }
      if (other.watcher_ != null) {
        if (watcher_ == null) {
          watcher_ = new global::GAM.PID();
        }
        Watcher.MergeFrom(other.Watcher);
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
          case 10: {
            if (watcher_ == null) {
              watcher_ = new global::GAM.PID();
            }
            input.ReadMessage(watcher_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Terminated : pb::IMessage<Terminated> {
    private static readonly pb::MessageParser<Terminated> _parser = new pb::MessageParser<Terminated>(() => new Terminated());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Terminated> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GAM.ProtosReflection.Descriptor.MessageTypes[8]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Terminated() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Terminated(Terminated other) : this() {
      Who = other.who_ != null ? other.Who.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Terminated Clone() {
      return new Terminated(this);
    }

    /// <summary>Field number for the "who" field.</summary>
    public const int WhoFieldNumber = 1;
    private global::GAM.PID who_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GAM.PID Who {
      get { return who_; }
      set {
        who_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Terminated);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Terminated other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Who, other.Who)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (who_ != null) hash ^= Who.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (who_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Who);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (who_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Who);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Terminated other) {
      if (other == null) {
        return;
      }
      if (other.who_ != null) {
        if (who_ == null) {
          who_ = new global::GAM.PID();
        }
        Who.MergeFrom(other.Who);
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
          case 10: {
            if (who_ == null) {
              who_ = new global::GAM.PID();
            }
            input.ReadMessage(who_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
