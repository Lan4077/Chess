using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
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
                    else if(doska[x,y,1,0] == 1)
                    {
                        e.DrawImage(Image.FromFile("img/black/pawn_w.png"), cletochki[x,y,0]);
                    }
                    else if (doska[x, y, 2, 0] == 1)
                    {
                        e.DrawImage(Image.FromFile("img/black/knight_w.png"), cletochki[x, y, 0]);
                    }
                    else if (doska[x, y, 3, 0] == 1)
                    {
                        e.DrawImage(Image.FromFile("img/black/bishop_w.png"), cletochki[x, y, 0]);
                    }
                    else if (doska[x, y, 4, 0] == 1)
                    {
                        e.DrawImage(Image.FromFile("img/black/rook_w.png"), cletochki[x, y, 0]);
                    }
                    else if (doska[x, y, 5, 0] == 1)
                    {
                        e.DrawImage(Image.FromFile("img/black/queen_b.png"), cletochki[x, y, 0]);
                    }
                    else if (doska[x, y, 6, 0] == 1)
                    {
                        e.DrawImage(Image.FromFile("img/black/king_w.png"), cletochki[x, y, 0]);
                    }

                }
            }
            return doska_bitmap;
        }
    }
}
