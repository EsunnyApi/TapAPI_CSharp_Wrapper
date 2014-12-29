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

public class TapAPIContract : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIContract(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TapAPIContract obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIContract() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradePINVOKE.delete_TapAPIContract(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public TapAPICommodity Commodity {
    set {
      TapTradePINVOKE.TapAPIContract_Commodity_set(swigCPtr, TapAPICommodity.getCPtr(value));
    } 
    get {
      IntPtr cPtr = TapTradePINVOKE.TapAPIContract_Commodity_get(swigCPtr);
      TapAPICommodity ret = (cPtr == IntPtr.Zero) ? null : new TapAPICommodity(cPtr, false);
      return ret;
    } 
  }

  public string ContractNo1 {
    set {
      TapTradePINVOKE.TapAPIContract_ContractNo1_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradePINVOKE.TapAPIContract_ContractNo1_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice1 {
    set {
      TapTradePINVOKE.TapAPIContract_StrikePrice1_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradePINVOKE.TapAPIContract_StrikePrice1_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag1 {
    set {
      TapTradePINVOKE.TapAPIContract_CallOrPutFlag1_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradePINVOKE.TapAPIContract_CallOrPutFlag1_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo2 {
    set {
      TapTradePINVOKE.TapAPIContract_ContractNo2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradePINVOKE.TapAPIContract_ContractNo2_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice2 {
    set {
      TapTradePINVOKE.TapAPIContract_StrikePrice2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradePINVOKE.TapAPIContract_StrikePrice2_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag2 {
    set {
      TapTradePINVOKE.TapAPIContract_CallOrPutFlag2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradePINVOKE.TapAPIContract_CallOrPutFlag2_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIContract() : this(TapTradePINVOKE.new_TapAPIContract__SWIG_0(), true) {
  }

  public TapAPIContract(TapAPIContract other) : this(TapTradePINVOKE.new_TapAPIContract__SWIG_1(TapAPIContract.getCPtr(other)), true) {
    if (TapTradePINVOKE.SWIGPendingException.Pending) throw TapTradePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
