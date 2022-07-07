using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExtractBytes
{
    public class ExtractBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputFilePath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using (var binaryStream = new FileStream(binaryFilePath, FileMode.Open))
            using (var bytesStream = new FileStream(bytesFilePath, FileMode.Open))
            {
                List<byte> binary = File.ReadAllBytes(binaryFilePath).ToList();
                List<byte> bytes = File.ReadAllBytes(bytesFilePath).ToList();

                byte[] occurences = binary.Intersect(bytes).ToArray();
                using (var writer = new FileStream(outputPath, FileMode.Open))
                {
                    writer.Write(occurences);
                }
            }
        }
    }
}
