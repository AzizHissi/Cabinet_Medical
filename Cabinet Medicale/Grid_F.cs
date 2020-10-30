using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Cabinet_Medicale
{
    public partial class Grid_F : Form
    {
        DbEntity db = new DbEntity();
        public Grid_F()
        {
            InitializeComponent();
           
        }
      
        private void Grid_F_Load(object sender, EventArgs e)
        {
            if (Form1.Status == 3)
            {
                patient_title.Text = "Liste des medecins";
                Grid.DataSource = (from m in db.Medecins
                                   join s in db.Specialites on m.SpecialiteMedecin equals s.Code
                                   select new { m.CodeMedecin, m.NomMedecin, m.TelMedecin, m.DateEmbauche, Specialite = s.Nom }).ToList();
            }
            else if (Form1.Status == 4)
            {
                patient_title.Text = "Liste des patients";
                Grid.DataSource = (from p in db.Patients select new {p.CodePatient , p.NomPatient , p.DateNaissance , p.SexePatient , p.AdressePatient} ).ToList();

            }
            else if (Form1.Status == 5)
            {
                patient_title.Text = "Liste des RDV";
                Grid.DataSource = (from r in db.RDVs
                                   join p in db.Patients on r.CodePatient equals p.CodePatient
                                   join m in db.Medecins on r.CodeMedecin equals m.CodeMedecin
                                   select new {r.NumeroRDV , r.DateRDV , r.HeureRDV , p.NomPatient , m.NomMedecin }).ToList();
            }
            Change_Mode(this);

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void Change_Mode(Control ctrl)
        {
            ColorConverter color = new ColorConverter();
            foreach (Control c in ctrl.Controls)
            {
                if (Form1.Mode && c is Panel) c.BackColor = (Color)color.ConvertFromString("51, 52, 74");
                else if (!Form1.Mode && c is Panel) c.BackColor = (Color)color.ConvertFromString("64,64,64");
                if (Form1.Mode && c is BunifuCustomDataGrid)
                {
                    ((BunifuCustomDataGrid)c).HeaderBgColor = (Color)color.ConvertFromString("254, 127, 153");
                    ((BunifuCustomDataGrid)c).GridColor = (Color)color.ConvertFromString("216, 160, 171");
                    ((BunifuCustomDataGrid)c).BackgroundColor = (Color)color.ConvertFromString("242, 223, 227");
                }
                else if (!Form1.Mode && c is BunifuCustomDataGrid)
                {
                    ((BunifuCustomDataGrid)c).HeaderBgColor = (Color)color.ConvertFromString("127, 127, 127");
                    ((BunifuCustomDataGrid)c).GridColor = (Color)color.ConvertFromString("169, 169, 169");
                    ((BunifuCustomDataGrid)c).BackgroundColor = (Color)color.ConvertFromString("226, 226, 226");
                }
                if (c.Controls.Count != 0) Change_Mode(c);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
