﻿using System;
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
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }
        Personel personel;

        public Form4(Personel personel) : this()
        {
            this.personel = personel;
        }


        public void Temizle(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is MetroTextBox)
                {
                    item.Text = "";
                }
                else if (item is MetroComboBox)
                {
                    item.Text = default;
                }
                if (item is MetroDateTime)
                {
                    item.Text = "";
                }
            }
        }
        public void Form4_Load(object sender, EventArgs e)
        {
            cmbDepartment.Items.AddRange(Enum.GetNames(typeof(Department)));

            txtFirstName.Text = personel.FirstName;
            txtLastName.Text = personel.LastName;
            txtPhone.Text = personel.Phone;
            txtAddress.Text = personel.Address;
            dtBirthDate.Value = personel.BirthDate;
            txtMail.Text = personel.Mail;
            cmbDepartment.Text = personel.Department.ToString();

            MetroRadioButton rd = (MetroRadioButton)metroPanel1.Controls.Find(("rd" + personel.Gender.ToString()), false)[0];
            rd.Checked = true;
            pcbImageUrl.Image = Image.FromFile(Environment.CurrentDirectory + @"\..\..\img" + personel.ImageUrl);


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            personel.FirstName = txtFirstName.Text;
            personel.LastName = txtLastName.Text;
            personel.Phone = txtPhone.Text;
            personel.Address = txtAddress.Text;
            personel.BirthDate = dtBirthDate.Value;
            personel.Mail = txtMail.Text;

            foreach (Control item in metroPanel1.Controls)
            {
                if (item is MetroRadioButton)//MetroRadioButton'un çalışması için yukarıya "using MetroFramework.Controls" ekle

                {
                    MetroRadioButton rd = (MetroRadioButton)item;
                    if (rd.Checked)
                    {
                        personel.Gender = (Gender)Enum.Parse(typeof(Gender), rd.Text);
                    }
                }
            }

            if (pcbImageUrl.Tag != null)
            {
                personel.ImageUrl = pcbImageUrl.Tag.ToString();
            }

            Temizle(groupBox1);

            MessageBox.Show("İşleminiz başarıyla gerçekleşti.");
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
        }

        private void PcbImageUrl_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                pcbImageUrl.Image = Image.FromFile(ofd.FileName);

                string imageName = $@"{Environment.CurrentDirectory}\..\..\img\{Guid.NewGuid()}{System.IO.Path.GetExtension(ofd.FileName)}";

                pcbImageUrl.Image.Save(imageName);

                bool result = System.IO.File.Exists(imageName);
                if (result)
                {
                    pcbImageUrl.Tag = imageName;
                }
            }
        }
    }
}
