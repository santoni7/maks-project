namespace SnakeGame
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playBtn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSize3 = new System.Windows.Forms.RadioButton();
            this.rbSize2 = new System.Windows.Forms.RadioButton();
            this.rbSize1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(12, 266);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(293, 23);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Normal";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Fast";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 67);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Very fast";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 91);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(57, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Insane";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSize3);
            this.groupBox2.Controls.Add(this.rbSize2);
            this.groupBox2.Controls.Add(this.rbSize1);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size:";
            // 
            // rbSize3
            // 
            this.rbSize3.AutoSize = true;
            this.rbSize3.Location = new System.Drawing.Point(6, 68);
            this.rbSize3.Name = "rbSize3";
            this.rbSize3.Size = new System.Drawing.Size(60, 17);
            this.rbSize3.TabIndex = 2;
            this.rbSize3.TabStop = true;
            this.rbSize3.Text = "50 x 50";
            this.rbSize3.UseVisualStyleBackColor = true;
            // 
            // rbSize2
            // 
            this.rbSize2.AutoSize = true;
            this.rbSize2.Location = new System.Drawing.Point(6, 44);
            this.rbSize2.Name = "rbSize2";
            this.rbSize2.Size = new System.Drawing.Size(60, 17);
            this.rbSize2.TabIndex = 1;
            this.rbSize2.TabStop = true;
            this.rbSize2.Text = "25 x 25";
            this.rbSize2.UseVisualStyleBackColor = true;
            // 
            // rbSize1
            // 
            this.rbSize1.AutoSize = true;
            this.rbSize1.Checked = true;
            this.rbSize1.Location = new System.Drawing.Point(7, 20);
            this.rbSize1.Name = "rbSize1";
            this.rbSize1.Size = new System.Drawing.Size(60, 17);
            this.rbSize1.TabIndex = 0;
            this.rbSize1.TabStop = true;
            this.rbSize1.Text = "10 x 10";
            this.rbSize1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Walls";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 295);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(293, 23);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(293, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 388);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.Text = "Launcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSize3;
        private System.Windows.Forms.RadioButton rbSize2;
        private System.Windows.Forms.RadioButton rbSize1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
    }
}