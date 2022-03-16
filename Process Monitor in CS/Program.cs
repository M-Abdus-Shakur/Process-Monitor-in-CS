using System;
using System.Diagnostics;
namespace Process_Monitor_in_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] proclist = Process.GetProcesses();
            foreach (Process process in proclist)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Process : " + process.ProcessName);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PID : " + process.Id);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("WindowTitle : " + process.MainWindowTitle);
            }
            Console.ReadLine();
        }
    }
}
