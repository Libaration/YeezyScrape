using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using MetroFramework;
using MetroFramework.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : MetroForm
    {
        string usersloop = null;
        WebClient web = new WebClient();
         
        private string htmlloop = null;
        List<string> users = new List<string>();

        public Form1()
        {
            web.Encoding = Encoding.UTF8;
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pageNum1.Maximum = Decimal.MaxValue;
            pageNum2.Maximum = Decimal.MaxValue;
            
            //listUsers.Items.Add("TestAccount");
            //listUsers.Items.Add("Hi Im Gosu");
            //listUsers.Items.Add("CLG Doublelift");
            //listUsers.Items.Add("BehkuhTV");
        }

        private void btnScrape_Click(object sender, EventArgs e)
        {
            
           
          
        }

        private void grabUsers()
        {
            if (listUsers.InvokeRequired)
            {
                MethodInvoker txtUsersInvoker = new MethodInvoker(grabUsers);
                listUsers.Invoke(txtUsersInvoker);
            }
            else
            {
                if (pageNum1.Value > pageNum2.Value | cmbServerMetro.Text == "")
                {
                    MetroMessageBox.Show(this, "Recheck your fields", "YeezyScrape - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    try
                    {
                        int pageNum1int = Convert.ToInt32(pageNum1.Value);
                        int pageNum2int = Convert.ToInt32(pageNum2.Value);

                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "Numbers too big", "YeezyScrape - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       
                    }
                        for (int i = Convert.ToInt32(pageNum1.Value); i < pageNum2.Value; i++)
                        {

                            btnScrapeMetro.Enabled = false;
                            progbarMetro.Maximum = Convert.ToInt32(pageNum2.Value) - 1;

                            string link = ("http://www.lolsummoners.com/ladders/" + cmbServerMetro.Text + "/") +
                                          i.ToString();
                            htmlloop = web.DownloadString(link);
                            sortUsers(htmlloop);

                            progbarMetro.Value = i;

                    }
                    btnScrapeMetro.Enabled = true;
                    progbarMetro.Visible = false;
                    btnSaveMetro.Visible = true;
                    MetroMessageBox.Show(this, "Scrape completed", "YeezyScrape - Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            
        }

        private void sortUsers(string htmlloop)
        {
            MatchCollection m1loop = Regex.Matches(htmlloop, @"name""><a href=""/leagues/.{2,4}/[0-9]+"">\s*(.+?)\s*</a></td>", RegexOptions.Singleline);
            foreach (Match m in m1loop)
            {

                usersloop = m.Groups[1].Value;

                bool hasspace = usersloop.Contains(" ");

                if (hasspace == false)
                {
                    users.Add(usersloop);
                    listUsers.Items.Add(usersloop);


                    updateStatus();
                }
              
               
            }

            
        }

        


        private void updateStatus()
        {

            label1Metro.Text = ("Count ( " + users.Count + " )");
            
        }

        private void saveUsers()
        {

            const string savePath = "accounts.txt";

            StreamWriter SaveFile = new System.IO.StreamWriter(savePath);


            if (chkUserPassMetro.Checked == true & chkCommonMetro.Checked == true)
            {
                foreach (var item in listUsers.Items)
                {

                    SaveFile.WriteLine(item + ":" + item);
                    SaveFile.WriteLine(item + ":" + "1" + item);
                    SaveFile.WriteLine(item + ":" + "12" + item);
                    SaveFile.WriteLine(item + ":" + "123" + item);
                    SaveFile.WriteLine(item + ":" + "1234" + item);
                    SaveFile.WriteLine(item + ":" + item + "1");
                    SaveFile.WriteLine(item + ":" + item + "12");
                    SaveFile.WriteLine(item + ":" + item + "123");
                    SaveFile.WriteLine(item + ":" + item + "1234");
                    SaveFile.WriteLine(item + ":" + "letmein");
                    SaveFile.WriteLine(item + ":" + "trustno1");
                    SaveFile.WriteLine(item + ":" + "qwerty123456");
                    SaveFile.WriteLine(item + ":" + "123456qwerty");
                    SaveFile.WriteLine(item + ":" + "123456789a");
                    SaveFile.WriteLine(item + ":" + "123456a");
                }
            }

            if (chkUserPassMetro.Checked == false & chkCommonMetro.Checked == false)
            {
                foreach (var item in listUsers.Items)
                {

                    SaveFile.WriteLine(item);
                }
            }



            if (chkUserPassMetro.Checked == true & chkCommonMetro.Checked == false)
            {
                foreach (var item in listUsers.Items)
                {

                    SaveFile.WriteLine(item + ":" + item);
                }
            }

            if (chkUserPassMetro.Checked == false & chkCommonMetro.Checked == true)
            {
                foreach (var item in listUsers.Items)
                {
                    SaveFile.WriteLine(item + ":" + "1" + item);
                    SaveFile.WriteLine(item + ":" + "12" + item);
                    SaveFile.WriteLine(item + ":" + "123" + item);
                    SaveFile.WriteLine(item + ":" + "1234" + item);
                    SaveFile.WriteLine(item + ":" + item + "1");
                    SaveFile.WriteLine(item + ":" + item + "12");
                    SaveFile.WriteLine(item + ":" + item + "123");
                    SaveFile.WriteLine(item + ":" + item + "1234");
                    SaveFile.WriteLine(item + ":" + "letmein");
                    SaveFile.WriteLine(item + ":" + "trustno1");
                    SaveFile.WriteLine(item + ":" + "qwerty123456");
                    SaveFile.WriteLine(item + ":" + "123456qwerty");
                    SaveFile.WriteLine(item + ":" + "123456789a");
                    SaveFile.WriteLine(item + ":" + "123456a");
                    
                }
            }
            SaveFile.Close();

            MetroMessageBox.Show(this, "List saved to " + savePath, "YeezyScrape - Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            

        }

        private void btnSaveOptions_Click(object sender, EventArgs e)
        {
            if (this.Height == 612)
            {
                this.Height = 912;
                btnSaveOptions.Text = "Hide Save Options";
            }
            else
            {
                this.Height = 612;
                btnSaveOptions.Text = "Show Save Options";
            }
            

        }

        private void btnScrapeMetro_Click(object sender, EventArgs e)
        {
            Thread grabUsersThread = new Thread(new ThreadStart(grabUsers));
            grabUsersThread.Start();
            progbarMetro.Visible = true;
            label1Metro.Visible = true;
            
        }

        private void btnSaveMetro_Click(object sender, EventArgs e)
        {
            saveUsers();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

            
        }


        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       

    }
}
