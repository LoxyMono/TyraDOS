using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.System.Graphics.Fonts;
using Cosmos.System.Graphics;
using System.Drawing;
using Sys = Cosmos.System;
using System.Timers;

using static TyraDOS.src.ASC16;
using static TyraDOS.src.CanvasLog;

using Mouse = Cosmos.System.MouseManager;

namespace TyraDOS
{
    public class Kernel : Sys.Kernel
    {

        public static int ModeRange = 0;

        public static bool StartMenu = false;

        public static Canvas canvas;

        [ManifestResourceStream(ResourceName = "TyraDOS.src.img.cursor.bmp")] public static byte[] CRSR; public static Bitmap Cursor = new Bitmap(CRSR);
        [ManifestResourceStream(ResourceName = "TyraDOS.src.img.cursorpressed.bmp")] public static byte[] CRSRP; public static Bitmap CursorPressed = new Bitmap(CRSR);

        protected override void BeforeRun()
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1920, 1080, ColorDepth.ColorDepth32));
            canvas.Clear();

            Mouse.ScreenWidth = 1920;
            Mouse.ScreenHeight = 1080;

            BOOT.LoadSrc();

        }

        protected override void Run()
        {
            if (StartMenu == true)
            {
                canvas.Clear(Color.FromArgb(1, 1, 1));
                OOBM.BootMenu();
                canvas.Display();
            }
            else
            {
                canvas.Clear(Color.FromArgb(20, 20, 20));
                src.Desktop.DrawDesktop();

                if (Mouse.MouseState == Sys.MouseState.Left || Mouse.MouseState == Sys.MouseState.Right)
                {
                    canvas.DrawImageAlpha(CursorPressed, (int)Mouse.X, (int)Mouse.Y);
                }
                else if (Mouse.MouseState != Sys.MouseState.Left || Mouse.MouseState != Sys.MouseState.Right)
                {
                    canvas.DrawImageAlpha(Cursor, (int)Mouse.X, (int)Mouse.Y);
                }

                canvas.Display();
                Cosmos.Core.Memory.Heap.Collect();
            }
        }
    }
}
