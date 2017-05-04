using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.AdvancedDrawing.Art;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineV8
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = "V8";
            Console.WriteLine("Rendering with {0}:", v);

            Bitmap baseImage = new Aurigma.GraphicsMill.Bitmap("../../../base.tif");
            Bitmap embeddedImage = new Aurigma.GraphicsMill.Bitmap("../../../embedded-image.tif");
            CmykColor backgroundColor = (CmykColor)embeddedImage.GetPixel(0, 0);

            Console.WriteLine(backgroundColor.ToString());

            using (var graphics = baseImage.GetAdvancedGraphics())
            {
                graphics.FillRectangle(new SolidBrush(backgroundColor), new System.Drawing.Rectangle(134, 0, baseImage.Width - 134, baseImage.Height));
            }

            baseImage.Save("../../../output-" + v.ToLower() + ".tif");
        }
    }
}
