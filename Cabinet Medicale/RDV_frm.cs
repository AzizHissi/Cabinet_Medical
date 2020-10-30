using MetroFramework.Forms;
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
    public partial class RDV_frm : MetroForm
    {
        DbEntity db = new DbEntity();
        BindingSource bs1 = new BindingSource();
        BindingSource bs2 = new BindingSource();
        BindingSource bs3 = new BindingSource();
        BindingSource bs4 = new BindingSource();
        DataTable data_Patient = new DataTable();
        DataTable data_Medecin = new DataTable();
        public RDV_frm()
        {
            InitializeComponent();
        }
        private void RDV_frm_Load(object sender, EventArgs e)
        {

            try
            {
                Charger_Grid();
                /******************************************************************************************/
                cb_pat_mod.DataSource = bs1;
                cb_pat_mod.DisplayMember = "CodePatient";
                cb_pat_mod.ValueMember = "CodePatient";
                txt_pat_mod.DataBindings.Add("Text", bs1, "NomPatient");
                dt_dateN_mod.DataBindings.Add("Text", bs1, "DateNaissance");
                bs1.CurrentChanged += Bs1_CurrentChanged;
                Bs1_CurrentChanged(sender, e);
                /*****************************************************************************************/
                grid_mod.DataSource = bs2;
                txt_code_mod.DataBindings.Add("Text", bs2, "NumeroRDV");
                dt_date_mod.DataBindings.Add("Value", bs2, "DateRDV");
                txt_heure_mod.DataBindings.Add("Text", bs2, "HeureRDV");
                cb_med_mod.DataBindings.Add("Text", bs2, "NomMedecin");
                /*****************************************************************************************/
                cb_pat_add.DataSource = bs3;
                cb_pat_add.DisplayMember = "CodePatient";
                cb_pat_add.ValueMember = "CodePatient";
                txt_nomp_add.DataBindings.Add("Text", bs3, "NomPatient");
                bs3.CurrentChanged += Bs3_CurrentChanged;
                Bs3_CurrentChanged(sender, e);
                /*****************************************************************************************/
                cb_med_add.DataSource = bs4;
                cb_med_add.DisplayMember = cb_med_mod.DisplayMember = "CodeMedecin";
                cb_med_add.ValueMember = cb_med_mod.ValueMember = "CodeMedecin";
                txt_nomm_add.DataBindings.Add("Text", bs4, "NomMedecin");
                txt_sepci_add.DataBindings.Add("Text", bs4, "Nom");
                /*****************************************************************************************/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Bs1_CurrentChanged(object sender, EventArgs e)
        {
            Patient ptnt = db.Patients.Find(cb_pat_mod.SelectedValue);
            if(ptnt != null)
            {
                if (ptnt.SexePatient == "M") rb_m_mod.Checked = true;
                else rb_f_mod.Checked = true;
                bs2.DataSource = ptnt.RDVs.Select(r => new { r.NumeroRDV, r.HeureRDV, r.DateRDV, r.Medecin.NomMedecin }).ToList();
            }
            
         }
        private void Bs3_CurrentChanged(object sender, EventArgs e)
        {
            Patient ptnt = db.Patients.Find(cb_pat_add.SelectedValue);
            if (ptnt.SexePatient == "M") rd_m_add.Checked = true;
            else rd_f_add.Checked = true;
        }

        private void Charger_Grid()
        {
            Grid.DataSource = (from r in db.RDVs
                               join p in db.Patients on r.CodePatient equals p.CodePatient
                               join m in db.Medecins on r.CodeMedecin equals m.CodeMedecin
                               select new { r.NumeroRDV, r.DateRDV, r.HeureRDV, p.NomPatient, m.NomMedecin }).ToList();

            bs1.DataSource = bs3.DataSource = db.Patients.Select(p => new { p.CodePatient, p.NomPatient, p.SexePatient, p.DateNaissance,p.RDVs}).ToList();
            
           bs4.DataSource = (from m in db.Medecins join s in db.Specialites on m.SpecialiteMedecin 
                                     equals s.Code select new { m.CodeMedecin, m.NomMedecin ,s.Nom}).ToList();
            cb_med_mod.DataSource = (from m in db.Medecins select new { m.CodeMedecin, m.NomMedecin }).ToList();

        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(txt_code_mod.Text);
                RDV r = db.RDVs.Find(num);
                if (txt_heure_mod.MaskCompleted  && dt_date_mod.Text != "" && cb_med_mod.Text != "")
                {
                  
                        if (MessageBox.Show("Voulez-vous vraimant enregistrer les modificcations", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            r.HeureRDV = txt_heure_mod.Text;
                            r.DateRDV = DateTime.Parse(dt_date_mod.Value.ToShortDateString());
                            r.CodeMedecin = cb_med_mod.SelectedValue + "";
                            r.CodePatient = cb_pat_mod.SelectedValue + "";
                            db.SaveChanges();
                            Charger_Grid();
                            MessageBox.Show("Modifier avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else MessageBox.Show("Operation annuler ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Merci de remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(txt_code_mod.Text);
                RDV r = db.RDVs.Find(num);

                if (MessageBox.Show("Voulez-vous vraimant suprimer ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bs1.MoveFirst();
                        db.RDVs.Remove(r);
                        db.SaveChanges();
                        Charger_Grid();
                    MessageBox.Show("Suprimer avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else MessageBox.Show("Operation annuler ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_pat_add.Text != "" && cb_med_add.Text != "" && txt_heure_add.MaskCompleted )
                {
                    ;


                    RDV rdv = new RDV()
                        {
                            HeureRDV = txt_heure_add.Text,
                            DateRDV = DateTime.Parse(dt_date_add.Value.ToShortDateString()),
                            CodeMedecin = cb_med_add.SelectedValue+"",
                            CodePatient = cb_pat_add.SelectedValue + ""
                          
                        };
                        db.RDVs.Add(rdv);
                        db.SaveChanges();
                    Charger_Grid();
                    Form f1 = Application.OpenForms["Form1"];

                    ((Form1)f1).Form1_Load(sender, e);
                    MessageBox.Show("Ajouter avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vider(groupBox1);
                   
                }
                else MessageBox.Show("Merci de remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void vider(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                if (c is MaskedTextBox) ((MaskedTextBox)c).Clear();
                if (c is ComboBox) ((ComboBox)c).SelectedIndex = 0;
            }
        }
    }
}
