using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Data.OleDb;
using System.Data.Odbc;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2(int score)
        {
            InitializeComponent();
             val = score;
        }
        int val;
        SoundPlayer sp3 = new SoundPlayer();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                val=int.Parse("string");
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Source);
            }
            
            textBox2.Text=""+val;
        }

        private void save_Click(object sender, EventArgs e)
        {
            //connexion à la base de données
            Class1 cl = new Class1();
            OleDbConnection connex = cl.ouvrirconnect();
            string req="insert into Joueur values('"+textBox1.Text.Trim()+"',"+textBox2.Text+")";
            OleDbDataReader repons = cl.executionRequete(req,connex);


            //routine
            MessageBox.Show("Votre Score a été enregistré dans la BD");
            /*string message2 = "Vous allez Commencer une nouvelle partie?";
            string caption = "RECOMMENCER LA PARTIE";
            MessageBoxButtons init = MessageBoxButtons.YesNo;
            DialogResult reponse;
            reponse = MessageBox.Show(this, message2, caption, init);
            if (reponse == DialogResult.Yes)
            {
                this.Hide();
                Principale nouvelle_partie = new Principale();
                nouvelle_partie.FormClosed += new FormClosedEventHandler(ferme_FormClosed);
                nouvelle_partie.Show();
            }*/
            Dispose();
            connex.Close();
        }
       /* private void ferme_FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.Close();
        }*/
    }
}
