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
                    if (figura[1] == 6)
                    {
                        if (doska[figura[0], (figura[1] - 1), 0, 0] == 1)
                        {
                            if (doska[figura[0], (figura[1] - 2), 0, 0] == 1)
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
                else { } //Nothing
            }
            else if (figura[2] == 2) //Конь
            {
                if (figura[3] == 1)
                {
                    if (figura[0] - 1 >= 0 && figura[1] - 2 >= 0)
                    {
                        if (doska[figura[0] - 1, figura[1] - 2, 0, 0] == 1)
                        {
                            xodi[0, figura[0] - 1, figura[1] - 2] = 1;
                        }
                    }
                    if (figura[0] + 1 <= 7 && figura[1] - 2 >= 0)
                    {
                        if (doska[figura[0] + 1, figura[1] - 2, 0, 0] == 1)
                        {
                            xodi[1, figura[0] + 1, figura[1] - 2] = 1;
                        }
                    }
                    if (figura[0] + 2 <= 7 && figura[1] - 1 >= 0)
                    {
                        if (doska[figura[0] + 2, figura[1] - 1, 0, 0] == 1)
                        {
                            xodi[2, figura[0] + 2, figura[1] - 1] = 1;
                        }
                    }
                    if (figura[0] + 2 <= 7 && figura[1] + 1 <= 7)
                    {
                        if (doska[figura[0] + 2, figura[1] + 1, 0, 0] == 1)
                        {
                            xodi[3, figura[0] + 2, figura[1] + 1] = 1;
                        }
                    }
                    if (figura[0] + 1 <= 7 && figura[1] + 2 <= 7)
                    {
                        if (doska[figura[0] + 1, figura[1] + 2, 0, 0] == 1)
                        {
                            xodi[4, figura[0] + 1, figura[1] + 2] = 1;
                        }
                    }
                    if (figura[0] - 1 >= 0 && figura[1] + 2 <= 7)
                    {
                        if (doska[figura[0] - 1, figura[1] + 2, 0, 0] == 1)
                        {
                            xodi[5, figura[0] - 1, figura[1] + 2] = 1;
                        }
                    }
                    if (figura[0] - 2 >= 0 && figura[1] + 1 <= 7)
                    {
                        if (doska[figura[0] - 2, figura[1] + 1, 0, 0] == 1)
                        {
                            xodi[6, figura[0] - 2, figura[1] + 1] = 1;
                        }
                    }
                    if (figura[0] - 2 >= 0 && figura[1] - 1 >= 0)
                    {
                        if (doska[figura[0] - 2, figura[1] - 1, 0, 0] == 1)
                        {
                            xodi[7, figura[0] - 2, figura[1] - 1] = 1;
                        }
                    }
                }
                else { } // nothing
            }
            else if (figura[2] == 3) //Слон
            {
                if (figura[3] == 1)
                {
                    int i = 0; int x1 = figura[0]; int y1 = figura[1];
                    while (x1 < 8 && y1 < 8)
                    {
                        if (doska[x1, y1, 0, 0] == 1)
                        {
                            xodi[i, x1, y1] = 1;
                            i++;
                        }
                        else if (x1 == figura[0] && y1 == figura[1]) { } // nothing
                        else
                        {
                            break;
                        }
                        x1++; y1++;
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (x1 < 8 && y1 >= 0)
                    {
                        if (doska[x1, y1, 0, 0] == 1)
                        {
                            xodi[i, x1, y1] = 1;
                            i++;
                        }
                        else if (x1 == figura[0] && y1 == figura[1]) { } // nothing
                        else
                        {
                            break;
                        }
                        x1++; y1--;
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (x1 >= 0 && y1 >= 0)
                    {
                        if (doska[x1, y1, 0, 0] == 1)
                        {
                            xodi[i, x1, y1] = 1;
                            i++;
                        }
                        else if (x1 == figura[0] && y1 == figura[1]) { } // nothing
                        else
                        {
                            break;
                        }
                        x1--; y1--;
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (x1 >= 0 && y1 < 8)
                    {
                        if (doska[x1, y1, 0, 0] == 1)
                        {
                            xodi[i, x1, y1] = 1;
                            i++;
                        }
                        else if (x1 == figura[0] && y1 == figura[1]) { } // nothing
                        else
                        {
                            break;
                        }
                        x1--; y1++;
                    }
                }
                else { } // nothing 
            }

            else if (figura[2] == 4) //Ладья
            {
                if (figura[3] == 1)
                {
                    int i = 0; int x1 = figura[0]; int y1 = figura[1];
                    while (x1 < 8)
                    {
                        if (x1 != 7)
                        {
                            x1++;
                            if (doska[x1, y1, 0, 0] == 1)
                            {
                                xodi[i, x1, y1] = 1;
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else { break; }
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (x1 >= 0)
                    {
                        if (x1 != 0)
                        {
                            x1--;
                            if (doska[x1, y1, 0, 0] == 1)
                            {
                                xodi[i, x1, y1] = 1;
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else { break; }
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (y1 < 8)
                    {
                        if (y1 != 7)
                        {
                            y1++;
                            if (doska[x1, y1, 0, 0] == 1)
                            {
                                xodi[i, x1, y1] = 1;
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else { break; }
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (y1 >= 0)
                    {
                        if (y1 != 0)
                        {
                            y1--;
                            if (doska[x1, y1, 0, 0] == 1)
                            {
                                xodi[i, x1, y1] = 1;
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else { break; }
                    }
                }
                else { } //nothing
            }
            else if (figura[2] == 5) //Ферзь
            {
                if (figura[3] == 1)
                {
                    int i = 0; int x1 = figura[0]; int y1 = figura[1];
                    while (x1 < 8 && y1 < 8)
                    {
                        if (doska[x1, y1, 0, 0] == 1)
                        {
                            xodi[i, x1, y1] = 1;
                            i++;
                        }
                        else if (x1 == figura[0] && y1 == figura[1]) { } // nothing
                        else
                        {
                            break;
                        }
                        x1++; y1++;
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (x1 < 8 && y1 >= 0)
                    {
                        if (doska[x1, y1, 0, 0] == 1)
                        {
                            xodi[i, x1, y1] = 1;
                            i++;
                        }
                        else if (x1 == figura[0] && y1 == figura[1]) { } // nothing
                        else
                        {
                            break;
                        }
                        x1++; y1--;
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (x1 >= 0 && y1 >= 0)
                    {
                        if (doska[x1, y1, 0, 0] == 1)
                        {
                            xodi[i, x1, y1] = 1;
                            i++;
                        }
                        else if (x1 == figura[0] && y1 == figura[1]) { } // nothing
                        else
                        {
                            break;
                        }
                        x1--; y1--;
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (x1 >= 0 && y1 < 8)
                    {
                        if (doska[x1, y1, 0, 0] == 1)
                        {
                            xodi[i, x1, y1] = 1;
                            i++;
                        }
                        else if (x1 == figura[0] && y1 == figura[1]) { } // nothing
                        else
                        {
                            break;
                        }
                        x1--; y1++;
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (x1 < 8)
                    {
                        if (x1 != 7)
                        {
                            x1++;
                            if (doska[x1, y1, 0, 0] == 1)
                            {
                                xodi[i, x1, y1] = 1;
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else { break; }
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (x1 >= 0)
                    {
                        if (x1 != 0)
                        {
                            x1--;
                            if (doska[x1, y1, 0, 0] == 1)
                            {
                                xodi[i, x1, y1] = 1;
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else { break; }
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (y1 < 8)
                    {
                        if (y1 != 7)
                        {
                            y1++;
                            if (doska[x1, y1, 0, 0] == 1)
                            {
                                xodi[i, x1, y1] = 1;
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else { break; }
                    }
                    x1 = figura[0]; y1 = figura[1];
                    while (y1 >= 0)
                    {
                        if (y1 != 0)
                        {
                            y1--;
                            if (doska[x1, y1, 0, 0] == 1)
                            {
                                xodi[i, x1, y1] = 1;
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else { break; }
                    }
                }
                else { } //nothing
            }
            else if (figura[2] == 6) //Король
            {
                if (figura[3] == 1)
                {
                    king under_attack = new king();
                    int[,] is_being_attacked = under_attack.cltchki_under_attack(doska, 1);
                    if (figura[1] - 1 != -1)
                    {
                        if (doska[figura[0], figura[1] - 1, 0, 0] == 1 && is_being_attacked[figura[0], figura[1] - 1] == 0)
                        {
                            xodi[0, figura[0], figura[1] - 1] = 1;
                        }
                    }
                    if (figura[1] + 1 != 8 && is_being_attacked[figura[0], figura[1] + 1] == 0)
                    {
                        if (doska[figura[0], figura[1] + 1, 0, 0] == 1)
                        {
                            xodi[1, figura[0], figura[1] + 1] = 1;
                        }
                    }
                    if (figura[0] - 1 != -1 && is_being_attacked[figura[0] - 1, figura[1]] == 0)
                    {
                        if (doska[figura[0] - 1, figura[1], 0, 0] == 1)
                        {
                            xodi[2, figura[0] - 1, figura[1]] = 1;
                        }
                    }
                    if (figura[0] + 1 != 8 && is_being_attacked[figura[0] + 1, figura[1]] == 0) 
                    {
                        if (doska[figura[0] + 1, figura[1], 0, 0] == 1)
                        {
                            xodi[3, figura[0] + 1, figura[1]] = 1;
                        }
                    }
                    if (figura[1] - 1 != -1 && figura[0] - 1 != -1 && is_being_attacked[figura[0] - 1, figura[1] - 1] == 0)
                    {
                        if (doska[figura[0] - 1, figura[1] - 1, 0, 0] == 1)
                        {
                            xodi[4, figura[0] - 1, figura[1] - 1] = 1;
                        }
                    }
                    if (figura[1] + 1 != 8 && figura[0] - 1 != -1 && is_being_attacked[figura[0] - 1, figura[1] + 1] == 0)
                    {
                        if (doska[figura[0] - 1, figura[1] + 1, 0, 0] == 1)
                        {
                            xodi[5, figura[0] - 1, figura[1] + 1] = 1;
                        }
                    }
                    if (figura[1] + 1 != 8 && figura[0] + 1 != 8 && is_being_attacked[figura[0] + 1, figura[1] + 1] == 0)
                    {
                        if (doska[figura[0] + 1, figura[1] + 1, 0, 0] == 1)
                        {
                            xodi[6, figura[0] + 1, figura[1] + 1] = 1;
                        }
                    }
                    if (figura[0] + 1 != 8 && figura[1] - 1 != -1 && is_being_attacked[figura[0] + 1, figura[1] - 1] == 0)
                    {
                        if (doska[figura[0] + 1, figura[1] - 1, 0, 0] == 1)
                        {
                            xodi[7, figura[0] + 1, figura[1] - 1] = 1;
                        }
                    }
                }
                else { } //nothing
            }
            return xodi;
        }
    }
}
