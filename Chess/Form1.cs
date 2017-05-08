using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        bool player1_xod, game_start = false;
        int[,,,] doska = new int[8, 8, 7, 2]; //Сложный 4-ех мерный массив(ряд, столбец, фигура(0 - пустая клеточка), сторона(1 - белые))
        public Form1()
        {
            InitializeComponent();
            START_BUTTON.Enabled = false;
        }

        private void START_BUTTON_Click(object sender, EventArgs e) //Нужно будет механизм старта придумать
        {
            game_start = true;
            if(black_button.Checked == true)
            {

            }
            else if(White_button.Checked == true)
            {

            }
            else
            {

            }
        }

        private void EXIT_BUTTON_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (game_start == true)
            {
                if (player1_xod == true) //player1_xod_cs юзаем
                {
                    
                }
                else //player2_xod_cs юзаем
                {

                }
            }
        }
    }
}
