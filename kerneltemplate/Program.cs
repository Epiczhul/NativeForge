//#define USBDebug
//#define NETWORK

using NativeForge;
using System.Runtime;

unsafe class Program
{
    static void Main() { }

    [RuntimeExport("KMain")]
    static void KMain()
    {
        Console.WriteLine("Welcome to NativeForge!");
        for (;;); //dont delete this! its loop!
    }
}
