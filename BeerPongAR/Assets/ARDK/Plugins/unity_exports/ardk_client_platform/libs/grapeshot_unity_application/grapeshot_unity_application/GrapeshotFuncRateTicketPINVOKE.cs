//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Grapeshot {

class GrapeshotFuncRateTicketPINVOKE {

  /// For Mono AOT platforms compatibility
  /// This attribute can be defined in any assembly for Mono AOT to use it.
  public class MonoPInvokeCallbackAttribute : global::System.Attribute {
    public MonoPInvokeCallbackAttribute(global::System.Type t) {
    }
  }


  protected class SWIGExceptionHelper {
    public delegate void ExceptionDelegate(string message); 
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="SWIGRegisterExceptionCallbacks_GrapeshotFuncRateTicket")]
    public static extern void SWIGRegisterExceptionCallbacks_GrapeshotFuncRateTicket(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="SWIGRegisterExceptionArgumentCallbacks_GrapeshotFuncRateTicket")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_GrapeshotFuncRateTicket(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);


    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]


    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]


    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }



    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]


    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_GrapeshotFuncRateTicket(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_GrapeshotFuncRateTicket(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(GrapeshotFuncRateTicketPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(GrapeshotFuncRateTicketPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {
    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="SWIGRegisterStringCallback_GrapeshotFuncRateTicket")]
    public static extern void SWIGRegisterStringCallback_GrapeshotFuncRateTicket(SWIGStringDelegate stringDelegate);


    [GrapeshotFuncRateTicketPINVOKE.MonoPInvokeCallback(typeof(SWIGStringDelegate))]


    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_GrapeshotFuncRateTicket(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static GrapeshotFuncRateTicketPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_FuncRateTicketCallback_FunctionApplicationBridgeBase_invokeApplicationLogic")]
  public static extern void FuncRateTicketCallback_FunctionApplicationBridgeBase_invokeApplicationLogic(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_FuncRateTicketCallback_FunctionApplicationBridgeBase_releaseApplicationCallback")]
  public static extern void FuncRateTicketCallback_FunctionApplicationBridgeBase_releaseApplicationCallback(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_delete_FuncRateTicketCallback_FunctionApplicationBridgeBase")]
  public static extern void delete_FuncRateTicketCallback_FunctionApplicationBridgeBase(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_new_FuncRateTicketCallback_FunctionApplicationBridgeBase")]
  public static extern global::System.IntPtr new_FuncRateTicketCallback_FunctionApplicationBridgeBase();

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_FuncRateTicketCallback_FunctionApplicationBridgeBase_director_connect")]
  public static extern void FuncRateTicketCallback_FunctionApplicationBridgeBase_director_connect(global::System.Runtime.InteropServices.HandleRef jarg1, FuncRateTicketCallback_FunctionApplicationBridgeBase.SwigDelegateFuncRateTicketCallback_FunctionApplicationBridgeBase_0_Dispatcher delegate0_dispatcher, global::System.IntPtr delegate0gcHandlePtr, FuncRateTicketCallback_FunctionApplicationBridgeBase.SwigDelegateFuncRateTicketCallback_FunctionApplicationBridgeBase_1_Dispatcher delegate1_dispatcher, global::System.IntPtr delegate1gcHandlePtr);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_FuncRateTicket_createFuncRateTicket")]
  public static extern global::System.IntPtr FuncRateTicket_createFuncRateTicket(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_delete_FuncRateTicket")]
  public static extern void delete_FuncRateTicket(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_FuncRateTicket_SWIGSmartPtrUpcast")]
  public static extern global::System.IntPtr FuncRateTicket_SWIGSmartPtrUpcast(global::System.IntPtr jarg1);
}

}
