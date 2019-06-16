using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.IO;
using ConvertorApp.Forms;

namespace ConvertorApp
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

        }

        private void OnArchive(object sender, EventArgs e) => new ArchiveForm().Show();

        private void OnAbout(object sender, EventArgs e) => new AboutForm().Show();

        private void OnSend(object sender, EventArgs e)
        {

            byte[] bytes = new byte[1024];
                    
            IPAddress ipAddr = IPAddress.Loopback;
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 8080);

            using (Socket sndr = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp))
            {
                sndr.Connect(ipEndPoint);

                string[] arrX = xTextbox.Text.Split(',');
                string[] arrY = yTextbox.Text.Split(',');


                if (arrX.Length == arrY.Length && arrX.Length !=0)
                {
                    string message = xTextbox.Text + "|" + yTextbox.Text;

                    byte[] msg = Encoding.UTF8.GetBytes(message);


                    int bytesSent = sndr.Send(msg);
                    int bytesRec = sndr.Receive(bytes);
                    string result = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                    serverTextbox.Text = result;
                    SaveToDB(xTextbox.Text, yTextbox.Text, result);
                }
                else
                {
                    MessageBox.Show("Incorrect data!", "Error");
                }

            
            }

        }

        private void SaveToDB(string arrX, string arrY, string coeff)
        {
            
           if ( coeff != null)
           {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
                builder.AttachDBFilename = @"E:\6 семестр\C sharp\ExamProject\ConvertorApp\ConvertorApp\ConvertDB.mdf";
                builder.IntegratedSecurity = true;
                
                using (IDbConnection connection = new SqlConnection(builder.ConnectionString))
                using (ConvertDBDataContext db = new ConvertDBDataContext(connection))
                {
                Archive row = new Archive()
                {
                    arrayX = arrX,
                    arrayY = arrY,
                    coefficient = coeff
                };

                    db.Archive.InsertOnSubmit(row);
                    db.SubmitChanges();

                }   

           }
        }

        private void OnClear(object sender, EventArgs e)
        {
            xTextbox.Clear();
            yTextbox.Clear();
            serverTextbox.Clear();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar == 189)
             e.Handled = true;
        }
    }
}
