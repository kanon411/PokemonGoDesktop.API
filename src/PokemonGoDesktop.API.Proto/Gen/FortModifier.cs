// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Map/Fort/FortModifier.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Map/Fort/FortModifier.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class FortModifierReflection {

    #region Descriptor
    /// <summary>File descriptor for Map/Fort/FortModifier.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FortModifierReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtNYXAvRm9ydC9Gb3J0TW9kaWZpZXIucHJvdG8SCE1hcC5Gb3J0GhtJbnZl",
            "bnRvcnkvSXRlbS9JdGVtSWQucHJvdG8iegoMRm9ydE1vZGlmaWVyEicKB2l0",
            "ZW1faWQYASABKA4yFi5JbnZlbnRvcnkuSXRlbS5JdGVtSWQSHwoXZXhwaXJh",
            "dGlvbl90aW1lc3RhbXBfbXMYAiABKAMSIAoYZGVwbG95ZXJfcGxheWVyX2Nv",
            "ZGVuYW1lGAMgASgJQh2qAhpQb2tlbW9uR29EZXNrdG9wLkFQSS5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.FortModifier), global::PokemonGoDesktop.API.Proto.FortModifier.Parser, new[]{ "ItemId", "ExpirationTimestampMs", "DeployerPlayerCodename" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class FortModifier : pb::IMessage<FortModifier> {
    private static readonly pb::MessageParser<FortModifier> _parser = new pb::MessageParser<FortModifier>(() => new FortModifier());
    public static pb::MessageParser<FortModifier> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.FortModifierReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public FortModifier() {
      OnConstruction();
    }

    partial void OnConstruction();

    public FortModifier(FortModifier other) : this() {
      itemId_ = other.itemId_;
      expirationTimestampMs_ = other.expirationTimestampMs_;
      deployerPlayerCodename_ = other.deployerPlayerCodename_;
    }

    public FortModifier Clone() {
      return new FortModifier(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private global::PokemonGoDesktop.API.Proto.ItemId itemId_ = 0;
    public global::PokemonGoDesktop.API.Proto.ItemId ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "expiration_timestamp_ms" field.</summary>
    public const int ExpirationTimestampMsFieldNumber = 2;
    private long expirationTimestampMs_;
    public long ExpirationTimestampMs {
      get { return expirationTimestampMs_; }
      set {
        expirationTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "deployer_player_codename" field.</summary>
    public const int DeployerPlayerCodenameFieldNumber = 3;
    private string deployerPlayerCodename_ = "";
    public string DeployerPlayerCodename {
      get { return deployerPlayerCodename_; }
      set {
        deployerPlayerCodename_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as FortModifier);
    }

    public bool Equals(FortModifier other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (ExpirationTimestampMs != other.ExpirationTimestampMs) return false;
      if (DeployerPlayerCodename != other.DeployerPlayerCodename) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (ExpirationTimestampMs != 0L) hash ^= ExpirationTimestampMs.GetHashCode();
      if (DeployerPlayerCodename.Length != 0) hash ^= DeployerPlayerCodename.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemId);
      }
      if (ExpirationTimestampMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ExpirationTimestampMs);
      }
      if (DeployerPlayerCodename.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DeployerPlayerCodename);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (ExpirationTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpirationTimestampMs);
      }
      if (DeployerPlayerCodename.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeployerPlayerCodename);
      }
      return size;
    }

    public void MergeFrom(FortModifier other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.ExpirationTimestampMs != 0L) {
        ExpirationTimestampMs = other.ExpirationTimestampMs;
      }
      if (other.DeployerPlayerCodename.Length != 0) {
        DeployerPlayerCodename = other.DeployerPlayerCodename;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            itemId_ = (global::PokemonGoDesktop.API.Proto.ItemId) input.ReadEnum();
            break;
          }
          case 16: {
            ExpirationTimestampMs = input.ReadInt64();
            break;
          }
          case 26: {
            DeployerPlayerCodename = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
