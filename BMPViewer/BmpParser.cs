using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMPViewer
{
    public class BmpParser
    {
        public static BmpInfo Parse(byte[] stream)
        {
            var bmpInfo = new BmpInfo
            {
                bfType = System.Text.ASCIIEncoding.ASCII.GetString(stream, 0, 2),
                bfSize = BitConverter.ToInt32(stream, 2),
                bfReserved0 = BitConverter.ToInt16(stream, 6),
                bfReserved1 = BitConverter.ToInt16(stream, 8),
                bfOffBits = BitConverter.ToInt32(stream, 10),
                biSize = BitConverter.ToInt32(stream, 14),
                biWidth = BitConverter.ToInt32(stream, 18),
                biHeight = BitConverter.ToInt32(stream, 22),
                biPlanes = BitConverter.ToInt16(stream, 26),
                biBitCount = BitConverter.ToInt16(stream, 28),
                biCompression = BitConverter.ToInt32(stream, 30),
                biSizeImage = BitConverter.ToInt32(stream, 34),
                biXPelsPerMeter = BitConverter.ToInt32(stream, 38),
                biYPelsPerMeter = BitConverter.ToInt32(stream, 42),
                biClrUsed = BitConverter.ToInt32(stream, 46),
                biClrImportant = BitConverter.ToInt32(stream, 50)
            };
            return bmpInfo;
        }
    }
}
