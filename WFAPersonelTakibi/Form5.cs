using MetroFramework.Forms;
using System;

namespace WFAPersonelTakibi
{
    public partial class Form5 : MetroForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
