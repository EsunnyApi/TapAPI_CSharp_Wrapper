/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace TapQuoteAPI {

using System;
using System.Runtime.InteropServices;

public class TapAPIHisQuoteQryReq : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIHisQuoteQryReq(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TapAPIHisQuoteQryReq obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIHisQuoteQryReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapQuotePINVOKE.delete_TapAPIHisQuoteQryReq(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public TapAPIContract Contract {
    set {
      TapQuotePINVOKE.TapAPIHisQuoteQryReq_Contract_set(swigCPtr, TapAPIContract.getCPtr(value));
    } 
    get {
      IntPtr cPtr = TapQuotePINVOKE.TapAPIHisQuoteQryReq_Contract_get(swigCPtr);
      TapAPIContract ret = (cPtr == IntPtr.Zero) ? null : new TapAPIContract(cPtr, false);
      return ret;
    } 
  }

  public char HisQuoteType {
    set {
      TapQuotePINVOKE.TapAPIHisQuoteQryReq_HisQuoteType_set(swigCPtr, value);
    } 
    get {
      char ret = TapQuotePINVOKE.TapAPIHisQuoteQryReq_HisQuoteType_get(swigCPtr);
      return ret;
    } 
  }

  public string HisQuoteEndTime {
    set {
      TapQuotePINVOKE.TapAPIHisQuoteQryReq_HisQuoteEndTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIHisQuoteQryReq_HisQuoteEndTime_get(swigCPtr);
      return ret;
    } 
  }

  public ulong HisQuoteCandleQryCount {
    set {
      TapQuotePINVOKE.TapAPIHisQuoteQryReq_HisQuoteCandleQryCount_set(swigCPtr, value);
    } 
    get {
      ulong ret = TapQuotePINVOKE.TapAPIHisQuoteQryReq_HisQuoteCandleQryCount_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIHisQuoteQryReq() : this(TapQuotePINVOKE.new_TapAPIHisQuoteQryReq__SWIG_0(), true) {
  }

  public TapAPIHisQuoteQryReq(TapAPIHisQuoteQryReq other) : this(TapQuotePINVOKE.new_TapAPIHisQuoteQryReq__SWIG_1(TapAPIHisQuoteQryReq.getCPtr(other)), true) {
    if (TapQuotePINVOKE.SWIGPendingException.Pending) throw TapQuotePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
