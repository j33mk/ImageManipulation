using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Image image = ImageManipulation.Instance.ResizeImage("C:\\Users\\Jamal\\Desktop\\images\\test.jpg",199,199);
            ImageManipulation.Instance.SaveImage(image,"C:\\Users\\Jamal\\Desktop\\images\\resized.jpg",ImageFormat.Jpeg);
 
            Console.WriteLine("Images are resized");
            Console.ReadLine();
        }
    }
}
