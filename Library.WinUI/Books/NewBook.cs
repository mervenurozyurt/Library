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
    public partial class NewBook : Form
    {
        public NewBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBookName.Text) || string.IsNullOrEmpty(txtAuthor.Text) || numUnitsInStock.Value < 1)
            {
                lblmessage.Text = "Lütfen tüm alanları doldurunuz.";
                lblmessage.ForeColor = Color.Red;
                return;
            }

            using (BookService service = new BookService())
            {
               
                DialogResult dr = MessageBox.Show("Kaydetmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    BookDTO book = new BookDTO
                    {
                        BookName = txtBookName.Text,
                        GenreId = Convert.ToByte(cmbGenre.SelectedValue),
                        Author = txtAuthor.Text,
                        PublishDate = dateTimePicker1.Value,

                        UnitsInStock = Convert.ToInt32(numUnitsInStock.Value)


                    };

                    var result = service.Save(book);



                    if (result != null)
                    {
                        MessageBox.Show("Kayıt başarılı", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Kayıt sırasında bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }


                    }

            }
        }

        private void NewBook_Load(object sender, EventArgs e)
        {
            using (DefinitionService service = new DefinitionService())
            {
                cmbGenre.DataSource = service.GetGenres();
                cmbGenre.DisplayMember = "GenreName";
                cmbGenre.ValueMember = "GenreId";
            }
        }
    }
}
