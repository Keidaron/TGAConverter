using System.Drawing;

namespace TGAConverter
{
    public class TGAImage
    {
        public TGAHeader Header { get; set; }
        public Bitmap PixelData { get; set; }

        public TGAImage(TGAHeader header)
        {
            Header = header;
            PixelData = new Bitmap(Header.Width, Header.Height);
        }
    }
}