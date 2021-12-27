using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Drf_OCR_Manager_UI.Common
{
    public class ProcessDetector
    {
        public static bool IsWin64(Process process)
        {
            if (Environment.Is64BitOperatingSystem)
            {
                IntPtr processHandle;
                bool retVal;

                try
                {
                    processHandle = Process.GetProcessById(process.Id).Handle;
                }
                catch
                {
                    return false;
                }
                return Win32API.IsWow64Process(processHandle, out retVal) && retVal;
            }

            return false;
        }
    }

    internal static class Win32API
    {
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool IsWow64Process([In] IntPtr process, [Out] out bool wow64Process);
    }
}

