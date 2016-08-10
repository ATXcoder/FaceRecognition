namespace FaceIdentification
{
    partial class Form1
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
            this.BTTN_SnapPic = new System.Windows.Forms.Button();
            this.DBOX_Camera = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 368);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTTN_Start
            // 
            this.BTTN_Start.BackColor = System.Drawing.Color.Lime;
            this.BTTN_Start.Location = new System.Drawing.Point(12, 396);
            this.BTTN_Start.Name = "BTTN_Start";
            this.BTTN_Start.Size = new System.Drawing.Size(107, 50);
            this.BTTN_Start.TabIndex = 1;
            this.BTTN_Start.Text = "Start";
            this.BTTN_Start.UseVisualStyleBackColor = false;
            this.BTTN_Start.Click += new System.EventHandler(this.BTTN_Start_Click);
            // 
            // BTTN_Stop
            // 
            this.BTTN_Stop.BackColor = System.Drawing.Color.Red;
            this.BTTN_Stop.Location = new System.Drawing.Point(407, 396);
            this.BTTN_Stop.Name = "BTTN_Stop";
            this.BTTN_Stop.Size = new System.Drawing.Size(107, 50);
            this.BTTN_Stop.TabIndex = 2;
            this.BTTN_Stop.Text = "Stop";
            this.BTTN_Stop.UseVisualStyleBackColor = false;
            this.BTTN_Stop.Click += new System.EventHandler(this.BTTN_Stop_Click);
            // 
            // BTTN_SnapPic
            // 
            this.BTTN_SnapPic.BackColor = System.Drawing.Color.Peru;
            this.BTTN_SnapPic.Location = new System.Drawing.Point(205, 396);
            this.BTTN_SnapPic.Name = "BTTN_SnapPic";
            this.BTTN_SnapPic.Size = new System.Drawing.Size(107, 50);
            this.BTTN_SnapPic.TabIndex = 3;
            this.BTTN_SnapPic.Text = "Snap Picture";
            this.BTTN_SnapPic.UseVisualStyleBackColor = false;
            this.BTTN_SnapPic.Click += new System.EventHandler(this.BTTN_SnapPic_Click);
            // 
            // DBOX_Camera
            // 
            this.DBOX_Camera.FormattingEnabled = true;
            this.DBOX_Camera.Location = new System.Drawing.Point(563, 12);
            this.DBOX_Camera.Name = "DBOX_Camera";
            this.DBOX_Camera.Size = new System.Drawing.Size(216, 21);
            this.DBOX_Camera.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 457);
            this.Controls.Add(this.DBOX_Camera);
            this.Controls.Add(this.BTTN_SnapPic);
            this.Controls.Add(this.BTTN_Stop);
            this.Controls.Add(this.BTTN_Start);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Facial Recognition Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTTN_Start;
        private System.Windows.Forms.Button BTTN_Stop;
        private System.Windows.Forms.Button BTTN_SnapPic;
        private System.Windows.Forms.ComboBox DBOX_Camera;
    }
}

