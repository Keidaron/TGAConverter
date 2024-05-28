using System.Drawing;
using System.IO;

namespace TGAConverter.TGA
{
    public class TGAReader
    {
        public static TGAImage ReadTGAFile(string _filePath)
        {
            // File read from filePath
            FileStream fileStream = new FileStream(_filePath, FileMode.Open);
            BinaryReader binaryReader = new BinaryReader(fileStream);

            TGAHeader header = new TGAHeader();
            /* Inside the first 18 Bytes of the TGA File is the Header
             * We dont need everything from the Header File so we start by skipping 
             * unnecessary data. Since we only need Width, Hight and pixelDepth
             */

            binaryReader.BaseStream.Seek(12, SeekOrigin.Begin); // Skips all Bytes till excluding 12
            header.Width = binaryReader.ReadInt16();
            header.Height = binaryReader.ReadInt16();
            header.PixelDepth = binaryReader.ReadByte();

            // Skips the last not needed byte of the file
            binaryReader.BaseStream.Seek(1, SeekOrigin.Current);

            TGAImage image = new TGAImage(header);

            // 32 Bit Targa files do contain an alphachannel
            if (image.Header.PixelDepth == 32) 
            {
                for (int y = image.PixelData.Height - 1; y >= 0; y--)
                {
                    for (int x = 0; x <= image.PixelData.Width - 1; x++)
                    {
                        
                        byte blue   = binaryReader.ReadByte();
                        byte green  = binaryReader.ReadByte();
                        byte red    = binaryReader.ReadByte();
                        byte alpha  = binaryReader.ReadByte();

                        Color cl = Color.FromArgb(alpha, red, green, blue);
                        image.PixelData.SetPixel(x, y, cl);
                    }
                }
            }
            else
            {
                for (int y = image.PixelData.Height - 1; y >= 0; y--)
                {
                    for (int x = 0; x <= image.PixelData.Width - 1; x++)
                    {
                        int blue    = binaryReader.ReadByte();
                        int green   = binaryReader.ReadByte();
                        int red     = binaryReader.ReadByte();

                        Color cl = Color.FromArgb(255, red, green, blue);
                        image.PixelData.SetPixel(x, y, cl);
                    }
                }
            }

            return image;
        }
    }
}