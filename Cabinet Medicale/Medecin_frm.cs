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
    public partial class Medecin_frm : MetroForm
    {

        DbEntity db = new DbEntity();
        BindingSource binding = new BindingSource();
        public Medecin_frm()
        {
            InitializeComponent();

        }
        private void Medecin_frm_Load(object sender, EventArgs e)
        {
            try
            {
                Charger_Source();
                cb_speciliste_add.DataSource = cb_specialite_mod.DataSource = db.Specialites.Select(s => new { s.Code, s.Nom }).ToList();
                cb_speciliste_add.DisplayMember = cb_specialite_mod.DisplayMember = "Nom";
                cb_speciliste_add.ValueMember = cb_specialite_mod.ValueMember = "Code";
                Grid.DataSource = binding;
                cb_med_mod.DataSource = binding;
                cb_med_mod.DisplayMember = "CodeMedecin";
                cb_med_mod.ValueMember = "CodeMedecin";
                txt_nom_mod.DataBindings.Add("Text", binding, "NomMedecin");
                dt_dateE_mod.DataBindings.Add("Value", binding, "DateEmbauche");
                txt_tel_mod.DataBindings.Add("Text", binding, "TelMedecin");
                cb_specialite_mod.DataBindings.Add("Text", binding, "Nom");

                tab_medecin.SelectTab("tab_add");
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
                if (txt_code_add.Text != "" && txt_nom_add.Text != "" && txt_tel_add.MaskCompleted  )
                {
                    if (db.Medecins.Find(txt_code_add.Text) == null)
                    {
                        Medecin m = new Medecin()
                        {
                            CodeMedecin = txt_code_add.Text,
                            NomMedecin = txt_nom_add.Text,
                            TelMedecin = txt_tel_add.Text,
                            DateEmbauche = DateTime.Parse(dt_dateE_add.Value.ToShortDateString()),
                            SpecialiteMedecin = cb_speciliste_add.SelectedValue+""
                        };
                        db.Medecins.Add(m);
                        db.SaveChanges();
                        MessageBox.Show("Ajouter avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vider(groupBox2);
                    }
                    else MessageBox.Show("Le code utuliser est existe deja ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Merci de remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab_patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_medecin.SelectedTab.Name == "tab_grid")
            {
                Charger_Source();
            }
            else if (tab_medecin.SelectedTab.Name == "tab_modify")
            {
                Charger_Source();
            }
            else if (tab_medecin.SelectedTab.Name == "tab_add")
            {
                vider(groupBox2);
            }

        }

        private void Charger_Source()
        {
            binding.DataSource = (from m in db.Medecins join s in db.Specialites on m.SpecialiteMedecin equals s.Code select new
            {
                m.CodeMedecin,
                m.NomMedecin,
                m.TelMedecin,
                m.DateEmbauche,
                s.Nom
            }).ToList();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Medecin m = new Medecin();
                if (txt_nom_mod.Text != "" && txt_tel_mod.MaskCompleted  )
                {
                    if ((m = db.Medecins.Find(cb_med_mod.SelectedValue)) != null)
                    {
                        if (MessageBox.Show("Voulez-vous vraimant enregistrer les modificcations", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            m.NomMedecin = txt_nom_mod.Text;
                            m.TelMedecin = txt_tel_mod.Text;
                            m.DateEmbauche = DateTime.Parse(dt_dateE_mod.Value.ToShortDateString());
                            m.SpecialiteMedecin = cb_specialite_mod.SelectedValue + "";
                            db.SaveChanges();
                            Charger_Source();
                            MessageBox.Show("Modifier avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else MessageBox.Show("Operation annuler ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else MessageBox.Show("Code medecin n'existe pas ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Medecin m = new Medecin();

                if ((m = db.Medecins.Find(cb_med_mod.SelectedValue)) != null)
                {
                    if (MessageBox.Show("Voulez-vous vraimant suprimer ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        binding.MoveFirst();
                        db.Medecins.Remove(m);
                        db.SaveChanges();
                        Charger_Source();
                        MessageBox.Show("Suprimer avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else MessageBox.Show("Operation annuler ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else MessageBox.Show("Code medecin n'existe pas ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);


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
                if (c is RadioButton) ((RadioButton)c).Checked = false;
                if (c is ComboBox) ((ComboBox)c).SelectedIndex = 0;
            }
        }

    }
}
