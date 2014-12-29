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

public class TapAPIQuoteContractInfo : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIQuoteContractInfo(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TapAPIQuoteContractInfo obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIQuoteContractInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapQuotePINVOKE.delete_TapAPIQuoteContractInfo(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public TapAPIContract Contract {
    set {
      TapQuotePINVOKE.TapAPIQuoteContractInfo_Contract_set(swigCPtr, TapAPIContract.getCPtr(value));
    } 
    get {
      IntPtr cPtr = TapQuotePINVOKE.TapAPIQuoteContractInfo_Contract_get(swigCPtr);
      TapAPIContract ret = (cPtr == IntPtr.Zero) ? null : new TapAPIContract(cPtr, false);
      return ret;
    } 
  }

  public char ContractType {
    set {
      TapQuotePINVOKE.TapAPIQuoteContractInfo_ContractType_set(swigCPtr, value);
    } 
    get {
      char ret = TapQuotePINVOKE.TapAPIQuoteContractInfo_ContractType_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteUnderlyingContract {
    set {
      TapQuotePINVOKE.TapAPIQuoteContractInfo_QuoteUnderlyingContract_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuoteContractInfo_QuoteUnderlyingContract_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractName {
    set {
      TapQuotePINVOKE.TapAPIQuoteContractInfo_ContractName_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuoteContractInfo_ContractName_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractExpDate {
    set {
      TapQuotePINVOKE.TapAPIQuoteContractInfo_ContractExpDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuoteContractInfo_ContractExpDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LastTradeDate {
    set {
      TapQuotePINVOKE.TapAPIQuoteContractInfo_LastTradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuoteContractInfo_LastTradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string FirstNoticeDate {
    set {
      TapQuotePINVOKE.TapAPIQuoteContractInfo_FirstNoticeDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuoteContractInfo_FirstNoticeDate_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIQuoteContractInfo() : this(TapQuotePINVOKE.new_TapAPIQuoteContractInfo__SWIG_0(), true) {
  }

  public TapAPIQuoteContractInfo(TapAPIQuoteContractInfo other) : this(TapQuotePINVOKE.new_TapAPIQuoteContractInfo__SWIG_1(TapAPIQuoteContractInfo.getCPtr(other)), true) {
    if (TapQuotePINVOKE.SWIGPendingException.Pending) throw TapQuotePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
