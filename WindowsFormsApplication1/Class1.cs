using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    class  Class1
    {
        //String  chaine = "Provider =  Microsoft.Jet.OLEDB.4.0; DataSource=cheminDeLaBaseDeDonnees";// connection avec odbc

        public  OleDbConnection ouvrirconnect()
        {
            OleDbConnection connexion = new OleDbConnection();
            connexion.ConnectionString =" Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Directory.GetCurrentDirectory()+@"\mindbm.mdb";
            try {
            connexion.Open();
            }catch(Exception ex)

            {
                      MessageBox.Show(ex.Message);
            }
            return connexion;
        }

        public  OleDbDataReader executionRequete(String LaRequete, OleDbConnection maconnexion)
        {
            OleDbDataReader req = null;
            try
            {
                OleDbCommand Macommande = maconnexion.CreateCommand();
                Macommande.CommandText = LaRequete;
                req = Macommande.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return req;
        }

    
    }
}
