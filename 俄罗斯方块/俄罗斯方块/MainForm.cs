using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 俄罗斯方块
{
    public partial class Fome1 : Form
    {
        enum 状态
        {
            无,
            落,
            有
        }

        状态[,] 场景 = new 状态[22, 15];
        int[][,] 图形 = new int[7][,]
        {
            new int [4, 2] { { 0, 6 }, {0, 7},{ 0, 8 }, { 0, 9 } },
            new int [4, 2] { { 0, 6 }, {0, 7},{ 0, 8 }, { 1, 6 } },
            new int [4, 2]{ { 0, 6 }, {0, 7},{ 0, 8 }, { 1, 7 } },
            new int [4, 2]{ { 0, 6 }, {0, 7},{ 0, 8 }, { 1, 8 } },
            new int [4, 2]{ { 0, 7 }, {0, 8},{ 1, 7 }, { 1, 8 } },
            new int [4, 2]{ { 0, 6 }, {0, 7},{ 1, 7 }, { 1, 8 } },
            new int [4, 2]{ { 1, 6 }, {1, 7},{ 0, 7 }, { 0, 8 } }
        };

        int 分数 = 0;

        Random rnd = new Random();
        int x;

        bool 有落 = false;

        bool 正在变形 = false;

        bool 重画无 = false;

        public Fome1()
        {
            InitializeComponent();
        }

        private void 舞台_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            for (int i = 0; i <= 舞台.Height; i += 32)
            {
                g.DrawLine(Pens.DarkSlateGray, new Point(0, i), new Point(Width, i));
            }

            for (int i = 0; i <= 舞台.Width; i += 32)
            {
                g.DrawLine(Pens.DarkSlateGray, new Point(i, 0), new Point(i, Height));
            }

            for (int i = 0; i < 22; i++)
            {
                for (var j = 0; j < 15; j++)
                {
                    if (场景[i, j] == 状态.有)
                    {
                        Rectangle rect = new Rectangle(new Point(j * 32 + 1, i * 32 + 1), new Size(30, 30));
                        g.DrawRectangle(Pens.Red, rect);
                        g.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), rect);
                    }
                    else if (重画无 && 场景[i, j] == 状态.无)
                    {
                        Rectangle rect = new Rectangle(new Point(j * 32 + 1, i * 32 + 1), new Size(30, 30));
                        g.DrawRectangle(new Pen(new SolidBrush(舞台.BackColor), 1), rect);
                        g.FillRectangle(new SolidBrush(舞台.BackColor), rect);
                    }
                }
            }

            重画无 = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = rnd.Next(7);

            Height = 744;
            Width = 650;
            
            舞台.Height = 704;
            舞台.Width = 480;

            下一个图形.Top = 64;
            下一个图形.Left = 舞台.Width + 15;

            预览窗口.Height = 128;
            预览窗口.Width = 128;
            预览窗口.Top = 96;
            预览窗口.Left = 舞台.Width + 10;

            分数显示.Top = 预览窗口.Bottom + 32;
            分数显示.Left = 舞台.Width + 15;

            help.Top = 分数显示.Bottom + 32;
            help.Left = 舞台.Width + 7;

            sf1.Size = sf2.Size = sf3.Size = sf4.Size = new Size(32, 32);
            sf1.Visible = sf2.Visible = sf3.Visible = sf4.Visible = false;

            游戏结束.Visible = false;
            f1.Size = f2.Size = f3.Size = f4.Size = new Size(32, 32);
            f1.Visible = f2.Visible = f3.Visible = f4.Visible = false;

            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    场景[i, j] = 状态.无;
                }
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
            {
                return false;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void 新建方块()
        {
            for (int i = 0; i < 4; i++)
            {
                if (场景[图形[x][i, 0], 图形[x][i, 1]] == 状态.无)
                    场景[图形[x][i, 0], 图形[x][i, 1]] = 状态.落;
                else
                {
                    timer1.Enabled = false;
                    游戏结束.Visible = true;

                }
            }
            f1.Visible = f2.Visible = f3.Visible = f4.Visible = true;

            刷新显示();
            x = rnd.Next(7);

            刷新预览();
            sf1.Visible = sf2.Visible = sf3.Visible = sf4.Visible = true;
        }


        private void 刷新预览()
        {
            sf1.Location = new Point((图形[x][0, 1] - 6) * 32, 图形[x][0, 0] * 32 + 32);
            sf2.Location = new Point((图形[x][1, 1] - 6) * 32, 图形[x][1, 0] * 32 + 32);
            sf3.Location = new Point((图形[x][2, 1] - 6) * 32, 图形[x][2, 0] * 32 + 32);
            sf4.Location = new Point((图形[x][3, 1] - 6) * 32, 图形[x][3, 0] * 32 + 32);
        }

        private void 刷新显示()
        {
            int f = 1;
            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (场景[i, j] == 状态.落)
                    {
                        switch (f)
                        {
                            case 1:
                                f1.Location = new Point(j * 32, i * 32);
                                break;

                            case 2:
                                f2.Location = new Point(j * 32, i * 32);
                                break;

                            case 3:
                                f3.Location = new Point(j * 32, i * 32);
                                break;

                            case 4:
                                f4.Location = new Point(j * 32, i * 32);
                                break;
                        }
                        f++;
                    }
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            bool 能落 = true;
            if (!有落)
            {
                新建方块();
                有落 = true;
            }
            else
            {
                for (int i = 21; i >= 0; i--)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        if (场景[i, j] == 状态.落)
                        {
                            if (i == 21 || 场景[i + 1, j] == 状态.有)
                            {
                                f1.Visible = f2.Visible = f3.Visible = f4.Visible = false;
                                有落 = false;
                                能落 = false;
                                timer1.Interval = 500;
                                消方块();
                            }
                        }
                    }
                }

                if (能落)
                {
                    for (int i = 21; i >= 0; i--)
                    {
                        for (int j = 0; j < 15; j++)
                        {
                            if (场景[i, j] == 状态.落)
                            {
                                场景[i, j] = 状态.无;
                                场景[i + 1, j] = 状态.落;
                            }
                        }
                    }
                }

                刷新显示();
            }
        }

        private void 消方块()
        {
            for (int i = 0; i < 22; i++)
            {
                bool x = true;
                for (var j = 0; j < 15; j++)
                {

                    if (场景[i, j] == 状态.落)
                    {
                        场景[i, j] = 状态.有;
                    }
                    if (场景[i, j] == 状态.无)
                    {
                        x = false;
                    }
                }
                if (x)
                {
                    timer1.Enabled = false;

                    var g = 舞台.CreateGraphics();
                    for (var j = 0; j < 15; j++)
                    {

                        场景[i, j] = 状态.无;

                        Rectangle rect = new Rectangle(new Point(j * 32 + 1, i * 32 + 1), new Size(30, 30));
                        g.DrawRectangle(Pens.Green, rect);
                        g.FillRectangle(Brushes.Green, rect);

                        Thread.Sleep(50);

                        g.DrawRectangle(new Pen(new SolidBrush(舞台.BackColor), 1), rect);
                        g.FillRectangle(new SolidBrush(舞台.BackColor), rect);

                        分数++;
                        分数显示.Text = $"分数：{分数}";
                        分数显示.Refresh();
                    }

                    重画无 = true;
                    舞台.Invalidate();
                    timer1.Enabled = true;

                    if (i != 0)
                    {
                        for (int m = i - 1; m >= 0; m--)
                        {
                            bool f = true;
                            for (var n = 0; n < 15; n++)
                            {
                                if (场景[m, n] == 状态.有)
                                {
                                    场景[m, n] = 状态.无;
                                    场景[m + 1, n] = 状态.有;
                                    f = false;
                                }
                            }
                            if (f)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }





        private bool 是否出界或有方块(Point pt)
        {
            var 出界 = pt.X < 0 || pt.X > 舞台.Width || pt.Y < 0 || pt.Y > 舞台.Height;
            var 有方块 = false;
            if (!出界)
            {
                有方块 = 场景[pt.Y / 32, pt.X / 32] == 状态.有;
            }
            return 出界 || 有方块;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (正在变形)
            {
                return;
            }

            正在变形 = true;

            switch (e.KeyCode)
            {
                case Keys.Down:
                    timer1.Interval = 5;

                    break;
                case Keys.Left:
                    for (int i = 0; i < 15; i++)
                    {
                        for (int j = 0; j < 22; j++)
                        {
                            if (场景[j, i] == 状态.落)
                            {
                                if (i > 0 && 场景[j, i - 1] != 状态.有)
                                {
                                    场景[j, i] = 状态.无;
                                    场景[j, i - 1] = 状态.落;
                                }
                                else
                                {
                                    正在变形 = false;
                                    return;
                                }
                            }
                        }
                    }
                    刷新显示();
                    break;
                case Keys.Right:
                    for (int i = 14; i >= 0; i--)
                    {
                        for (int j = 0; j < 22; j++)
                        {
                            if (场景[j, i] == 状态.落)
                            {
                                if (i < 14 && 场景[j, i + 1] != 状态.有)
                                {
                                    场景[j, i] = 状态.无;
                                    场景[j, i + 1] = 状态.落;
                                }
                                else
                                {
                                    正在变形 = false;
                                    return;
                                }


                            }
                        }
                    }
                    刷新显示();
                    break;
                case Keys.Space:
                    Point[] 新位置 = new Point[3];

                    var x = f1.Location.X - (f4.Location.Y - f1.Location.Y);
                    var y = f4.Location.X - f1.Location.X + f1.Location.Y;
                    新位置[0] = new Point(x, y);

                    x = f1.Location.X - (f3.Location.Y - f1.Location.Y);
                    y = f3.Location.X - f1.Location.X + f1.Location.Y;
                    新位置[1] = new Point(x, y);

                    x = f1.Location.X - (f2.Location.Y - f1.Location.Y);
                    y = f2.Location.X - f1.Location.X + f1.Location.Y;
                    新位置[2] = new Point(x, y);

                    foreach (var pt in 新位置)
                    {
                        if (是否出界或有方块(pt))
                        {
                            正在变形 = false;
                            return;
                        }
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        var f = (PictureBox)舞台.Controls.Find($"f{i + 2}", false)[0];
                        场景[f.Location.Y / 32, f.Location.X / 32] = 状态.无;
                        场景[新位置[i].Y / 32, 新位置[i].X / 32] = 状态.落;
                    }
                    刷新显示();
                    break;
            }
            正在变形 = false;
        }

        private void 预览窗口_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            for (int i = 0; i <= 预览窗口.Height; i += 32)
            {
                g.DrawLine(Pens.DarkSlateGray, new Point(0, i), new Point(Width, i));
            }

            for (int i = 0; i <= 预览窗口.Width; i += 32)
            {
                g.DrawLine(Pens.DarkSlateGray, new Point(i, 0), new Point(i, Height));
            }
        }
    }
}
