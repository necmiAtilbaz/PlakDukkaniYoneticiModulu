using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniYoneticiModulu
{
    public partial class frmOnSales : Form
    {
        PDukDbContext db = new PDukDbContext();
        public frmOnSales()
        {
            InitializeComponent();
            AlbumleriYenile();
        }
        public void AlbumleriYenile()
        {
            dgvOnSales.Rows.Clear();
            foreach (Album item in db.Albums.ToList())
            {
                if (item.SatistaMi)
                {
                    
                    dgvOnSales.Rows.Add(item.AlbumAdi, item.SanatciGrup);
                }

            }
        }

        private void frmOnSales_Load(object sender, EventArgs e)
        {
            AlbumleriYenile();
        }
    }
}
