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
    
    public partial class Patient_F : Form
    {
        DbEntity db1 = new DbEntity();
        public Patient_F()
        {
            InitializeComponent();
            
            if (Form1.Status == 1)
            {
                patient_title.Text = "Ajouter un patient";
                btn_add.Text = "Ajouter";
                btn_cancel.Text = "Annuler";
            }
            else if (Form1.Status == 2)
            {
                textBox1.Enabled = false;
                patient_title.Text = "Modifier les information du patient";
                btn_add.Text = "Modifier";
                btn_cancel.Text = "Supprimer";
                Patient patient = db1.Patients.Where(p => p.CodePatient == Form1.cherche).First();
                textBox1.Text = patient.CodePatient;
                textBox2.Text = patient.NomPatient;
                textBox3.Text = patient.AdressePatient;
                dateTimePicker1.Value = DateTime.Parse(patient.DateNaissance+"");
                 rd_m.Checked = (patient.SexePatient == "M") ? true : false;
                rd_f.Checked = (patient.SexePatient == "F") ? true : false;
            }
            Change_Mode(this);
        }
        public void Change_Mode(Control ctrl)
        {
            ColorConverter color = new ColorConverter();
            foreach (Control c in ctrl.Controls)
            {
                if (Form1.Mode && (c is Panel  || c is Button)) c.BackColor = (Color)color.ConvertFromString("51, 52, 74");
                else if (!Form1.Mode && (c is Panel || c is Button)) c.BackColor = (Color)color.ConvertFromString("64,64,64");
                if (c.Controls.Count != 0) Change_Mode(c);
            }
        }
        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Patient_F_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Form1.Status == 1)
            {
                string sexe =(rd_f.Checked == true) ? "M" : "F";
                try
                {
                    if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || !(rd_f.Checked ^ rd_m.Checked)) {

                        MessageBox.Show("Veuillez remplir tous les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        Patient p = new Patient()
                        {
                            CodePatient = textBox1.Text,
                        NomPatient = textBox2.Text,
                        AdressePatient = textBox3.Text,
                        DateNaissance = dateTimePicker1.Value,
                        SexePatient = sexe
                        };
                        db1.Patients.Add(p);
                        db1.SaveChanges();
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
                string sexe = (rd_f.Checked == true) ? "M" : "F";
                try
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || !(rd_f.Checked ^ rd_m.Checked))
                    {

                        MessageBox.Show("Veuillez remplir tous les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if (db1.Patients.Where(p => p.CodePatient == textBox1.Text).First()!=null)
                        {

                            if (MessageBox.Show("Voulez vous vraiment suprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                db1.Patients.Where(p => p.CodePatient == textBox1.Text).First().NomPatient = textBox2.Text;
                                db1.Patients.Where(p => p.CodePatient == textBox1.Text).First().AdressePatient = textBox3.Text;
                                db1.Patients.Where(p => p.CodePatient == textBox1.Text).First().DateNaissance = dateTimePicker1.Value;
                                db1.Patients.Where(p => p.CodePatient == textBox1.Text).First().SexePatient = sexe;
                                db1.SaveChanges();
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (Form1.Status == 1)
            {
                this.Close();
            }
            else if (Form1.Status == 2)
            {
                try
                {

                    if (db1.Patients.Where(p => p.CodePatient == textBox1.Text).First() != null)
                    {
                   
                        if (MessageBox.Show("Voulez vous vraiment suprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db1.Patients.Remove(db1.Patients.Where(p => p.CodePatient == textBox1.Text).First());
                            db1.SaveChanges();
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
            foreach(Control c in ctrl.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                if (c is RadioButton) ((RadioButton)c).Checked = false;
                if (c.Controls.Count != 0) Vider(c);
            }
        }
    }
}
