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
        public bool player1_xod, game_start, click = false; //player1 - белые(player2 нет по причине ненадобности)
        public Bitmap doska_bitmap = new Bitmap(640, 640);
        public Image doska_image = Image.FromFile("doska.png");
        public int[] vibrannaya_figura = new int[4];
        public int[,,] xodi = new int[26, 8, 8];
        public Point[,,] cletochki = new Point[8, 8, 2];
        public int[,,,] doska = new int[8, 8, 7, 2]; //Сложный 4-ех мерный массив(ряд, столбец, фигура(0 - пустая клеточка, 1 - Пешка, 2 - Конь, 3 - Слон, 4 - Ладья, 5 - Ферзь, - 6 - Король), сторона(1 - белые))
        /// координаты клеточек(сначала идёт x координата всех клеточек, потом для каждого ряда координата y(сначала верхняя потом нижняя)):
        /// [0, a] - (32, 102) [1, a] - (104, 174) [2, a] - (176, 246) [3, a] - (248, 319) [4, a] - (321, 391) [5, a] - (393, 463) [6, a] - (465, 535) [7, a] - (537, 607)
        /// [b, 0] - (32, 102) 
        /// [b, 1] - (104, 174)
        /// [b, 2] - (176, 246)
        /// [b, 3] - (248, 319)
        /// [b, 4] - (321, 391)
        /// [b, 5] - (393, 463)
        /// [b, 6] - (465, 535)
        /// [b, 7] - (537, 607)
        public Form1()
        {
            InitializeComponent();
            set_point setpoint = new set_point();
            cletochki = setpoint.setpnt(cletochki);
            stopgame_button.Enabled = false;
            Graphics e = Graphics.FromImage(doska_bitmap);
            e.DrawImage(doska_image, 0, 0);
            pictureBox1.Image = doska_bitmap;
            pictureBox1.Refresh();
        }

        private void START_BUTTON_Click(object sender, EventArgs e) //Нужно будет механизм старта придумать
        {
            arrangement_of_figures arragement_of_f = new arrangement_of_figures();
            otrisovka otrsvka = new otrisovka();
            doska = arragement_of_f.arrangement(doska);
            otrsvka.otrisoBka(doska_bitmap, doska, cletochki);
            game_start = true;
            START_BUTTON.Enabled = false;
            stopgame_button.Enabled = true;
            player1_xod = true;
            pictureBox1.Image = doska_bitmap;
            pictureBox1.Refresh();
        }

        private void EXIT_BUTTON_Click(object sender, EventArgs e) //Выход(кап. Очевидность)
        {
            Application.Exit();
        }
        
        //just for стопить игру and стирать поле
        private void stopgame_button_Click(object sender, EventArgs e)
        {
            arrangement_of_figures arragement_of_f = new arrangement_of_figures();
            doska = arragement_of_f.arrangement_zero(doska);
            game_start = false;
            stopgame_button.Enabled = false;
            START_BUTTON.Enabled = true;
            xod_partii.Text = "";
            click = false;
            doska = new int[8, 8, 7, 2];
            Graphics e1 = Graphics.FromImage(doska_bitmap);
            e1.DrawImage(doska_image, 0, 0);
            pictureBox1.Image = doska_bitmap;
            pictureBox1.Refresh();
        }

        //Сам геймплей далее будет

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (game_start == true)
            {
                if (player1_xod == true) //player1_xod_cs юзаем
                {
                    if (click == false)
                    {
                        Graphics e1 = Graphics.FromImage(doska_bitmap);
                        otrisovka otrsvka = new otrisovka();
                        picturebox_click_check class_picturebox = new picturebox_click_check();
                        player1_xod_cs xod = new player1_xod_cs();
                        int x = Convert.ToInt32(e.X);
                        int y = Convert.ToInt32(e.Y);
                        int[] figura = class_picturebox.rachet(doska, x, y); //юзая класс определяем клетку нажатия и фигуру
                        if (figura[2] == 0) { } //nothing
                        else if (figura[3] == 0) { }
                        else
                        {
                            xodi = xod.firts_etap(doska, figura);
                            otrsvka.otrisoBka(doska_bitmap, doska, cletochki);
                            pictureBox1.Image = doska_bitmap;
                            pictureBox1.Refresh();
                            e1.FillRectangle(new SolidBrush(Color.FromArgb(155, Color.Yellow)), cletochki[figura[0], figura[1], 0].X, cletochki[figura[0], figura[1], 0].Y, Convert.ToSingle(Math.Sqrt(Math.Pow((cletochki[figura[0], figura[1], 0].X - cletochki[figura[0], figura[1], 1].X), 2) + Math.Pow((cletochki[figura[0], figura[1], 0].Y - cletochki[figura[0], figura[1], 1].Y), 2)) / Math.Sqrt(2)) + 1, Convert.ToSingle(Math.Sqrt(Math.Pow((cletochki[figura[0], figura[1], 0].X - cletochki[figura[0], figura[1], 1].X), 2) + Math.Pow((cletochki[figura[0], figura[1], 0].Y - cletochki[figura[0], figura[1], 1].Y), 2)) / Math.Sqrt(2)) + 1);
                            for (int i = 0; i < 26; i++)
                            {
                                for (int x1 = 0; x1 < 8; x1++)
                                {
                                    for (int y1 = 0; y1 < 8; y1++)
                                    {
                                        if (xodi[i, x1, y1] == 1)
                                        {
                                            click = true;
                                            e1.FillRectangle(new SolidBrush(Color.FromArgb(155, Color.Green)), cletochki[x1, y1, 0].X, cletochki[x1, y1, 0].Y, Convert.ToSingle(Math.Sqrt(Math.Pow((cletochki[x1, y1, 0].X - cletochki[x1, y1, 1].X), 2) + Math.Pow((cletochki[x1, y1, 0].Y - cletochki[x1, y1, 1].Y), 2)) / Math.Sqrt(2)) + 1, Convert.ToSingle(Math.Sqrt(Math.Pow((cletochki[x1, y1, 0].X - cletochki[x1, y1, 1].X), 2) + Math.Pow((cletochki[x1, y1, 0].Y - cletochki[x1, y1, 1].Y), 2)) / Math.Sqrt(2)) + 1);
                                        }
                                    }
                                }
                            }
                        }
                        vibrannaya_figura = figura;
                        pictureBox1.Image = doska_bitmap;
                        pictureBox1.Refresh();
                    }
                    else
                    {
                        Graphics e1 = Graphics.FromImage(doska_bitmap);
                        otrisovka otrsvka = new otrisovka();
                        picturebox_click_check class_picturebox = new picturebox_click_check();
                        int x = Convert.ToInt32(e.X);
                        int y = Convert.ToInt32(e.Y);
                        int[] figura = class_picturebox.rachet(doska, x, y);
                        click = false;
                        for (int x1 = 0; x1 < 8; x1++)
                        {
                            for (int y1 = 0; y1 < 8; y1++)
                            {
                                if (figura[0] == x1 && figura[1] == y1)
                                {
                                    for (int i = 0; i < 26; i++)
                                    {
                                        if (xodi[i, x1, y1] == 1)
                                        {
                                            player1_xod = false;
                                            doska[vibrannaya_figura[0], vibrannaya_figura[1], vibrannaya_figura[2], vibrannaya_figura[3]] = 0;
                                            doska[vibrannaya_figura[0], vibrannaya_figura[1], 0, 0] = 1;
                                            doska[x1, y1, 0, 0] = 0;
                                            doska[x1, y1, vibrannaya_figura[2], vibrannaya_figura[3]] = 1;
                                            break;
                                        }
                                    }
                                }
                            }
                        }

                        otrsvka.otrisoBka(doska_bitmap, doska, cletochki);
                        pictureBox1.Image = doska_bitmap;
                        pictureBox1.Refresh();
                    }
                }
                else //player2_xod_cs юзаем
                {
                    if (click == false)
                    {
                        Graphics e1 = Graphics.FromImage(doska_bitmap);
                        otrisovka otrsvka = new otrisovka();
                        picturebox_click_check class_picturebox = new picturebox_click_check();
                        player2_xod_cs xod = new player2_xod_cs();
                        int x = Convert.ToInt32(e.X);
                        int y = Convert.ToInt32(e.Y);
                        int[] figura = class_picturebox.rachet(doska, x, y); //юзая класс определяем клетку нажатия и фигуру
                        if (figura[2] == 0) { } //nothing
                        else if (figura[3] == 1) { }
                        else
                        {
                            xodi = xod.firts_etap(doska, figura);
                            otrsvka.otrisoBka(doska_bitmap, doska, cletochki);
                            pictureBox1.Image = doska_bitmap;
                            pictureBox1.Refresh();
                            e1.FillRectangle(new SolidBrush(Color.FromArgb(155, Color.Yellow)), cletochki[figura[0], figura[1], 0].X, cletochki[figura[0], figura[1], 0].Y, Convert.ToSingle(Math.Sqrt(Math.Pow((cletochki[figura[0], figura[1], 0].X - cletochki[figura[0], figura[1], 1].X), 2) + Math.Pow((cletochki[figura[0], figura[1], 0].Y - cletochki[figura[0], figura[1], 1].Y), 2)) / Math.Sqrt(2)) + 1, Convert.ToSingle(Math.Sqrt(Math.Pow((cletochki[figura[0], figura[1], 0].X - cletochki[figura[0], figura[1], 1].X), 2) + Math.Pow((cletochki[figura[0], figura[1], 0].Y - cletochki[figura[0], figura[1], 1].Y), 2)) / Math.Sqrt(2)) + 1);
                            for (int i = 0; i < 26; i++)
                            {
                                for (int x1 = 0; x1 < 8; x1++)
                                {
                                    for (int y1 = 0; y1 < 8; y1++)
                                    {
                                        if (xodi[i, x1, y1] == 1)
                                        {
                                            click = true;
                                            e1.FillRectangle(new SolidBrush(Color.FromArgb(155, Color.Green)), cletochki[x1, y1, 0].X, cletochki[x1, y1, 0].Y, Convert.ToSingle(Math.Sqrt(Math.Pow((cletochki[x1, y1, 0].X - cletochki[x1, y1, 1].X), 2) + Math.Pow((cletochki[x1, y1, 0].Y - cletochki[x1, y1, 1].Y), 2)) / Math.Sqrt(2)) + 1, Convert.ToSingle(Math.Sqrt(Math.Pow((cletochki[x1, y1, 0].X - cletochki[x1, y1, 1].X), 2) + Math.Pow((cletochki[x1, y1, 0].Y - cletochki[x1, y1, 1].Y), 2)) / Math.Sqrt(2)) + 1);
                                        }
                                    }
                                }
                            }
                        }
                        vibrannaya_figura = figura;
                        pictureBox1.Image = doska_bitmap;
                        pictureBox1.Refresh();
                    }
                    else
                    {
                        Graphics e1 = Graphics.FromImage(doska_bitmap);
                        otrisovka otrsvka = new otrisovka();
                        picturebox_click_check class_picturebox = new picturebox_click_check();
                        int x = Convert.ToInt32(e.X);
                        int y = Convert.ToInt32(e.Y);
                        int[] figura = class_picturebox.rachet(doska, x, y);
                        click = false;
                        for (int x1 = 0; x1 < 8; x1++)
                        {
                            for (int y1 = 0; y1 < 8; y1++)
                            {
                                if (figura[0] == x1 && figura[1] == y1)
                                {
                                    for (int i = 0; i < 26; i++)
                                    {
                                        if (xodi[i, x1, y1] == 1)
                                        {
                                            player1_xod = true;
                                            doska[vibrannaya_figura[0], vibrannaya_figura[1], vibrannaya_figura[2], vibrannaya_figura[3]] = 0;
                                            doska[vibrannaya_figura[0], vibrannaya_figura[1], 0, 0] = 1;
                                            doska[x1, y1, 0, 0] = 0;
                                            doska[x1, y1, vibrannaya_figura[2], vibrannaya_figura[3]] = 1;
                                            break;
                                        }
                                    }
                                }
                            }
                        }

                        otrsvka.otrisoBka(doska_bitmap, doska, cletochki);
                        pictureBox1.Image = doska_bitmap;
                        pictureBox1.Refresh();
                    }
                }
            }
        }
    }
}
