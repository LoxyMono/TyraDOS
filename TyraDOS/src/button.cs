using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

using Cosmos.System.Graphics;

using static TyraDOS.Kernel;

namespace TyraDOS.src
{
    class button
    {
        public static void PowerButton(Bitmap image, int x, int y, int scalex, int scaley)
        {
            canvas.DrawImage(image, x, y, scalex, scaley);

            if (Cosmos.System.MouseManager.MouseState == Cosmos.System.MouseState.Left)
            {
                if (Cosmos.System.MouseManager.X > x && Cosmos.System.MouseManager.X < x + scalex)
                {
                    if (Cosmos.System.MouseManager.Y > y && Cosmos.System.MouseManager.Y < x + scaley)
                    {
                        Cosmos.System.Power.Shutdown();
                    }
                }
            }
        }
        public static void Make(int x, int y, int scalex, int scaley)
        {

        }
    }
}
