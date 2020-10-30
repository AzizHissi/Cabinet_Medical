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
    public partial class RDV_f : Form
    {
     
        DbEntity db4 = new DbEntity();
        BindingSource bs1 = new BindingSource();
        BindingSource bs2 = new BindingSource();

        public RDV_f()
        {
            InitializeComponent();
            Change_Mode(this);
        }
        public void Change_Mode(Control ctrl)
        {
            ColorConverter color = new ColorConverter();
            

            foreach (Control c in ctrl.Controls)
            {
                if (Form1.Mode && (c is Panel || c is Button)) c.BackColor = (Color)color.ConvertFromString("51, 52, 74");
                else if (!Form1.Mode && (c is Panel || c is Button)) c.BackColor = (Color)color.ConvertFromString("64,64,64");
                if (c.Controls.Count != 0) Change_Mode(c);
            }
        }
        private void RDV_f_Load(object sender, EventArgs e)
        {
            bs1.DataSource = db4.Patients.Select(p => new { p.CodePatient, p.NomPatient, p.SexePatient }).ToList();
            cb_patient.DataSource = bs1;
            txt_patient.DataBindings.Add("Text", bs1, "NomPatient");
            txt_patient.Enabled = false;
            rb_f.Enabled = false;
            rb_m.Enabled = false;
            cb_patient.DisplayMember = "CodePatient";
            cb_patient.ValueMember = "CodePatient";
            bs2.DataSource = (from m in db4.Medecins
                              join s in db4.Specialites on m.SpecialiteMedecin equals s.Code
                              select new { m.CodeMedecin, m.NomMedecin,Specialite = s.Nom }).ToList();
            cb_medecin.DataSource = bs2;
            cb_medecin.DisplayMember = "CodeMedecin";
            cb_medecin.ValueMember = "CodeMedecin";
            txt_medecin.DataBindings.Add("Text", bs2, "NomMedecin");
            txt_medecin.Enabled = false;
            txt_specialite.DataBindings.Add("Text", bs2, "Specialite");
            txt_specialite.Enabled = false;
            bs1.MoveFirst();
            bs1.CurrentChanged += Bs1_CurrentChanged;
            Bs1_CurrentChanged(sender, e);
            txt_time.Text = DateTime.Now.ToLocalTime().ToString("hh:mm"); 
        }

        private void Bs1_CurrentChanged(object sender, EventArgs e)
        {
            Patient p = db4.Patients.Find(cb_patient.SelectedValue);
            if (p.SexePatient == "M") rb_m.Checked = true;
            else rb_f.Checked = true;
        }

        private void roundButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundButton11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(cb_medecin.Text == ""  || cb_patient.Text == "" || txt_time.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    RDV rdv = new RDV()
                    {
                        DateRDV = dt_date.Value,
                        HeureRDV = txt_time.Text,
                        CodeMedecin = cb_medecin.SelectedValue + "",
                        CodePatient = cb_patient.SelectedValue + ""
                    };
                    db4.RDVs.Add(rdv);
                    db4.SaveChanges();
                    Form f1 = Application.OpenForms["Form1"];

                    ((Form1)f1).Form1_Load(sender, e);

                    
                    MessageBox.Show("Ajouter avec sucess", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
