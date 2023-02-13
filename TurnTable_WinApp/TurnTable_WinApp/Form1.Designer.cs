namespace TurnTable_WinApp
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
            this.connect_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logClear_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ipTextBox2 = new System.Windows.Forms.TextBox();
            this.ipTextBox3 = new System.Windows.Forms.TextBox();
            this.ipTextBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.degree_btn = new System.Windows.Forms.Button();
            this.repeatTextBox_lower = new System.Windows.Forms.TextBox();
            this.degreeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cw_inf_btn = new System.Windows.Forms.Button();
            this.ccw_inf_btn = new System.Windows.Forms.Button();
            this.cw_ccw_inf_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.repeatTextBox_upper = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.repeat_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.speed_btn = new System.Windows.Forms.Button();
            this.ipTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(689, 127);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(78, 37);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(547, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = ".";
            // 
            // logClear_btn
            // 
            this.logClear_btn.Location = new System.Drawing.Point(331, 387);
            this.logClear_btn.Name = "logClear_btn";
            this.logClear_btn.Size = new System.Drawing.Size(78, 37);
            this.logClear_btn.TabIndex = 2;
            this.logClear_btn.Text = "Clear";
            this.logClear_btn.UseVisualStyleBackColor = true;
            this.logClear_btn.Click += new System.EventHandler(this.logClear_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(624, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(696, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = ".";
            // 
            // ipTextBox2
            // 
            this.ipTextBox2.Location = new System.Drawing.Point(562, 56);
            this.ipTextBox2.Name = "ipTextBox2";
            this.ipTextBox2.Size = new System.Drawing.Size(56, 21);
            this.ipTextBox2.TabIndex = 6;
            // 
            // ipTextBox3
            // 
            this.ipTextBox3.Location = new System.Drawing.Point(634, 56);
            this.ipTextBox3.Name = "ipTextBox3";
            this.ipTextBox3.Size = new System.Drawing.Size(56, 21);
            this.ipTextBox3.TabIndex = 7;
            // 
            // ipTextBox4
            // 
            this.ipTextBox4.Location = new System.Drawing.Point(711, 56);
            this.ipTextBox4.Name = "ipTextBox4";
            this.ipTextBox4.Size = new System.Drawing.Size(56, 21);
            this.ipTextBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP :";
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(12, 56);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(397, 314);
            this.LogBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Logs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "PORT :";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(485, 100);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(56, 21);
            this.portTextBox.TabIndex = 13;
            // 
            // degree_btn
            // 
            this.degree_btn.Location = new System.Drawing.Point(685, 223);
            this.degree_btn.Name = "degree_btn";
            this.degree_btn.Size = new System.Drawing.Size(82, 21);
            this.degree_btn.TabIndex = 14;
            this.degree_btn.Text = "Set";
            this.degree_btn.UseVisualStyleBackColor = true;
            this.degree_btn.Click += new System.EventHandler(this.degree_btn_Click);
            // 
            // repeatTextBox_lower
            // 
            this.repeatTextBox_lower.Location = new System.Drawing.Point(485, 269);
            this.repeatTextBox_lower.Name = "repeatTextBox_lower";
            this.repeatTextBox_lower.Size = new System.Drawing.Size(48, 21);
            this.repeatTextBox_lower.TabIndex = 15;
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.Location = new System.Drawing.Point(573, 227);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.Size = new System.Drawing.Size(48, 21);
            this.degreeTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "Deg. :";
            // 
            // cw_inf_btn
            // 
            this.cw_inf_btn.Location = new System.Drawing.Point(462, 387);
            this.cw_inf_btn.Name = "cw_inf_btn";
            this.cw_inf_btn.Size = new System.Drawing.Size(82, 33);
            this.cw_inf_btn.TabIndex = 18;
            this.cw_inf_btn.Text = "+ inf.";
            this.cw_inf_btn.UseVisualStyleBackColor = true;
            // 
            // ccw_inf_btn
            // 
            this.ccw_inf_btn.Location = new System.Drawing.Point(688, 387);
            this.ccw_inf_btn.Name = "ccw_inf_btn";
            this.ccw_inf_btn.Size = new System.Drawing.Size(82, 33);
            this.ccw_inf_btn.TabIndex = 19;
            this.ccw_inf_btn.Text = "- inf.";
            this.ccw_inf_btn.UseVisualStyleBackColor = true;
            // 
            // cw_ccw_inf_btn
            // 
            this.cw_ccw_inf_btn.Location = new System.Drawing.Point(577, 387);
            this.cw_ccw_inf_btn.Name = "cw_ccw_inf_btn";
            this.cw_ccw_inf_btn.Size = new System.Drawing.Size(82, 33);
            this.cw_ccw_inf_btn.TabIndex = 20;
            this.cw_ccw_inf_btn.Text = "+ - inf.";
            this.cw_ccw_inf_btn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "(-360 ~ 360 )";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "Repeat :";
            // 
            // repeatTextBox_upper
            // 
            this.repeatTextBox_upper.Location = new System.Drawing.Point(573, 269);
            this.repeatTextBox_upper.Name = "repeatTextBox_upper";
            this.repeatTextBox_upper.Size = new System.Drawing.Size(48, 21);
            this.repeatTextBox_upper.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "~";
            // 
            // repeat_btn
            // 
            this.repeat_btn.Location = new System.Drawing.Point(688, 268);
            this.repeat_btn.Name = "repeat_btn";
            this.repeat_btn.Size = new System.Drawing.Size(82, 21);
            this.repeat_btn.TabIndex = 25;
            this.repeat_btn.Text = "Set";
            this.repeat_btn.UseVisualStyleBackColor = true;
            this.repeat_btn.Click += new System.EventHandler(this.repeat_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "(-360 ~ 360 )";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(424, 318);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(49, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "Speed :";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(573, 315);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(48, 21);
            this.speedTextBox.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(571, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "(1 ~ 10 )";
            // 
            // speed_btn
            // 
            this.speed_btn.Location = new System.Drawing.Point(685, 315);
            this.speed_btn.Name = "speed_btn";
            this.speed_btn.Size = new System.Drawing.Size(82, 21);
            this.speed_btn.TabIndex = 30;
            this.speed_btn.Text = "Set";
            this.speed_btn.UseVisualStyleBackColor = true;
            this.speed_btn.Click += new System.EventHandler(this.speed_btn_Click);
            // 
            // ipTextBox1
            // 
            this.ipTextBox1.Location = new System.Drawing.Point(485, 56);
            this.ipTextBox1.Name = "ipTextBox1";
            this.ipTextBox1.Size = new System.Drawing.Size(56, 21);
            this.ipTextBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.speed_btn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.repeat_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.repeatTextBox_upper);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cw_ccw_inf_btn);
            this.Controls.Add(this.ccw_inf_btn);
            this.Controls.Add(this.cw_inf_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.degreeTextBox);
            this.Controls.Add(this.repeatTextBox_lower);
            this.Controls.Add(this.degree_btn);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ipTextBox4);
            this.Controls.Add(this.ipTextBox3);
            this.Controls.Add(this.ipTextBox2);
            this.Controls.Add(this.ipTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logClear_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect_btn);
            this.Name = "Form1";
            this.Text = "TurnTable2D_WinApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logClear_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipTextBox2;
        private System.Windows.Forms.TextBox ipTextBox3;
        private System.Windows.Forms.TextBox ipTextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button degree_btn;
        private System.Windows.Forms.TextBox repeatTextBox_lower;
        private System.Windows.Forms.TextBox degreeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cw_inf_btn;
        private System.Windows.Forms.Button ccw_inf_btn;
        private System.Windows.Forms.Button cw_ccw_inf_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox repeatTextBox_upper;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button repeat_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button speed_btn;
        private System.Windows.Forms.TextBox ipTextBox1;
    }
}

