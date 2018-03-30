using System;
using System.IO;

namespace SHA3
{
    public enum SHA3Bitsize
    {
        SHA128 = 128,
        SHA224 = 224,
        SHA256 = 256,
        SHA384 = 384,
        SHA512 = 512,
    }
    
    public class SHA3 
    {
        public static string CalculateSHA3(string filepath, SHA3Bitsize bitsize)
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("Cannot find file: " + filepath);
            }
            byte[] bb = File.ReadAllBytes(filepath);
            Sha3Digest digest = new Sha3Digest((int) bitsize);
            digest.BlockUpdate(bb, 0, bb.Length);
            int digestsize = digest.GetDigestSize(); // Calculate the size of our byte array
            byte[] storage = new byte[digestsize];
            digest.DoFinal(storage, 0);
            return BitConverter.ToString(storage, 0);
        }

        public static byte[] CalculateSHA3Byte(string filepath, SHA3Bitsize bitsize)
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("Cannot find file: " + filepath);
            }
            byte[] bb = File.ReadAllBytes(filepath);
            Sha3Digest digest = new Sha3Digest((int) bitsize);
            digest.BlockUpdate(bb, 0, bb.Length);
            int digestsize = digest.GetDigestSize(); // Calculate the size of our byte array
            byte[] storage = new byte[digestsize];
            digest.DoFinal(storage, 0);
            return storage;
        }
    }
}