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
    public partial class RechercheDate : Form
    {
        DbEntity db6 = new DbEntity();
        BindingSource bs = new BindingSource();
        public RechercheDate()
        {
            InitializeComponent();
        }
        private void RechercheDate_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(DateTime.Now.ToShortDateString());
            
            Charger_Grid(dt);
            grid.DataSource = bs;
            grid.Columns.Remove(grid.Columns["Patient"]);
            grid.Columns.Remove(grid.Columns["Medecin"]);
           
            txt_nomm.DataBindings.Add("Text", bs, "Medecin.NomMedecin");
            txt_nomp.DataBindings.Add("Text", bs, "Patient.NomPatient");
            txt_spec.DataBindings.Add("Text", bs, "Medecin.Specialite.Nom");
            dt_datN.DataBindings.Add("Text", bs, "Patient.DateNaissance");

            bs.CurrentChanged += Bs_CurrentChanged;
            Bs_CurrentChanged(sender, e);
          
        }

        private void Bs_CurrentChanged(object sender, EventArgs e)
        {
            RDV r = (RDV)bs.Current;
            if(r != null)
            {
                if (r.Patient.SexePatient == "M") rb_m.Checked = true;
                else rb_f.Checked = true;
            }
           
        }



        private void Charger_Grid(DateTime dt)
        {
            bs.DataSource = db6.RDVs.Where(r => r.DateRDV == dt).ToList();
            //(from r in db6.RDVs
            //                 join m in db6.Medecins on r.CodeMedecin equals m.CodeMedecin
            //                 join p in db6.Patients on r.CodePatient equals p.CodePatient
            //                 join s in db6.Specialites on m.SpecialiteMedecin equals s.Code
            //                 where r.DateRDV == dt
            //                 select new
            //                 {
            //                     r.NumeroRDV,
            //                     r.DateRDV,
            //                     r.HeureRDV,
            //                     m.CodeMedecin,
            //                     p.CodePatient,
            //                     m.NomMedecin,
            //                     s.Nom,
                                 
            //                     p.NomPatient,
            //                     p.DateNaissance,
            //                     p.SexePatient
            //                 }).ToList();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Charger_Grid(DateTime.Parse(dateTimePicker1.Value.ToShortDateString()));
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
