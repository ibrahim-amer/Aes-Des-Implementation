/*
* MATLAB Compiler: 4.18.1 (R2013a)
* Date: Thu May 08 21:18:51 2014
* Arguments: "-B" "macro_default" "-W" "dotnet:SteganographyMatlab,AES,0.0,private" "-T"
* "link:lib" "-d" "D:\Programming\Security project\AES Matlab\AES
* Matlab\SteganographyMatlab\src" "-w" "enable:specified_file_mismatch" "-w"
* "enable:repeated_file" "-w" "enable:switch_ignored" "-w" "enable:missing_lib_sentinel"
* "-w" "enable:demo_license" "-v" "class{AES:D:\Programming\Security project\AES
* Matlab\AES Matlab\AESDecrypt.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\AESEncrypt.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\block2str.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\blocks2vector.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\bunchbitxor.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\cell2decmat.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\circularshift.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\colwisexor.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\dec2cellhex.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\fifieldsmul.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\getstates.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\KeyExpansion.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\loadmatfile.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\MixCol.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\shiftrows.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\SubBytes.m,D:\Programming\Security project\AES Matlab\AES
* Matlab\vector2blocks.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace SteganographyMatlabNative
{

  /// <summary>
  /// The AES class provides a CLS compliant, Object (native) interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\AESDecrypt.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\AESEncrypt.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\block2str.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\blocks2vector.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\bunchbitxor.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\cell2decmat.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\circularshift.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\colwisexor.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\dec2cellhex.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\fifieldsmul.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\getstates.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\KeyExpansion.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\loadmatfile.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\MixCol.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\shiftrows.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\SubBytes.m
  /// <newpara></newpara>
  /// D:\Programming\Security project\AES Matlab\AES Matlab\vector2blocks.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class AES : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static AES()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "SteganographyMatlab.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the AES class.
    /// </summary>
    public AES()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~AES()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the AESDecrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESDecrypt()
    {
      return mcr.EvaluateFunction("AESDecrypt", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the AESDecrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="ciphertext">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESDecrypt(Object ciphertext)
    {
      return mcr.EvaluateFunction("AESDecrypt", ciphertext);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the AESDecrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="ciphertext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESDecrypt(Object ciphertext, Object cipherkey)
    {
      return mcr.EvaluateFunction("AESDecrypt", ciphertext, cipherkey);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the AESDecrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="ciphertext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESDecrypt(Object ciphertext, Object cipherkey, Object sbox)
    {
      return mcr.EvaluateFunction("AESDecrypt", ciphertext, cipherkey, sbox);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the AESDecrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="ciphertext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <param name="sboxinv">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESDecrypt(Object ciphertext, Object cipherkey, Object sbox, Object 
                       sboxinv)
    {
      return mcr.EvaluateFunction("AESDecrypt", ciphertext, cipherkey, sbox, sboxinv);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the AESDecrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="ciphertext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <param name="sboxinv">Input argument #4</param>
    /// <param name="rcon">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESDecrypt(Object ciphertext, Object cipherkey, Object sbox, Object 
                       sboxinv, Object rcon)
    {
      return mcr.EvaluateFunction("AESDecrypt", ciphertext, cipherkey, sbox, sboxinv, rcon);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the AESDecrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="ciphertext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <param name="sboxinv">Input argument #4</param>
    /// <param name="rcon">Input argument #5</param>
    /// <param name="mixcolmatinv">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESDecrypt(Object ciphertext, Object cipherkey, Object sbox, Object 
                       sboxinv, Object rcon, Object mixcolmatinv)
    {
      return mcr.EvaluateFunction("AESDecrypt", ciphertext, cipherkey, sbox, sboxinv, rcon, mixcolmatinv);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the AESDecrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESDecrypt(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESDecrypt", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the AESDecrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ciphertext">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESDecrypt(int numArgsOut, Object ciphertext)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESDecrypt", ciphertext);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the AESDecrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ciphertext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESDecrypt(int numArgsOut, Object ciphertext, Object cipherkey)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESDecrypt", ciphertext, cipherkey);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the AESDecrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ciphertext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESDecrypt(int numArgsOut, Object ciphertext, Object cipherkey, 
                         Object sbox)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESDecrypt", ciphertext, cipherkey, sbox);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the AESDecrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ciphertext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <param name="sboxinv">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESDecrypt(int numArgsOut, Object ciphertext, Object cipherkey, 
                         Object sbox, Object sboxinv)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESDecrypt", ciphertext, cipherkey, sbox, sboxinv);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the AESDecrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ciphertext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <param name="sboxinv">Input argument #4</param>
    /// <param name="rcon">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESDecrypt(int numArgsOut, Object ciphertext, Object cipherkey, 
                         Object sbox, Object sboxinv, Object rcon)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESDecrypt", ciphertext, cipherkey, sbox, sboxinv, rcon);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the AESDecrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ciphertext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <param name="sboxinv">Input argument #4</param>
    /// <param name="rcon">Input argument #5</param>
    /// <param name="mixcolmatinv">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESDecrypt(int numArgsOut, Object ciphertext, Object cipherkey, 
                         Object sbox, Object sboxinv, Object rcon, Object mixcolmatinv)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESDecrypt", ciphertext, cipherkey, sbox, sboxinv, rcon, mixcolmatinv);
    }


    /// <summary>
    /// Provides an interface for the AESDecrypt function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("AESDecrypt", 6, 1, 0)]
    protected void AESDecrypt(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("AESDecrypt", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the AESEncrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESEncrypt()
    {
      return mcr.EvaluateFunction("AESEncrypt", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the AESEncrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="plaintext">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESEncrypt(Object plaintext)
    {
      return mcr.EvaluateFunction("AESEncrypt", plaintext);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the AESEncrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="plaintext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESEncrypt(Object plaintext, Object cipherkey)
    {
      return mcr.EvaluateFunction("AESEncrypt", plaintext, cipherkey);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the AESEncrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="plaintext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESEncrypt(Object plaintext, Object cipherkey, Object sbox)
    {
      return mcr.EvaluateFunction("AESEncrypt", plaintext, cipherkey, sbox);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the AESEncrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="plaintext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <param name="rcon">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESEncrypt(Object plaintext, Object cipherkey, Object sbox, Object rcon)
    {
      return mcr.EvaluateFunction("AESEncrypt", plaintext, cipherkey, sbox, rcon);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the AESEncrypt MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="plaintext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <param name="rcon">Input argument #4</param>
    /// <param name="mixcolmat">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AESEncrypt(Object plaintext, Object cipherkey, Object sbox, Object 
                       rcon, Object mixcolmat)
    {
      return mcr.EvaluateFunction("AESEncrypt", plaintext, cipherkey, sbox, rcon, mixcolmat);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the AESEncrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESEncrypt(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESEncrypt", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the AESEncrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="plaintext">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESEncrypt(int numArgsOut, Object plaintext)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESEncrypt", plaintext);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the AESEncrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="plaintext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESEncrypt(int numArgsOut, Object plaintext, Object cipherkey)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESEncrypt", plaintext, cipherkey);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the AESEncrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="plaintext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESEncrypt(int numArgsOut, Object plaintext, Object cipherkey, Object 
                         sbox)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESEncrypt", plaintext, cipherkey, sbox);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the AESEncrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="plaintext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <param name="rcon">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESEncrypt(int numArgsOut, Object plaintext, Object cipherkey, Object 
                         sbox, Object rcon)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESEncrypt", plaintext, cipherkey, sbox, rcon);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the AESEncrypt MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="plaintext">Input argument #1</param>
    /// <param name="cipherkey">Input argument #2</param>
    /// <param name="sbox">Input argument #3</param>
    /// <param name="rcon">Input argument #4</param>
    /// <param name="mixcolmat">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AESEncrypt(int numArgsOut, Object plaintext, Object cipherkey, Object 
                         sbox, Object rcon, Object mixcolmat)
    {
      return mcr.EvaluateFunction(numArgsOut, "AESEncrypt", plaintext, cipherkey, sbox, rcon, mixcolmat);
    }


    /// <summary>
    /// Provides an interface for the AESEncrypt function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// for each block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("AESEncrypt", 5, 1, 0)]
    protected void AESEncrypt(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("AESEncrypt", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the block2str MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function converts from block (cipher or plain text) into 
    /// String 
    /// Input : block - Input block to be converted
    /// Output : The coressponding string to the specified block
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object block2str()
    {
      return mcr.EvaluateFunction("block2str", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the block2str MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function converts from block (cipher or plain text) into 
    /// String 
    /// Input : block - Input block to be converted
    /// Output : The coressponding string to the specified block
    /// </remarks>
    /// <param name="block">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object block2str(Object block)
    {
      return mcr.EvaluateFunction("block2str", block);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the block2str MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function converts from block (cipher or plain text) into 
    /// String 
    /// Input : block - Input block to be converted
    /// Output : The coressponding string to the specified block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] block2str(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "block2str", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the block2str MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function converts from block (cipher or plain text) into 
    /// String 
    /// Input : block - Input block to be converted
    /// Output : The coressponding string to the specified block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="block">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] block2str(int numArgsOut, Object block)
    {
      return mcr.EvaluateFunction(numArgsOut, "block2str", block);
    }


    /// <summary>
    /// Provides an interface for the block2str function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// This function converts from block (cipher or plain text) into 
    /// String 
    /// Input : block - Input block to be converted
    /// Output : The coressponding string to the specified block
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("block2str", 1, 1, 0)]
    protected void block2str(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("block2str", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the blocks2vector MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object blocks2vector()
    {
      return mcr.EvaluateFunction("blocks2vector", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the blocks2vector MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="blocks">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object blocks2vector(Object blocks)
    {
      return mcr.EvaluateFunction("blocks2vector", blocks);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the blocks2vector MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] blocks2vector(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "blocks2vector", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the blocks2vector MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="blocks">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] blocks2vector(int numArgsOut, Object blocks)
    {
      return mcr.EvaluateFunction(numArgsOut, "blocks2vector", blocks);
    }


    /// <summary>
    /// Provides an interface for the blocks2vector function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("blocks2vector", 1, 1, 0)]
    protected void blocks2vector(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("blocks2vector", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the bunchbitxor MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Takes a bunch of iput paramters and calculate bitxor between them
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object bunchbitxor()
    {
      return mcr.EvaluateFunction("bunchbitxor", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the bunchbitxor MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Takes a bunch of iput paramters and calculate bitxor between them
    /// </remarks>
    /// <param name="varargin">Array of Objects representing the input arguments 1
    /// through varargin.length</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object bunchbitxor(params Object[] varargin)
    {
      return mcr.EvaluateFunction("bunchbitxor", varargin);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the bunchbitxor MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Takes a bunch of iput paramters and calculate bitxor between them
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] bunchbitxor(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "bunchbitxor", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the bunchbitxor MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Takes a bunch of iput paramters and calculate bitxor between them
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="varargin">Array of Objects representing the input arguments 1
    /// through varargin.length</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] bunchbitxor(int numArgsOut, params Object[] varargin)
    {
      return mcr.EvaluateFunction(numArgsOut, "bunchbitxor", varargin);
    }


    /// <summary>
    /// Provides an interface for the bunchbitxor function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Takes a bunch of iput paramters and calculate bitxor between them
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("bunchbitxor", 0, 1, 1)]
    protected void bunchbitxor(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("bunchbitxor", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the cell2decmat MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object cell2decmat()
    {
      return mcr.EvaluateFunction("cell2decmat", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the cell2decmat MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="cell">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object cell2decmat(Object cell)
    {
      return mcr.EvaluateFunction("cell2decmat", cell);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the cell2decmat MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] cell2decmat(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "cell2decmat", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the cell2decmat MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="cell">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] cell2decmat(int numArgsOut, Object cell)
    {
      return mcr.EvaluateFunction(numArgsOut, "cell2decmat", cell);
    }


    /// <summary>
    /// Provides an interface for the cell2decmat function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("cell2decmat", 1, 1, 0)]
    protected void cell2decmat(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("cell2decmat", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the circularshift MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// out = fliplr(cs);
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object circularshift()
    {
      return mcr.EvaluateFunction("circularshift", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the circularshift MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// out = fliplr(cs);
    /// </remarks>
    /// <param name="col">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object circularshift(Object col)
    {
      return mcr.EvaluateFunction("circularshift", col);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the circularshift MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// out = fliplr(cs);
    /// </remarks>
    /// <param name="col">Input argument #1</param>
    /// <param name="k">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object circularshift(Object col, Object k)
    {
      return mcr.EvaluateFunction("circularshift", col, k);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the circularshift MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// out = fliplr(cs);
    /// </remarks>
    /// <param name="col">Input argument #1</param>
    /// <param name="k">Input argument #2</param>
    /// <param name="state">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object circularshift(Object col, Object k, Object state)
    {
      return mcr.EvaluateFunction("circularshift", col, k, state);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the circularshift MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// out = fliplr(cs);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] circularshift(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "circularshift", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the circularshift MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// out = fliplr(cs);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="col">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] circularshift(int numArgsOut, Object col)
    {
      return mcr.EvaluateFunction(numArgsOut, "circularshift", col);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the circularshift MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// out = fliplr(cs);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="col">Input argument #1</param>
    /// <param name="k">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] circularshift(int numArgsOut, Object col, Object k)
    {
      return mcr.EvaluateFunction(numArgsOut, "circularshift", col, k);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the circularshift MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// out = fliplr(cs);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="col">Input argument #1</param>
    /// <param name="k">Input argument #2</param>
    /// <param name="state">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] circularshift(int numArgsOut, Object col, Object k, Object state)
    {
      return mcr.EvaluateFunction(numArgsOut, "circularshift", col, k, state);
    }


    /// <summary>
    /// Provides an interface for the circularshift function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// out = fliplr(cs);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("circularshift", 3, 1, 0)]
    protected void circularshift(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("circularshift", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the colwisexor MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object colwisexor()
    {
      return mcr.EvaluateFunction("colwisexor", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the colwisexor MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object colwisexor(Object a)
    {
      return mcr.EvaluateFunction("colwisexor", a);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the colwisexor MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object colwisexor(Object a, Object b)
    {
      return mcr.EvaluateFunction("colwisexor", a, b);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the colwisexor MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] colwisexor(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "colwisexor", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the colwisexor MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] colwisexor(int numArgsOut, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "colwisexor", a);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the colwisexor MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] colwisexor(int numArgsOut, Object a, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "colwisexor", a, b);
    }


    /// <summary>
    /// Provides an interface for the colwisexor function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("colwisexor", 2, 1, 0)]
    protected void colwisexor(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("colwisexor", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the dec2cellhex MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dec2cellhex()
    {
      return mcr.EvaluateFunction("dec2cellhex", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the dec2cellhex MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="dec">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dec2cellhex(Object dec)
    {
      return mcr.EvaluateFunction("dec2cellhex", dec);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the dec2cellhex MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dec2cellhex(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "dec2cellhex", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the dec2cellhex MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="dec">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dec2cellhex(int numArgsOut, Object dec)
    {
      return mcr.EvaluateFunction(numArgsOut, "dec2cellhex", dec);
    }


    /// <summary>
    /// Provides an interface for the dec2cellhex function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("dec2cellhex", 1, 1, 0)]
    protected void dec2cellhex(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("dec2cellhex", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the fifieldsmul MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// *8
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fifieldsmul()
    {
      return mcr.EvaluateFunction("fifieldsmul", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the fifieldsmul MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// *8
    /// </remarks>
    /// <param name="element">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fifieldsmul(Object element)
    {
      return mcr.EvaluateFunction("fifieldsmul", element);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the fifieldsmul MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// *8
    /// </remarks>
    /// <param name="element">Input argument #1</param>
    /// <param name="prod">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fifieldsmul(Object element, Object prod)
    {
      return mcr.EvaluateFunction("fifieldsmul", element, prod);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the fifieldsmul MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// *8
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fifieldsmul(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "fifieldsmul", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the fifieldsmul MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// *8
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="element">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fifieldsmul(int numArgsOut, Object element)
    {
      return mcr.EvaluateFunction(numArgsOut, "fifieldsmul", element);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the fifieldsmul MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// *8
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="element">Input argument #1</param>
    /// <param name="prod">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fifieldsmul(int numArgsOut, Object element, Object prod)
    {
      return mcr.EvaluateFunction(numArgsOut, "fifieldsmul", element, prod);
    }


    /// <summary>
    /// Provides an interface for the fifieldsmul function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// *8
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("fifieldsmul", 2, 1, 0)]
    protected void fifieldsmul(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("fifieldsmul", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the getstates MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// create cell array of the hexadecimal reprsentation of 
    /// the plain text
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object getstates()
    {
      return mcr.EvaluateFunction("getstates", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the getstates MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// create cell array of the hexadecimal reprsentation of 
    /// the plain text
    /// </remarks>
    /// <param name="plaintext">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object getstates(Object plaintext)
    {
      return mcr.EvaluateFunction("getstates", plaintext);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the getstates MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// create cell array of the hexadecimal reprsentation of 
    /// the plain text
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] getstates(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "getstates", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the getstates MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// create cell array of the hexadecimal reprsentation of 
    /// the plain text
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="plaintext">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] getstates(int numArgsOut, Object plaintext)
    {
      return mcr.EvaluateFunction(numArgsOut, "getstates", plaintext);
    }


    /// <summary>
    /// Provides an interface for the getstates function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// create cell array of the hexadecimal reprsentation of 
    /// the plain text
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("getstates", 1, 2, 0)]
    protected void getstates(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("getstates", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the KeyExpansion MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Rotate last column
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KeyExpansion()
    {
      return mcr.EvaluateFunction("KeyExpansion", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the KeyExpansion MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Rotate last column
    /// </remarks>
    /// <param name="Key">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KeyExpansion(Object Key)
    {
      return mcr.EvaluateFunction("KeyExpansion", Key);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the KeyExpansion MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Rotate last column
    /// </remarks>
    /// <param name="Key">Input argument #1</param>
    /// <param name="SBox">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KeyExpansion(Object Key, Object SBox)
    {
      return mcr.EvaluateFunction("KeyExpansion", Key, SBox);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the KeyExpansion MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Rotate last column
    /// </remarks>
    /// <param name="Key">Input argument #1</param>
    /// <param name="SBox">Input argument #2</param>
    /// <param name="RconDec">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KeyExpansion(Object Key, Object SBox, Object RconDec)
    {
      return mcr.EvaluateFunction("KeyExpansion", Key, SBox, RconDec);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the KeyExpansion MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Rotate last column
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KeyExpansion(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "KeyExpansion", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the KeyExpansion MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Rotate last column
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Key">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KeyExpansion(int numArgsOut, Object Key)
    {
      return mcr.EvaluateFunction(numArgsOut, "KeyExpansion", Key);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the KeyExpansion MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Rotate last column
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Key">Input argument #1</param>
    /// <param name="SBox">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KeyExpansion(int numArgsOut, Object Key, Object SBox)
    {
      return mcr.EvaluateFunction(numArgsOut, "KeyExpansion", Key, SBox);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the KeyExpansion MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Rotate last column
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Key">Input argument #1</param>
    /// <param name="SBox">Input argument #2</param>
    /// <param name="RconDec">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KeyExpansion(int numArgsOut, Object Key, Object SBox, Object RconDec)
    {
      return mcr.EvaluateFunction(numArgsOut, "KeyExpansion", Key, SBox, RconDec);
    }


    /// <summary>
    /// Provides an interface for the KeyExpansion function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Rotate last column
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("KeyExpansion", 3, 1, 0)]
    protected void KeyExpansion(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("KeyExpansion", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the loadmatfile MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object loadmatfile()
    {
      return mcr.EvaluateFunction("loadmatfile", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the loadmatfile MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="path">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object loadmatfile(Object path)
    {
      return mcr.EvaluateFunction("loadmatfile", path);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the loadmatfile MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] loadmatfile(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "loadmatfile", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the loadmatfile MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="path">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] loadmatfile(int numArgsOut, Object path)
    {
      return mcr.EvaluateFunction(numArgsOut, "loadmatfile", path);
    }


    /// <summary>
    /// Provides an interface for the loadmatfile function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("loadmatfile", 1, 1, 0)]
    protected void loadmatfile(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("loadmatfile", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the MixCol MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --------------------------------------------------------------------------
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MixCol()
    {
      return mcr.EvaluateFunction("MixCol", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the MixCol MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --------------------------------------------------------------------------
    /// </remarks>
    /// <param name="InMatrix">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MixCol(Object InMatrix)
    {
      return mcr.EvaluateFunction("MixCol", InMatrix);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the MixCol MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --------------------------------------------------------------------------
    /// </remarks>
    /// <param name="InMatrix">Input argument #1</param>
    /// <param name="MatMixCol">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MixCol(Object InMatrix, Object MatMixCol)
    {
      return mcr.EvaluateFunction("MixCol", InMatrix, MatMixCol);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the MixCol MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --------------------------------------------------------------------------
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MixCol(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "MixCol", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the MixCol MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --------------------------------------------------------------------------
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="InMatrix">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MixCol(int numArgsOut, Object InMatrix)
    {
      return mcr.EvaluateFunction(numArgsOut, "MixCol", InMatrix);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the MixCol MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --------------------------------------------------------------------------
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="InMatrix">Input argument #1</param>
    /// <param name="MatMixCol">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MixCol(int numArgsOut, Object InMatrix, Object MatMixCol)
    {
      return mcr.EvaluateFunction(numArgsOut, "MixCol", InMatrix, MatMixCol);
    }


    /// <summary>
    /// Provides an interface for the MixCol function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// --------------------------------------------------------------------------
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("MixCol", 2, 1, 0)]
    protected void MixCol(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("MixCol", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the shiftrows MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object shiftrows()
    {
      return mcr.EvaluateFunction("shiftrows", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the shiftrows MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="mat">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object shiftrows(Object mat)
    {
      return mcr.EvaluateFunction("shiftrows", mat);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the shiftrows MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="mat">Input argument #1</param>
    /// <param name="state">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object shiftrows(Object mat, Object state)
    {
      return mcr.EvaluateFunction("shiftrows", mat, state);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the shiftrows MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] shiftrows(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "shiftrows", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the shiftrows MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="mat">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] shiftrows(int numArgsOut, Object mat)
    {
      return mcr.EvaluateFunction(numArgsOut, "shiftrows", mat);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the shiftrows MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="mat">Input argument #1</param>
    /// <param name="state">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] shiftrows(int numArgsOut, Object mat, Object state)
    {
      return mcr.EvaluateFunction(numArgsOut, "shiftrows", mat, state);
    }


    /// <summary>
    /// Provides an interface for the shiftrows function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("shiftrows", 2, 1, 0)]
    protected void shiftrows(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("shiftrows", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the SubBytes MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNTITLED4 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SubBytes()
    {
      return mcr.EvaluateFunction("SubBytes", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the SubBytes MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNTITLED4 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="InMat">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SubBytes(Object InMat)
    {
      return mcr.EvaluateFunction("SubBytes", InMat);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the SubBytes MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNTITLED4 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="InMat">Input argument #1</param>
    /// <param name="Sbox">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SubBytes(Object InMat, Object Sbox)
    {
      return mcr.EvaluateFunction("SubBytes", InMat, Sbox);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the SubBytes MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNTITLED4 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] SubBytes(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "SubBytes", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the SubBytes MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNTITLED4 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="InMat">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] SubBytes(int numArgsOut, Object InMat)
    {
      return mcr.EvaluateFunction(numArgsOut, "SubBytes", InMat);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the SubBytes MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNTITLED4 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="InMat">Input argument #1</param>
    /// <param name="Sbox">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] SubBytes(int numArgsOut, Object InMat, Object Sbox)
    {
      return mcr.EvaluateFunction(numArgsOut, "SubBytes", InMat, Sbox);
    }


    /// <summary>
    /// Provides an interface for the SubBytes function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// UNTITLED4 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("SubBytes", 2, 1, 0)]
    protected void SubBytes(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("SubBytes", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the vector2blocks MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object vector2blocks()
    {
      return mcr.EvaluateFunction("vector2blocks", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the vector2blocks MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="vector">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object vector2blocks(Object vector)
    {
      return mcr.EvaluateFunction("vector2blocks", vector);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the vector2blocks MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="vector">Input argument #1</param>
    /// <param name="n">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object vector2blocks(Object vector, Object n)
    {
      return mcr.EvaluateFunction("vector2blocks", vector, n);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the vector2blocks MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="vector">Input argument #1</param>
    /// <param name="n">Input argument #2</param>
    /// <param name="m">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object vector2blocks(Object vector, Object n, Object m)
    {
      return mcr.EvaluateFunction("vector2blocks", vector, n, m);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the vector2blocks MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] vector2blocks(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "vector2blocks", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the vector2blocks MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="vector">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] vector2blocks(int numArgsOut, Object vector)
    {
      return mcr.EvaluateFunction(numArgsOut, "vector2blocks", vector);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the vector2blocks MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="vector">Input argument #1</param>
    /// <param name="n">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] vector2blocks(int numArgsOut, Object vector, Object n)
    {
      return mcr.EvaluateFunction(numArgsOut, "vector2blocks", vector, n);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the vector2blocks MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="vector">Input argument #1</param>
    /// <param name="n">Input argument #2</param>
    /// <param name="m">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] vector2blocks(int numArgsOut, Object vector, Object n, Object m)
    {
      return mcr.EvaluateFunction(numArgsOut, "vector2blocks", vector, n, m);
    }


    /// <summary>
    /// Provides an interface for the vector2blocks function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("vector2blocks", 3, 1, 0)]
    protected void vector2blocks(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("vector2blocks", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
