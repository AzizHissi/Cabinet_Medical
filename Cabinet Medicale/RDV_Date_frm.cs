using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Medicale
{
    public partial class RDV_Date_frm : MetroForm
    {
        DbEntity db = new DbEntity();
        public RDV_Date_frm()
        {
            InitializeComponent();
        }

        private void RDV_Date_frm_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Parse(DateTime.Now.ToShortDateString());
                Charger_Grid(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                Charger_Grid(DateTime.Parse(dt_date.Value.ToShortDateString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Charger_Grid(DateTime dt)
        {
            Grid.DataSource = (from r in db.RDVs
                               join p in db.Patients on r.CodePatient equals p.CodePatient
                               join m in db.Medecins on r.CodeMedecin equals m.CodeMedecin
                               where r.DateRDV == dt
                               select new { r.NumeroRDV, r.DateRDV, r.HeureRDV, p.NomPatient, m.NomMedecin }).ToList();
        }
    }
}
