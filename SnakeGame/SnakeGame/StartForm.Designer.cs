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
            this.playFastBtn = new System.Windows.Forms.Button();
            this.playFastestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(12, 12);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(260, 23);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Normal";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // playFastBtn
            // 
            this.playFastBtn.Location = new System.Drawing.Point(12, 42);
            this.playFastBtn.Name = "playFastBtn";
            this.playFastBtn.Size = new System.Drawing.Size(260, 23);
            this.playFastBtn.TabIndex = 1;
            this.playFastBtn.Text = "Fast";
            this.playFastBtn.UseVisualStyleBackColor = true;
            this.playFastBtn.Click += new System.EventHandler(this.playFastBtn_Click);
            // 
            // playFastestBtn
            // 
            this.playFastestBtn.Location = new System.Drawing.Point(12, 72);
            this.playFastestBtn.Name = "playFastestBtn";
            this.playFastestBtn.Size = new System.Drawing.Size(260, 23);
            this.playFastestBtn.TabIndex = 2;
            this.playFastestBtn.Text = "Very fast";
            this.playFastestBtn.UseVisualStyleBackColor = true;
            this.playFastestBtn.Click += new System.EventHandler(this.playFastestBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.playFastestBtn);
            this.Controls.Add(this.playFastBtn);
            this.Controls.Add(this.playBtn);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button playFastBtn;
        private System.Windows.Forms.Button playFastestBtn;
    }
}