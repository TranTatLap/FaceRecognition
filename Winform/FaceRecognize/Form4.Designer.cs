namespace FaceRecognize
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnFaceRecognition = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnPres = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFaceRecognition
            // 
            this.btnFaceRecognition.BackColor = System.Drawing.Color.White;
            this.btnFaceRecognition.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaceRecognition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnFaceRecognition.Location = new System.Drawing.Point(741, 153);
            this.btnFaceRecognition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFaceRecognition.Name = "btnFaceRecognition";
            this.btnFaceRecognition.Size = new System.Drawing.Size(212, 38);
            this.btnFaceRecognition.TabIndex = 17;
            this.btnFaceRecognition.Text = "Recognition System";
            this.btnFaceRecognition.UseVisualStyleBackColor = false;
            this.btnFaceRecognition.Click += new System.EventHandler(this.btnFaceRecognition_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnAbout.Location = new System.Drawing.Point(741, 282);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(212, 38);
            this.btnAbout.TabIndex = 18;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnPres
            // 
            this.btnPres.BackColor = System.Drawing.Color.White;
            this.btnPres.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnPres.Location = new System.Drawing.Point(741, 239);
            this.btnPres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPres.Name = "btnPres";
            this.btnPres.Size = new System.Drawing.Size(212, 38);
            this.btnPres.TabIndex = 19;
            this.btnPres.Text = "Prescription";
            this.btnPres.UseVisualStyleBackColor = false;
            this.btnPres.Click += new System.EventHandler(this.btnPres_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.White;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnInfo.Location = new System.Drawing.Point(741, 196);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(212, 38);
            this.btnInfo.TabIndex = 20;
            this.btnInfo.Text = "Information";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.White;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnQuit.Location = new System.Drawing.Point(741, 324);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(212, 38);
            this.btnQuit.TabIndex = 21;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnPres);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnFaceRecognition);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFaceRecognition;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnPres;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnQuit;
    }
}