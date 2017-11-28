using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void ürünGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler frmurun = new Urunler();
            frmurun.MdiParent = this;
            frmurun.Show();
        }

        private void stokGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İletisim frm = new İletisim();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kategoriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategoriler frmkate = new Kategoriler();
            frmkate.MdiParent = this;
            frmkate.Show();
        }

        private void parçaGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parcalar frmparca = new Parcalar();
            frmparca.MdiParent = this;
            frmparca.Show();
        }

        private void anaform_Load(object sender, EventArgs e)
        {

        }

        private void ürünStokGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunstok frmurunstok = new Urunstok();
            frmurunstok.MdiParent = this;
            frmurunstok.Show();
        }

        private void parçaStokGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parcastokk frmparcastok = new Parcastokk();
            frmparcastok.MdiParent = this;
            frmparcastok.Show();
        }

        private void satışGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satis frmsatis = new Satis();
            frmsatis.MdiParent = this;
            frmsatis.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
