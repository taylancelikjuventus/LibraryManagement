namespace LibraryManagementSystem
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBookName = new System.Windows.Forms.TextBox();
            this.btnSearchRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditDelete = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.dateTimePickerOfEditPAnel = new System.Windows.Forms.DateTimePicker();
            this.txtEditQuantity = new System.Windows.Forms.TextBox();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.txtEditBPublication = new System.Windows.Forms.TextBox();
            this.txtEditBAutName = new System.Windows.Forms.TextBox();
            this.txtEditBname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "View Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name :";
            // 
            // txtSearchBookName
            // 
            this.txtSearchBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBookName.Location = new System.Drawing.Point(363, 132);
            this.txtSearchBookName.Name = "txtSearchBookName";
            this.txtSearchBookName.Size = new System.Drawing.Size(242, 26);
            this.txtSearchBookName.TabIndex = 2;
            this.txtSearchBookName.TextChanged += new System.EventHandler(this.txtSearchBookName_TextChanged);
            // 
            // btnSearchRefresh
            // 
            this.btnSearchRefresh.BackColor = System.Drawing.Color.Tomato;
            this.btnSearchRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRefresh.Location = new System.Drawing.Point(631, 131);
            this.btnSearchRefresh.Name = "btnSearchRefresh";
            this.btnSearchRefresh.Size = new System.Drawing.Size(75, 27);
            this.btnSearchRefresh.TabIndex = 3;
            this.btnSearchRefresh.Text = "Refresh";
            this.btnSearchRefresh.UseVisualStyleBackColor = false;
            this.btnSearchRefresh.Click += new System.EventHandler(this.btnSearchRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(985, 252);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.panelEdit.Controls.Add(this.btnEditCancel);
            this.panelEdit.Controls.Add(this.btnEditDelete);
            this.panelEdit.Controls.Add(this.btnEditUpdate);
            this.panelEdit.Controls.Add(this.dateTimePickerOfEditPAnel);
            this.panelEdit.Controls.Add(this.txtEditQuantity);
            this.panelEdit.Controls.Add(this.txtEditPrice);
            this.panelEdit.Controls.Add(this.txtEditBPublication);
            this.panelEdit.Controls.Add(this.txtEditBAutName);
            this.panelEdit.Controls.Add(this.txtEditBname);
            this.panelEdit.Controls.Add(this.label9);
            this.panelEdit.Controls.Add(this.label8);
            this.panelEdit.Controls.Add(this.label7);
            this.panelEdit.Controls.Add(this.label6);
            this.panelEdit.Controls.Add(this.label5);
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(this.label3);
            this.panelEdit.Location = new System.Drawing.Point(13, 448);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(984, 262);
            this.panelEdit.TabIndex = 5;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.Location = new System.Drawing.Point(873, 210);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(75, 34);
            this.btnEditCancel.TabIndex = 15;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditDelete
            // 
            this.btnEditDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnEditDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDelete.Location = new System.Drawing.Point(782, 210);
            this.btnEditDelete.Name = "btnEditDelete";
            this.btnEditDelete.Size = new System.Drawing.Size(75, 34);
            this.btnEditDelete.TabIndex = 14;
            this.btnEditDelete.Text = "Delete";
            this.btnEditDelete.UseVisualStyleBackColor = false;
            this.btnEditDelete.Click += new System.EventHandler(this.btnEditDelete_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.BackColor = System.Drawing.Color.Tomato;
            this.btnEditUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUpdate.Location = new System.Drawing.Point(679, 210);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(87, 34);
            this.btnEditUpdate.TabIndex = 13;
            this.btnEditUpdate.Text = "Update";
            this.btnEditUpdate.UseVisualStyleBackColor = false;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // dateTimePickerOfEditPAnel
            // 
            this.dateTimePickerOfEditPAnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOfEditPAnel.Location = new System.Drawing.Point(679, 59);
            this.dateTimePickerOfEditPAnel.Name = "dateTimePickerOfEditPAnel";
            this.dateTimePickerOfEditPAnel.Size = new System.Drawing.Size(269, 26);
            this.dateTimePickerOfEditPAnel.TabIndex = 12;
            // 
            // txtEditQuantity
            // 
            this.txtEditQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditQuantity.Location = new System.Drawing.Point(679, 139);
            this.txtEditQuantity.Name = "txtEditQuantity";
            this.txtEditQuantity.Size = new System.Drawing.Size(269, 26);
            this.txtEditQuantity.TabIndex = 11;
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPrice.Location = new System.Drawing.Point(679, 99);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(269, 26);
            this.txtEditPrice.TabIndex = 10;
            // 
            // txtEditBPublication
            // 
            this.txtEditBPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditBPublication.Location = new System.Drawing.Point(200, 142);
            this.txtEditBPublication.Name = "txtEditBPublication";
            this.txtEditBPublication.Size = new System.Drawing.Size(269, 26);
            this.txtEditBPublication.TabIndex = 9;
            // 
            // txtEditBAutName
            // 
            this.txtEditBAutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditBAutName.Location = new System.Drawing.Point(200, 99);
            this.txtEditBAutName.Name = "txtEditBAutName";
            this.txtEditBAutName.Size = new System.Drawing.Size(269, 26);
            this.txtEditBAutName.TabIndex = 8;
            // 
            // txtEditBname
            // 
            this.txtEditBname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditBname.Location = new System.Drawing.Point(200, 59);
            this.txtEditBname.Name = "txtEditBname";
            this.txtEditBname.Size = new System.Drawing.Size(269, 26);
            this.txtEditBname.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Edit Selected Book";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(498, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Book Quantity :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Book Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(498, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Book Publication Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Book Publication :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Author Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(259, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(526, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Note:Click on any cell on the table in order to see Edit Panel at the bottom of  " +
    "this window\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(399, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Search By Book Name";
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1020, 441);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchRefresh);
            this.Controls.Add(this.txtSearchBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewBook";
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBookName;
        private System.Windows.Forms.Button btnSearchRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerOfEditPAnel;
        private System.Windows.Forms.TextBox txtEditQuantity;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.TextBox txtEditBPublication;
        private System.Windows.Forms.TextBox txtEditBAutName;
        private System.Windows.Forms.TextBox txtEditBname;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditDelete;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
    }
}