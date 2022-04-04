using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Cosmos.System.Graphics;
using System.Threading.Tasks;
using Cosmos.HAL.Drivers.USB;

using static TyraDOS.BOOT;
using static TyraDOS.Kernel;

namespace TyraDOS.src
{
    class Desktop
    {

        private static bool MenuOpened = false;

        public static void DrawDesktop()
        {


            canvas.DrawImage(Wallpaper, 0, 0);

            //canvas.DrawFilledRectangle(new Pen(Color.FromArgb(50, 50, 50)), 0, 1020, 1920, 60);
            canvas.DrawFilledRectangle(new Pen(Color.FromArgb(40, 40, 40)), 0, 0, 1920, 20);
            button.PowerButton(PowerButton, 1899, 1, 18, 18);
            //canvas.DrawImage(PowerButton, 1899, 1, 18, 18);
            //src.ASC16.DrawACSIIString(canvas, SVGAIIConsoleDefault_, Cosmos.Core.CPU.time().ToString(), 1800, 1);

            if (!MenuOpened)
            {
                canvas.DrawImage(Taskbar, canvas.Mode.Columns / 2 - (int)Taskbar.Width / 2, 1080 - 120);
            }
            else
            {
                
            }

        }
    }
}
