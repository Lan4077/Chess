using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Chess
{
    class picturebox_click_check
    {
        public int[] rachet(int[,,,] array,int x = 0, int y = 0)
        {
            int[] figura = new int[4];
            if(x - 248 < 0) //Ща будыт жара из сложных ифоф
            {
                if (x - 104 < 0)
                {
                    figura[0] = 0;
                }
                else if(x - 104 == 0)
                {
                    figura[0] = 1;
                }
                else
                {
                    if(x - 176 >= 0)
                    {
                        figura[0] = 2;
                    }
                    else
                    {
                        figura[0] = 1;
                    }
                }
            }
            else if(x-248 == 0)
            {
                figura[0] = 3;
            }
            else
            {
                if(x - 393 < 0)
                {
                    if(x - 321 < 0)
                    {
                        figura[0] = 3;
                    }
                    else
                    {
                        figura[0] = 4;
                    }
                }
                else if(x - 393 == 0)
                {
                    figura[0] = 5;
                }
                else
                {
                    if(x - 465 < 0)
                    {
                        figura[0] = 5;
                    }
                    else if(x - 465 == 0)
                    {
                        figura[0] = 6;
                    }
                    else
                    {
                        if(x-537 >= 0)
                        {
                            figura[0] = 7;
                        }
                        else
                        {
                            figura[0] = 6;
                        }
                    }
                }
            }
            return figura;
        }
    }
}
