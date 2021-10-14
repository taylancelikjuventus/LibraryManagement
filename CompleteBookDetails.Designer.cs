namespace LibraryManagementSystem
{
    partial class CompleteBookDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewIssuedBooks = new System.Windows.Forms.DataGridView();
            this.dataGridViewReturnedBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISSUED BOOKS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(323, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "RETURNED BOOKS";
            // 
            // dataGridViewIssuedBooks
            // 
            this.dataGridViewIssuedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIssuedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssuedBooks.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewIssuedBooks.Name = "dataGridViewIssuedBooks";
            this.dataGridViewIssuedBooks.Size = new System.Drawing.Size(776, 203);
            this.dataGridViewIssuedBooks.TabIndex = 2;
            // 
            // dataGridViewReturnedBooks
            // 
            this.dataGridViewReturnedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReturnedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturnedBooks.Location = new System.Drawing.Point(12, 292);
            this.dataGridViewReturnedBooks.Name = "dataGridViewReturnedBooks";
            this.dataGridViewReturnedBooks.Size = new System.Drawing.Size(776, 203);
            this.dataGridViewReturnedBooks.TabIndex = 3;
            // 
            // CompleteBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.dataGridViewReturnedBooks);
            this.Controls.Add(this.dataGridViewIssuedBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompleteBookDetails";
            this.Text = "CompleteBookDetails";
            this.Load += new System.EventHandler(this.CompleteBookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewIssuedBooks;
        private System.Windows.Forms.DataGridView dataGridViewReturnedBooks;
    }
}