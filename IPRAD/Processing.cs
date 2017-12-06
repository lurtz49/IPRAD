using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace IPRAD
{
    class Processing
    {
        public Processing()
        {

        }

        public static bool ConvertToGray(System.Drawing.Bitmap b)
        {
            for (int i=0; i<b.Width; i++)
              for (int j=0; j<b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);

                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));


               }
            return true;
        }
    }
}
