// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Settings/Master/Pokemon/CameraAttributes.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Settings.Master.Pokemon {

  /// <summary>Holder for reflection information generated from Settings/Master/Pokemon/CameraAttributes.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class CameraAttributesReflection {

    #region Descriptor
    /// <summary>File descriptor for Settings/Master/Pokemon/CameraAttributes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CameraAttributesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5TZXR0aW5ncy9NYXN0ZXIvUG9rZW1vbi9DYW1lcmFBdHRyaWJ1dGVzLnBy",
            "b3RvEhdTZXR0aW5ncy5NYXN0ZXIuUG9rZW1vbiKXAQoQQ2FtZXJhQXR0cmli",
            "dXRlcxIVCg1kaXNrX3JhZGl1c19tGAEgASgCEhkKEWN5bGluZGVyX3JhZGl1",
            "c19tGAIgASgCEhkKEWN5bGluZGVyX2hlaWdodF9tGAMgASgCEhkKEWN5bGlu",
            "ZGVyX2dyb3VuZF9tGAQgASgCEhsKE3Nob3VsZGVyX21vZGVfc2NhbGUYBSAB",
            "KAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Settings.Master.Pokemon.CameraAttributes), global::Settings.Master.Pokemon.CameraAttributes.Parser, new[]{ "DiskRadiusM", "CylinderRadiusM", "CylinderHeightM", "CylinderGroundM", "ShoulderModeScale" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CameraAttributes : pb::IMessage<CameraAttributes> {
    private static readonly pb::MessageParser<CameraAttributes> _parser = new pb::MessageParser<CameraAttributes>(() => new CameraAttributes());
    public static pb::MessageParser<CameraAttributes> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Settings.Master.Pokemon.CameraAttributesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CameraAttributes() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CameraAttributes(CameraAttributes other) : this() {
      diskRadiusM_ = other.diskRadiusM_;
      cylinderRadiusM_ = other.cylinderRadiusM_;
      cylinderHeightM_ = other.cylinderHeightM_;
      cylinderGroundM_ = other.cylinderGroundM_;
      shoulderModeScale_ = other.shoulderModeScale_;
    }

    public CameraAttributes Clone() {
      return new CameraAttributes(this);
    }

    /// <summary>Field number for the "disk_radius_m" field.</summary>
    public const int DiskRadiusMFieldNumber = 1;
    private float diskRadiusM_;
    public float DiskRadiusM {
      get { return diskRadiusM_; }
      set {
        diskRadiusM_ = value;
      }
    }

    /// <summary>Field number for the "cylinder_radius_m" field.</summary>
    public const int CylinderRadiusMFieldNumber = 2;
    private float cylinderRadiusM_;
    public float CylinderRadiusM {
      get { return cylinderRadiusM_; }
      set {
        cylinderRadiusM_ = value;
      }
    }

    /// <summary>Field number for the "cylinder_height_m" field.</summary>
    public const int CylinderHeightMFieldNumber = 3;
    private float cylinderHeightM_;
    public float CylinderHeightM {
      get { return cylinderHeightM_; }
      set {
        cylinderHeightM_ = value;
      }
    }

    /// <summary>Field number for the "cylinder_ground_m" field.</summary>
    public const int CylinderGroundMFieldNumber = 4;
    private float cylinderGroundM_;
    public float CylinderGroundM {
      get { return cylinderGroundM_; }
      set {
        cylinderGroundM_ = value;
      }
    }

    /// <summary>Field number for the "shoulder_mode_scale" field.</summary>
    public const int ShoulderModeScaleFieldNumber = 5;
    private float shoulderModeScale_;
    public float ShoulderModeScale {
      get { return shoulderModeScale_; }
      set {
        shoulderModeScale_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as CameraAttributes);
    }

    public bool Equals(CameraAttributes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DiskRadiusM != other.DiskRadiusM) return false;
      if (CylinderRadiusM != other.CylinderRadiusM) return false;
      if (CylinderHeightM != other.CylinderHeightM) return false;
      if (CylinderGroundM != other.CylinderGroundM) return false;
      if (ShoulderModeScale != other.ShoulderModeScale) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (DiskRadiusM != 0F) hash ^= DiskRadiusM.GetHashCode();
      if (CylinderRadiusM != 0F) hash ^= CylinderRadiusM.GetHashCode();
      if (CylinderHeightM != 0F) hash ^= CylinderHeightM.GetHashCode();
      if (CylinderGroundM != 0F) hash ^= CylinderGroundM.GetHashCode();
      if (ShoulderModeScale != 0F) hash ^= ShoulderModeScale.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (DiskRadiusM != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(DiskRadiusM);
      }
      if (CylinderRadiusM != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(CylinderRadiusM);
      }
      if (CylinderHeightM != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(CylinderHeightM);
      }
      if (CylinderGroundM != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(CylinderGroundM);
      }
      if (ShoulderModeScale != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(ShoulderModeScale);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (DiskRadiusM != 0F) {
        size += 1 + 4;
      }
      if (CylinderRadiusM != 0F) {
        size += 1 + 4;
      }
      if (CylinderHeightM != 0F) {
        size += 1 + 4;
      }
      if (CylinderGroundM != 0F) {
        size += 1 + 4;
      }
      if (ShoulderModeScale != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    public void MergeFrom(CameraAttributes other) {
      if (other == null) {
        return;
      }
      if (other.DiskRadiusM != 0F) {
        DiskRadiusM = other.DiskRadiusM;
      }
      if (other.CylinderRadiusM != 0F) {
        CylinderRadiusM = other.CylinderRadiusM;
      }
      if (other.CylinderHeightM != 0F) {
        CylinderHeightM = other.CylinderHeightM;
      }
      if (other.CylinderGroundM != 0F) {
        CylinderGroundM = other.CylinderGroundM;
      }
      if (other.ShoulderModeScale != 0F) {
        ShoulderModeScale = other.ShoulderModeScale;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 13: {
            DiskRadiusM = input.ReadFloat();
            break;
          }
          case 21: {
            CylinderRadiusM = input.ReadFloat();
            break;
          }
          case 29: {
            CylinderHeightM = input.ReadFloat();
            break;
          }
          case 37: {
            CylinderGroundM = input.ReadFloat();
            break;
          }
          case 45: {
            ShoulderModeScale = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code