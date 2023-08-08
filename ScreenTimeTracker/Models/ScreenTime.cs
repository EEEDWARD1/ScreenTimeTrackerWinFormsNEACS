using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenTimeTracker.Models
{
    internal class ScreenTime
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        public static void ScreenTimeCheck()
        {
            string currentTime;
            string initialApp = GetCurrentForegroundWindow();
            string initialTime = GetCurrentTime();

            while (true) // An infinite loop
            {
                if (initialApp != GetCurrentForegroundWindow()) // If the application in focus has changed
                {
                    currentTime = GetCurrentTime(); // Update the current time
                    TimeSpan timeSpent = DateTime.Parse(currentTime).Subtract(DateTime.Parse(initialTime)); // Calculate how much time was spent on the previous application
                    Debug.WriteLine($"User has used: {initialApp} for {timeSpent}"); // Print out the result into debug console

                    DataHandler.WriteToCSV(initialApp, timeSpent);

                    initialApp = GetCurrentForegroundWindow();
                    initialTime = GetCurrentTime();
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
        private static string GetCurrentForegroundWindow()
        {
            IntPtr hWnd = GetForegroundWindow(); // Get foreground window handle
            uint processID;
            GetWindowThreadProcessId(hWnd, out processID); // Get PID from window handle
            Process fgProc = Process.GetProcessById((int)processID); // Get process by ID
            return fgProc.ProcessName; // Print process name

        }

        private static string GetCurrentTime()
        {
            DateTime now = DateTime.Now; // Declares and assign DateTime variable with the current local time
            return now.ToString(); // Returns the current local time
        }
    }
}
