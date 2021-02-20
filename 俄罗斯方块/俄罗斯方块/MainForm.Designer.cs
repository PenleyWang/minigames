namespace 俄罗斯方块
{
    partial class Fome1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fome1));
            this.舞台 = new System.Windows.Forms.Panel();
            this.游戏结束 = new System.Windows.Forms.Label();
            this.f4 = new System.Windows.Forms.PictureBox();
            this.f3 = new System.Windows.Forms.PictureBox();
            this.f2 = new System.Windows.Forms.PictureBox();
            this.f1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.预览窗口 = new System.Windows.Forms.Panel();
            this.sf4 = new System.Windows.Forms.PictureBox();
            this.sf3 = new System.Windows.Forms.PictureBox();
            this.sf2 = new System.Windows.Forms.PictureBox();
            this.sf1 = new System.Windows.Forms.PictureBox();
            this.下一个图形 = new System.Windows.Forms.Label();
            this.分数显示 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.PictureBox();
            this.舞台.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1)).BeginInit();
            this.预览窗口.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sf4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sf3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).BeginInit();
            this.SuspendLayout();
            // 
            // 舞台
            // 
            this.舞台.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.舞台.Controls.Add(this.游戏结束);
            this.舞台.Controls.Add(this.f4);
            this.舞台.Controls.Add(this.f3);
            this.舞台.Controls.Add(this.f2);
            this.舞台.Controls.Add(this.f1);
            this.舞台.Location = new System.Drawing.Point(0, 0);
            this.舞台.Margin = new System.Windows.Forms.Padding(0);
            this.舞台.Name = "舞台";
            this.舞台.Size = new System.Drawing.Size(450, 700);
            this.舞台.TabIndex = 0;
            this.舞台.Paint += new System.Windows.Forms.PaintEventHandler(this.舞台_Paint);
            // 
            // 游戏结束
            // 
            this.游戏结束.AutoSize = true;
            this.游戏结束.BackColor = System.Drawing.Color.Transparent;
            this.游戏结束.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F);
            this.游戏结束.ForeColor = System.Drawing.Color.Yellow;
            this.游戏结束.Location = new System.Drawing.Point(48, 335);
            this.游戏结束.Name = "游戏结束";
            this.游戏结束.Size = new System.Drawing.Size(520, 104);
            this.游戏结束.TabIndex = 2;
            this.游戏结束.Text = "Game Over";
            // 
            // f4
            // 
            this.f4.BackColor = System.Drawing.Color.Red;
            this.f4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f4.Location = new System.Drawing.Point(246, 67);
            this.f4.Margin = new System.Windows.Forms.Padding(0);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(32, 32);
            this.f4.TabIndex = 1;
            this.f4.TabStop = false;
            // 
            // f3
            // 
            this.f3.BackColor = System.Drawing.Color.Red;
            this.f3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f3.Location = new System.Drawing.Point(198, 67);
            this.f3.Margin = new System.Windows.Forms.Padding(0);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(32, 32);
            this.f3.TabIndex = 1;
            this.f3.TabStop = false;
            // 
            // f2
            // 
            this.f2.BackColor = System.Drawing.Color.Red;
            this.f2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f2.Location = new System.Drawing.Point(148, 67);
            this.f2.Margin = new System.Windows.Forms.Padding(0);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(32, 32);
            this.f2.TabIndex = 1;
            this.f2.TabStop = false;
            // 
            // f1
            // 
            this.f1.BackColor = System.Drawing.Color.Red;
            this.f1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f1.Location = new System.Drawing.Point(101, 67);
            this.f1.Margin = new System.Windows.Forms.Padding(0);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(32, 32);
            this.f1.TabIndex = 1;
            this.f1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 预览窗口
            // 
            this.预览窗口.BackColor = System.Drawing.Color.Blue;
            this.预览窗口.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.预览窗口.Controls.Add(this.sf4);
            this.预览窗口.Controls.Add(this.sf3);
            this.预览窗口.Controls.Add(this.sf2);
            this.预览窗口.Controls.Add(this.sf1);
            this.预览窗口.Location = new System.Drawing.Point(479, 103);
            this.预览窗口.Margin = new System.Windows.Forms.Padding(0);
            this.预览窗口.Name = "预览窗口";
            this.预览窗口.Size = new System.Drawing.Size(144, 85);
            this.预览窗口.TabIndex = 1;
            this.预览窗口.Paint += new System.Windows.Forms.PaintEventHandler(this.预览窗口_Paint);
            // 
            // sf4
            // 
            this.sf4.BackColor = System.Drawing.Color.Red;
            this.sf4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sf4.Location = new System.Drawing.Point(86, 32);
            this.sf4.Margin = new System.Windows.Forms.Padding(0);
            this.sf4.Name = "sf4";
            this.sf4.Size = new System.Drawing.Size(32, 32);
            this.sf4.TabIndex = 2;
            this.sf4.TabStop = false;
            // 
            // sf3
            // 
            this.sf3.BackColor = System.Drawing.Color.Red;
            this.sf3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sf3.Location = new System.Drawing.Point(13, 32);
            this.sf3.Margin = new System.Windows.Forms.Padding(0);
            this.sf3.Name = "sf3";
            this.sf3.Size = new System.Drawing.Size(32, 32);
            this.sf3.TabIndex = 3;
            this.sf3.TabStop = false;
            // 
            // sf2
            // 
            this.sf2.BackColor = System.Drawing.Color.Red;
            this.sf2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sf2.Location = new System.Drawing.Point(61, 0);
            this.sf2.Margin = new System.Windows.Forms.Padding(0);
            this.sf2.Name = "sf2";
            this.sf2.Size = new System.Drawing.Size(32, 32);
            this.sf2.TabIndex = 4;
            this.sf2.TabStop = false;
            // 
            // sf1
            // 
            this.sf1.BackColor = System.Drawing.Color.Red;
            this.sf1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sf1.Location = new System.Drawing.Point(13, 0);
            this.sf1.Margin = new System.Windows.Forms.Padding(0);
            this.sf1.Name = "sf1";
            this.sf1.Size = new System.Drawing.Size(32, 32);
            this.sf1.TabIndex = 5;
            this.sf1.TabStop = false;
            // 
            // 下一个图形
            // 
            this.下一个图形.AutoSize = true;
            this.下一个图形.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.下一个图形.Location = new System.Drawing.Point(474, 55);
            this.下一个图形.Name = "下一个图形";
            this.下一个图形.Size = new System.Drawing.Size(142, 25);
            this.下一个图形.TabIndex = 2;
            this.下一个图形.Text = "下一个图形";
            // 
            // 分数显示
            // 
            this.分数显示.AutoSize = true;
            this.分数显示.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.分数显示.Location = new System.Drawing.Point(477, 247);
            this.分数显示.Name = "分数显示";
            this.分数显示.Size = new System.Drawing.Size(104, 25);
            this.分数显示.TabIndex = 3;
            this.分数显示.Text = "分数：0";
            // 
            // help
            // 
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.Location = new System.Drawing.Point(462, 335);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(150, 276);
            this.help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.help.TabIndex = 4;
            this.help.TabStop = false;
            // 
            // Fome1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(623, 750);
            this.Controls.Add(this.help);
            this.Controls.Add(this.分数显示);
            this.Controls.Add(this.下一个图形);
            this.Controls.Add(this.预览窗口);
            this.Controls.Add(this.舞台);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fome1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "俄罗斯方块";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.舞台.ResumeLayout(false);
            this.舞台.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1)).EndInit();
            this.预览窗口.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sf4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sf3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel 舞台;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox f1;
        private System.Windows.Forms.PictureBox f4;
        private System.Windows.Forms.PictureBox f3;
        private System.Windows.Forms.PictureBox f2;
        private System.Windows.Forms.Label 游戏结束;
        private System.Windows.Forms.Panel 预览窗口;
        private System.Windows.Forms.PictureBox sf4;
        private System.Windows.Forms.PictureBox sf3;
        private System.Windows.Forms.PictureBox sf2;
        private System.Windows.Forms.PictureBox sf1;
        private System.Windows.Forms.Label 下一个图形;
        private System.Windows.Forms.Label 分数显示;
        private System.Windows.Forms.PictureBox help;
    }
}

