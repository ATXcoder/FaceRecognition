namespace AccordFaceID
{
    partial class Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTTN_Start = new System.Windows.Forms.Button();
            this.BTTN_Stop = new System.Windows.Forms.Button();
            this.DBOX_Camera = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTTN_Detect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 340);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTTN_Start
            // 
            this.BTTN_Start.BackColor = System.Drawing.Color.Lime;
            this.BTTN_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTN_Start.Location = new System.Drawing.Point(12, 376);
            this.BTTN_Start.Name = "BTTN_Start";
            this.BTTN_Start.Size = new System.Drawing.Size(110, 40);
            this.BTTN_Start.TabIndex = 1;
            this.BTTN_Start.Text = "Start";
            this.BTTN_Start.UseVisualStyleBackColor = false;
            this.BTTN_Start.Click += new System.EventHandler(this.BTTN_Start_Click);
            // 
            // BTTN_Stop
            // 
            this.BTTN_Stop.BackColor = System.Drawing.Color.Red;
            this.BTTN_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTN_Stop.Location = new System.Drawing.Point(168, 376);
            this.BTTN_Stop.Name = "BTTN_Stop";
            this.BTTN_Stop.Size = new System.Drawing.Size(110, 40);
            this.BTTN_Stop.TabIndex = 2;
            this.BTTN_Stop.Text = "Stop";
            this.BTTN_Stop.UseVisualStyleBackColor = false;
            this.BTTN_Stop.Click += new System.EventHandler(this.BTTN_Stop_Click);
            // 
            // DBOX_Camera
            // 
            this.DBOX_Camera.FormattingEnabled = true;
            this.DBOX_Camera.Location = new System.Drawing.Point(537, 12);
            this.DBOX_Camera.Name = "DBOX_Camera";
            this.DBOX_Camera.Size = new System.Drawing.Size(180, 21);
            this.DBOX_Camera.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(537, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 297);
            this.textBox1.TabIndex = 4;
            // 
            // BTTN_Detect
            // 
            this.BTTN_Detect.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BTTN_Detect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTN_Detect.Location = new System.Drawing.Point(537, 376);
            this.BTTN_Detect.Name = "BTTN_Detect";
            this.BTTN_Detect.Size = new System.Drawing.Size(110, 40);
            this.BTTN_Detect.TabIndex = 5;
            this.BTTN_Detect.Text = "Detect Face";
            this.BTTN_Detect.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 521);
            this.Controls.Add(this.BTTN_Detect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DBOX_Camera);
            this.Controls.Add(this.BTTN_Stop);
            this.Controls.Add(this.BTTN_Start);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "Accord Facial Recognition Demo";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTTN_Start;
        private System.Windows.Forms.Button BTTN_Stop;
        private System.Windows.Forms.ComboBox DBOX_Camera;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BTTN_Detect;
    }
}

