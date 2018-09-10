//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Aqrose.Aidi {

public class AIDI : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AIDI(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AIDI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AIDI() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csharpaidiclientPINVOKE.delete_AIDI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AIDI(string check_code) : this(csharpaidiclientPINVOKE.new_AIDI__SWIG_0(check_code), true) {
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public AIDI() : this(csharpaidiclientPINVOKE.new_AIDI__SWIG_1(), true) {
  }

  public void set_param(FactoryClientParamWrapper arg0) {
    csharpaidiclientPINVOKE.AIDI_set_param(swigCPtr, FactoryClientParamWrapper.getCPtr(arg0));
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public void initial_test_model() {
    csharpaidiclientPINVOKE.AIDI_initial_test_model(swigCPtr);
  }

  public void set_batch_size(IntVector batch_size) {
    csharpaidiclientPINVOKE.AIDI_set_batch_size(swigCPtr, IntVector.getCPtr(batch_size));
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public string start_test(AidiImage image) {
    string ret = csharpaidiclientPINVOKE.AIDI_start_test__SWIG_0(swigCPtr, AidiImage.getCPtr(image));
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringVector start_test(BatchAidiImage batch_images) {
    StringVector ret = new StringVector(csharpaidiclientPINVOKE.AIDI_start_test__SWIG_1(swigCPtr, BatchAidiImage.getCPtr(batch_images)), true);
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string start_test(SWIGTYPE_p_uchar data, int width, int height) {
    string ret = csharpaidiclientPINVOKE.AIDI_start_test__SWIG_2(swigCPtr, SWIGTYPE_p_uchar.getCPtr(data), width, height);
    return ret;
  }

}

}
