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
            doska[4, 0, 6, 0] = 0; //Короли
            doska[4, 7, 6, 0] = 1;
            for(int i = 0; i < 7; i++) //Пешки
            {
                doska[i, 1, 1, 0] = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                doska[i, 6, 1, 0] = 1;
            }
            doska[0, 0, 4, 0] = 0; //латьи
            doska[7, 0, 4, 0] = 0;
            doska[0, 7, 4, 0] = 1;
            doska[7, 7, 4, 0] = 1;
            doska[1, 0, 2, 0] = 0; //Кони
            doska[6, 0, 2, 0] = 0;
            doska[1, 7, 2, 0] = 1;
            doska[6, 7, 2, 0] = 1;
            doska[2, 0, 3, 0] = 0; //Смерть Македонского
            doska[5, 0, 3, 0] = 0;
            doska[2, 7, 3, 0] = 1;
            doska[5, 7, 3, 0] = 1;
            doska[3, 0, 3, 0] = 0; //Когъолева
            doska[3, 7, 3, 0] = 1;
            return doska;
        }
        public int[,,,] arrangement_zero(int[,,,] doska)
        {
            doska[4, 0, 6, 0] = 0; //Короли
            doska[4, 7, 6, 0] = 0;
            for (int i = 0; i < 7; i++) //Пешки
            {
                doska[i, 1, 1, 0] = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                doska[i, 6, 1, 0] = 0;
            }
            doska[0, 0, 4, 0] = 0; //латьи
            doska[7, 0, 4, 0] = 0;
            doska[0, 7, 4, 0] = 0;
            doska[7, 7, 4, 0] = 0;
            doska[1, 0, 2, 0] = 0; //Кони
            doska[6, 0, 2, 0] = 0;
            doska[1, 7, 2, 0] = 0;
            doska[6, 7, 2, 0] = 0;
            doska[2, 0, 3, 0] = 0; //Смерть Македонского
            doska[5, 0, 3, 0] = 0;
            doska[2, 7, 3, 0] = 0;
            doska[5, 7, 3, 0] = 0;
            doska[3, 0, 3, 0] = 0; //Когъолева
            doska[3, 7, 3, 0] = 0;

            doska[4, 0, 0, 0] = 1; //Короли
            doska[4, 7, 0, 0] = 1;
            for (int i = 0; i < 7; i++) //Пешки
            {
                doska[i, 1, 0, 0] = 1;
            }
            for (int i = 0; i < 7; i++)
            {
                doska[i, 6, 0, 0] = 1;
            }
            doska[0, 0, 0, 0] = 1; //латьи
            doska[7, 0, 0, 0] = 1;
            doska[0, 7, 0, 0] = 1;
            doska[7, 7, 0, 0] = 1;
            doska[1, 0, 0, 0] = 1; //Кони
            doska[6, 0, 0, 0] = 1;
            doska[1, 7, 0, 0] = 1;
            doska[6, 7, 0, 0] = 1;
            doska[2, 0, 0, 0] = 1; //Смерть Македонского
            doska[5, 0, 0, 0] = 1;
            doska[2, 7, 0, 0] = 1;
            doska[5, 7, 0, 0] = 1;
            doska[3, 0, 0, 0] = 1; //Когъолева
            doska[3, 7, 0, 0] = 1;
            return doska;
        }
    }
}
