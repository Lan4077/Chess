using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class player1_xod_cs
    {
        public int[,,] firts_etap(int[,,,] doska, int[] figura)
        {
            int[,,] xodi = new int[26, 8, 8];
            if (figura[2] == 1) //Пешка
            {
                if (figura[3] == 1)
                {
                    if(figura[1] == 6)
                    {
                        if(doska[figura[0], (figura[1]-1), 0, 0] == 1)
                        {
                            if(doska[figura[0], (figura[1]-2), 0, 0] == 1)
                            {
                                xodi[0, figura[0], figura[1] - 1] = 1;
                                xodi[1, figura[0], figura[1] - 2] = 1;
                            }
                            else
                            {
                                xodi[0, figura[0], figura[1] - 1] = 1;
                            }
                        }
                    }
                    else
                    {
                        if (doska[figura[0], (figura[1] - 1), 0, 0] == 1)
                        {
                            xodi[0, figura[0], figura[1] - 1] = 1;
                        }
                    }
                }
                else{} //Nothing
            }
            else if(figura[2] == 2) //Конь
            {
                if (figura[3] == 1)
                {
                    if(figura[0] - 1 >= 0 && figura[1] - 2 >= 0)
                    {
                        if(doska[figura[0] - 1, figura[1] - 2, 0, 0] == 1)
                        {
                            xodi[0, figura[0] - 1, figura[1] - 2] = 1;
                        }
                    }
                    if(figura[0] + 1 <= 7 && figura[1] - 2 >= 0)
                    {
                        if (doska[figura[0] + 1, figura[1] - 2, 0, 0] == 1)
                        {
                            xodi[1, figura[0] + 1, figura[1] - 2] = 1;
                        }
                    }
                    if(figura[0] + 2 <= 7 && figura[1] - 1 >= 0)
                    {
                        if (doska[figura[0] + 2, figura[1] - 1, 0, 0] == 1)
                        {
                            xodi[2, figura[0] + 2, figura[1] - 1] = 1;
                        }
                    }
                    if(figura[0] + 2 <= 7 && figura[1] + 1 <= 7)
                    {
                        if (doska[figura[0] + 2, figura[1] + 1, 0, 0] == 1)
                        {
                            xodi[3, figura[0] + 2, figura[1] + 1] = 1;
                        }
                    }
                    if(figura[0] + 1 <= 7 && figura[1] + 2 <= 7)
                    {
                        if (doska[figura[0] + 1, figura[1] + 2, 0, 0] == 1)
                        {
                            xodi[4, figura[0] + 1, figura[1] + 2] = 1;
                        }
                    }
                    if(figura[0] - 1 >= 0 && figura[1] + 2 <= 7)
                    {
                        if (doska[figura[0] - 1, figura[1] + 2, 0, 0] == 1)
                        {
                            xodi[5, figura[0] - 1, figura[1] + 2] = 1;
                        }
                    }
                    if(figura[0] - 2 >= 0 && figura[1] + 1 <= 7)
                    {
                        if (doska[figura[0] - 2, figura[1] + 1, 0, 0] == 1)
                        {
                            xodi[6, figura[0] - 2, figura[1] + 1] = 1;
                        }
                    }
                    if(figura[0] - 2 >= 0 && figura[1] - 1 >= 0)
                    {
                        if (doska[figura[0] - 2, figura[1] - 1, 0, 0] == 1)
                        {
                            xodi[7, figura[0] - 2, figura[1] - 1] = 1;
                        }
                    }
                }
                else { } // nothing
            }
            return xodi;
        }
    }
}
