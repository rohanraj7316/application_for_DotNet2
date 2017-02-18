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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string user = null;
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=ORACALDB;Persist Security Info=True;User ID=scott;Password=tiger;Unicode=True");
        OleDbConnection con1 = new OleDbConnection("Provider=MSDAORA;Data Source=ORACALDB;Persist Security Info=True;User ID=scott;Password=tiger;Unicode=True");
        OleDbConnection con2 = new OleDbConnection("Provider=MSDAORA;Data Source=ORACALDB;Persist Security Info=True;User ID=scott;Password=tiger;Unicode=True");
        OleDbConnection con3 = new OleDbConnection("Provider=MSDAORA;Data Source=ORACALDB;Persist Security Info=True;User ID=scott;Password=tiger;Unicode=True");
        OleDbConnection con4 = new OleDbConnection("Provider=MSDAORA;Data Source=ORACALDB;Persist Security Info=True;User ID=scott;Password=tiger;Unicode=True");


        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string uname = username.Text;
                string pass = password.Text;
            

            
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;


                    tabControl1.Visible = true;
                    label5.Text = uname.ToUpper();
                    try
                    {
                        con1.Open();
                        OleDbCommand cmd1 = new OleDbCommand("SELECT * FROM MYINFO WHERE USNAME ='"+uname+"'", con1);
                        OleDbDataReader reader = cmd1.ExecuteReader();

                        
                            while (reader.Read())
                            {

                                label5.Text = (reader["USNAME"].ToString());
                                fathername.Text = (reader["FNAME"].ToString());
                                mothername.Text = (reader["MNAME"].ToString());
                                add1.Text = (reader["ADDR"].ToString());
                                city.Text = (reader["CITY"].ToString());
                                state.Text = (reader["STATE"].ToString());
                                pin.Text = (reader["PIN"].ToString());
                                label6.Text = (reader["ENROLLNO"].ToString());

                            }

                        
                        
                    }

                    catch (Exception ob)
                    {
                        MessageBox.Show("error occurs" + ob, "alert");
                    }
                    finally
                    {
                        con1.Close();
                    }

                    try
                    {
                        con2.Open();
                        OleDbDataAdapter oledb = new OleDbDataAdapter("select * from LIB", con2);
                        DataTable dt1 = new DataTable();
                        oledb.Fill(dt1);
                        dataGridView1.DataSource = dt1;
                        con2.Close();

                    }catch(Exception ob )
                    {
                        MessageBox.Show("error in table binding", "alert");
                    }
                    try
                    {
                        con3.Open();
                        OleDbDataAdapter ol4 = new OleDbDataAdapter("select * from FEE WHERE USNAME='" + uname + "'", con3);
                        DataTable dt2 = new DataTable();
                        ol4.Fill(dt2);
                        dataGridView2.DataSource = dt2;
                       
                        con3.Close();
                    }catch(Exception ob)
                    {
                        MessageBox.Show("error in binding of fee data", "alert");
                    }
                    try
                    {
                        con4.Open();
                        OleDbCommand cmd134 = new OleDbCommand("SELECT * FROM ATTEN WHERE USNAME ='" + uname + "'", con4);
                        OleDbDataReader reader12 = cmd134.ExecuteReader();


                        while (reader12.Read())
                        {

                            label35.Text = (reader12["COA"].ToString());
                            label26.Text = (reader12["CN"].ToString());
                            label28.Text = (reader12["CG"].ToString());
                            label30.Text = (reader12["PLCC"].ToString());
                            label32.Text = (reader12["NET"].ToString());
                            label34.Text = (reader12["HOI"].ToString());
                            label21.Text = (reader12["CGPA"].ToString());
                            

                        }
                        con4.Close();
                    }catch(Exception ob34)
                    {
                        MessageBox.Show("attendance error", "alert");
                    }
               
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = label5.Text;
                con.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO LFORM VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'," + Convert.ToInt64(textBox5.Text) + "," + Convert.ToInt64(textBox6.Text) + ",'" + textBox7.Text + "','" + textBox8.Text + "')", con);
                cmd.ExecuteNonQuery();
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;
                textBox8.Text = null;
                
            }
            catch (Exception ob)
            {
                MessageBox.Show("error "+ ob, "alert");
            }
            finally
            {
                MessageBox.Show(" data has been updated ","message");
                con.Close();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void state_Click(object sender, EventArgs e)
        {

        }

        private void city_Click(object sender, EventArgs e)
        {

        }

        private void pin_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
    }
}
