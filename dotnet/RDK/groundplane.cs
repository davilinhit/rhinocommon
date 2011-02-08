using System;
using System.Runtime.InteropServices;

#if USING_RDK
namespace Rhino.Render
{
  /// <summary>
  /// Infinite plane for implementation by renderers.  See "SupportsFeature"
  /// </summary>
  public class GroundPlane
  {
    private Rhino.RhinoDoc m_doc;

    internal GroundPlane(Rhino.RhinoDoc doc)
    {
      m_doc = doc;
    }

    /// <summary>
    /// Determines whether the document ground plane is enabled.
    /// </summary>
    public bool Enabled
    {
      get { return UnsafeNativeMethods.Rdk_GroundPlane_Enabled(); }
      set { UnsafeNativeMethods.Rdk_GroundPlane_SetEnabled(value); }
    }

    /// <summary>
    /// Height above world XY plane in model units
    /// </summary>
    public double Altitude
    {
      get { return UnsafeNativeMethods.Rdk_GroundPlane_Altitude(); }
      set { UnsafeNativeMethods.Rdk_GroundPlane_SetAltitude(value); }
    }

    /// <summary>
    /// Id of material in material table for this ground plane
    /// </summary>
    public Guid MaterialInstanceId
    {
      get { return UnsafeNativeMethods.Rdk_GroundPlane_MaterialInstanceId(); }
      set { UnsafeNativeMethods.Rdk_GroundPlane_SetMaterialInstanceId(value); }
    }

    /// <summary>
    /// Texture mapping offset in world units
    /// </summary>
    public Rhino.Geometry.Vector2d TextureOffset
    {
      get
      {
        Rhino.Geometry.Vector2d v = new Rhino.Geometry.Vector2d();
        UnsafeNativeMethods.Rdk_GroundPlane_TextureOffset(ref v);
        return v;
      }
      set { UnsafeNativeMethods.Rdk_GroundPlane_SetTextureOffset(value); }
    }

    /// <summary>
    /// Texture mapping single UV span size in world units
    /// </summary>
    public Rhino.Geometry.Vector2d TextureSize
    {
      get
      {
        Rhino.Geometry.Vector2d v = new Rhino.Geometry.Vector2d();
        UnsafeNativeMethods.Rdk_GroundPlane_TextureSize(ref v);
        return v;
      }
      set { UnsafeNativeMethods.Rdk_GroundPlane_SetTextureSize(value); }
    }

    /// <summary>
    /// Texture mapping rotation around world origin + offset in degrees
    /// </summary>
    public double TextureRotation
    {
      get { return UnsafeNativeMethods.Rdk_GroundPlane_TextureRotation(); }
      set { UnsafeNativeMethods.Rdk_GroundPlane_SetTextureRotation(value); }
    }
  }
}
#endif