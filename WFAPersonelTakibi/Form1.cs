using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace WFAPersonelTakibi
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDepartment.Items.AddRange(Enum.GetNames(typeof(Department)));
        }

        public static List<Personel> Personeller = new List<Personel>(); //static olarak işaretlediğimiz için projedeki her formdan buna ulaşmak mümkün olur.

        #region Save Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();

            personel.Mail = txtMail.Text;
            personel.Phone = txtPhone.Text;
            personel.Address = txtAddress.Text;
            personel.LastName = txtLastName.Text;
            personel.FirstName = txtFirstName.Text;
            personel.BirthDate = dtBirthDate.Value;

            personel.Department = (Department)Enum.Parse(typeof(Department), cmbDepartment.Text);

            #region Uzun yol
            //if (rdFemale.Checked)
            //{
            //    personel.Gender = Gender.Female;
            //}
            //else if (rdMale.Checked)
            //{
            //    personel.Gender = Gender.Male;
            //}
            //else if (rdRandom.Checked)
            //{
            //    personel.Gender = Gender.Random;
            //}   
            #endregion

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

            Personeller.Add(personel);
        }
        #endregion

        #region IMG Click
        private void PcbImageUrl_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK) //eğer kullanıcı bir img seçip ok tuşuna bastıysa...
            {
                pcbImageUrl.Image = Image.FromFile(ofd.FileName);

                //string imageName = $"{Guid.NewGuid()}{System.IO.Path.GetExtension(ofd.FileName)}"; --bir aşağıdaki kod satırının farklı versiyonu. bir alttaki satırda sonraki adımların yazımını kolaylaştırmış olduk. {Environment.CurrentDirectory}\..\..\img\ kısmını tekrar tekrar yazmamıza gerek kalmadı.
                string imageName = $@"{Environment.CurrentDirectory}\..\..\img\{Guid.NewGuid()}{System.IO.Path.GetExtension(ofd.FileName)}"; //dosyaya isim atama

                //pcbImageUrl.Image.Save($@"{Environment.CurrentDirectory}\..\..\img\{imageName}");
                pcbImageUrl.Image.Save(imageName);
                //seçili resmi kaydettiğiizde hangi dosyaya atayacağını gösteriyor. bunu, direkt dosya uzantısını ekleyerek yapabilirdik ancak program başka bir bilgisayrda çalıştırıldığında aynı noktada aynı dosyaları bulamayacağından hata verecektir. bu sebeple dinamik bir yapı haline getirdik ve proje içerisindek img dosyasının içine attık. environment kısmı programın çalıştığı bilgisayardaki kullanıcı konum vs'yi tanımlar. \..\ komutu bir üst dosya konumuna çıkmamızı sağlar.

                bool result = System.IO.File.Exists(imageName);
                if (result)
                {
                    pcbImageUrl.Tag = imageName;
                }
            }
        }
        #endregion

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
        }

    }
}
