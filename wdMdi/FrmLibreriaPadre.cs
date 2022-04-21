using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wdMdi
{
    public partial class frm_FormularioPadre : Form
    {
        public frm_FormularioPadre()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmLibreriaHijo = new Form();
            FrmLibreriaHijo.MdiParent = this;
            FrmLibreriaHijo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmLibreriaHijo = this.ActiveMdiChild;
            if (FrmLibreriaHijo != null)
            {
                FrmLibreriaHijo.Close();
            }
        }
    }
}
