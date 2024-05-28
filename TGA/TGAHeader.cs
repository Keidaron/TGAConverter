using System;
using System.IO;

namespace TGAConverter
{
    public class TGAHeader
    {
        // TGA Image Size
        public Int16 Width { get; set; }
        public Int16 Height { get; set; }
        
        // TGA Image ColorDepth
        public byte PixelDepth { get; set; }
    }
}