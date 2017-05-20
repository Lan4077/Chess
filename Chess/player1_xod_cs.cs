using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Chess
{
    class player1_xod_cs
    {
        public int[,,] firts_etap(int[,,,] doska, Point[,,] cletochki, int[] figura, Bitmap doska_bitmap)
        {
            int[,,] xodi = new int[26, 8, 8];
            Graphics e = Graphics.FromImage(doska_bitmap);
            if (figura[2] == 1) //Пешка
            {
                if (figura[3] == 0)
                {
                    if(figura[1] == 6)
                    {
                        if(doska[figura[0], (figura[1]+1), 0, 0] == 1)
                        {
                            if(doska[figura[0], (figura[1]+2), 0, 0] == 1)
                            {
                                e.FillRectangle(new SolidBrush(Color.FromArgb(155, Color.Yellow)), 0, 0, 200, 200);
                            }
                            else
                            {

                            }
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    if(figura[1] == 1)
                    {

                    }
                    else
                    {

                    }
                }
            }
            return xodi;
        }
    }
}
