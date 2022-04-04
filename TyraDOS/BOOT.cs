using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Cosmos.System.Graphics;
using System.Threading.Tasks;
using System.Timers;

using static TyraDOS.Kernel;

namespace TyraDOS
{
    class BOOT
    {
        [ManifestResourceStream(ResourceName = "TyraDOS.src.img.Logo.bmp")] public static byte[] TyraLogoColor;
        [ManifestResourceStream(ResourceName = "TyraDOS.src.img.LogoBare.bmp")] public static byte[] TyraLogoBare;
        [ManifestResourceStream(ResourceName = "TyraDOS.src.img.wallpaper.bmp")] public static byte[] WPP;
        [ManifestResourceStream(ResourceName = "TyraDOS.src.img.Power.bmp")] public static byte[] PB;
        [ManifestResourceStream(ResourceName = "TyraDOS.src.img.taskbar.bmp")] public static byte[] TB;

        public static Bitmap TyraLogo = new Bitmap(TyraLogoColor);
        public static Bitmap TyraLogoNoColor = null;
        public static Bitmap Wallpaper = null;
        public static Bitmap PowerButton = null;
        public static Bitmap Taskbar = null;

        public static Pen SVGAIIConsoleDefault_ = new Pen(Color.FromArgb(200, 200, 200));

        public static void LoadSrc()
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1920, 1080, ColorDepth.ColorDepth32));
            canvas.DrawImageAlpha(TyraLogo, canvas.Mode.Columns / 2 - (int)TyraLogo.Width / 2, canvas.Mode.Rows / 2 - (int)TyraLogo.Height / 2);
            canvas.Display();
            TyraLogoNoColor = new Bitmap(TyraLogoBare);
            Wallpaper = new Bitmap(WPP);
            PowerButton = new Bitmap(PB);
            Taskbar = new Bitmap(TB);
    }
    }
}
