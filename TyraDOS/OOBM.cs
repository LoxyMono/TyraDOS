using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Cosmos.System.Graphics;
using System.Threading.Tasks;
using static TyraDOS.Kernel;
using Keyboard = Cosmos.System.KeyboardManager;

namespace TyraDOS
{
    class OOBM
    {
        public static ConsoleKey key;

        public static int selection = 1;

        public static bool KeyLock = false;

        public static void BootMenu()
        {
            canvas.DrawFilledRectangle(new Pen(Color.FromArgb(0, 0, 200)), 0, 0, 720, 20);
            src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(200, 200, 200)), "OOBM Options", 320, 0);
            src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(200, 200, 200)), "Shut Down", 0, 30);
            src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(200, 200, 200)), "Reboot", 0, 50);
            src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(200, 200, 200)), "Start TyraDOS", 0, 70);

            switch (selection)
            {
                case 3:

                    src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(200, 200, 200)), "Shut Down", 0, 30);
                    src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(200, 200, 200)), "Reboot", 0, 50);
                    src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(0, 200, 0)), "Start TyraDOS <", 0, 70);

                    break;
                case 2:

                    src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(200, 200, 200)), "Shut Down", 0, 30);
                    src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(0, 200, 0)), "Reboot <", 0, 50);
                    src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(200, 200, 200)), "Start TyraDOS", 0, 70);

                    break;
                case 1:

                    src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(0, 200, 0)), "Shut Down <", 0, 30);
                    src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(200, 200, 200)), "Reboot", 0, 50);
                    src.ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(200, 200, 200)), "Start TyraDOS", 0, 70);

                    break;
            }

            if (selection > 3)
                selection = 1;
            if (selection < 1)
                selection = 3;

            if (Keyboard.AltPressed)
            {
                if (selection == 1)
                {
                    Cosmos.System.Power.Shutdown();
                }
            }
        }
    }
}
