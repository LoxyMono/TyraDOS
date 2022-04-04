using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using static TyraDOS.Kernel;
using Cosmos.System.Graphics;
using System.Threading.Tasks;

namespace TyraDOS.src
{
    class CanvasLog
    {

        public static void LogERR(string ERRMessage, int row)
        {
            ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(255, 43, 28)), ERRMessage, 0, row * 16);
        }
        public static void LogWRN(string WRNMessage, int row)
        {
            ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(246, 255, 0)), WRNMessage, 0, row * 16);
        }
        public static void LogINF(string INFMessage, int row)
        {
            ASC16.DrawACSIIString(canvas, new Pen(Color.FromArgb(200, 200, 200)), INFMessage, 0, row * 16);
            canvas.Display();
        }
    }
}