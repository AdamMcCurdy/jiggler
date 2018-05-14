using System;
using System.Threading;
using System.Windows.Forms;

namespace Jiggler
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                var pt = Cursor.Position;

                var rnd = new Random();
                var movementX = rnd.Next(-4, 5);
                var movementY = rnd.Next(-4, 5);

                pt.Y += movementY;
                pt.X += movementX;

                Cursor.Position = pt;
                Thread.Sleep(10);
            }
        }
    }
}