namespace FaceRecognize
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTake = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbTypeCam = new System.Windows.Forms.ComboBox();
            this.picRes = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.picCam = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDoB = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.White;
            this.btnTake.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnTake.Location = new System.Drawing.Point(472, 673);
            this.btnTake.Margin = new System.Windows.Forms.Padding(2);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(133, 33);
            this.btnTake.TabIndex = 7;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = false;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnReset.Location = new System.Drawing.Point(335, 673);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 33);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnStart.Location = new System.Drawing.Point(198, 673);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 33);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbTypeCam
            // 
            this.cbTypeCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeCam.FormattingEnabled = true;
            this.cbTypeCam.Location = new System.Drawing.Point(32, 677);
            this.cbTypeCam.Margin = new System.Windows.Forms.Padding(2);
            this.cbTypeCam.Name = "cbTypeCam";
            this.cbTypeCam.Size = new System.Drawing.Size(151, 26);
            this.cbTypeCam.TabIndex = 4;
            // 
            // picRes
            // 
            this.picRes.Image = global::FaceRecognize.Properties.Resources._0;
            this.picRes.Location = new System.Drawing.Point(804, 43);
            this.picRes.Margin = new System.Windows.Forms.Padding(2);
            this.picRes.Name = "picRes";
            this.picRes.Size = new System.Drawing.Size(427, 637);
            this.picRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRes.TabIndex = 9;
            this.picRes.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "ID_picture|*.jpg";
            // 
            // picCam
            // 
            this.picCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCam.Image = ((System.Drawing.Image)(resources.GetObject("picCam.Image")));
            this.picCam.Location = new System.Drawing.Point(58, 166);
            this.picCam.Margin = new System.Windows.Forms.Padding(2);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(630, 469);
            this.picCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCam.TabIndex = 8;
            this.picCam.TabStop = false;
            this.picCam.Click += new System.EventHandler(this.picCam_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnNew.Location = new System.Drawing.Point(609, 673);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(133, 33);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.White;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnDetail.Location = new System.Drawing.Point(953, 677);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(133, 33);
            this.btnDetail.TabIndex = 11;
            this.btnDetail.Text = "Detai";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbAvatar.InitialImage")));
            this.pbAvatar.Location = new System.Drawing.Point(915, 179);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(207, 211);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 12;
            this.pbAvatar.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(939, 499);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(246, 22);
            this.tbName.TabIndex = 14;
            this.tbName.Text = "Wonder Woman";
            this.tbName.WordWrap = false;
            // 
            // tbDoB
            // 
            this.tbDoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.tbDoB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDoB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoB.ForeColor = System.Drawing.Color.White;
            this.tbDoB.Location = new System.Drawing.Point(937, 546);
            this.tbDoB.Name = "tbDoB";
            this.tbDoB.ReadOnly = true;
            this.tbDoB.Size = new System.Drawing.Size(248, 22);
            this.tbDoB.TabIndex = 15;
            this.tbDoB.Text = "10/10/2022";
            this.tbDoB.WordWrap = false;
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.White;
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.tbId.Location = new System.Drawing.Point(977, 414);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(109, 22);
            this.tbId.TabIndex = 13;
            this.tbId.Text = "123455";
            this.tbId.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1279, 718);
            this.Controls.Add(this.tbDoB);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.picCam);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbTypeCam);
            this.Controls.Add(this.picRes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Recognition System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbTypeCam;
        private System.Windows.Forms.PictureBox picRes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox picCam;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDoB;
        private System.Windows.Forms.TextBox tbId;
    }
}

