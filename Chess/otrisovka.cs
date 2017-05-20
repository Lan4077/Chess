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
            e.Clear(Color.White);
            Image doska_image = Image.FromFile("doska.png");
             e.DrawImage(doska_image, 0, 0);
            for (int y = 0; y < 8; y++)
            {
                for(int x = 0; x < 8; x++)
                {
                    if (doska[x,y,0,0] == 1){} //Делаем ничего
                    else if((x+y)%2==0) //Белая клеточка
                    {
                        if (doska[x, y, 1, 0] == 1) //Чёрные
                        {
                            e.DrawImage(Image.FromFile("img/black/pawn_w.png"), cletochki[x, y, 0]);
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
                            e.DrawImage(Image.FromFile("img/black/queen_w.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 6, 0] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/black/king_w.png"), cletochki[x, y, 0]);
                        }


                        else if (doska[x, y, 1, 1] == 1) //Белые
                        {
                            e.DrawImage(Image.FromFile("img/white/pawn_w.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 2, 1] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/white/knight_w.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 3, 1] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/white/bishop_w.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 4, 1] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/white/rook_w.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 5, 1] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/white/queen_w.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 6, 1] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/white/king_w.png"), cletochki[x, y, 0]);
                        }
                    }
                    else
                    {
                        if (doska[x, y, 1, 0] == 1) //Чёрные
                        {
                            e.DrawImage(Image.FromFile("img/black/pawn_b.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 2, 0] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/black/knight_b.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 3, 0] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/black/bishop_b.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 4, 0] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/black/rook_b.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 5, 0] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/black/queen_b.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 6, 0] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/black/king_b.png"), cletochki[x, y, 0]);
                        }


                        else if (doska[x, y, 1, 1] == 1) //Белые
                        {
                            e.DrawImage(Image.FromFile("img/white/pawn_b.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 2, 1] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/white/knight_b.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 3, 1] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/white/bishop_b.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 4, 1] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/white/rook_b.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 5, 1] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/white/queen_b.png"), cletochki[x, y, 0]);
                        }
                        else if (doska[x, y, 6, 1] == 1)
                        {
                            e.DrawImage(Image.FromFile("img/white/king_b.png"), cletochki[x, y, 0]);
                        }
                    }
                }
            }
            return doska_bitmap;
        }
    }
}
