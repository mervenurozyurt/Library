using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void öğrenciKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Students.NewStudent newForm = new Students.NewStudent();
            newForm.MdiParent = this;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }

        private void öğrenciDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students.UpdateStudent newForm = new Students.UpdateStudent();
            newForm.MdiParent = this;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }

        private void kitapKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books.NewBook newForm = new Books.NewBook();
            newForm.MdiParent = this;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }

        private void kitapDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books.UpdateBook newForm = new Books.UpdateBook();
            newForm.MdiParent = this;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }

        private void yeniİşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrows.NewBorrow newForm = new Borrows.NewBorrow();
            newForm.MdiParent = this;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }

        private void verilenKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrows.BorrowedBooks newForm = new Borrows.BorrowedBooks();
            newForm.MdiParent = this;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();

        }

        private void kitapRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books.BookReport newForm = new Books.BookReport();
            newForm.MdiParent = this;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }
    }
}
