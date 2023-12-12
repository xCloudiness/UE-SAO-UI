namespace SAO_DESIGN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            CheckDB = new Button();
            IDInputBTN = new Button();
            IDInput = new TextBox();
            StudentPhoto = new PictureBox();
            StudentNumber = new Label();
            StudentName = new Label();
            StudentInfoDataGrid = new DataGridView();
            attendance = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentInfoDataGrid).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(attendance);
            groupBox1.Controls.Add(CheckDB);
            groupBox1.Controls.Add(IDInputBTN);
            groupBox1.Controls.Add(IDInput);
            groupBox1.Controls.Add(StudentPhoto);
            groupBox1.Controls.Add(StudentNumber);
            groupBox1.Controls.Add(StudentName);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(25, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 476);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // CheckDB
            // 
            CheckDB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CheckDB.Location = new Point(146, 440);
            CheckDB.Name = "CheckDB";
            CheckDB.Size = new Size(195, 36);
            CheckDB.TabIndex = 5;
            CheckDB.Text = "Check Connection";
            CheckDB.UseVisualStyleBackColor = true;
            CheckDB.Click += CheckDB_Click;
            // 
            // IDInputBTN
            // 
            IDInputBTN.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            IDInputBTN.Location = new Point(6, 440);
            IDInputBTN.Name = "IDInputBTN";
            IDInputBTN.Size = new Size(140, 36);
            IDInputBTN.TabIndex = 4;
            IDInputBTN.Text = "Violations";
            IDInputBTN.UseVisualStyleBackColor = true;
            IDInputBTN.Click += IDInputBTN_Click;
            // 
            // IDInput
            // 
            IDInput.Location = new Point(62, 395);
            IDInput.Name = "IDInput";
            IDInput.Size = new Size(220, 43);
            IDInput.TabIndex = 3;
            // 
            // StudentPhoto
            // 
            StudentPhoto.BackColor = Color.Black;
            StudentPhoto.BackgroundImage = Properties.Resources.student1;
            StudentPhoto.BorderStyle = BorderStyle.Fixed3D;
            StudentPhoto.Cursor = Cursors.Hand;
            StudentPhoto.Image = Properties.Resources.student1;
            StudentPhoto.Location = new Point(56, 51);
            StudentPhoto.Name = "StudentPhoto";
            StudentPhoto.Size = new Size(325, 254);
            StudentPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            StudentPhoto.TabIndex = 0;
            StudentPhoto.TabStop = false;
            StudentPhoto.Click += student1_Click;
            // 
            // StudentNumber
            // 
            StudentNumber.AutoSize = true;
            StudentNumber.ForeColor = SystemColors.ButtonHighlight;
            StudentNumber.Location = new Point(56, 346);
            StudentNumber.Name = "StudentNumber";
            StudentNumber.Size = new Size(191, 38);
            StudentNumber.TabIndex = 2;
            StudentNumber.Text = "Student No. :";
            // 
            // StudentName
            // 
            StudentName.AutoSize = true;
            StudentName.ForeColor = Color.WhiteSmoke;
            StudentName.Location = new Point(56, 308);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(111, 38);
            StudentName.TabIndex = 1;
            StudentName.Text = "Name :";
            StudentName.Click += label1_Click;
            // 
            // StudentInfoDataGrid
            // 
            StudentInfoDataGrid.AllowUserToAddRows = false;
            StudentInfoDataGrid.AllowUserToDeleteRows = false;
            StudentInfoDataGrid.AllowUserToResizeColumns = false;
            StudentInfoDataGrid.AllowUserToResizeRows = false;
            StudentInfoDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentInfoDataGrid.Location = new Point(519, 41);
            StudentInfoDataGrid.Name = "StudentInfoDataGrid";
            StudentInfoDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            StudentInfoDataGrid.Size = new Size(484, 461);
            StudentInfoDataGrid.TabIndex = 1;
            StudentInfoDataGrid.CellContentClick += StudentInfoDataGrid_CellContentClick;
            // 
            // attendance
            // 
            attendance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            attendance.Location = new Point(341, 440);
            attendance.Name = "attendance";
            attendance.Size = new Size(118, 35);
            attendance.TabIndex = 6;
            attendance.Text = "Attendance";
            attendance.UseVisualStyleBackColor = true;
            attendance.Click += attendance_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1015, 529);
            Controls.Add(StudentInfoDataGrid);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentInfoDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label StudentName;
        private Label StudentNumber;
        private Button IDInputBTN;
        private TextBox IDInput;
        private DataGridView StudentInfoDataGrid;
        private Button CheckDB;
        private PictureBox StudentPhoto;
        private Button attendance;
    }
}
