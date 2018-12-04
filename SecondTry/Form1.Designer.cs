namespace SecondTry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coluserid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsuffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colviolation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcomplainant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.e_userid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.e_fname = new System.Windows.Forms.TextBox();
            this.e_mname = new System.Windows.Forms.TextBox();
            this.e_lname = new System.Windows.Forms.TextBox();
            this.e_oname = new System.Windows.Forms.TextBox();
            this.e_violation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.e_complainant = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtPageCount = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.e_bday = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(452, 632);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(259, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluserid,
            this.colfname,
            this.colmname,
            this.collname,
            this.colsuffix,
            this.colbday,
            this.colviolation,
            this.colcomplainant});
            this.dataGridView1.Location = new System.Drawing.Point(453, 146);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 467);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // coluserid
            // 
            this.coluserid.DataPropertyName = "userid";
            this.coluserid.HeaderText = "ID";
            this.coluserid.Name = "coluserid";
            this.coluserid.ReadOnly = true;
            this.coluserid.Width = 50;
            // 
            // colfname
            // 
            this.colfname.DataPropertyName = "firstname";
            this.colfname.HeaderText = "First Name";
            this.colfname.Name = "colfname";
            this.colfname.ReadOnly = true;
            // 
            // colmname
            // 
            this.colmname.DataPropertyName = "middlename";
            this.colmname.HeaderText = "Middle Name";
            this.colmname.Name = "colmname";
            this.colmname.ReadOnly = true;
            // 
            // collname
            // 
            this.collname.DataPropertyName = "lastname";
            this.collname.HeaderText = "Last Name";
            this.collname.Name = "collname";
            this.collname.ReadOnly = true;
            // 
            // colsuffix
            // 
            this.colsuffix.DataPropertyName = "othername";
            this.colsuffix.HeaderText = "Suffix";
            this.colsuffix.Name = "colsuffix";
            this.colsuffix.ReadOnly = true;
            this.colsuffix.Width = 50;
            // 
            // colbday
            // 
            this.colbday.DataPropertyName = "bdate";
            this.colbday.HeaderText = "Birthdate";
            this.colbday.Name = "colbday";
            this.colbday.ReadOnly = true;
            // 
            // colviolation
            // 
            this.colviolation.DataPropertyName = "violation";
            this.colviolation.HeaderText = "Violation";
            this.colviolation.Name = "colviolation";
            this.colviolation.ReadOnly = true;
            // 
            // colcomplainant
            // 
            this.colcomplainant.DataPropertyName = "cmplainant";
            this.colcomplainant.HeaderText = "Complainant";
            this.colcomplainant.Name = "colcomplainant";
            this.colcomplainant.ReadOnly = true;
            this.colcomplainant.Width = 120;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(108, 560);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 41);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "List of Watchlisted";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // e_userid
            // 
            this.e_userid.Enabled = false;
            this.e_userid.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_userid.Location = new System.Drawing.Point(189, 256);
            this.e_userid.Name = "e_userid";
            this.e_userid.Size = new System.Drawing.Size(219, 27);
            this.e_userid.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name *";
            // 
            // e_fname
            // 
            this.e_fname.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_fname.Location = new System.Drawing.Point(189, 290);
            this.e_fname.Name = "e_fname";
            this.e_fname.Size = new System.Drawing.Size(219, 27);
            this.e_fname.TabIndex = 9;
            // 
            // e_mname
            // 
            this.e_mname.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_mname.Location = new System.Drawing.Point(189, 326);
            this.e_mname.Name = "e_mname";
            this.e_mname.Size = new System.Drawing.Size(219, 27);
            this.e_mname.TabIndex = 10;
            // 
            // e_lname
            // 
            this.e_lname.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_lname.Location = new System.Drawing.Point(189, 364);
            this.e_lname.Name = "e_lname";
            this.e_lname.Size = new System.Drawing.Size(219, 27);
            this.e_lname.TabIndex = 11;
            // 
            // e_oname
            // 
            this.e_oname.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_oname.Location = new System.Drawing.Point(189, 400);
            this.e_oname.Name = "e_oname";
            this.e_oname.Size = new System.Drawing.Size(219, 27);
            this.e_oname.TabIndex = 12;
            // 
            // e_violation
            // 
            this.e_violation.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_violation.Location = new System.Drawing.Point(189, 476);
            this.e_violation.Name = "e_violation";
            this.e_violation.Size = new System.Drawing.Size(219, 27);
            this.e_violation.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Middle Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Last Name *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Suffix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Birthday *";
            // 
            // e_complainant
            // 
            this.e_complainant.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_complainant.Location = new System.Drawing.Point(189, 511);
            this.e_complainant.Name = "e_complainant";
            this.e_complainant.Size = new System.Drawing.Size(219, 27);
            this.e_complainant.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Violation *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Complainant *";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(941, 632);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(63, 41);
            this.btnPrev.TabIndex = 22;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1010, 632);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 41);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPageCount
            // 
            this.txtPageCount.AutoSize = true;
            this.txtPageCount.Location = new System.Drawing.Point(1089, 646);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(126, 13);
            this.txtPageCount.TabIndex = 24;
            this.txtPageCount.Text = "Showing x out of x pages";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(800, 632);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(64, 41);
            this.btnFirst.TabIndex = 25;
            this.btnFirst.Text = "First Page";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(870, 632);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(65, 41);
            this.btnLast.TabIndex = 26;
            this.btnLast.Text = "Last Page";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(998, 105);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 23);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDown);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            this.txtSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseUp);
            // 
            // e_bday
            // 
            this.e_bday.CustomFormat = "yyyy-MM-dd";
            this.e_bday.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_bday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.e_bday.Location = new System.Drawing.Point(189, 438);
            this.e_bday.Name = "e_bday";
            this.e_bday.Size = new System.Drawing.Size(219, 27);
            this.e_bday.TabIndex = 28;
            this.e_bday.Value = new System.DateTime(2018, 11, 27, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(937, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 142);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Coral;
            this.label11.Location = new System.Drawing.Point(63, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 14);
            this.label11.TabIndex = 33;
            this.label11.Text = "Note: Fields with (*) are required.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1245, 723);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.e_bday);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtPageCount);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.e_complainant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.e_violation);
            this.Controls.Add(this.e_oname);
            this.Controls.Add(this.e_lname);
            this.Controls.Add(this.e_mname);
            this.Controls.Add(this.e_fname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.e_userid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MARINA SID WATCH LIST";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox e_userid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox e_fname;
        private System.Windows.Forms.TextBox e_mname;
        private System.Windows.Forms.TextBox e_lname;
        private System.Windows.Forms.TextBox e_oname;
        private System.Windows.Forms.TextBox e_violation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox e_complainant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label txtPageCount;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker e_bday;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluserid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmname;
        private System.Windows.Forms.DataGridViewTextBoxColumn collname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsuffix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colviolation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcomplainant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
    }
}

