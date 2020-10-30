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
    public partial class Patient_frm : MetroForm
    {

        DbEntity db = new DbEntity();
        BindingSource binding = new BindingSource();
        public Patient_frm()
        {
            InitializeComponent();
           
        }
        private void Patient_frm_Load(object sender, EventArgs e)
        {
            try
            {
                Charger_Source();
                Grid.DataSource = binding;
                cb_code_patient.DataSource = binding;
                cb_code_patient.DisplayMember = "CodePatient";
                cb_code_patient.ValueMember = "CodePatient";
                txt_nom_mod.DataBindings.Add("Text", binding, "NomPatient");
                dt_daten_mod.DataBindings.Add("Value", binding, "DateNaissance");
                txt_adress_mod.DataBindings.Add("Text", binding, "AdressePatient");
                binding.CurrentChanged += Binding_CurrentChanged;
                Binding_CurrentChanged(sender, e);

                tab_patient.SelectTab("tab_add");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void Binding_CurrentChanged(object sender, EventArgs e)
        {
            Patient p = db.Patients.Find(cb_code_patient.SelectedValue);
            if (p.SexePatient == "M") rb_m_mod.Checked = true;
            else rb_f_mod.Checked = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_code_add.Text != "" && txt_nom_add.Text != "" && txt_adress_add.Text != "" && (rd_f_add.Checked ^ rd_m_add.Checked))
                {
                    if (db.Patients.Find(txt_code_add.Text) == null)
                    {
                        Patient p = new Patient()
                        {
                            CodePatient = txt_code_add.Text,
                            NomPatient = txt_nom_add.Text,
                            AdressePatient = txt_adress_add.Text,
                            DateNaissance = DateTime.Parse(dt_daten_add.Value.ToShortDateString()),
                            SexePatient = (rd_m_add.Checked) ? "M" : "F"
                        };
                        db.Patients.Add(p);
                        db.SaveChanges();
                        MessageBox.Show("Ajouter avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vider(groupBox1);
                    }
                    else MessageBox.Show("Le code utuliser est existe deja ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Merci de remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab_patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tab_patient.SelectedTab.Name == "tab_grid")
            {
                Charger_Source();
            }
            else if (tab_patient.SelectedTab.Name == "tab_modify")
            {
                Charger_Source();
            }
            else if (tab_patient.SelectedTab.Name == "tab_add")
            {
                vider(groupBox1);
            }

        }

        private void Charger_Source()
        {
            binding.DataSource = db.Patients.Select(p => new { p.CodePatient, p.NomPatient, p.AdressePatient, p.DateNaissance, p.SexePatient }).ToList();
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Patient p = new Patient();
                if (txt_nom_mod.Text != "" && txt_adress_mod.Text != "" && (rb_f_mod.Checked ^ rb_m_mod.Checked))
                {
                    if ((p = db.Patients.Find(cb_code_patient.SelectedValue)) != null)
                    {
                        if(MessageBox.Show("Voulez-vous vraimant enregistrer les modificcations", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            p.NomPatient = txt_nom_mod.Text;
                            p.AdressePatient = txt_adress_mod.Text;
                            p.DateNaissance = DateTime.Parse(dt_daten_mod.Value.ToShortDateString());
                            p.SexePatient = (rb_m_mod.Checked) ? "M" : "F";
                            db.SaveChanges();
                            Charger_Source();
                            MessageBox.Show("Modifier avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else MessageBox.Show("Operation annuler ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else MessageBox.Show("Code patient n'existe pas ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Patient p = new Patient();
               
                    if ((p = db.Patients.Find(cb_code_patient.SelectedValue)) != null)
                    {
                        if (MessageBox.Show("Voulez-vous vraimant suprimer ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            binding.MoveFirst();
                            db.Patients.Remove(p);
                            db.SaveChanges();
                            Charger_Source();
                        MessageBox.Show("Suprimer avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else MessageBox.Show("Operation annuler ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else MessageBox.Show("Code patient n'existe pas ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void vider(Control ctrl)
        {
            foreach(Control c in ctrl.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                if (c is RadioButton) ((RadioButton)c).Checked=false;
            }
        }

    }
}
