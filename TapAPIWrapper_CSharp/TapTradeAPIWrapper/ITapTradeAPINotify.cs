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

public class ITapTradeAPINotify : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ITapTradeAPINotify(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ITapTradeAPINotify obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ITapTradeAPINotify() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradePINVOKE.delete_ITapTradeAPINotify(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual void OnConnect() {
    TapTradePINVOKE.ITapTradeAPINotify_OnConnect(swigCPtr);
  }

  public virtual void OnRspLogin(int errorCode, TapAPITradeLoginRspInfo loginRspInfo) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspLogin(swigCPtr, errorCode, TapAPITradeLoginRspInfo.getCPtr(loginRspInfo));
  }

  public virtual void OnAPIReady() {
    TapTradePINVOKE.ITapTradeAPINotify_OnAPIReady(swigCPtr);
  }

  public virtual void OnDisconnect(int reasonCode) {
    TapTradePINVOKE.ITapTradeAPINotify_OnDisconnect(swigCPtr, reasonCode);
  }

  public virtual void OnRspChangePassword(uint sessionID, int errorCode) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspChangePassword(swigCPtr, sessionID, errorCode);
  }

  public virtual void OnRspSetReservedInfo(uint sessionID, int errorCode, string info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspSetReservedInfo(swigCPtr, sessionID, errorCode, info);
  }

  public virtual void OnRspQryAccount(uint sessionID, uint errorCode, char isLast, TapAPIAccountInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspQryAccount(swigCPtr, sessionID, errorCode, isLast, TapAPIAccountInfo.getCPtr(info));
  }

  public virtual void OnRspQryFund(uint sessionID, int errorCode, char isLast, TapAPIFundData info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspQryFund(swigCPtr, sessionID, errorCode, isLast, TapAPIFundData.getCPtr(info));
  }

  public virtual void OnRtnFund(TapAPIFundData info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRtnFund(swigCPtr, TapAPIFundData.getCPtr(info));
  }

  public virtual void OnRspQryExchange(uint sessionID, int errorCode, char isLast, TapAPIExchangeInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspQryExchange(swigCPtr, sessionID, errorCode, isLast, TapAPIExchangeInfo.getCPtr(info));
  }

  public virtual void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPICommodityInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspQryCommodity(swigCPtr, sessionID, errorCode, isLast, TapAPICommodityInfo.getCPtr(info));
  }

  public virtual void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPITradeContractInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspQryContract(swigCPtr, sessionID, errorCode, isLast, TapAPITradeContractInfo.getCPtr(info));
  }

  public virtual void OnRtnContract(TapAPITradeContractInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRtnContract(swigCPtr, TapAPITradeContractInfo.getCPtr(info));
  }

  public virtual void OnRtnOrder(TapAPIOrderInfoNotice info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRtnOrder(swigCPtr, TapAPIOrderInfoNotice.getCPtr(info));
  }

  public virtual void OnRspOrderAction(uint sessionID, uint errorCode, TapAPIOrderActionRsp info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspOrderAction(swigCPtr, sessionID, errorCode, TapAPIOrderActionRsp.getCPtr(info));
  }

  public virtual void OnRspQryOrder(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspQryOrder(swigCPtr, sessionID, errorCode, isLast, TapAPIOrderInfo.getCPtr(info));
  }

  public virtual void OnRspQryOrderProcess(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspQryOrderProcess(swigCPtr, sessionID, errorCode, isLast, TapAPIOrderInfo.getCPtr(info));
  }

  public virtual void OnRspQryFill(uint sessionID, int errorCode, char isLast, TapAPIFillInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspQryFill(swigCPtr, sessionID, errorCode, isLast, TapAPIFillInfo.getCPtr(info));
  }

  public virtual void OnRtnFill(TapAPIFillInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRtnFill(swigCPtr, TapAPIFillInfo.getCPtr(info));
  }

  public virtual void OnRspQryPosition(uint sessionID, int errorCode, char isLast, TapAPIPositionInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspQryPosition(swigCPtr, sessionID, errorCode, isLast, TapAPIPositionInfo.getCPtr(info));
  }

  public virtual void OnRtnPosition(TapAPIPositionInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRtnPosition(swigCPtr, TapAPIPositionInfo.getCPtr(info));
  }

  public virtual void OnRspQryClose(uint sessionID, int errorCode, char isLast, TapAPICloseInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspQryClose(swigCPtr, sessionID, errorCode, isLast, TapAPICloseInfo.getCPtr(info));
  }

  public virtual void OnRtnClose(TapAPICloseInfo info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRtnClose(swigCPtr, TapAPICloseInfo.getCPtr(info));
  }

  public virtual void OnRtnPositionProfit(TapAPIPositionProfitNotice info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRtnPositionProfit(swigCPtr, TapAPIPositionProfitNotice.getCPtr(info));
  }

  public virtual void OnRspQryDeepQuote(uint sessionID, int errorCode, char isLast, TapAPIDeepQuoteQryRsp info) {
    TapTradePINVOKE.ITapTradeAPINotify_OnRspQryDeepQuote(swigCPtr, sessionID, errorCode, isLast, TapAPIDeepQuoteQryRsp.getCPtr(info));
  }

  public ITapTradeAPINotify() : this(TapTradePINVOKE.new_ITapTradeAPINotify__SWIG_0(), true) {
    SwigDirectorConnect();
  }

  public ITapTradeAPINotify(ITapTradeAPINotify other) : this(TapTradePINVOKE.new_ITapTradeAPINotify__SWIG_1(ITapTradeAPINotify.getCPtr(other)), true) {
    if (TapTradePINVOKE.SWIGPendingException.Pending) throw TapTradePINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnConnect", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateITapTradeAPINotify_0(SwigDirectorOnConnect);
    if (SwigDerivedClassHasMethod("OnRspLogin", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateITapTradeAPINotify_1(SwigDirectorOnRspLogin);
    if (SwigDerivedClassHasMethod("OnAPIReady", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateITapTradeAPINotify_2(SwigDirectorOnAPIReady);
    if (SwigDerivedClassHasMethod("OnDisconnect", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateITapTradeAPINotify_3(SwigDirectorOnDisconnect);
    if (SwigDerivedClassHasMethod("OnRspChangePassword", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateITapTradeAPINotify_4(SwigDirectorOnRspChangePassword);
    if (SwigDerivedClassHasMethod("OnRspSetReservedInfo", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateITapTradeAPINotify_5(SwigDirectorOnRspSetReservedInfo);
    if (SwigDerivedClassHasMethod("OnRspQryAccount", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateITapTradeAPINotify_6(SwigDirectorOnRspQryAccount);
    if (SwigDerivedClassHasMethod("OnRspQryFund", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateITapTradeAPINotify_7(SwigDirectorOnRspQryFund);
    if (SwigDerivedClassHasMethod("OnRtnFund", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateITapTradeAPINotify_8(SwigDirectorOnRtnFund);
    if (SwigDerivedClassHasMethod("OnRspQryExchange", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateITapTradeAPINotify_9(SwigDirectorOnRspQryExchange);
    if (SwigDerivedClassHasMethod("OnRspQryCommodity", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateITapTradeAPINotify_10(SwigDirectorOnRspQryCommodity);
    if (SwigDerivedClassHasMethod("OnRspQryContract", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateITapTradeAPINotify_11(SwigDirectorOnRspQryContract);
    if (SwigDerivedClassHasMethod("OnRtnContract", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateITapTradeAPINotify_12(SwigDirectorOnRtnContract);
    if (SwigDerivedClassHasMethod("OnRtnOrder", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateITapTradeAPINotify_13(SwigDirectorOnRtnOrder);
    if (SwigDerivedClassHasMethod("OnRspOrderAction", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateITapTradeAPINotify_14(SwigDirectorOnRspOrderAction);
    if (SwigDerivedClassHasMethod("OnRspQryOrder", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateITapTradeAPINotify_15(SwigDirectorOnRspQryOrder);
    if (SwigDerivedClassHasMethod("OnRspQryOrderProcess", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateITapTradeAPINotify_16(SwigDirectorOnRspQryOrderProcess);
    if (SwigDerivedClassHasMethod("OnRspQryFill", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateITapTradeAPINotify_17(SwigDirectorOnRspQryFill);
    if (SwigDerivedClassHasMethod("OnRtnFill", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateITapTradeAPINotify_18(SwigDirectorOnRtnFill);
    if (SwigDerivedClassHasMethod("OnRspQryPosition", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateITapTradeAPINotify_19(SwigDirectorOnRspQryPosition);
    if (SwigDerivedClassHasMethod("OnRtnPosition", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateITapTradeAPINotify_20(SwigDirectorOnRtnPosition);
    if (SwigDerivedClassHasMethod("OnRspQryClose", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateITapTradeAPINotify_21(SwigDirectorOnRspQryClose);
    if (SwigDerivedClassHasMethod("OnRtnClose", swigMethodTypes22))
      swigDelegate22 = new SwigDelegateITapTradeAPINotify_22(SwigDirectorOnRtnClose);
    if (SwigDerivedClassHasMethod("OnRtnPositionProfit", swigMethodTypes23))
      swigDelegate23 = new SwigDelegateITapTradeAPINotify_23(SwigDirectorOnRtnPositionProfit);
    if (SwigDerivedClassHasMethod("OnRspQryDeepQuote", swigMethodTypes24))
      swigDelegate24 = new SwigDelegateITapTradeAPINotify_24(SwigDirectorOnRspQryDeepQuote);
    TapTradePINVOKE.ITapTradeAPINotify_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22, swigDelegate23, swigDelegate24);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ITapTradeAPINotify));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnConnect() {
    OnConnect();
  }

  private void SwigDirectorOnRspLogin(int errorCode, IntPtr loginRspInfo) {
    OnRspLogin(errorCode, (loginRspInfo == IntPtr.Zero) ? null : new TapAPITradeLoginRspInfo(loginRspInfo, false));
  }

  private void SwigDirectorOnAPIReady() {
    OnAPIReady();
  }

  private void SwigDirectorOnDisconnect(int reasonCode) {
    OnDisconnect(reasonCode);
  }

  private void SwigDirectorOnRspChangePassword(uint sessionID, int errorCode) {
    OnRspChangePassword(sessionID, errorCode);
  }

  private void SwigDirectorOnRspSetReservedInfo(uint sessionID, int errorCode, string info) {
    OnRspSetReservedInfo(sessionID, errorCode, info);
  }

  private void SwigDirectorOnRspQryAccount(uint sessionID, uint errorCode, char isLast, IntPtr info) {
    OnRspQryAccount(sessionID, errorCode, isLast, (info == IntPtr.Zero) ? null : new TapAPIAccountInfo(info, false));
  }

  private void SwigDirectorOnRspQryFund(uint sessionID, int errorCode, char isLast, IntPtr info) {
    OnRspQryFund(sessionID, errorCode, isLast, (info == IntPtr.Zero) ? null : new TapAPIFundData(info, false));
  }

  private void SwigDirectorOnRtnFund(IntPtr info) {
    OnRtnFund((info == IntPtr.Zero) ? null : new TapAPIFundData(info, false));
  }

  private void SwigDirectorOnRspQryExchange(uint sessionID, int errorCode, char isLast, IntPtr info) {
    OnRspQryExchange(sessionID, errorCode, isLast, (info == IntPtr.Zero) ? null : new TapAPIExchangeInfo(info, false));
  }

  private void SwigDirectorOnRspQryCommodity(uint sessionID, int errorCode, char isLast, IntPtr info) {
    OnRspQryCommodity(sessionID, errorCode, isLast, (info == IntPtr.Zero) ? null : new TapAPICommodityInfo(info, false));
  }

  private void SwigDirectorOnRspQryContract(uint sessionID, int errorCode, char isLast, IntPtr info) {
    OnRspQryContract(sessionID, errorCode, isLast, (info == IntPtr.Zero) ? null : new TapAPITradeContractInfo(info, false));
  }

  private void SwigDirectorOnRtnContract(IntPtr info) {
    OnRtnContract((info == IntPtr.Zero) ? null : new TapAPITradeContractInfo(info, false));
  }

  private void SwigDirectorOnRtnOrder(IntPtr info) {
    OnRtnOrder((info == IntPtr.Zero) ? null : new TapAPIOrderInfoNotice(info, false));
  }

  private void SwigDirectorOnRspOrderAction(uint sessionID, uint errorCode, IntPtr info) {
    OnRspOrderAction(sessionID, errorCode, (info == IntPtr.Zero) ? null : new TapAPIOrderActionRsp(info, false));
  }

  private void SwigDirectorOnRspQryOrder(uint sessionID, int errorCode, char isLast, IntPtr info) {
    OnRspQryOrder(sessionID, errorCode, isLast, (info == IntPtr.Zero) ? null : new TapAPIOrderInfo(info, false));
  }

  private void SwigDirectorOnRspQryOrderProcess(uint sessionID, int errorCode, char isLast, IntPtr info) {
    OnRspQryOrderProcess(sessionID, errorCode, isLast, (info == IntPtr.Zero) ? null : new TapAPIOrderInfo(info, false));
  }

  private void SwigDirectorOnRspQryFill(uint sessionID, int errorCode, char isLast, IntPtr info) {
    OnRspQryFill(sessionID, errorCode, isLast, (info == IntPtr.Zero) ? null : new TapAPIFillInfo(info, false));
  }

  private void SwigDirectorOnRtnFill(IntPtr info) {
    OnRtnFill((info == IntPtr.Zero) ? null : new TapAPIFillInfo(info, false));
  }

  private void SwigDirectorOnRspQryPosition(uint sessionID, int errorCode, char isLast, IntPtr info) {
    OnRspQryPosition(sessionID, errorCode, isLast, (info == IntPtr.Zero) ? null : new TapAPIPositionInfo(info, false));
  }

  private void SwigDirectorOnRtnPosition(IntPtr info) {
    OnRtnPosition((info == IntPtr.Zero) ? null : new TapAPIPositionInfo(info, false));
  }

  private void SwigDirectorOnRspQryClose(uint sessionID, int errorCode, char isLast, IntPtr info) {
    OnRspQryClose(sessionID, errorCode, isLast, (info == IntPtr.Zero) ? null : new TapAPICloseInfo(info, false));
  }

  private void SwigDirectorOnRtnClose(IntPtr info) {
    OnRtnClose((info == IntPtr.Zero) ? null : new TapAPICloseInfo(info, false));
  }

  private void SwigDirectorOnRtnPositionProfit(IntPtr info) {
    OnRtnPositionProfit((info == IntPtr.Zero) ? null : new TapAPIPositionProfitNotice(info, false));
  }

  private void SwigDirectorOnRspQryDeepQuote(uint sessionID, int errorCode, char isLast, IntPtr info) {
    OnRspQryDeepQuote(sessionID, errorCode, isLast, (info == IntPtr.Zero) ? null : new TapAPIDeepQuoteQryRsp(info, false));
  }

  public delegate void SwigDelegateITapTradeAPINotify_0();
  public delegate void SwigDelegateITapTradeAPINotify_1(int errorCode, IntPtr loginRspInfo);
  public delegate void SwigDelegateITapTradeAPINotify_2();
  public delegate void SwigDelegateITapTradeAPINotify_3(int reasonCode);
  public delegate void SwigDelegateITapTradeAPINotify_4(uint sessionID, int errorCode);
  public delegate void SwigDelegateITapTradeAPINotify_5(uint sessionID, int errorCode, string info);
  public delegate void SwigDelegateITapTradeAPINotify_6(uint sessionID, uint errorCode, char isLast, IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_7(uint sessionID, int errorCode, char isLast, IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_8(IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_9(uint sessionID, int errorCode, char isLast, IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_10(uint sessionID, int errorCode, char isLast, IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_11(uint sessionID, int errorCode, char isLast, IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_12(IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_13(IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_14(uint sessionID, uint errorCode, IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_15(uint sessionID, int errorCode, char isLast, IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_16(uint sessionID, int errorCode, char isLast, IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_17(uint sessionID, int errorCode, char isLast, IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_18(IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_19(uint sessionID, int errorCode, char isLast, IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_20(IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_21(uint sessionID, int errorCode, char isLast, IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_22(IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_23(IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_24(uint sessionID, int errorCode, char isLast, IntPtr info);

  private SwigDelegateITapTradeAPINotify_0 swigDelegate0;
  private SwigDelegateITapTradeAPINotify_1 swigDelegate1;
  private SwigDelegateITapTradeAPINotify_2 swigDelegate2;
  private SwigDelegateITapTradeAPINotify_3 swigDelegate3;
  private SwigDelegateITapTradeAPINotify_4 swigDelegate4;
  private SwigDelegateITapTradeAPINotify_5 swigDelegate5;
  private SwigDelegateITapTradeAPINotify_6 swigDelegate6;
  private SwigDelegateITapTradeAPINotify_7 swigDelegate7;
  private SwigDelegateITapTradeAPINotify_8 swigDelegate8;
  private SwigDelegateITapTradeAPINotify_9 swigDelegate9;
  private SwigDelegateITapTradeAPINotify_10 swigDelegate10;
  private SwigDelegateITapTradeAPINotify_11 swigDelegate11;
  private SwigDelegateITapTradeAPINotify_12 swigDelegate12;
  private SwigDelegateITapTradeAPINotify_13 swigDelegate13;
  private SwigDelegateITapTradeAPINotify_14 swigDelegate14;
  private SwigDelegateITapTradeAPINotify_15 swigDelegate15;
  private SwigDelegateITapTradeAPINotify_16 swigDelegate16;
  private SwigDelegateITapTradeAPINotify_17 swigDelegate17;
  private SwigDelegateITapTradeAPINotify_18 swigDelegate18;
  private SwigDelegateITapTradeAPINotify_19 swigDelegate19;
  private SwigDelegateITapTradeAPINotify_20 swigDelegate20;
  private SwigDelegateITapTradeAPINotify_21 swigDelegate21;
  private SwigDelegateITapTradeAPINotify_22 swigDelegate22;
  private SwigDelegateITapTradeAPINotify_23 swigDelegate23;
  private SwigDelegateITapTradeAPINotify_24 swigDelegate24;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(int), typeof(TapAPITradeLoginRspInfo) };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(int) };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(uint), typeof(int) };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(uint), typeof(int), typeof(string) };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(uint), typeof(uint), typeof(char), typeof(TapAPIAccountInfo) };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIFundData) };
  private static Type[] swigMethodTypes8 = new Type[] { typeof(TapAPIFundData) };
  private static Type[] swigMethodTypes9 = new Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIExchangeInfo) };
  private static Type[] swigMethodTypes10 = new Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPICommodityInfo) };
  private static Type[] swigMethodTypes11 = new Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPITradeContractInfo) };
  private static Type[] swigMethodTypes12 = new Type[] { typeof(TapAPITradeContractInfo) };
  private static Type[] swigMethodTypes13 = new Type[] { typeof(TapAPIOrderInfoNotice) };
  private static Type[] swigMethodTypes14 = new Type[] { typeof(uint), typeof(uint), typeof(TapAPIOrderActionRsp) };
  private static Type[] swigMethodTypes15 = new Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIOrderInfo) };
  private static Type[] swigMethodTypes16 = new Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIOrderInfo) };
  private static Type[] swigMethodTypes17 = new Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIFillInfo) };
  private static Type[] swigMethodTypes18 = new Type[] { typeof(TapAPIFillInfo) };
  private static Type[] swigMethodTypes19 = new Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIPositionInfo) };
  private static Type[] swigMethodTypes20 = new Type[] { typeof(TapAPIPositionInfo) };
  private static Type[] swigMethodTypes21 = new Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPICloseInfo) };
  private static Type[] swigMethodTypes22 = new Type[] { typeof(TapAPICloseInfo) };
  private static Type[] swigMethodTypes23 = new Type[] { typeof(TapAPIPositionProfitNotice) };
  private static Type[] swigMethodTypes24 = new Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIDeepQuoteQryRsp) };
}

}
