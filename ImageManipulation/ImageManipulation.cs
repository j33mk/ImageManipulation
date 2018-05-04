using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation
{
    public class ImageManipulation
    {
        //This will enable the that only one object of this class will be created
        private ImageManipulation(){}
        private static ImageManipulation _instanceImageManip= null;
        public static ImageManipulation Instance => _instanceImageManip ?? (_instanceImageManip = new ImageManipulation());


        public Image ResizeImage(string path, int width, int height)
        {
            Image image = Image.FromFile(path);
            Bitmap bmp = new Bitmap(width,height);
            using (var graphic = Graphics.FromImage(bmp))
            {
                graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphic.SmoothingMode = SmoothingMode.HighQuality;
                graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphic.CompositingQuality = CompositingQuality.HighQuality;
                graphic.DrawImage(image, 0, 0, width, height);
            }
            return bmp;
        }

        public void SaveImage(Image image, string path,ImageFormat imageFormat)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (FileStream fs = new FileStream(path,FileMode.Create,FileAccess.Write))
                {
                    image.Save(memoryStream, imageFormat);
                    byte[] bytes = memoryStream.ToArray();
                    fs.Write(bytes,0,bytes.Length);
                }
            }
        }

        public void GenerateMsg(string msg)
        {
            if (msg.Equals(""))
            {
                Console.WriteLine("msg is null");
            }
        }
        
    }
}
