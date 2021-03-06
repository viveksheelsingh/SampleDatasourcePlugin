using System.Text;

namespace SamplePlugin
{
    /// <summary>
    /// Barebone mock source dataplane.
    /// </summary>
    internal static class MockSourceDataplane
    {
        private static string backupContent = "Just a small random backup content";
        public static int maxReadSize = 1024;

        public static Stream DoBackup()
        {
            return new MemoryStream(Encoding.ASCII.GetBytes(backupContent));
        }

        public static void DoRestore(Stream stream)
        {
            byte[] buffer = new byte[maxReadSize];
            stream.ReadAsync(buffer, 0, maxReadSize);
            string restoredContent = Encoding.ASCII.GetString(buffer);
        }
        
    }
}
