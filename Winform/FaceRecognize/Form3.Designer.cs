namespace FaceRecognize
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.tbDisease = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPres = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(157, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(209, 252);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(528, 29);
            this.tbID.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(209, 289);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(528, 29);
            this.tbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(116, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(71, 457);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start date:";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM/dd/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(209, 459);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(265, 22);
            this.dtpStart.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(72, 494);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Next date:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MM/dd/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(209, 496);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(265, 22);
            this.dtpEnd.TabIndex = 9;
            // 
            // tbDisease
            // 
            this.tbDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisease.Location = new System.Drawing.Point(209, 326);
            this.tbDisease.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDisease.Name = "tbDisease";
            this.tbDisease.Size = new System.Drawing.Size(528, 29);
            this.tbDisease.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(100, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Disease:";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(209, 363);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(528, 29);
            this.tbPhone.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(23, 366);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone number:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(209, 546);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 33);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.White;
            this.btnReceive.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnReceive.Location = new System.Drawing.Point(423, 546);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(171, 33);
            this.btnReceive.TabIndex = 16;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(209, 15);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(384, 230);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 17;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtpDoB
            // 
            this.dtpDoB.CustomFormat = "MM/dd/yyyy";
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoB.Location = new System.Drawing.Point(208, 407);
            this.dtpDoB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(265, 22);
            this.dtpDoB.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(41, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "Date of birth:";
            // 
            // btnPres
            // 
            this.btnPres.Location = new System.Drawing.Point(747, 331);
            this.btnPres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPres.Name = "btnPres";
            this.btnPres.Size = new System.Drawing.Size(32, 28);
            this.btnPres.TabIndex = 20;
            this.btnPres.Text = "...";
            this.btnPres.UseVisualStyleBackColor = true;
            this.btnPres.Click += new System.EventHandler(this.btnPres_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 594);
            this.Controls.Add(this.btnPres);
            this.Controls.Add(this.dtpDoB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDisease);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient information";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox tbDisease;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPres;
    }
}