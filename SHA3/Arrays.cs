namespace SHA3
{
    internal abstract class Arrays
    {
        public static byte[] Clone(
            byte[] data)
        {
            return data == null ? null : (byte[]) data.Clone();
        }

        public static void Fill(
            byte[] buf,
            byte b)
        {
            int i = buf.Length;
            while (i > 0)
            {
                buf[--i] = b;
            }
        }
    }
}