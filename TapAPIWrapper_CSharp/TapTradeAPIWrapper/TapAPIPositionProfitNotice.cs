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

public class TapAPIPositionProfitNotice : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIPositionProfitNotice(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TapAPIPositionProfitNotice obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIPositionProfitNotice() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradePINVOKE.delete_TapAPIPositionProfitNotice(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public char IsLast {
    set {
      TapTradePINVOKE.TapAPIPositionProfitNotice_IsLast_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradePINVOKE.TapAPIPositionProfitNotice_IsLast_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIPositionProfit Data {
    set {
      TapTradePINVOKE.TapAPIPositionProfitNotice_Data_set(swigCPtr, TapAPIPositionProfit.getCPtr(value));
    } 
    get {
      IntPtr cPtr = TapTradePINVOKE.TapAPIPositionProfitNotice_Data_get(swigCPtr);
      TapAPIPositionProfit ret = (cPtr == IntPtr.Zero) ? null : new TapAPIPositionProfit(cPtr, false);
      return ret;
    } 
  }

  public TapAPIPositionProfitNotice() : this(TapTradePINVOKE.new_TapAPIPositionProfitNotice__SWIG_0(), true) {
  }

  public TapAPIPositionProfitNotice(TapAPIPositionProfitNotice other) : this(TapTradePINVOKE.new_TapAPIPositionProfitNotice__SWIG_1(TapAPIPositionProfitNotice.getCPtr(other)), true) {
    if (TapTradePINVOKE.SWIGPendingException.Pending) throw TapTradePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
