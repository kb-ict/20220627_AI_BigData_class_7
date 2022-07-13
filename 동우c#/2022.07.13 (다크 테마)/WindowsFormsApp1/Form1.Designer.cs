namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.woya1 = new System.Windows.Forms.Button();
            this.woya2 = new System.Windows.Forms.Button();
            this.woya3 = new System.Windows.Forms.Button();
            this.woya4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pan7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.woya4);
            this.panel1.Controls.Add(this.woya3);
            this.panel1.Controls.Add(this.woya2);
            this.panel1.Controls.Add(this.woya1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 681);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 138);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴 윤체 M", 71.99999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(30, -13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 131);
            this.label2.TabIndex = 3;
            this.label2.Text = "m";
            // 
            // woya1
            // 
            this.woya1.FlatAppearance.BorderSize = 0;
            this.woya1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.woya1.Font = new System.Drawing.Font("한컴 윤체 M", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.woya1.ForeColor = System.Drawing.Color.White;
            this.woya1.Image = ((System.Drawing.Image)(resources.GetObject("woya1.Image")));
            this.woya1.Location = new System.Drawing.Point(-3, 175);
            this.woya1.Name = "woya1";
            this.woya1.Size = new System.Drawing.Size(212, 108);
            this.woya1.TabIndex = 4;
            this.woya1.Text = "Dashboard";
            this.woya1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.woya1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.woya1.UseVisualStyleBackColor = true;
            this.woya1.Click += new System.EventHandler(this.woya1_Click);
            // 
            // woya2
            // 
            this.woya2.FlatAppearance.BorderSize = 0;
            this.woya2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.woya2.Font = new System.Drawing.Font("한컴 윤체 M", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.woya2.ForeColor = System.Drawing.Color.White;
            this.woya2.Image = ((System.Drawing.Image)(resources.GetObject("woya2.Image")));
            this.woya2.Location = new System.Drawing.Point(-3, 275);
            this.woya2.Name = "woya2";
            this.woya2.Size = new System.Drawing.Size(212, 108);
            this.woya2.TabIndex = 5;
            this.woya2.Text = "Sellers";
            this.woya2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.woya2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.woya2.UseVisualStyleBackColor = true;
            this.woya2.Click += new System.EventHandler(this.woya2_Click);
            // 
            // woya3
            // 
            this.woya3.FlatAppearance.BorderSize = 0;
            this.woya3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.woya3.Font = new System.Drawing.Font("한컴 윤체 M", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.woya3.ForeColor = System.Drawing.Color.White;
            this.woya3.Image = ((System.Drawing.Image)(resources.GetObject("woya3.Image")));
            this.woya3.Location = new System.Drawing.Point(0, 379);
            this.woya3.Name = "woya3";
            this.woya3.Size = new System.Drawing.Size(212, 108);
            this.woya3.TabIndex = 6;
            this.woya3.Text = "Calender";
            this.woya3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.woya3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.woya3.UseVisualStyleBackColor = true;
            this.woya3.Click += new System.EventHandler(this.button3_Click);
            // 
            // woya4
            // 
            this.woya4.FlatAppearance.BorderSize = 0;
            this.woya4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.woya4.Font = new System.Drawing.Font("한컴 윤체 M", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.woya4.ForeColor = System.Drawing.Color.White;
            this.woya4.Image = ((System.Drawing.Image)(resources.GetObject("woya4.Image")));
            this.woya4.Location = new System.Drawing.Point(0, 481);
            this.woya4.Name = "woya4";
            this.woya4.Size = new System.Drawing.Size(212, 108);
            this.woya4.TabIndex = 7;
            this.woya4.Text = "Talks";
            this.woya4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.woya4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.woya4.UseVisualStyleBackColor = true;
            this.woya4.Click += new System.EventHandler(this.woya4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(779, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(215, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 302);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "Talks";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("한컴 윤체 M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(881, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "Week";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("한컴 윤체 M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(777, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 50);
            this.button6.TabIndex = 6;
            this.button6.Text = "Month";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("한컴 윤체 M", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(676, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 50);
            this.button7.TabIndex = 7;
            this.button7.Text = "Six Months";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("한컴 윤체 M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(556, 38);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(145, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "Week";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(538, 257);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("한컴 윤체 M", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.Location = new System.Drawing.Point(593, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 25);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "IBM";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("한컴 윤체 M", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox2.Location = new System.Drawing.Point(593, 111);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 25);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "SAMSUNG";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("한컴 윤체 M", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox3.Location = new System.Drawing.Point(593, 142);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(53, 25);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Kia";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("한컴 윤체 M", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox4.Location = new System.Drawing.Point(593, 173);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 25);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Lotte";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(210, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 100);
            this.panel4.TabIndex = 8;
            // 
            // pan7
            // 
            this.pan7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pan7.Location = new System.Drawing.Point(213, 175);
            this.pan7.Name = "pan7";
            this.pan7.Size = new System.Drawing.Size(14, 77);
            this.pan7.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1137, 681);
            this.Controls.Add(this.pan7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("한컴 윤체 M", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button woya4;
        private System.Windows.Forms.Button woya3;
        private System.Windows.Forms.Button woya2;
        private System.Windows.Forms.Button woya1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pan7;
    }
}

