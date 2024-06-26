namespace Library_Management_System
{
    partial class ReturnBook
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
            this.panelEnterInfo = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtBoxEnterEnroll = new System.Windows.Forms.TextBox();
            this.labelEnterEnroll = new System.Windows.Forms.Label();
            this.pictureBoxShowStud = new System.Windows.Forms.PictureBox();
            this.dataGridViewReturnBook = new System.Windows.Forms.DataGridView();
            this.panelBawahReturn = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.txtBookIssueDate = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.labelBookReturn = new System.Windows.Forms.Label();
            this.labelIssueDate = new System.Windows.Forms.Label();
            this.labelBookN = new System.Windows.Forms.Label();
            this.panelEnterInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowStud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnBook)).BeginInit();
            this.panelBawahReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEnterInfo
            // 
            this.panelEnterInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelEnterInfo.BackColor = System.Drawing.Color.Cyan;
            this.panelEnterInfo.Controls.Add(this.btnExit);
            this.panelEnterInfo.Controls.Add(this.btnRefresh);
            this.panelEnterInfo.Controls.Add(this.btnSearchStudent);
            this.panelEnterInfo.Controls.Add(this.txtBoxEnterEnroll);
            this.panelEnterInfo.Controls.Add(this.labelEnterEnroll);
            this.panelEnterInfo.Controls.Add(this.pictureBoxShowStud);
            this.panelEnterInfo.Location = new System.Drawing.Point(16, 15);
            this.panelEnterInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelEnterInfo.Name = "panelEnterInfo";
            this.panelEnterInfo.Size = new System.Drawing.Size(345, 453);
            this.panelEnterInfo.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(196, 361);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.buttonExitt_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(49, 361);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 43);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.Location = new System.Drawing.Point(83, 268);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(180, 48);
            this.btnSearchStudent.TabIndex = 3;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtBoxEnterEnroll
            // 
            this.txtBoxEnterEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEnterEnroll.Location = new System.Drawing.Point(49, 219);
            this.txtBoxEnterEnroll.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEnterEnroll.Name = "txtBoxEnterEnroll";
            this.txtBoxEnterEnroll.Size = new System.Drawing.Size(245, 29);
            this.txtBoxEnterEnroll.TabIndex = 2;
            this.txtBoxEnterEnroll.TextChanged += new System.EventHandler(this.txtBoxEnterEnroll_TextChanged);
            // 
            // labelEnterEnroll
            // 
            this.labelEnterEnroll.AutoSize = true;
            this.labelEnterEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterEnroll.Location = new System.Drawing.Point(89, 180);
            this.labelEnterEnroll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnterEnroll.Name = "labelEnterEnroll";
            this.labelEnterEnroll.Size = new System.Drawing.Size(156, 25);
            this.labelEnterEnroll.TabIndex = 1;
            this.labelEnterEnroll.Text = "Enter Matrics No";
            this.labelEnterEnroll.Click += new System.EventHandler(this.labelEnterEnroll_Click);
            // 
            // pictureBoxShowStud
            // 
            this.pictureBoxShowStud.Location = new System.Drawing.Point(100, 31);
            this.pictureBoxShowStud.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxShowStud.Name = "pictureBoxShowStud";
            this.pictureBoxShowStud.Size = new System.Drawing.Size(145, 133);
            this.pictureBoxShowStud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShowStud.TabIndex = 0;
            this.pictureBoxShowStud.TabStop = false;
            // 
            // dataGridViewReturnBook
            // 
            this.dataGridViewReturnBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReturnBook.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridViewReturnBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturnBook.Location = new System.Drawing.Point(369, 15);
            this.dataGridViewReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReturnBook.Name = "dataGridViewReturnBook";
            this.dataGridViewReturnBook.RowHeadersWidth = 51;
            this.dataGridViewReturnBook.Size = new System.Drawing.Size(957, 453);
            this.dataGridViewReturnBook.TabIndex = 1;
            this.dataGridViewReturnBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReturnBook_CellClick);
            // 
            // panelBawahReturn
            // 
            this.panelBawahReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBawahReturn.BackColor = System.Drawing.Color.Cyan;
            this.panelBawahReturn.Controls.Add(this.btnCancel);
            this.panelBawahReturn.Controls.Add(this.btnReturn);
            this.panelBawahReturn.Controls.Add(this.dateTimePickerReturn);
            this.panelBawahReturn.Controls.Add(this.txtBookIssueDate);
            this.panelBawahReturn.Controls.Add(this.txtBookName);
            this.panelBawahReturn.Controls.Add(this.labelBookReturn);
            this.panelBawahReturn.Controls.Add(this.labelIssueDate);
            this.panelBawahReturn.Controls.Add(this.labelBookN);
            this.panelBawahReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBawahReturn.Location = new System.Drawing.Point(369, 300);
            this.panelBawahReturn.Margin = new System.Windows.Forms.Padding(4);
            this.panelBawahReturn.Name = "panelBawahReturn";
            this.panelBawahReturn.Size = new System.Drawing.Size(957, 174);
            this.panelBawahReturn.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(669, 114);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(669, 70);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 28);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReturn.Location = new System.Drawing.Point(348, 114);
            this.dateTimePickerReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(265, 26);
            this.dateTimePickerReturn.TabIndex = 5;
            // 
            // txtBookIssueDate
            // 
            this.txtBookIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookIssueDate.Location = new System.Drawing.Point(348, 71);
            this.txtBookIssueDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookIssueDate.Name = "txtBookIssueDate";
            this.txtBookIssueDate.Size = new System.Drawing.Size(265, 26);
            this.txtBookIssueDate.TabIndex = 4;
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(348, 27);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(265, 26);
            this.txtBookName.TabIndex = 3;
            // 
            // labelBookReturn
            // 
            this.labelBookReturn.AutoSize = true;
            this.labelBookReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookReturn.Location = new System.Drawing.Point(143, 117);
            this.labelBookReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBookReturn.Name = "labelBookReturn";
            this.labelBookReturn.Size = new System.Drawing.Size(165, 25);
            this.labelBookReturn.TabIndex = 2;
            this.labelBookReturn.Text = "Book Return Date";
            // 
            // labelIssueDate
            // 
            this.labelIssueDate.AutoSize = true;
            this.labelIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssueDate.Location = new System.Drawing.Point(143, 75);
            this.labelIssueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIssueDate.Name = "labelIssueDate";
            this.labelIssueDate.Size = new System.Drawing.Size(155, 25);
            this.labelIssueDate.TabIndex = 1;
            this.labelIssueDate.Text = "Book Issue Date";
            // 
            // labelBookN
            // 
            this.labelBookN.AutoSize = true;
            this.labelBookN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookN.Location = new System.Drawing.Point(143, 32);
            this.labelBookN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBookN.Name = "labelBookN";
            this.labelBookN.Size = new System.Drawing.Size(114, 25);
            this.labelBookN.TabIndex = 0;
            this.labelBookN.Text = "Book Name";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1344, 474);
            this.Controls.Add(this.panelBawahReturn);
            this.Controls.Add(this.dataGridViewReturnBook);
            this.Controls.Add(this.panelEnterInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReturnBook";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.panelEnterInfo.ResumeLayout(false);
            this.panelEnterInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowStud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnBook)).EndInit();
            this.panelBawahReturn.ResumeLayout(false);
            this.panelBawahReturn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEnterInfo;
        private System.Windows.Forms.DataGridView dataGridViewReturnBook;
        private System.Windows.Forms.Panel panelBawahReturn;
        private System.Windows.Forms.PictureBox pictureBoxShowStud;
        private System.Windows.Forms.Label labelEnterEnroll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtBoxEnterEnroll;
        private System.Windows.Forms.Label labelBookReturn;
        private System.Windows.Forms.Label labelIssueDate;
        private System.Windows.Forms.Label labelBookN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        private System.Windows.Forms.TextBox txtBookIssueDate;
        private System.Windows.Forms.TextBox txtBookName;
    }
}

