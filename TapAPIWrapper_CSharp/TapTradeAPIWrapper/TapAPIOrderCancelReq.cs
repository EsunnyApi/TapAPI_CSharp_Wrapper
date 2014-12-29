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

public class TapAPIOrderCancelReq : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIOrderCancelReq(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TapAPIOrderCancelReq obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIOrderCancelReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradePINVOKE.delete_TapAPIOrderCancelReq(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int RefInt {
    set {
      TapTradePINVOKE.TapAPIOrderCancelReq_RefInt_set(swigCPtr, value);
    } 
    get {
      int ret = TapTradePINVOKE.TapAPIOrderCancelReq_RefInt_get(swigCPtr);
      return ret;
    } 
  }

  public string RefString {
    set {
      TapTradePINVOKE.TapAPIOrderCancelReq_RefString_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradePINVOKE.TapAPIOrderCancelReq_RefString_get(swigCPtr);
      return ret;
    } 
  }

  public char ServerFlag {
    set {
      TapTradePINVOKE.TapAPIOrderCancelReq_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradePINVOKE.TapAPIOrderCancelReq_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      TapTradePINVOKE.TapAPIOrderCancelReq_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradePINVOKE.TapAPIOrderCancelReq_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIOrderCancelReq() : this(TapTradePINVOKE.new_TapAPIOrderCancelReq__SWIG_0(), true) {
  }

  public TapAPIOrderCancelReq(TapAPIOrderCancelReq other) : this(TapTradePINVOKE.new_TapAPIOrderCancelReq__SWIG_1(TapAPIOrderCancelReq.getCPtr(other)), true) {
    if (TapTradePINVOKE.SWIGPendingException.Pending) throw TapTradePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
