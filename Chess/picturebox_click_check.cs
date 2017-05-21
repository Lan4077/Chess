using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Chess
{
    class picturebox_click_check
    {
        public int[] rachet(int[,,,] doska, int x = 0, int y = 0)
        {
            int[] figura = new int[4];
            if (x - 32 < 0 || x - 607 > 0 || y - 32 < 0 || y - 607 > 0) //Ща будыт жара из сложных ифоф
            {
                //NOTHING AZAZAZA
            }
            else
            {
                if (x - 248 < 0)
                {
                    if (x - 104 < 0)
                    {
                        figura[0] = 0;
                    }
                    else if (x - 104 == 0)
                    {
                        figura[0] = 1;
                    }
                    else
                    {
                        if (x - 176 >= 0)
                        {
                            figura[0] = 2;
                        }
                        else
                        {
                            figura[0] = 1;
                        }
                    }
                }
                else if (x - 248 == 0)
                {
                    figura[0] = 3;
                }
                else
                {
                    if (x - 393 < 0)
                    {
                        if (x - 321 < 0)
                        {
                            figura[0] = 3;
                        }
                        else
                        {
                            figura[0] = 4;
                        }
                    }
                    else if (x - 393 == 0)
                    {
                        figura[0] = 5;
                    }
                    else
                    {
                        if (x - 465 < 0)
                        {
                            figura[0] = 5;
                        }
                        else if (x - 465 == 0)
                        {
                            figura[0] = 6;
                        }
                        else
                        {
                            if (x - 537 >= 0)
                            {
                                figura[0] = 7;
                            }
                            else
                            {
                                figura[0] = 6;
                            }
                        }
                    }
                } //теперь определяем ряд(ololo)
                if (y - 248 < 0)
                {
                    if (y - 104 < 0)
                    {
                        figura[1] = 0;
                    }
                    else if (y - 104 == 0)
                    {
                        figura[1] = 1;
                    }
                    else
                    {
                        if (y - 176 >= 0)
                        {
                            figura[1] = 2;
                        }
                        else
                        {
                            figura[1] = 1;
                        }
                    }
                }
                else if (y - 248 == 0)
                {
                    figura[1] = 3;
                }
                else
                {
                    if (y - 393 < 0)
                    {
                        if (y - 321 < 0)
                        {
                            figura[1] = 3;
                        }
                        else
                        {
                            figura[1] = 4;
                        }
                    }
                    else if (y - 393 == 0)
                    {
                        figura[1] = 5;
                    }
                    else
                    {
                        if (y - 465 < 0)
                        {
                            figura[1] = 5;
                        }
                        else if (y - 465 == 0)
                        {
                            figura[1] = 6;
                        }
                        else
                        {
                            if (y - 537 >= 0)
                            {
                                figura[1] = 7;
                            }
                            else
                            {
                                figura[1] = 6;
                            }
                        }
                    }
                }
                //Дальше определяем фигуру
                for (int i = 0; i < 7; i++)
                {
                    for (int a = 0; a < 2; a++)
                    {
                        if (doska[figura[0], figura[1], i, a] == 1)
                        {
                            figura[2] = i;
                            figura[3] = a;
                            break;
                        }
                    }
                }
            }
            return figura;
        }
    }
}
