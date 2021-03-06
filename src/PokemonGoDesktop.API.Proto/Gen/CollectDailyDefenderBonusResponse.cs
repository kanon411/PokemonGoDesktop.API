// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/CollectDailyDefenderBonusResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Responses/CollectDailyDefenderBonusResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class CollectDailyDefenderBonusResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/CollectDailyDefenderBonusResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CollectDailyDefenderBonusResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxOZXR3b3JraW5nL1Jlc3BvbnNlcy9Db2xsZWN0RGFpbHlEZWZlbmRlckJv",
            "bnVzUmVzcG9uc2UucHJvdG8SFE5ldHdvcmtpbmcuUmVzcG9uc2VzIowCCiFD",
            "b2xsZWN0RGFpbHlEZWZlbmRlckJvbnVzUmVzcG9uc2USTgoGcmVzdWx0GAEg",
            "ASgOMj4uTmV0d29ya2luZy5SZXNwb25zZXMuQ29sbGVjdERhaWx5RGVmZW5k",
            "ZXJCb251c1Jlc3BvbnNlLlJlc3VsdBIVCg1jdXJyZW5jeV90eXBlGAIgAygJ",
            "EhgKEGN1cnJlbmN5X2F3YXJkZWQYAyADKAUSFwoPZGVmZW5kZXJzX2NvdW50",
            "GAQgASgFIk0KBlJlc3VsdBIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQARILCgdG",
            "QUlMVVJFEAISDAoIVE9PX1NPT04QAxIQCgxOT19ERUZFTkRFUlMQBEIdqgIa",
            "UG9rZW1vbkdvRGVza3RvcC5BUEkuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.CollectDailyDefenderBonusResponse), global::PokemonGoDesktop.API.Proto.CollectDailyDefenderBonusResponse.Parser, new[]{ "Result", "CurrencyType", "CurrencyAwarded", "DefendersCount" }, null, new[]{ typeof(global::PokemonGoDesktop.API.Proto.CollectDailyDefenderBonusResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CollectDailyDefenderBonusResponse : pb::IMessage<CollectDailyDefenderBonusResponse> {
    private static readonly pb::MessageParser<CollectDailyDefenderBonusResponse> _parser = new pb::MessageParser<CollectDailyDefenderBonusResponse>(() => new CollectDailyDefenderBonusResponse());
    public static pb::MessageParser<CollectDailyDefenderBonusResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.CollectDailyDefenderBonusResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CollectDailyDefenderBonusResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CollectDailyDefenderBonusResponse(CollectDailyDefenderBonusResponse other) : this() {
      result_ = other.result_;
      currencyType_ = other.currencyType_.Clone();
      currencyAwarded_ = other.currencyAwarded_.Clone();
      defendersCount_ = other.defendersCount_;
    }

    public CollectDailyDefenderBonusResponse Clone() {
      return new CollectDailyDefenderBonusResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::PokemonGoDesktop.API.Proto.CollectDailyDefenderBonusResponse.Types.Result result_ = 0;
    public global::PokemonGoDesktop.API.Proto.CollectDailyDefenderBonusResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "currency_type" field.</summary>
    public const int CurrencyTypeFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_currencyType_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> currencyType_ = new pbc::RepeatedField<string>();
    public pbc::RepeatedField<string> CurrencyType {
      get { return currencyType_; }
    }

    /// <summary>Field number for the "currency_awarded" field.</summary>
    public const int CurrencyAwardedFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_currencyAwarded_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> currencyAwarded_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> CurrencyAwarded {
      get { return currencyAwarded_; }
    }

    /// <summary>Field number for the "defenders_count" field.</summary>
    public const int DefendersCountFieldNumber = 4;
    private int defendersCount_;
    public int DefendersCount {
      get { return defendersCount_; }
      set {
        defendersCount_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as CollectDailyDefenderBonusResponse);
    }

    public bool Equals(CollectDailyDefenderBonusResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if(!currencyType_.Equals(other.currencyType_)) return false;
      if(!currencyAwarded_.Equals(other.currencyAwarded_)) return false;
      if (DefendersCount != other.DefendersCount) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      hash ^= currencyType_.GetHashCode();
      hash ^= currencyAwarded_.GetHashCode();
      if (DefendersCount != 0) hash ^= DefendersCount.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      currencyType_.WriteTo(output, _repeated_currencyType_codec);
      currencyAwarded_.WriteTo(output, _repeated_currencyAwarded_codec);
      if (DefendersCount != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(DefendersCount);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      size += currencyType_.CalculateSize(_repeated_currencyType_codec);
      size += currencyAwarded_.CalculateSize(_repeated_currencyAwarded_codec);
      if (DefendersCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DefendersCount);
      }
      return size;
    }

    public void MergeFrom(CollectDailyDefenderBonusResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      currencyType_.Add(other.currencyType_);
      currencyAwarded_.Add(other.currencyAwarded_);
      if (other.DefendersCount != 0) {
        DefendersCount = other.DefendersCount;
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
            result_ = (global::PokemonGoDesktop.API.Proto.CollectDailyDefenderBonusResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            currencyType_.AddEntriesFrom(input, _repeated_currencyType_codec);
            break;
          }
          case 26:
          case 24: {
            currencyAwarded_.AddEntriesFrom(input, _repeated_currencyAwarded_codec);
            break;
          }
          case 32: {
            DefendersCount = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CollectDailyDefenderBonusResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("FAILURE")] Failure = 2,
        [pbr::OriginalName("TOO_SOON")] TooSoon = 3,
        [pbr::OriginalName("NO_DEFENDERS")] NoDefenders = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
