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

namespace Library.WinUI.Students
{
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StudentService service = new StudentService())
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtMobilePhone.Text) || string.IsNullOrEmpty(txtStudentNo.Text) || string.IsNullOrEmpty(txtStudentNo.Text))
                {
                    lblmssage.Text = "Lütfen tüm alanları doldurunuz.";
                    lblmssage.ForeColor = Color.Red;
                    return;
                }
                else
                {

                    StudentDTO student = new StudentDTO
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        StudentNumber = txtStudentNo.Text,
                        MobilePhone = txtMobilePhone.Text,
                        EmailAdress = txtEmail.Text,


                    };

                    var result = service.Save(student);

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
    }
}
