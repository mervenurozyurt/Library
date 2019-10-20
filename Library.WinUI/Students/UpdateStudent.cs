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

namespace Library.WinUI.Students
{
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            using (DefinitionService service = new DefinitionService())
            {
                cmbRecordStatus.DataSource = service.GetRecordStatuses();
                cmbRecordStatus.DisplayMember = "RecordStatusName";
                cmbRecordStatus.ValueMember = "RecordStatusId";
            }


            using (StudentService service = new StudentService())
            {
                listBox1.DataSource = service.List();
                listBox1.DisplayMember = "FullName";
                listBox1.ValueMember = "StudentId";
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var selectedStudent = listBox1.SelectedItem as StudentDTO;

            using (StudentService service = new StudentService())
            {
                var student = service.Get(selectedStudent.StudentId);

                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtMobilePhone.Text = student.MobilePhone;
                txtStudentNo.Text = student.StudentNumber;
                txtEmail.Text = student.EmailAdress;
                cmbRecordStatus.SelectedValue = student.RecordStatusId;
                lblCratedDate.Text = student.CreatedDate.ToString("dd/mm/yyy");


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (StudentService service = new StudentService())
            {
                DialogResult dr = MessageBox.Show("Güncellemek istediğinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    StudentDTO student = new StudentDTO
                    {
                        StudentId = Convert.ToInt32(listBox1.SelectedValue),
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        StudentNumber = txtStudentNo.Text,
                        MobilePhone = txtMobilePhone.Text,
                        EmailAdress = txtEmail.Text,
                        CreatedDate = Convert.ToDateTime(lblCratedDate.Text),
                        RecordStatusId = Convert.ToByte(cmbRecordStatus.SelectedValue)

                    };

                    var result = service.Update(student);

                    if (result)
                    {
                        MessageBox.Show("Güncelleme başarılı", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Güncelleme sırasında bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }
    }
}
