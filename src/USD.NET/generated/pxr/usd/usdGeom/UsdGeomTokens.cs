//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class UsdGeomTokens : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdGeomTokens(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomTokens obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static TfToken all = new TfToken("all");
  public static TfToken angularVelocities = new TfToken("angularVelocities");
  public static TfToken axis = new TfToken("axis");
  public static TfToken basis = new TfToken("basis");
  public static TfToken bezier = new TfToken("bezier");
  public static TfToken bilinear = new TfToken("bilinear");
  public static TfToken boundaries = new TfToken("boundaries");
  public static TfToken bounds = new TfToken("bounds");
  public static TfToken box = new TfToken("box");
  public static TfToken bspline = new TfToken("bspline");
  public static TfToken cards = new TfToken("cards");
  public static TfToken catmullClark = new TfToken("catmullClark");
  public static TfToken catmullRom = new TfToken("catmullRom");
  public static TfToken clippingPlanes = new TfToken("clippingPlanes");
  public static TfToken clippingRange = new TfToken("clippingRange");
  public static TfToken closed = new TfToken("closed");
  public static TfToken constant = new TfToken("constant");
  public static TfToken cornerIndices = new TfToken("cornerIndices");
  public static TfToken cornerSharpnesses = new TfToken("cornerSharpnesses");
  public static TfToken cornersOnly = new TfToken("cornersOnly");
  public static TfToken cornersPlus1 = new TfToken("cornersPlus1");
  public static TfToken cornersPlus2 = new TfToken("cornersPlus2");
  public static TfToken creaseIndices = new TfToken("creaseIndices");
  public static TfToken creaseLengths = new TfToken("creaseLengths");
  public static TfToken creaseSharpnesses = new TfToken("creaseSharpnesses");
  public static TfToken cross = new TfToken("cross");
  public static TfToken cubic = new TfToken("cubic");
  public static TfToken curveVertexCounts = new TfToken("curveVertexCounts");
  public static TfToken default_ = new TfToken("default");
  public static TfToken doubleSided = new TfToken("doubleSided");
  public static TfToken edgeAndCorner = new TfToken("edgeAndCorner");
  public static TfToken edgeOnly = new TfToken("edgeOnly");
  public static TfToken elementSize = new TfToken("elementSize");
  public static TfToken elementType = new TfToken("elementType");
  public static TfToken extent = new TfToken("extent");
  public static TfToken extentsHint = new TfToken("extentsHint");
  public static TfToken fStop = new TfToken("fStop");
  public static TfToken face = new TfToken("face");
  public static TfToken faceVarying = new TfToken("faceVarying");
  public static TfToken faceVaryingLinearInterpolation = new TfToken("faceVaryingLinearInterpolation");
  public static TfToken faceVertexCounts = new TfToken("faceVertexCounts");
  public static TfToken faceVertexIndices = new TfToken("faceVertexIndices");
  public static TfToken familyName = new TfToken("familyName");
  public static TfToken focalLength = new TfToken("focalLength");
  public static TfToken focusDistance = new TfToken("focusDistance");
  public static TfToken fromTexture = new TfToken("fromTexture");
  public static TfToken guide = new TfToken("guide");
  public static TfToken height = new TfToken("height");
  public static TfToken hermite = new TfToken("hermite");
  public static TfToken holeIndices = new TfToken("holeIndices");
  public static TfToken horizontalAperture = new TfToken("horizontalAperture");
  public static TfToken horizontalApertureOffset = new TfToken("horizontalApertureOffset");
  public static TfToken ids = new TfToken("ids");
  public static TfToken inactiveIds = new TfToken("inactiveIds");
  public static TfToken indices = new TfToken("indices");
  public static TfToken inherited = new TfToken("inherited");
  public static TfToken interpolateBoundary = new TfToken("interpolateBoundary");
  public static TfToken interpolation = new TfToken("interpolation");
  public static TfToken invisible = new TfToken("invisible");
  public static TfToken invisibleIds = new TfToken("invisibleIds");
  public static TfToken knots = new TfToken("knots");
  public static TfToken left = new TfToken("left");
  public static TfToken leftHanded = new TfToken("leftHanded");
  public static TfToken linear = new TfToken("linear");
  public static TfToken loop = new TfToken("loop");
  public static TfToken metersPerUnit = new TfToken("metersPerUnit");
  public static TfToken modelApplyDrawMode = new TfToken("model:applyDrawMode");
  public static TfToken modelCardGeometry = new TfToken("model:cardGeometry");
  public static TfToken modelCardTextureXNeg = new TfToken("model:cardTextureXNeg");
  public static TfToken modelCardTextureXPos = new TfToken("model:cardTextureXPos");
  public static TfToken modelCardTextureYNeg = new TfToken("model:cardTextureYNeg");
  public static TfToken modelCardTextureYPos = new TfToken("model:cardTextureYPos");
  public static TfToken modelCardTextureZNeg = new TfToken("model:cardTextureZNeg");
  public static TfToken modelCardTextureZPos = new TfToken("model:cardTextureZPos");
  public static TfToken modelDrawMode = new TfToken("model:drawMode");
  public static TfToken modelDrawModeColor = new TfToken("model:drawModeColor");
  public static TfToken mono = new TfToken("mono");
  public static TfToken motionVelocityScale = new TfToken("motion:velocityScale");
  public static TfToken nonOverlapping = new TfToken("nonOverlapping");
  public static TfToken none = new TfToken("none");
  public static TfToken nonperiodic = new TfToken("nonperiodic");
  public static TfToken normals = new TfToken("normals");
  public static TfToken open = new TfToken("open");
  public static TfToken order = new TfToken("order");
  public static TfToken orientation = new TfToken("orientation");
  public static TfToken orientations = new TfToken("orientations");
  public static TfToken origin = new TfToken("origin");
  public static TfToken orthographic = new TfToken("orthographic");
  public static TfToken partition = new TfToken("partition");
  public static TfToken periodic = new TfToken("periodic");
  public static TfToken perspective = new TfToken("perspective");
  public static TfToken pointWeights = new TfToken("pointWeights");
  public static TfToken points = new TfToken("points");
  public static TfToken positions = new TfToken("positions");
  public static TfToken power = new TfToken("power");
  public static TfToken primvarsDisplayColor = new TfToken("primvars:displayColor");
  public static TfToken primvarsDisplayOpacity = new TfToken("primvars:displayOpacity");
  public static TfToken projection = new TfToken("projection");
  public static TfToken protoIndices = new TfToken("protoIndices");
  public static TfToken prototypes = new TfToken("prototypes");
  public static TfToken proxy = new TfToken("proxy");
  public static TfToken proxyPrim = new TfToken("proxyPrim");
  public static TfToken purpose = new TfToken("purpose");
  public static TfToken radius = new TfToken("radius");
  public static TfToken ranges = new TfToken("ranges");
  public static TfToken render = new TfToken("render");
  public static TfToken right = new TfToken("right");
  public static TfToken rightHanded = new TfToken("rightHanded");
  public static TfToken scales = new TfToken("scales");
  public static TfToken shutterClose = new TfToken("shutter:close");
  public static TfToken shutterOpen = new TfToken("shutter:open");
  public static TfToken size = new TfToken("size");
  public static TfToken smooth = new TfToken("smooth");
  public static TfToken stereoRole = new TfToken("stereoRole");
  public static TfToken subdivisionScheme = new TfToken("subdivisionScheme");
  public static TfToken triangleSubdivisionRule = new TfToken("triangleSubdivisionRule");
  public static TfToken trimCurveCounts = new TfToken("trimCurve:counts");
  public static TfToken trimCurveKnots = new TfToken("trimCurve:knots");
  public static TfToken trimCurveOrders = new TfToken("trimCurve:orders");
  public static TfToken trimCurvePoints = new TfToken("trimCurve:points");
  public static TfToken trimCurveRanges = new TfToken("trimCurve:ranges");
  public static TfToken trimCurveVertexCounts = new TfToken("trimCurve:vertexCounts");
  public static TfToken type = new TfToken("type");
  public static TfToken uForm = new TfToken("uForm");
  public static TfToken uKnots = new TfToken("uKnots");
  public static TfToken uOrder = new TfToken("uOrder");
  public static TfToken uRange = new TfToken("uRange");
  public static TfToken uVertexCount = new TfToken("uVertexCount");
  public static TfToken unauthoredValuesIndex = new TfToken("unauthoredValuesIndex");
  public static TfToken uniform = new TfToken("uniform");
  public static TfToken unrestricted = new TfToken("unrestricted");
  public static TfToken upAxis = new TfToken("upAxis");
  public static TfToken vForm = new TfToken("vForm");
  public static TfToken vKnots = new TfToken("vKnots");
  public static TfToken vOrder = new TfToken("vOrder");
  public static TfToken vRange = new TfToken("vRange");
  public static TfToken vVertexCount = new TfToken("vVertexCount");
  public static TfToken varying = new TfToken("varying");
  public static TfToken velocities = new TfToken("velocities");
  public static TfToken vertex = new TfToken("vertex");
  public static TfToken verticalAperture = new TfToken("verticalAperture");
  public static TfToken verticalApertureOffset = new TfToken("verticalApertureOffset");
  public static TfToken visibility = new TfToken("visibility");
  public static TfToken widths = new TfToken("widths");
  public static TfToken wrap = new TfToken("wrap");
  public static TfToken x = new TfToken("X");
  public static TfToken xformOpOrder = new TfToken("xformOpOrder");
  public static TfToken y = new TfToken("Y");
  public static TfToken z = new TfToken("Z");

}

}