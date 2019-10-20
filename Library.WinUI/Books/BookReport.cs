using Library.DTO;
using Library.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WinUI.Books
{
    public partial class BookReport : Form
    {
        public BookReport()
        {
            InitializeComponent();
        }

        private void BookReport_Load(object sender, EventArgs e)
        {
            using (BookService service = new BookService())
            {
                lstBooks.DataSource = service.List();
                lstBooks.DisplayMember = "BookName";
                lstBooks.ValueMember = "BookId";
            }

            using (BorrowService service = new BorrowService())
            {

                lstPenalties.DataSource = service.GetPEnaltyStudents();
                lstPenalties.DisplayMember = "FullName";
                lstPenalties.ValueMember = "StudentId";
            }
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (BorrowService service = new BorrowService())
            {
                if (lstBooks.SelectedItem ==null)
                {
                    return;
                }

                int bookId = (lstBooks.SelectedItem as BookDTO).BookId;

                lblAlınmaAdedi.Text = service.GetNumberOfBorrows(bookId) +" Adet";

            }

        }
    }
}
