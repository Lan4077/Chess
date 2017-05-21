using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class arrangement_of_figures
    {
        public int[,,,] arrangement(int[,,,] doska)
        {
            doska[4, 0, 6, 0] = 1; //Короли
            doska[4, 7, 6, 1] = 1;
            for(int i = 0; i < 8; i++) //Пешки
            {
                doska[i, 1, 1, 0] = 1;
            }
            for (int i = 0; i < 8; i++)
            {
                doska[i, 6, 1, 1] = 1;
            }
            doska[0, 0, 4, 0] = 1; //латьи
            doska[7, 0, 4, 0] = 1;
            doska[0, 7, 4, 1] = 1;
            doska[7, 7, 4, 1] = 1;
            doska[1, 0, 2, 0] = 1; //Кони
            doska[6, 0, 2, 0] = 1;
            doska[1, 7, 2, 1] = 1;
            doska[6, 7, 2, 1] = 1;
            doska[2, 0, 3, 0] = 1; //Смерть Македонского
            doska[5, 0, 3, 0] = 1;
            doska[2, 7, 3, 1] = 1;
            doska[5, 7, 3, 1] = 1;
            doska[3, 0, 5, 0] = 1; //Когъолева
            doska[3, 7, 5, 1] = 1;
            for(int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if(doska[x,y,1,0] == 0 && doska[x,y,1,1] == 0 && doska[x, y, 2, 0] == 0 && doska[x, y, 2, 1] == 0 && doska[x, y, 3, 0] == 0 && doska[x, y, 3, 1] == 0 && doska[x, y, 4, 0] == 0 && doska[x, y, 4, 1] == 0 && doska[x, y, 5, 0] == 0 && doska[x, y, 5, 1] == 0 && doska[x, y, 6, 0] == 0 && doska[x, y, 6, 1] == 0)
                    {
                        doska[x, y, 0, 0] = 1;
                    }
                }
                
            }
            return doska;
        }
        public int[,,,] arrangement_zero(int[,,,] doska)
        {
            for(int x = 0; x < 8; x++)
            {
                for(int y = 0; y < 8; y++)
                {
                    for(int z = 0; z < 7; z++)
                    {
                        for(int a = 0; a < 1; a++)
                        {
                            if(z == 0)
                            {
                                doska[x, y, z, a] = 1;
                            }
                            else
                            {
                                doska[x, y, z, a] = 0;
                            }
                        }
                    }
                }
            }
            return doska;
        }
    }
}
