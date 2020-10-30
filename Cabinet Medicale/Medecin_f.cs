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
    public partial class Medecin_f : Form
    {
        DbEntity db3 = new DbEntity();
        public Medecin_f()
        {
            InitializeComponent();
            if (Form1.Status == 1)
            {
                patient_title.Text = "Ajouter un medecin";
                btn1.Text = "Ajouter";
                btn2.Text = "Annuler";
            }
            else if (Form1.Status == 2)
            {
                txt_code.Enabled = false;
                patient_title.Text = "Modifier les information du medecin";
                btn1.Text = "Modifier";
                btn2.Text = "Supprimer";
                Medecin medecin = db3.Medecins.Find(Form1.cherche);
                txt_code.Text = medecin.CodeMedecin;
                txt_nom.Text = medecin.NomMedecin;
                txt_tel.Text = medecin.TelMedecin;
                cb_specia.SelectedValue = medecin.SpecialiteMedecin;
            }
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
        private void Medecin_f_Load(object sender, EventArgs e)
        {
            cb_specia.DataSource = db3.Specialites.Select(s => new { s.Code, s.Nom }).ToList();
            cb_specia.DisplayMember = "Nom";
            cb_specia.ValueMember = "Code";

        }
        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Form1.Status == 1)
            {
                
                try
                {
                    if (txt_code.Text == "" || txt_nom.Text == "" || txt_tel.Text == "" || cb_specia.Text == "")
                    {

                        MessageBox.Show("Veuillez remplir tous les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        Medecin p = new Medecin()
                        {
                            CodeMedecin = txt_code.Text,
                            NomMedecin = txt_nom.Text,
                            TelMedecin = txt_tel.Text,
                            DateEmbauche = dt_date.Value,
                            SpecialiteMedecin = cb_specia.SelectedValue + ""
                        };
                        db3.Medecins.Add(p);
                        db3.SaveChanges();
                        Vider(this);
                        MessageBox.Show("Ajouter avec Success", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (Form1.Status == 2)
            {
                
                try
                {
                    if (txt_code.Text == "" || txt_nom.Text == "" || txt_tel.Text == "" || cb_specia.Text == "")
                    {

                        MessageBox.Show("Veuillez remplir tous les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if (db3.Medecins.Find(txt_code.Text)!= null)
                        {

                            if (MessageBox.Show("Voulez vous vraiment suprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                db3.Medecins.Find(txt_code.Text).NomMedecin = txt_nom.Text;
                                db3.Medecins.Find(txt_code.Text).TelMedecin = txt_tel.Text;
                                db3.Medecins.Find(txt_code.Text).DateEmbauche = dt_date.Value;
                                db3.Medecins.Find(txt_code.Text).SpecialiteMedecin = cb_specia.SelectedValue + "";
                                db3.SaveChanges();
                                MessageBox.Show("Modifier avec Succes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else MessageBox.Show("Operation anuuler", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Form1.Status == 1)
            {
                this.Close();
            }
            else if (Form1.Status == 2)
            {
                try
                {

                    if (db3.Medecins.Find(txt_code.Text)!= null)
                    {

                        if (MessageBox.Show("Voulez vous vraiment suprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db3.Medecins.Remove(db3.Medecins.Find(txt_code.Text));
                            db3.SaveChanges();
                            MessageBox.Show("Suprimer avec Succes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Operation anuuler", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        public void Vider(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox || c is MaskedTextBox) c.Text = "";
                if (c is ComboBox) ((ComboBox)c).SelectedIndex = 0;
                if (c.Controls.Count != 0) Vider(c);
            }
        }

      
    }
}
