using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贪吃蛇
{
    enum 方向
    {
        上,
        下,
        左,
        右
    }

    public partial class MainForm : Form
    {
        private const int 最长蛇身 = 64;
        private int 所用时间 = 0;

        private 方向 当前方向 = 方向.上;
        private List<Point> 轨迹 = new List<Point>();
        private List<PictureBox> 蛇身 = new List<PictureBox>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (当前方向)
            {
                case 方向.上:
                    pbHead.Top -= pbHead.Width;
                    pbHead.Image = global::贪吃蛇.Properties.Resources.蛇头上;
                    break;
                case 方向.下:
                    pbHead.Top += pbHead.Width;
                    pbHead.Image = global::贪吃蛇.Properties.Resources.蛇头下;
                    break;
                case 方向.左:
                    pbHead.Left -= pbHead.Width;
                    pbHead.Image = global::贪吃蛇.Properties.Resources.蛇头左;
                    break;
                case 方向.右:
                    pbHead.Left += pbHead.Width;
                    pbHead.Image = global::贪吃蛇.Properties.Resources.蛇头右;
                    break;
            }

            for (int i = 0; i < 蛇身.Count; i++)
            {
                蛇身[i].Location = 轨迹[轨迹.Count - i - 1];
            }

            if (轨迹.Count - 1 == 蛇身.Count)
            {
                轨迹.RemoveAt(0);
            }
            轨迹.Add(pbHead.Location);

            //var headRect = pbHead.RectangleToClient(ClientRectangle);
            //var wutaiRect = 舞台.RectangleToClient(ClientRectangle);

            // if (!headRect.IntersectsWith(wutaiRect))
            //{
            //    timer1.Enabled = false;
            //}

            if(pbHead.Top < 0 || pbHead.Left < 0||pbHead.Bottom>舞台.Height||pbHead.Right>舞台.Width)
            {
                游戏结束();
            }
            if (pbHead.Location == pbApple.Location)
            {
                产生苹果();
            
                var p = new PictureBox();
                p.Image = global::贪吃蛇.Properties.Resources.蛇身;
                p.SizeMode = PictureBoxSizeMode.CenterImage;
                p.Size = new Size(32, 32);
                舞台.Controls.Add(p);
                蛇身.Insert(0, p);
                p.Location = 轨迹[0];

                txtLength.Text = 蛇身.Count.ToString();
            }
            


            for (int i = 0; i < 蛇身.Count; i++)
            {
                if(蛇身[i].Location == 轨迹[轨迹.Count - 1])
                {
                    游戏结束();
                    break;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Up:
                    当前方向 = 方向.上;
                    break;
                case Keys.Down:
                    当前方向 = 方向.下;
                    break;
                case Keys.Left:
                    当前方向 = 方向.左;
                    break;
                case Keys.Right:
                    当前方向 = 方向.右;
                    break;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if(keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
            {
                return false;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            初始化游戏();
        }

        private void 产生苹果()
        {
            var rnd = new Random(DateTime.Now.Second);

            var x = rnd.Next(舞台.Width);
            var y = rnd.Next(舞台.Height);
            x = x / 32 * 32;
            y = y / 32 * 32;
            pbApple.Location = new Point(x, y);
        }

        private void 初始化游戏()
        {
            当前方向 = 方向.上;
            轨迹.Clear();
            foreach(var c in 蛇身)
            {
                舞台.Controls.Remove(c);
            }
            蛇身.Clear();

            产生苹果();

            pbHead.Location = new Point(0, 320);
            轨迹.Insert(0, pbHead.Location);
            var top = pbHead.Bottom;
            for (int i = 0; i < 3; i++)
            {
                var p = new PictureBox();
                p.Image = global::贪吃蛇.Properties.Resources.蛇身;
                p.SizeMode = PictureBoxSizeMode.CenterImage;
                p.Top = top;
                p.Left = pbHead.Left;
                p.Size = new Size(32, 32);

                舞台.Controls.Add(p);

                蛇身.Insert(0, p);
                轨迹.Insert(0, p.Location);

                top += 32;
            }

            txtLength.Text = 蛇身.Count.ToString();
            所用时间 = 0;
            txtTime.Text = new TimeSpan(0, 0, 0).ToString("c");

            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void 游戏结束()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;

            var text = "游戏结束！\n" +
                $"蛇长：{蛇身.Count}\n" +
                $"用时：{所用时间}s\n\n" +
                "再玩一局？";

            if(DialogResult.Yes == MessageBox.Show(text, "小牛告诉你", MessageBoxButtons.YesNo))
            {
                初始化游戏();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            初始化游戏();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            所用时间++;
            txtTime.Text = new TimeSpan(0, 0, 所用时间).ToString("c");
        }
    }
}
