using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace CardReader
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        OleDbCommand cmd;
        OleDbDataReader dr;
        OleDbConnection con;
        private void MainPage_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=contacts.mdb");
            cmd = new OleDbCommand();
            con.Open();
            MessageBox.Show("Veritabanıyla Bağlantı kuruldu.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            




            GetPortNames();
            GetBaudRates();

            isimctrl.Enabled = false;
            mailctrl.Enabled = false;
            kartnumctrl.Enabled = false;
            bolumctrl.Enabled = false;
            sinifctrl.Enabled = false;
            numctrl.Enabled = false;
            kartnumtx.Enabled = false;

            Control.CheckForIllegalCrossThreadCalls = false;

        }
        private void GetPortNames()
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }
        private void GetBaudRates()
        {
            comboBox2.Items.Add("300");
            comboBox2.Items.Add("1200");
            comboBox2.Items.Add("2400");
            comboBox2.Items.Add("4800");
            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("14400");
            comboBox2.Items.Add("19200");
            comboBox2.Items.Add("28800");
            comboBox2.Items.Add("38400");
            comboBox2.Items.Add("57600");
            comboBox2.Items.Add("115200");
            comboBox2.Items.Add("230400");
        }
        private void OpenConnection()
        {
            if (!serialPort1.IsOpen)
            {
              
                try
                {
                    foreach (string port in SerialPort.GetPortNames())
                    {
                        serialPort1.PortName = comboBox1.Text;
                        serialPort1.BaudRate = int.Parse(comboBox2.Text);
                    }
                    if (!serialPort1.IsOpen) { 
                        serialPort1.Open();
                }
                   
                    MessageBox.Show("Kart Okuyucuya başarılı bir şekilde Bağlanıldı.");
                    button1.Enabled = false; button2.Enabled = true;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
        private void CloseConnection()
        {
            serialPort1.Close();
            button1.Enabled = true;
            button2.Enabled = false;
            MessageBox.Show("Kart Okuyucu ile bağlantı kesildi.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kartno = kartnumtx.Text;
            kartnumctrl.Text = kartno;

            string isimsoyisim = isimbilgitx.Text;
            isimctrl.Text = isimsoyisim;

            string mail = mailbilgitx.Text;
            mailctrl.Text = mail;

            string telno = numbilgitx.Text;
            numctrl.Text = telno;

            string bolum = bolumbilgitx.Text;
            bolumctrl.Text = bolum;

            string sinif = sinifbilgitx.Text;
            sinifctrl.Text = sinif;
           
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            kartnumtx.Text = serialPort1.ReadLine();
           
           
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isimctrl.Clear();
            mailctrl.Clear();
            numctrl.Clear();
            kartnumctrl.Clear();
            bolumctrl.Clear();
            sinifctrl.Clear();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO kartbilgiler(kartno,isimsoyisim,mail,telno,bolum,sınıf) VALUES ('" + kartnumctrl.Text + "','" + isimctrl.Text + "','" + mailctrl.Text + "','" + numctrl.Text + "','" + bolumctrl.Text + "','" + sinifctrl.Text + "')"; //sql kodumuzu yazıyoruz.
            cmd.ExecuteNonQuery();
        }

        private void kayıtlarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitGoruntule kayitshow = new KayitGoruntule();
            this.Hide();
            kayitshow.Show();
        }



        /* try
         {
             kartnumtx.Text = serialPort1.ReadLine();



         }
         catch (Exception ex)
         {
             MessageBox.Show(ex.Message); // basarısız olursa hata verecek.

         }
         */

    }
}
