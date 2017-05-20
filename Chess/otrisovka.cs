using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Chess
{
    class otrisovka
    {
        public Bitmap otrisoBka(Bitmap doska_bitmap, int[,,,] doska, Point[,,] cletochki)
        {
            Graphics e = Graphics.FromImage(doska_bitmap);
            for(int y = 0; y < 8; y++)
            {
                for(int x = 0; x < 8; x++)
                {
                    if (doska[x,y,0,0] == 1){} //Делаем ничего
                    else if((x+y)%2==0) //Белая клеточка
                    {

                    }
                    else
                    {

                    }
                }
            }
            return doska_bitmap;
        }
    }
}
