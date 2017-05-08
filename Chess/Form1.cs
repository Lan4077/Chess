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
        bool player1_xod, game_start = false; //player1 - белые(player2 нет по причине ненадобности)
        Bitmap doska_bitmap = new Bitmap(640, 640);
        Image doska_image = Image.FromFile("doska.png");
        int[,,,] doska = new int[8, 8, 7, 2]; //Сложный 4-ех мерный массив(ряд, столбец, фигура(0 - пустая клеточка), сторона(1 - белые))
        /// координаты клеточек(сначала идёт x координата всех клеточек, потом для каждого ряда координата y(сначала верхняя потом нижняя)):
        /// [a, 0] - (32, 102) [a,1] - (104, 174) [a,2] - (176, 246) [a,3] - (248, 319) [a,4] - (321, 391) [a,5] - (393, 463) [a,6] - (465, 535) [a,7] - (537, 607)
        /// [0, b] - (32, 102) 
        /// [1, b] - (104, 174)
        /// [2, b] - (176, 246)
        /// [3, b] - (248, 319)
        /// [4, b] - (321, 391)
        /// [5, b] - (393, 463)
        /// [6, b] - (465, 535)
        /// [7, b] - (537, 607)
        public Form1()
        {
            InitializeComponent();
            stopgame_button.Enabled = false;
            Graphics e = Graphics.FromImage(doska_bitmap);
            e.DrawImage(doska_image, 0, 0);
            pictureBox1.Image = doska_bitmap;
            pictureBox1.Refresh();
        }

        private void START_BUTTON_Click(object sender, EventArgs e) //Нужно будет механизм старта придумать
        {
            game_start = true;
            START_BUTTON.Enabled = false;
            stopgame_button.Enabled = true;
            player1_xod = true;
        }

        private void EXIT_BUTTON_Click(object sender, EventArgs e) //Выход(кап. Очевидность)
        {
            Application.Exit();
        }
        
        //just for стопить игру and стирать поле
        private void stopgame_button_Click(object sender, EventArgs e)
        {
            game_start = false;
            stopgame_button.Enabled = false;
            START_BUTTON.Enabled = true;
            xod_partii.Text = "";
            Graphics e1 = Graphics.FromImage(doska_bitmap);
            e1.DrawImage(doska_image, 0, 0);
            pictureBox1.Image = doska_bitmap;
            pictureBox1.Refresh();
        }
        //Сам геймплей далее будет

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
