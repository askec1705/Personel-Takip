using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
namespace WFAPersonelTakibi
{
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        Personel personel;

        public Form3(Personel personel) : this()
        {
            this.personel = personel;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = personel.FirstName;
            lblLastName.Text = personel.LastName;
            lblPhone.Text = personel.Phone;
            lblAddress.Text = personel.Address;
            lblBirthDate.Text = personel.BirthDate.ToString();
            lblMail.Text = personel.Mail;
            lblDepartment.Text = personel.Department.ToString();
            lblGender.Text = personel.Gender.ToString();
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
