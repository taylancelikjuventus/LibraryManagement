namespace LibraryManagementSystem
{
    partial class ViewStudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentInformation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchEnrollNo = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditStudentPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditContact = new System.Windows.Forms.TextBox();
            this.txtEditSemester = new System.Windows.Forms.TextBox();
            this.txtEditDepart = new System.Windows.Forms.TextBox();
            this.txtEditEnrollNo = new System.Windows.Forms.TextBox();
            this.txtEditSname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.EditStudentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 103);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enrollment No :";
            // 
            // txtSearchEnrollNo
            // 
            this.txtSearchEnrollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEnrollNo.Location = new System.Drawing.Point(368, 140);
            this.txtSearchEnrollNo.Name = "txtSearchEnrollNo";
            this.txtSearchEnrollNo.Size = new System.Drawing.Size(215, 26);
            this.txtSearchEnrollNo.TabIndex = 2;
            this.txtSearchEnrollNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Tomato;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(604, 138);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(996, 259);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // EditStudentPanel
            // 
            this.EditStudentPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.EditStudentPanel.Controls.Add(this.label9);
            this.EditStudentPanel.Controls.Add(this.txtEditEmail);
            this.EditStudentPanel.Controls.Add(this.txtEditContact);
            this.EditStudentPanel.Controls.Add(this.txtEditSemester);
            this.EditStudentPanel.Controls.Add(this.txtEditDepart);
            this.EditStudentPanel.Controls.Add(this.txtEditEnrollNo);
            this.EditStudentPanel.Controls.Add(this.txtEditSname);
            this.EditStudentPanel.Controls.Add(this.label8);
            this.EditStudentPanel.Controls.Add(this.label7);
            this.EditStudentPanel.Controls.Add(this.label6);
            this.EditStudentPanel.Controls.Add(this.label5);
            this.EditStudentPanel.Controls.Add(this.label4);
            this.EditStudentPanel.Controls.Add(this.label3);
            this.EditStudentPanel.Controls.Add(this.button4);
            this.EditStudentPanel.Controls.Add(this.button3);
            this.EditStudentPanel.Controls.Add(this.button2);
            this.EditStudentPanel.Location = new System.Drawing.Point(13, 466);
            this.EditStudentPanel.Name = "EditStudentPanel";
            this.EditStudentPanel.Size = new System.Drawing.Size(995, 247);
            this.EditStudentPanel.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Edit Student";
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEmail.Location = new System.Drawing.Point(658, 133);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(253, 26);
            this.txtEditEmail.TabIndex = 14;
            // 
            // txtEditContact
            // 
            this.txtEditContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditContact.Location = new System.Drawing.Point(658, 105);
            this.txtEditContact.Name = "txtEditContact";
            this.txtEditContact.Size = new System.Drawing.Size(253, 26);
            this.txtEditContact.TabIndex = 13;
            // 
            // txtEditSemester
            // 
            this.txtEditSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSemester.Location = new System.Drawing.Point(658, 76);
            this.txtEditSemester.Name = "txtEditSemester";
            this.txtEditSemester.Size = new System.Drawing.Size(253, 26);
            this.txtEditSemester.TabIndex = 12;
            // 
            // txtEditDepart
            // 
            this.txtEditDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditDepart.Location = new System.Drawing.Point(212, 140);
            this.txtEditDepart.Name = "txtEditDepart";
            this.txtEditDepart.Size = new System.Drawing.Size(241, 26);
            this.txtEditDepart.TabIndex = 11;
            // 
            // txtEditEnrollNo
            // 
            this.txtEditEnrollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEnrollNo.Location = new System.Drawing.Point(212, 108);
            this.txtEditEnrollNo.Name = "txtEditEnrollNo";
            this.txtEditEnrollNo.Size = new System.Drawing.Size(241, 26);
            this.txtEditEnrollNo.TabIndex = 10;
            // 
            // txtEditSname
            // 
            this.txtEditSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSname.Location = new System.Drawing.Point(212, 76);
            this.txtEditSname.Name = "txtEditSname";
            this.txtEditSname.Size = new System.Drawing.Size(241, 26);
            this.txtEditSname.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Contact(Tel) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Semester :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enrollment No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Name :";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tomato;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(830, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 32);
            this.button4.TabIndex = 2;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(749, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 1;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(658, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(382, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Search By Enrollment Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(249, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(526, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Note:Click on any cell on the table in order to see Edit Panel at the bottom of  " +
    "this window\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Information";
            // 
            // ViewStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1033, 483);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EditStudentPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearchEnrollNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewStudentInformation";
            this.Text = "ViewStudentInformation";
            this.Load += new System.EventHandler(this.ViewStudentInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.EditStudentPanel.ResumeLayout(false);
            this.EditStudentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchEnrollNo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel EditStudentPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditContact;
        private System.Windows.Forms.TextBox txtEditSemester;
        private System.Windows.Forms.TextBox txtEditDepart;
        private System.Windows.Forms.TextBox txtEditEnrollNo;
        private System.Windows.Forms.TextBox txtEditSname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
    }
}