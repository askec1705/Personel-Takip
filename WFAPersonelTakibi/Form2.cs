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
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Liste()
        {
            dgvEmployees.DataSource = Form1.Personeller.Select(pb => new
            {
                pb.Id,
                pb.FirstName,
                pb.LastName,
                pb.Phone
            }).ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form1 frm1 = new Form1();
            //dgvEmployees.DataSource = frm1.Personeller.ToList(); --  böyle yaparsak hata vermez ama önceki dormdan aldıklarını siler.

            dgvEmployees.DataSource = Form1.Personeller
                .Select(x => new { ID = x.Id, Adi = x.FirstName, Soyadi = x.LastName, Telefon = x.Phone})//buu yapmadan önce ekrana tüm datalar sıralanarak geliyordu. bunu yaptıktan sonra ise yalnızca bu başlıkların altındaki veriler sıralanmış oldu. aynı sqldeki gibi
                .ToList();//bu durumda şu komutu yazmasak da olur ama bazı durumlarda gerekli

            //anonim tipler -- içeriğinin ne tür tipte olduğunun belli olmadığı yapılar. Yularıdaki x böyle. anlık olarak çözüm üretecek tipler. nesne.
            Liste();
        }

        private void TsmSil_Click(object sender, EventArgs e)
        {
            //Guid id = (Guid)dgvEmployees.SelectedRows[0].Cells[0].Value; //tekli seçim yaptığımız için seçili satır indeksine (selectedrows) 0 yazabildik. Bu satırda ID yakalama işlemini gerçekleştirdik.
            ////var personeller = Form1.Personeller.Where(x => x.Id == id);// burası ise liste teslim eder
            //var personel = Form1.Personeller.FirstOrDefault(x => x.Id == id);//bu tek bir kaydı verir
            //Form1.Personeller.Remove(personel);

            if (dgvEmployees.SelectedRows.Count > 0)
            {
                Guid guid = (Guid)dgvEmployees.SelectedRows[0].Cells[0].Value;
                Form1.Personeller.RemoveAll(x => x.Id == guid);
                Liste();
            }
        }

        private void TsmDuzenle_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)dgvEmployees.SelectedRows[0].Cells[0].Value;
            Personel personel = Form1.Personeller.FirstOrDefault(x => x.Id == Id);
            Form4 frm4 = new Form4(personel);
            this.Hide();
            frm4.ShowDialog();
        }


        private void tsmYeni_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
        }

        private void tsmDetay_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)dgvEmployees.SelectedRows[0].Cells[0].Value;
            Personel personel = Form1.Personeller.FirstOrDefault(x => x.Id == Id);
            Form3 frm3 = new Form3(personel);
            this.Hide();
            frm3.ShowDialog();
        }
    }
}
