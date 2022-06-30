using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Covid_Register
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sqlserver.dynamicdna.co.za;Initial Catalog=Covid-Register-Innocent;User ID=BBD;Password=");
        public Form1()
        {
            InitializeComponent();
        }

        private void registerB_Click(object sender, EventArgs e)
        {
            if (fnameT.Text.Length > 0 && numberT.Text.Length > 0 && tempT.Text.Length > 0 && idT.Text.Length > 0)
            {
                try
                {
                    con.Open();
                     SqlCommand com = new SqlCommand("INSERT INTO [Covid-19](ID_Number,FullName,Phone_Number,Temperature,Date,Gender, Physical_Address) VALUES('" + idT.Text + "','" + fnameT.Text + "','" + numberT.Text + "','" +tempT.Text+ "','" + datePicker.Value + "','" + genderCmb.SelectedItem + "', '"+addressRtxb.Text+"')", con);

                    try
                    {
                  

                    com.ExecuteNonQuery();
                    datePicker.Value = DateTime.Now;
                    MessageBox.Show("Registered for covid");
                    fnameT.Clear();
                    tempT.Clear();
                    numberT.Clear();
                    idT.Clear();
                    fnameT.Focus();
                    addressRtxb.Clear();
                    genderCmb.SelectedItem = null;

                }
                    catch (Exception ex )
                    {

                    MessageBox.Show("Failed to connect to the database" + ex.Message);
                }

                    con.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Failed to connect to the database");
                }
            }
            else
                MessageBox.Show("Please fill all the fields");
        }
    }
}
