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

namespace Library.WinUI.Borrows
{
    public partial class BorrowedBooks : Form
    {
        public BorrowedBooks()
        {
            InitializeComponent();
        }

        private void BorrowedBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            using (BorrowService service = new BorrowService())
            {

                lstBorrows.DataSource = service.ListBorrows();
                lstBorrows.DisplayMember = "Display";
                lstBorrows.ValueMember = "StudentId";

            }
        }

        private void lstBorrows_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (BorrowService service = new BorrowService())
            {
                int studentId = (lstBorrows.SelectedItem as BorrowDTO).StudentId;

                lstBorrowedBooks.DataSource = service.ListBorrowedBooks(studentId);
                lstBorrowedBooks.DisplayMember = "BookName";
                lstBorrowedBooks.ValueMember = "BookId";


                var borrowInfo = service.GetBorrowDetails(studentId);
                lblEndate.Text = borrowInfo.EndDate.ToShortDateString();
                lblGecikme.Text = borrowInfo.LateDays + " Gün";
                lblPenalty.Text = borrowInfo.TotalAmount.ToString();

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lstBorrows.SelectedItem ==null)
            {
                MessageBox.Show("Kayıt seç");

            }
            int studentId = (lstBorrows.SelectedItem as BorrowDTO).StudentId;
            using (BorrowService service = new BorrowService())
            {
                var result = service.Return(studentId,Convert.ToDecimal(lblPenalty.Text));

                if (result)
                {
                    LoadBooks();
                    MessageBox.Show("Başarılı");
                }
                else
                {
                    MessageBox.Show("Başarısız.");
                }
            }
        }
    }
}
