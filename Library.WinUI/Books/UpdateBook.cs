using Library.Data;
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
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {
            using (DefinitionService service = new DefinitionService())
            {
                cmbRecordStatus.DataSource = service.GetRecordStatuses();
                cmbRecordStatus.DisplayMember = "RecordStatusName";
                cmbRecordStatus.ValueMember = "RecordStatusId";


                cmbGenre.DataSource = service.GetGenres();
                cmbGenre.DisplayMember = "GenreName";
                cmbGenre.ValueMember = "GenreId";

            }

            using (BookService service = new BookService())
            {
                listBox1.DataSource = service.List();
                listBox1.DisplayMember = "BookName";
                listBox1.ValueMember = "BookId";
            }

          

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var selectedBook = listBox1.SelectedItem as BookDTO;

            lblMessage.Visible = false;
            using (BookService service = new BookService())
            {
                var book = service.Get(selectedBook.BookId);

                txtBookName.Text = book.BookName;
                txtAuthor.Text = book.Author;
                numUnitsInStock.Value = book.UnitsInStock;
                cmbGenre.SelectedValue = book.GenreId;
                cmbRecordStatus.SelectedValue = book.RecordStatusId;
                dateTimePicker1.Value = book.PublishDate;
                lblCratedDate.Text = book.CreatedDate.ToShortDateString();
            }
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (BookService service = new BookService())
                {
                    BookDTO book = new BookDTO
                    {
                        BookId = Convert.ToInt32(listBox1.SelectedValue),
                        BookName =txtBookName.Text,
                        GenreId =Convert.ToByte(cmbGenre.SelectedValue),
                        Author = txtAuthor.Text,
                        PublishDate =dateTimePicker1.Value,
                        UnitsInStock = Convert.ToInt32(numUnitsInStock.Value),
                        CreatedDate = Convert.ToDateTime(lblCratedDate.Text),
                        RecordStatusId = Convert.ToByte(cmbRecordStatus.SelectedValue)


                    };

                    var result =service.Update(book);

                    lblMessage.Visible = true;
                    if (result)
                    {
                        lblMessage.Text = "Güncelleme başarılı";
                        lblMessage.ForeColor = Color.Green;
                    }
                    else
                    {
                        // MessageBox.Show("Güncelleme sırasında bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblMessage.Text = "Güncelleme sıtasında hata oluştu.";
                        lblMessage.ForeColor = Color.Red;
                    }

                }


            }
        }
    }
}
