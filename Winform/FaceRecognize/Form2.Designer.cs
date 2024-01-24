namespace FaceRecognize
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gridPres = new System.Windows.Forms.DataGridView();
            this.clbSession = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMedName = new System.Windows.Forms.TextBox();
            this.tbDose = new System.Windows.Forms.TextBox();
            this.tbNumDay = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPres)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPres
            // 
            this.gridPres.BackgroundColor = System.Drawing.Color.White;
            this.gridPres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSession,
            this.colDose,
            this.colDay,
            this.colTotal,
            this.colNote});
            this.gridPres.Location = new System.Drawing.Point(17, 15);
            this.gridPres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridPres.Name = "gridPres";
            this.gridPres.RowHeadersWidth = 51;
            this.gridPres.Size = new System.Drawing.Size(1229, 602);
            this.gridPres.TabIndex = 0;
            // 
            // clbSession
            // 
            this.clbSession.BackColor = System.Drawing.SystemColors.Control;
            this.clbSession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.clbSession.FormattingEnabled = true;
            this.clbSession.Items.AddRange(new object[] {
            "morning",
            "noon",
            "evening"});
            this.clbSession.Location = new System.Drawing.Point(575, 697);
            this.clbSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbSession.Name = "clbSession";
            this.clbSession.Size = new System.Drawing.Size(117, 63);
            this.clbSession.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(16, 688);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medicine name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(281, 688);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(397, 688);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of days";
            // 
            // tbMedName
            // 
            this.tbMedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMedName.Location = new System.Drawing.Point(17, 714);
            this.tbMedName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMedName.Name = "tbMedName";
            this.tbMedName.Size = new System.Drawing.Size(238, 26);
            this.tbMedName.TabIndex = 7;
            // 
            // tbDose
            // 
            this.tbDose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDose.Location = new System.Drawing.Point(285, 714);
            this.tbDose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDose.Name = "tbDose";
            this.tbDose.Size = new System.Drawing.Size(93, 26);
            this.tbDose.TabIndex = 9;
            this.tbDose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDose_KeyPress);
            // 
            // tbNumDay
            // 
            this.tbNumDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumDay.Location = new System.Drawing.Point(401, 714);
            this.tbNumDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNumDay.Name = "tbNumDay";
            this.tbNumDay.Size = new System.Drawing.Size(131, 26);
            this.tbNumDay.TabIndex = 10;
            this.tbNumDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumDay_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(802, 743);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 41);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbID
            // 
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(59, 640);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(238, 26);
            this.tbID.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(16, 642);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(843, 637);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 32);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.White;
            this.btnReceive.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnReceive.Location = new System.Drawing.Point(304, 638);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(136, 32);
            this.btnReceive.TabIndex = 16;
            this.btnReceive.Text = "Reveive";
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(702, 637);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 32);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbNote
            // 
            this.tbNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNote.Location = new System.Drawing.Point(17, 790);
            this.tbNote.Margin = new System.Windows.Forms.Padding(4);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(664, 112);
            this.tbNote.TabIndex = 19;
            this.tbNote.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(16, 764);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Note";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "Medicine name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 180;
            // 
            // colSession
            // 
            this.colSession.DataPropertyName = "session";
            this.colSession.HeaderText = "Session";
            this.colSession.MinimumWidth = 6;
            this.colSession.Name = "colSession";
            this.colSession.Width = 150;
            // 
            // colDose
            // 
            this.colDose.DataPropertyName = "dose";
            this.colDose.HeaderText = "Dose";
            this.colDose.MinimumWidth = 6;
            this.colDose.Name = "colDose";
            this.colDose.Width = 99;
            // 
            // colDay
            // 
            this.colDay.DataPropertyName = "numOfDays";
            this.colDay.HeaderText = "Number of days";
            this.colDay.MinimumWidth = 6;
            this.colDay.Name = "colDay";
            this.colDay.Width = 110;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "total";
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 70;
            // 
            // colNote
            // 
            this.colNote.DataPropertyName = "note";
            this.colNote.HeaderText = "Note";
            this.colNote.MinimumWidth = 6;
            this.colNote.Name = "colNote";
            this.colNote.Width = 255;
            // 
            // Form2
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1259, 915);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNumDay);
            this.Controls.Add(this.tbDose);
            this.Controls.Add(this.tbMedName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbSession);
            this.Controls.Add(this.gridPres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPres;
        private System.Windows.Forms.CheckedListBox clbSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMedName;
        private System.Windows.Forms.TextBox tbDose;
        private System.Windows.Forms.TextBox tbNumDay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
    }
}