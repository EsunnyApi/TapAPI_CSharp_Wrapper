/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace TapTradeAPI {

using System;
using System.Runtime.InteropServices;

public class TapAPIAccQryReq : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccQryReq(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TapAPIAccQryReq obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIAccQryReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradePINVOKE.delete_TapAPIAccQryReq(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradePINVOKE.TapAPIAccQryReq_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradePINVOKE.TapAPIAccQryReq_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccQryReq() : this(TapTradePINVOKE.new_TapAPIAccQryReq__SWIG_0(), true) {
  }

  public TapAPIAccQryReq(TapAPIAccQryReq other) : this(TapTradePINVOKE.new_TapAPIAccQryReq__SWIG_1(TapAPIAccQryReq.getCPtr(other)), true) {
    if (TapTradePINVOKE.SWIGPendingException.Pending) throw TapTradePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
