using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace CardReader
{
    public partial class KayitGoruntule : Form
    {
        public KayitGoruntule()
        {
            InitializeComponent();
        }
        OleDbConnection con; 
        OleDbDataReader dr;
        OleDbCommand cmd;
        private void KayitGoruntule_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=contacts.mdb");
            con.Open();
            cmd = new OleDbCommand("Select * From kartbilgiler", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Kimlik"].ToString());
                item.SubItems.Add(dr["kartno"].ToString());
                item.SubItems.Add(dr["isimsoyisim"].ToString());  //www.ahmetcansever.com
                item.SubItems.Add(dr["mail"].ToString());
                item.SubItems.Add(dr["telno"].ToString());
                item.SubItems.Add(dr["bolum"].ToString());
                item.SubItems.Add(dr["sınıf"].ToString());
                listView1.Items.Add(item);
            }
            con.Close();
        }
    }
}
