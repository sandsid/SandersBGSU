// Utility Dll: contains one function

using System;

namespace UtilityNS{
   public class Utility{
      public int NumLetters(string name, ref string dllversion)
      {
	  dllversion = "C# dll";
	  return name.Length;
      }
   };
};
