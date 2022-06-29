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
        SqlConnection con = new SqlConnection("");
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
                    SqlCommand com = new SqlCommand("", con);
                    try
                    {
                        com.ExecuteNonQuery();

                        MessageBox.Show("Successfully Registered");
                        //Clear all controls 
                        fnameT.Clear();
                        numberT.Clear();
                        tempT.Clear();
                        paddressRtxb.Clear();
                        genderCmb.SelectedItem = null;
                        datePicker.Value = DateTime.Now;

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Failed to register, please contact the system admin");
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
