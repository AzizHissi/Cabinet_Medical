using MetroFramework.Forms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Medicale
{
    public partial class Form1 : MetroForm
    {
        DbEntity db = new DbEntity();
        
        public Form1()
        {
            InitializeComponent();
            int x = (bunifuGradientPanel1.Size.Width - count_rdv.Size.Width) / 2;
            count_rdv.Location = new Point(x, count_rdv.Location.Y);
            
        }
        internal void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Parse(DateTime.Now.ToShortDateString());
                count_rdv.Text = db.RDVs.Where(r => r.DateRDV == dt).Count().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void doc_panel_Click(object sender, EventArgs e)
        {
            Medecin_frm m = new Medecin_frm();
            m.ShowDialog();
        }

        private void pat_panel_Click(object sender, EventArgs e)
        {
            Patient_frm p = new Patient_frm();
            p.ShowDialog();
        }

        private void rdv_panel_Click(object sender, EventArgs e)
        {
            RDV_frm r = new RDV_frm();
            r.ShowDialog();

        }

        private void label15_Click(object sender, EventArgs e)
        {
            RDV_Date_frm rd = new RDV_Date_frm();
            rd.ShowDialog();
        }
    }
}
