namespace Library.WinUI.Borrows
{
    partial class BorrowedBooks
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lstBorrowedBooks = new System.Windows.Forms.ListBox();
            this.lstBorrows = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.lblGecikme = new System.Windows.Forms.Label();
            this.lblEndate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(713, 582);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 89;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReturn.Location = new System.Drawing.Point(253, 641);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(135, 39);
            this.btnReturn.TabIndex = 88;
            this.btnReturn.Text = "Teslim Al";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(924, 623);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 39);
            this.btnAdd.TabIndex = 84;
            this.btnAdd.Text = ">>>";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Crimson;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Location = new System.Drawing.Point(738, 623);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 39);
            this.btnRemove.TabIndex = 85;
            this.btnRemove.Text = "<<<";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(410, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 81;
            this.label8.Text = "Verilen Kitaplar";
            // 
            // lstBorrowedBooks
            // 
            this.lstBorrowedBooks.FormattingEnabled = true;
            this.lstBorrowedBooks.ItemHeight = 20;
            this.lstBorrowedBooks.Location = new System.Drawing.Point(383, 159);
            this.lstBorrowedBooks.Name = "lstBorrowedBooks";
            this.lstBorrowedBooks.Size = new System.Drawing.Size(277, 424);
            this.lstBorrowedBooks.TabIndex = 79;
            // 
            // lstBorrows
            // 
            this.lstBorrows.FormattingEnabled = true;
            this.lstBorrows.ItemHeight = 20;
            this.lstBorrows.Location = new System.Drawing.Point(52, 159);
            this.lstBorrows.Name = "lstBorrows";
            this.lstBorrows.Size = new System.Drawing.Size(303, 444);
            this.lstBorrows.TabIndex = 80;
            this.lstBorrows.SelectedIndexChanged += new System.EventHandler(this.lstBorrows_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1190, 51);
            this.label1.TabIndex = 78;
            this.label1.Text = "Kitap Ödünç";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 90;
            this.label4.Text = "Öğrencilistesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(729, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 91;
            this.label2.Text = "bitiş Tarihi:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(733, 256);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(89, 25);
            this.lbl.TabIndex = 92;
            this.lbl.Text = "Gecikme";
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPenalty.Location = new System.Drawing.Point(729, 328);
            this.lblPenalty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(155, 25);
            this.lblPenalty.TabIndex = 93;
            this.lblPenalty.Text = "Gecikme Cezası";
            // 
            // lblGecikme
            // 
            this.lblGecikme.AutoSize = true;
            this.lblGecikme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecikme.Location = new System.Drawing.Point(869, 274);
            this.lblGecikme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGecikme.Name = "lblGecikme";
            this.lblGecikme.Size = new System.Drawing.Size(0, 25);
            this.lblGecikme.TabIndex = 94;
            // 
            // lblEndate
            // 
            this.lblEndate.AutoSize = true;
            this.lblEndate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEndate.Location = new System.Drawing.Point(852, 186);
            this.lblEndate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndate.Name = "lblEndate";
            this.lblEndate.Size = new System.Drawing.Size(89, 25);
            this.lblEndate.TabIndex = 95;
            this.lblEndate.Text = "Gecikme";
            // 
            // BorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 710);
            this.Controls.Add(this.lblEndate);
            this.Controls.Add(this.lblGecikme);
            this.Controls.Add(this.lblPenalty);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstBorrowedBooks);
            this.Controls.Add(this.lstBorrows);
            this.Controls.Add(this.label1);
            this.Name = "BorrowedBooks";
            this.Text = "BorrowedBooks";
            this.Load += new System.EventHandler(this.BorrowedBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstBorrowedBooks;
        private System.Windows.Forms.ListBox lstBorrows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Label lblGecikme;
        private System.Windows.Forms.Label lblEndate;
    }
}