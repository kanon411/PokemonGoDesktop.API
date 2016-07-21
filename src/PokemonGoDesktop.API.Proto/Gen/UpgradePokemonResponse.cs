// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/UpgradePokemonResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Responses {

  /// <summary>Holder for reflection information generated from Networking/Responses/UpgradePokemonResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UpgradePokemonResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/UpgradePokemonResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpgradePokemonResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFOZXR3b3JraW5nL1Jlc3BvbnNlcy9VcGdyYWRlUG9rZW1vblJlc3BvbnNl",
            "LnByb3RvEhROZXR3b3JraW5nLlJlc3BvbnNlcxoWRGF0YS9Qb2tlbW9uRGF0",
            "YS5wcm90byKsAgoWVXBncmFkZVBva2Vtb25SZXNwb25zZRJDCgZyZXN1bHQY",
            "ASABKA4yMy5OZXR3b3JraW5nLlJlc3BvbnNlcy5VcGdyYWRlUG9rZW1vblJl",
            "c3BvbnNlLlJlc3VsdBIrChB1cGdyYWRlZF9wb2tlbW9uGAIgASgLMhEuRGF0",
            "YS5Qb2tlbW9uRGF0YSKfAQoGUmVzdWx0EgkKBVVOU0VUEAASCwoHU1VDQ0VT",
            "UxABEhsKF0VSUk9SX1BPS0VNT05fTk9UX0ZPVU5EEAISIAocRVJST1JfSU5T",
            "VUZGSUNJRU5UX1JFU09VUkNFUxADEh8KG0VSUk9SX1VQR1JBREVfTk9UX0FW",
            "QUlMQUJMRRAEEh0KGUVSUk9SX1BPS0VNT05fSVNfREVQTE9ZRUQQBWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Data.PokemonDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Responses.UpgradePokemonResponse), global::Networking.Responses.UpgradePokemonResponse.Parser, new[]{ "Result", "UpgradedPokemon" }, null, new[]{ typeof(global::Networking.Responses.UpgradePokemonResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UpgradePokemonResponse : pb::IMessage<UpgradePokemonResponse> {
    private static readonly pb::MessageParser<UpgradePokemonResponse> _parser = new pb::MessageParser<UpgradePokemonResponse>(() => new UpgradePokemonResponse());
    public static pb::MessageParser<UpgradePokemonResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Responses.UpgradePokemonResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UpgradePokemonResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UpgradePokemonResponse(UpgradePokemonResponse other) : this() {
      result_ = other.result_;
      UpgradedPokemon = other.upgradedPokemon_ != null ? other.UpgradedPokemon.Clone() : null;
    }

    public UpgradePokemonResponse Clone() {
      return new UpgradePokemonResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::Networking.Responses.UpgradePokemonResponse.Types.Result result_ = 0;
    public global::Networking.Responses.UpgradePokemonResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "upgraded_pokemon" field.</summary>
    public const int UpgradedPokemonFieldNumber = 2;
    private global::Data.PokemonData upgradedPokemon_;
    public global::Data.PokemonData UpgradedPokemon {
      get { return upgradedPokemon_; }
      set {
        upgradedPokemon_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UpgradePokemonResponse);
    }

    public bool Equals(UpgradePokemonResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(UpgradedPokemon, other.UpgradedPokemon)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (upgradedPokemon_ != null) hash ^= UpgradedPokemon.GetHashCode();
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
      if (upgradedPokemon_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpgradedPokemon);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (upgradedPokemon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpgradedPokemon);
      }
      return size;
    }

    public void MergeFrom(UpgradePokemonResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.upgradedPokemon_ != null) {
        if (upgradedPokemon_ == null) {
          upgradedPokemon_ = new global::Data.PokemonData();
        }
        UpgradedPokemon.MergeFrom(other.UpgradedPokemon);
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
            result_ = (global::Networking.Responses.UpgradePokemonResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (upgradedPokemon_ == null) {
              upgradedPokemon_ = new global::Data.PokemonData();
            }
            input.ReadMessage(upgradedPokemon_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UpgradePokemonResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_POKEMON_NOT_FOUND")] ErrorPokemonNotFound = 2,
        [pbr::OriginalName("ERROR_INSUFFICIENT_RESOURCES")] ErrorInsufficientResources = 3,
        [pbr::OriginalName("ERROR_UPGRADE_NOT_AVAILABLE")] ErrorUpgradeNotAvailable = 4,
        [pbr::OriginalName("ERROR_POKEMON_IS_DEPLOYED")] ErrorPokemonIsDeployed = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code