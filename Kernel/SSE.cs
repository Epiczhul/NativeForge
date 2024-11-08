using System.Runtime.InteropServices;

namespace NativeForge
{
    internal static class SSE
    {
        [DllImport("*")]
        public static extern void enable_sse();
    }
}