using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数字拼图
{
    public partial class MainForm : Form
    {
        bool moved = false;
        bool initing = false;
        TableLayoutPanelCellPosition BankCellPos = new TableLayoutPanelCellPosition(2, 2);
        int seconds = 0;

        public MainForm()
        {
            InitializeComponent();

            初始化布局();
        }

        private void 初始化布局()
        {
            initing = true;

            var rnd = new Random(DateTime.Now.Second);

            for (int i = 0; i < 150; i++)
            {
                switch(rnd.Next(4))
                {
                    case 0:
                        if(BankCellPos.Row - 1 >= 0)
                        {
                            自动移动方块(BankCellPos.Column, BankCellPos.Row - 1);
                        }
                        break;
                    case 1:
                        if (BankCellPos.Row + 1 <= 2)
                        {
                            自动移动方块(BankCellPos.Column, BankCellPos.Row + 1);
                        }
                        break;
                    case 2:
                        if (BankCellPos.Column - 1 >= 0)
                        {
                            自动移动方块(BankCellPos.Column -1 , BankCellPos.Row);
                        }
                        break;
                    case 3:
                        if (BankCellPos.Column + 1 <= 2)
                        {
                            自动移动方块(BankCellPos.Column + 1, BankCellPos.Row);
                        }
                        break;
                }
            }

            initing = false;
            seconds = 0;
            timer1.Enabled = true;
        }

        private void 自动移动方块(int col, int row)
        {
            var c = (Button)tableLayoutPanel1.GetControlFromPosition(col, row);
            btn_Click(c, null);
        }

        private void 移动方块(Button btn, TableLayoutPanelCellPosition pos, int col, int row)
        {
            var c = (Button)tableLayoutPanel1.GetControlFromPosition(col, row);
            if (c.Text == " ")
            {
                c.Text = btn.Text;
                btn.Text = " ";

                moved = true;
                BankCellPos = pos;
            }
        }

        private void 判断是否完成()
        {
            if (moved && !initing)
            {
                var s = "";
                for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
                {
                    for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                    {
                        var c = (Button)tableLayoutPanel1.GetControlFromPosition(j, i);
                        s = s + c.Text;
                    }
                }
                if (s == "12345678 ")
                {
                    timer1.Enabled = false;

                    if(DialogResult.Yes == MessageBox.Show($"恭喜，成功！\n共用时:[{tsiTimer.Text}]\n再来一局吗？", "完成", MessageBoxButtons.YesNo))
                    {
                        初始化布局();
                    }
                    moved = false;
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            var pos = tableLayoutPanel1.GetPositionFromControl(btn);

            if(pos.Row - 1 >= 0)
            {
                移动方块(btn, pos, pos.Column, pos.Row - 1);
            }

            if (pos.Row + 1 <= 2)
            {
                移动方块(btn, pos, pos.Column, pos.Row + 1);
            }

            if (pos.Column - 1 >= 0)
            {
                移动方块(btn, pos, pos.Column - 1, pos.Row);
            }

            if (pos.Column + 1 <= 2)
            {
                移动方块(btn, pos, pos.Column + 1, pos.Row);
            }

            判断是否完成();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            var ts = new TimeSpan(0, 0, seconds);
            tsiTimer.Text = ts.ToString("c");
        }

        private void tsbReset_Click(object sender, EventArgs e)
        {
            初始化布局();
        }
    }
}
