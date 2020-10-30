using Bunifu.Framework.UI;
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
    public partial class RecherchePat : Form
    {
        DbEntity db5 = new DbEntity();
        BindingSource source = new BindingSource();
      
        public RecherchePat()
        {
            InitializeComponent();
            Change_Mode(this);
            groupBox2.Enabled = false;
            cb_medecin.DataSource = db5.Medecins.Select(p => new {p.CodeMedecin,p.NomMedecin }).ToList();
            cb_medecin.DisplayMember = "NomMedecin";
            cb_medecin.ValueMember = "CodeMedecin";
        }
        private void RecherchePat_Load(object sender, EventArgs e)
        {
           
        }
        public void Change_Mode(Control ctrl)
        {
            ColorConverter color = new ColorConverter();
            foreach (Control c in ctrl.Controls)
            {
                if (Form1.Mode && (c is Panel || c is Button)) c.BackColor = (Color)color.ConvertFromString("51, 52, 74");
                else if (!Form1.Mode && (c is Panel || c is Button)) c.BackColor = (Color)color.ConvertFromString("64,64,64");
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
            try
            {
                Patient p = new Patient();
                if ((p = db5.Patients.Find(txt_codep.Text)) != null)
                {
                    Disable_Bind_Data();
                   
                    txt_nom.Text = p.NomPatient;
                    txt_adresse.Text = p.AdressePatient;
                    dt_datN.Text = p.DateNaissance + "";
                    rb_m.Checked = (p.SexePatient == "M") ? true : false;
                    rb_f.Checked = (p.SexePatient == "F") ? true : false;
                    source.DataSource = (from r in db5.RDVs
                                         join m in db5.Medecins on r.CodeMedecin
                                         equals m.CodeMedecin
                                         where r.CodePatient == txt_codep.Text
                                         select new { r.NumeroRDV, r.DateRDV, r.HeureRDV, m.NomMedecin }).ToList();

                    Enable_Bind_Data();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Enable_Bind_Data()
        {
            
                grid.DataSource = source;
                txt_numrdv.DataBindings.Add("Text", source, "NumeroRDV");
                txt_time.DataBindings.Add("Text", source, "HeureRDV");
                dt_rdv.DataBindings.Add("Text", source, "DateRDV");
                cb_medecin.DataBindings.Add("Text", source, "NomMedecin");

            
            
        }
        private void Disable_Bind_Data()
        {

            grid.DataSource = null;
            txt_numrdv.DataBindings.Clear();
            txt_time.DataBindings.Clear();
            dt_rdv.DataBindings.Clear();
            cb_medecin.DataBindings.Clear();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txt_numrdv.Text);
            try
            {

                if (db5.RDVs.Find(num) != null)
                {
                    if(MessageBox.Show("Vouler vraimant modifier", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db5.RDVs.Where(r => r.NumeroRDV == num).First().DateRDV = dt_rdv.Value;
                        db5.RDVs.Where(r => r.NumeroRDV == num).First().HeureRDV = txt_time.Text;
                        db5.RDVs.Where(r => r.NumeroRDV == num).First().CodeMedecin = cb_medecin.SelectedValue + "";
                        db5.RDVs.Where(r => r.NumeroRDV == num).First().CodePatient = txt_codep.Text;
                        db5.SaveChanges();
                        MessageBox.Show("Modifier avec succes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else MessageBox.Show("Operation annuler", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txt_numrdv.Text);
            try
            {

                if (db5.RDVs.Find(num) != null)
                {
                    if (MessageBox.Show("Vouler vraimant suprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db5.RDVs.Remove(db5.RDVs.Find(num));
                        db5.SaveChanges();
                        MessageBox.Show("Suprimer avec succes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else MessageBox.Show("Operation annuler", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
