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
    public partial class NewBorrow : Form
    {
        public NewBorrow()
        {
            InitializeComponent();
        }

        private void NewBorrow_Load(object sender, EventArgs e)
        {
            using (StudentService service = new StudentService())
            {
                cmbStudentName.DataSource = service.List();
                cmbStudentName.DisplayMember = "FullName";
                cmbStudentName.ValueMember = "StudentId";
            }

            using (DefinitionService service = new DefinitionService())
            {
                cmbGenres.DataSource = service.GetGenres();
                cmbGenres.DisplayMember = "GenreName";
                cmbGenres.ValueMember = "GenreId";
            }

            using (BookService service = new BookService())
            {
                var id = (cmbGenres.SelectedItem as GenreDTO).GenreId;
                lstBooks.DataSource = service.ListByGenre(id);
                lstBooks.DisplayMember = "Display";
                lstBooks.ValueMember = "BookId";
            }
        }
        List<BorrowDTO> list = new List<BorrowDTO>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedBook = lstBooks.SelectedItem as BookDTO;

            if (list.Count >0)
            {
                if (list.Any(x=>x.BookId ==selectedBook.BookId))
                {
                    MessageBox.Show("Bu kitabı zaten seçtiniz.");
                    return;
                }

                #region listenin içine forecah ile girip if ile de sorgulayabilirdik.
                //foreach (var item in list)
                //{
                //    if (item.BookId ==selectedBook.BookId)
                //    {
                //        MessageBox.Show("Bu kitabı zaten seçtiniz.");
                //    }
                //}

                #endregion
            }

            BorrowDTO borrowDTO = new BorrowDTO
            {
                StudentId = Convert.ToInt32(cmbStudentName.SelectedValue),
                BookId= selectedBook.BookId,
                BookName=selectedBook.BookName

            };
            list.Add(borrowDTO);

            lstSelectedBooks.DataSource = null;
            lstSelectedBooks.DataSource = list ;
            lstSelectedBooks.DisplayMember = "BookName";
            lstSelectedBooks.ValueMember = "BookId";


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedBook = lstSelectedBooks.SelectedItem as BorrowDTO;

            if (list.Count ==0)
            {
                MessageBox.Show("Önce sepete bir kitap atmalısınız.");
                return;
            }


            list.Remove(selectedBook) ;

            lstSelectedBooks.DataSource = null;
            lstSelectedBooks.DataSource = list;
            lstSelectedBooks.DisplayMember = "BookName";
            lstSelectedBooks.ValueMember = "BookId";


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (list.Count ==0)
            {
                MessageBox.Show("Hiç Kitap eklmediniz. ");
                return;
            }

            using (BorrowService service = new BorrowService())
            {
                var result = service.Borrow(list);

                if (result)
                {
                    lblMessage.Text = "Kayıt başarılı";
                    lblMessage.ForeColor = Color.Green;
                }
                else
                {
                    // MessageBox.Show("Güncelleme sırasında bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblMessage.Text = "Kayıt sıtasında hata oluştu.";
                    lblMessage.ForeColor = Color.Red;
                }

            }
        }

        private void cmbGenres_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (BookService service = new BookService())
            {
                var id = (cmbGenres.SelectedItem as GenreDTO).GenreId;
                lstBooks.DataSource = service.ListByGenre(id);
                lstBooks.DisplayMember = "Display";
                lstBooks.ValueMember = "BookId";
            }
        }
    }
}
