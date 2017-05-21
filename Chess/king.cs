using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class king
    {
        public int[,] cltchki_under_attack(int[,,,] doska, int storona)
        {
            int[,] is_being_attacked = new int[8, 8];
            if (storona == 0)
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        for (int a = 1; a < 6; a++)
                        {
                            if(doska[x,y,a,1] == 1)
                            {
                                if(a == 1) //Пешка
                                {
                                    if (y - 1 >= 0 && x - 1 >= 0 && x + 1 < 8)
                                    {
                                        if (doska[x, y - 1, 0, 0] == 1)
                                        {
                                            is_being_attacked[x - 1, y - 1] = 1;
                                            is_being_attacked[x + 1, y - 1] = 1;
                                        }
                                    }
                                }
                                else if(a == 2) //конь
                                {
                                    if (x - 1 >= 0 && y - 2 >= 0)
                                    {
                                        if (doska[x - 1, y - 2, 0, 0] == 1 || doska[x - 1, y - 2, 6, 0] == 1)
                                        {
                                            is_being_attacked[x - 1, y - 2] = 1;
                                        }
                                    }
                                    if (x + 1 <= 7 && y - 2 >= 0)
                                    {
                                        if (doska[x + 1, y - 2, 0, 0] == 1 || doska[x + 1, y - 2, 6, 0] == 1)
                                        {
                                            is_being_attacked[x + 1, y - 2] = 1;
                                        }
                                    }
                                    if (x + 2 <= 7 && y - 1 >= 0)
                                    {
                                        if (doska[x + 2, y - 1, 0, 0] == 1 || doska[x + 2, y - 1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x + 2, y - 1] = 1;
                                        }
                                    }
                                    if (x + 2 <= 7 && y + 1 <= 7)
                                    {
                                        if (doska[x + 2, y + 1, 0, 0] == 1 || doska[x + 2, y + 1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x + 2, y + 1] = 1;
                                        }
                                    }
                                    if (x + 1 <= 7 && y + 2 <= 7)
                                    {
                                        if (doska[x + 1, y + 2, 0, 0] == 1 || doska[x + 1, y + 2, 6, 0] == 1)
                                        {
                                            is_being_attacked[x + 1, y + 2] = 1;
                                        }
                                    }
                                    if (x - 1 >= 0 && y + 2 <= 7)
                                    {
                                        if (doska[x - 1, y + 2, 0, 0] == 1 || doska[x - 1, y + 2, 6, 0] == 1)
                                        {
                                            is_being_attacked[x - 1, y + 2] = 1;
                                        }
                                    }
                                    if (x - 2 >= 0 && y + 1 <= 7)
                                    {
                                        if (doska[x - 2, y + 1, 0, 0] == 1 || doska[x - 2, y + 1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x - 2, y + 1] = 1;
                                        }
                                    }
                                    if (x - 2 >= 0 && y - 1 >= 0)
                                    {
                                        if (doska[x - 2, y - 1, 0, 0] == 1 || doska[x - 2, y - 1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x - 2, y - 1] = 1;
                                        }
                                    }
                                }
                                else if(a == 3) //Слон
                                {
                                    int x1 = x; int y1 = y;
                                    while (x1 < 8 && y1 < 8)
                                    {
                                        if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x1, y1] = 1;

                                        }
                                        else if (x1 == x && y1 == y) { } // nothing
                                        else
                                        {
                                            break;
                                        }
                                        x1++; y1++;
                                    }
                                    x1 = x; y1 = y;
                                    while (x1 < 8 && y1 >= 0)
                                    {
                                        if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x1, y1] = 1;

                                        }
                                        else if (x1 == x && y1 == y) { } // nothing
                                        else
                                        {
                                            break;
                                        }
                                        x1++; y1--;
                                    }
                                    x1 = x; y1 = y;
                                    while (x1 >= 0 && y1 >= 0)
                                    {
                                        if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x1, y1] = 1;

                                        }
                                        else if (x1 == x && y1 == y) { } // nothing
                                        else
                                        {
                                            break;
                                        }
                                        x1--; y1--;
                                    }
                                    x1 = x; y1 = y;
                                    while (x1 >= 0 && y1 < 8)
                                    {
                                        if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x1, y1] = 1;

                                        }
                                        else if (x1 == x && y1 == y) { } // nothing
                                        else
                                        {
                                            break;
                                        }
                                        x1--; y1++;
                                    }
                                }
                                else if(a == 4) //ладья
                                {
                                    int x1 = x; int y1 = y;
                                    while (x1 < 8)
                                    {
                                        if (x1 != 7)
                                        {
                                            x1++;
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        else { break; }
                                    }
                                    x1 = x; y1 = y;
                                    while (x1 >= 0)
                                    {
                                        if (x1 != 0)
                                        {
                                            x1--;
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        else { break; }
                                    }
                                    x1 = x; y1 = y;
                                    while (y1 < 8)
                                    {
                                        if (y1 != 7)
                                        {
                                            y1++;
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        else { break; }
                                    }
                                    x1 = x; y1 = y;
                                    while (y1 >= 0)
                                    {
                                        if (y1 != 0)
                                        {
                                            y1--;
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        else { break; }
                                    }
                                }
                                else if(a == 5)//Ферзь
                                {
                                    int x1 = x; int y1 = y;
                                    while (x1 < 8 && y1 < 8)
                                    {
                                        if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x1, y1] = 1;

                                        }
                                        else if (x1 == x && y1 == y) { } // nothing
                                        else
                                        {
                                            break;
                                        }
                                        x1++; y1++;
                                    }
                                    x1 = x; y1 = y;
                                    while (x1 < 8 && y1 >= 0)
                                    {
                                        if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x1, y1] = 1;

                                        }
                                        else if (x1 == x && y1 == y) { } // nothing
                                        else
                                        {
                                            break;
                                        }
                                        x1++; y1--;
                                    }
                                    x1 = x; y1 = y;
                                    while (x1 >= 0 && y1 >= 0)
                                    {
                                        if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x1, y1] = 1;

                                        }
                                        else if (x1 == x && y1 == y) { } // nothing
                                        else
                                        {
                                            break;
                                        }
                                        x1--; y1--;
                                    }
                                    x1 = x; y1 = y;
                                    while (x1 >= 0 && y1 < 8)
                                    {
                                        if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x1, y1] = 1;

                                        }
                                        else if (x1 == x && y1 == y) { } // nothing
                                        else
                                        {
                                            break;
                                        }
                                        x1--; y1++;
                                    }
                                    x1 = x; y1 = y;
                                    while (x1 < 8)
                                    {
                                        if (x1 != 7)
                                        {
                                            x1++;
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        else { break; }
                                    }
                                    x1 = x; y1 = y;
                                    while (x1 >= 0)
                                    {
                                        if (x1 != 0)
                                        {
                                            x1--;
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        else { break; }
                                    }
                                    x1 = x; y1 = y;
                                    while (y1 < 8)
                                    {
                                        if (y1 != 7)
                                        {
                                            y1++;
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        else { break; }
                                    }
                                    x1 = x; y1 = y;
                                    while (y1 >= 0)
                                    {
                                        if (y1 != 0)
                                        {
                                            y1--;
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 0] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        else { break; }
                                    }
                                }
                                else if(a == 6) //Король
                                {
                                    if (y - 1 != -1)
                                    {
                                        if (doska[x, y - 1, 0, 0] == 1 || doska[x, y - 1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x, y - 1] = 1;
                                        }
                                    }
                                    if (y + 1 != 8)
                                    {
                                        if (doska[x, y + 1, 0, 0] == 1 || doska[x, y + 1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x, y + 1] = 1;
                                        }
                                    }
                                    if (x - 1 != -1)
                                    {
                                        if (doska[x - 1, y, 0, 0] == 1 || doska[x - 1, y, 6, 0] == 1)
                                        {
                                            is_being_attacked[x - 1, y] = 1;
                                        }
                                    }
                                    if (x + 1 != 8)
                                    {
                                        if (doska[x + 1, y, 0, 0] == 1 || doska[x + 1, y, 6, 0] == 1)
                                        {
                                            is_being_attacked[x + 1, y] = 1;
                                        }
                                    }
                                    if (y - 1 != -1 && x - 1 != -1)
                                    {
                                        if (doska[x - 1, y - 1, 0, 0] == 1 || doska[x - 1, y - 1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x - 1, y - 1] = 1;
                                        }
                                    }
                                    if (y + 1 != 8 && x - 1 != -1)
                                    {
                                        if (doska[x - 1, y + 1, 0, 0] == 1 || doska[x - 1, y + 1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x - 1, y + 1] = 1;
                                        }
                                    }
                                    if (y + 1 != 8 && x + 1 != 8)
                                    {
                                        if (doska[x + 1, y + 1, 0, 0] == 1 || doska[x + 1, y + 1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x + 1, y + 1] = 1;
                                        }
                                    }
                                    if (x + 1 != 8 && y - 1 != -1)
                                    {
                                        if (doska[x + 1, y - 1, 0, 0] == 1 || doska[x + 1, y - 1, 6, 0] == 1)
                                        {
                                            is_being_attacked[x + 1, y - 1] = 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            else
            {
                {
                    for (int x = 0; x < 8; x++)
                    {
                        for (int y = 0; y < 8; y++)
                        {
                            for (int a = 1; a < 6; a++)
                            {
                                if (doska[x, y, a, 0] == 1)
                                {
                                    if (a == 1) //Пешка
                                    {
                                        if (y + 1 < 8 && x - 1 >= 0 && x + 1 < 8)
                                        {
                                            if (doska[x, y - 1, 0, 0] == 1)
                                            {
                                                is_being_attacked[x - 1, y + 1] = 1;
                                                is_being_attacked[x + 1, y + 1] = 1;
                                            }
                                        }
                                    }
                                    else if (a == 2) //конь
                                    {
                                        if (x - 1 >= 0 && y - 2 >= 0)
                                        {
                                            if (doska[x - 1, y - 2, 0, 0] == 1 || doska[x - 1, y - 2, 6, 1] == 1)
                                            {
                                                is_being_attacked[x - 1, y - 2] = 1;
                                            }
                                        }
                                        if (x + 1 <= 7 && y - 2 >= 0)
                                        {
                                            if (doska[x + 1, y - 2, 0, 0] == 1 || doska[x + 1, y - 2, 6, 1] == 1)
                                            {
                                                is_being_attacked[x + 1, y - 2] = 1;
                                            }
                                        }
                                        if (x + 2 <= 7 && y - 1 >= 0)
                                        {
                                            if (doska[x + 2, y - 1, 0, 0] == 1 || doska[x + 2, y - 1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x + 2, y - 1] = 1;
                                            }
                                        }
                                        if (x + 2 <= 7 && y + 1 <= 7)
                                        {
                                            if (doska[x + 2, y + 1, 0, 0] == 1 || doska[x + 2, y + 1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x + 2, y + 1] = 1;
                                            }
                                        }
                                        if (x + 1 <= 7 && y + 2 <= 7)
                                        {
                                            if (doska[x + 1, y + 2, 0, 0] == 1 || doska[x + 1, y + 2, 6, 1] == 1)
                                            {
                                                is_being_attacked[x + 1, y + 2] = 1;
                                            }
                                        }
                                        if (x - 1 >= 0 && y + 2 <= 7)
                                        {
                                            if (doska[x - 1, y + 2, 0, 0] == 1 || doska[x - 1, y + 2, 6, 1] == 1)
                                            {
                                                is_being_attacked[x - 1, y + 2] = 1;
                                            }
                                        }
                                        if (x - 2 >= 0 && y + 1 <= 7)
                                        {
                                            if (doska[x - 2, y + 1, 0, 0] == 1 || doska[x - 2, y + 1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x - 2, y + 1] = 1;
                                            }
                                        }
                                        if (x - 2 >= 0 && y - 1 >= 0)
                                        {
                                            if (doska[x - 2, y - 1, 0, 0] == 1 || doska[x - 2, y - 1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x - 2, y - 1] = 1;
                                            }
                                        }
                                    }
                                    else if (a == 3) //Слон
                                    {
                                        int x1 = x; int y1 = y;
                                        while (x1 < 8 && y1 < 8)
                                        {
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else if (x1 == x && y1 == y) { } // nothing
                                            else
                                            {
                                                break;
                                            }
                                            x1++; y1++;
                                        }
                                        x1 = x; y1 = y;
                                        while (x1 < 8 && y1 >= 0)
                                        {
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else if (x1 == x && y1 == y) { } // nothing
                                            else
                                            {
                                                break;
                                            }
                                            x1++; y1--;
                                        }
                                        x1 = x; y1 = y;
                                        while (x1 >= 0 && y1 >= 0)
                                        {
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else if (x1 == x && y1 == y) { } // nothing
                                            else
                                            {
                                                break;
                                            }
                                            x1--; y1--;
                                        }
                                        x1 = x; y1 = y;
                                        while (x1 >= 0 && y1 < 8)
                                        {
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else if (x1 == x && y1 == y) { } // nothing
                                            else
                                            {
                                                break;
                                            }
                                            x1--; y1++;
                                        }
                                    }
                                    else if (a == 4) //ладья
                                    {
                                        int x1 = x; int y1 = y;
                                        while (x1 < 8)
                                        {
                                            if (x1 != 7)
                                            {
                                                x1++;
                                                if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                                {
                                                    is_being_attacked[x1, y1] = 1;

                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            else { break; }
                                        }
                                        x1 = x; y1 = y;
                                        while (x1 >= 0)
                                        {
                                            if (x1 != 0)
                                            {
                                                x1--;
                                                if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                                {
                                                    is_being_attacked[x1, y1] = 1;

                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            else { break; }
                                        }
                                        x1 = x; y1 = y;
                                        while (y1 < 8)
                                        {
                                            if (y1 != 7)
                                            {
                                                y1++;
                                                if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                                {
                                                    is_being_attacked[x1, y1] = 1;

                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            else { break; }
                                        }
                                        x1 = x; y1 = y;
                                        while (y1 >= 0)
                                        {
                                            if (y1 != 0)
                                            {
                                                y1--;
                                                if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                                {
                                                    is_being_attacked[x1, y1] = 1;

                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            else { break; }
                                        }
                                    }
                                    else if (a == 5)//Ферзь
                                    {
                                        int x1 = x; int y1 = y;
                                        while (x1 < 8 && y1 < 8)
                                        {
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else if (x1 == x && y1 == y) { } // nothing
                                            else
                                            {
                                                break;
                                            }
                                            x1++; y1++;
                                        }
                                        x1 = x; y1 = y;
                                        while (x1 < 8 && y1 >= 0)
                                        {
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else if (x1 == x && y1 == y) { } // nothing
                                            else
                                            {
                                                break;
                                            }
                                            x1++; y1--;
                                        }
                                        x1 = x; y1 = y;
                                        while (x1 >= 0 && y1 >= 0)
                                        {
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else if (x1 == x && y1 == y) { } // nothing
                                            else
                                            {
                                                break;
                                            }
                                            x1--; y1--;
                                        }
                                        x1 = x; y1 = y;
                                        while (x1 >= 0 && y1 < 8)
                                        {
                                            if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x1, y1] = 1;

                                            }
                                            else if (x1 == x && y1 == y) { } // nothing
                                            else
                                            {
                                                break;
                                            }
                                            x1--; y1++;
                                        }
                                        x1 = x; y1 = y;
                                        while (x1 < 8)
                                        {
                                            if (x1 != 7)
                                            {
                                                x1++;
                                                if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                                {
                                                    is_being_attacked[x1, y1] = 1;

                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            else { break; }
                                        }
                                        x1 = x; y1 = y;
                                        while (x1 >= 0)
                                        {
                                            if (x1 != 0)
                                            {
                                                x1--;
                                                if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                                {
                                                    is_being_attacked[x1, y1] = 1;

                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            else { break; }
                                        }
                                        x1 = x; y1 = y;
                                        while (y1 < 8)
                                        {
                                            if (y1 != 7)
                                            {
                                                y1++;
                                                if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                                {
                                                    is_being_attacked[x1, y1] = 1;

                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            else { break; }
                                        }
                                        x1 = x; y1 = y;
                                        while (y1 >= 0)
                                        {
                                            if (y1 != 0)
                                            {
                                                y1--;
                                                if (doska[x1, y1, 0, 0] == 1 || doska[x1, y1, 6, 1] == 1)
                                                {
                                                    is_being_attacked[x1, y1] = 1;

                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            else { break; }
                                        }
                                    }
                                    else if (a == 6) //Король
                                    {
                                        if (y - 1 != -1)
                                        {
                                            if (doska[x, y - 1, 0, 0] == 1 || doska[x, y - 1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x, y - 1] = 1;
                                            }
                                        }
                                        if (y + 1 != 8)
                                        {
                                            if (doska[x, y + 1, 0, 0] == 1 || doska[x, y + 1, 6, 1] == 1)
                                            {
                                                is_being_attacked[x, y + 1] = 1;
                                            }
                                        }
                                        if (x - 1 != -1)
                                        {
                                            if (doska[x - 1, y, 0, 0] == 1 || doska[x - 1, y, 6, 1] == 1)
                                            {
                                                is_being_attacked[x - 1, y] = 1;
                                            }
                                        }
                                        if (x + 1 != 8)
                                        {
                                            if (doska[x + 1, y, 0, 0] == 1 || doska[x + 1, y, 6, 1] == 1)
                                            {
                                                is_being_attacked[x + 1, y] = 1;
                                            }
                                        }
                                        if (y - 1 != -1 && x - 1 != -1 || doska[x - 1, y - 1, 6, 1] == 1)
                                        {
                                            if (doska[x - 1, y - 1, 0, 0] == 1)
                                            {
                                                is_being_attacked[x - 1, y - 1] = 1;
                                            }
                                        }
                                        if (y + 1 != 8 && x - 1 != -1 || doska[x - 1, y + 1, 6, 1] == 1)
                                        {
                                            if (doska[x - 1, y + 1, 0, 0] == 1)
                                            {
                                                is_being_attacked[x - 1, y + 1] = 1;
                                            }
                                        }
                                        if (y + 1 != 8 && x + 1 != 8 || doska[x + 1, y + 1, 6, 1] == 1)
                                        {
                                            if (doska[x + 1, y + 1, 0, 0] == 1)
                                            {
                                                is_being_attacked[x + 1, y + 1] = 1;
                                            }
                                        }
                                        if (x + 1 != 8 && y - 1 != -1 || doska[x + 1, y - 1, 6, 1] == 1)
                                        {
                                            if (doska[x + 1, y - 1, 0, 0] == 1)
                                            {
                                                is_being_attacked[x + 1, y - 1] = 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return is_being_attacked;
        }
    }
}
