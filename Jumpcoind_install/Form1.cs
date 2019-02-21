using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using Microsoft.VisualBasic;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Net;



//Thanks to WlanWerner(https://github.com/WlanWerner)

namespace Jumpcoin_install_win
{
    public partial class Form1 : Form
    {

        // create variables
        public string ip;
        public string username;
        public string password;
        public string genkey;
        public string output;
        public string output_after;
        public string masternodename;
        public string port;
        public string rpcuser;
        public string rpcpassword;
        public Int16 test = 0;


        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("I take no responsibility for this program." + "\r\n"
                      + "Use this program with caution." + "\r\n"
                      + "I take no responsibility for lost coins and/or their VPS." + "\r\n"
                      + "I can't get in touch with their coins." + "\r\n"
                      + "Please encrypt your wallet anyway and make a note of your password." + "\r\n"
                      + "Check also my Code(it's open Source) and don't flame I'm a student :D", "Information");
        }

        /// <summary>
        /// Start the RunCommand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void button1_Click(object sender, EventArgs e)
        {
            new Task(() => RunCommand()).Start();
        }

        /// <summary>
        /// Installs the jumpcoind with (if wanted) cronjob 
        /// </summary>
        private void RunCommand()
        {


            //load all variables

            ip = ip_feld.Text;
            username = username_feld.Text;
            password = password_feld.Text;
            port = port_feld.Text;
            rpcuser = RpcUser_feld.Text;
            rpcpassword = RpcPassword_feld.Text;
            string TEMP_PATH = Path.GetTempPath();


            /// <summary>
            /// The Part with cron
            /// </summary>

            if (startup_checkbox.Checked)
            {
                using (var client = new SshClient(ip, Convert.ToInt16(port), username, password))
                {

                    // check if everything givem
                    try
                    {
                        client.Connect();
                    }
                    catch
                    {
                        MessageBox.Show("Please fill out the IP, user, password, rpcuser and rpcpassword!");  //if not
                        return;
                    }


                    // Crappy way!! I don't know how to transfer a lokal variable to the vps. So I create lokal a file with the genkey as name, upload it 
                    // to the vps and read the new created directory. The output is the genkey :D

                    var command = client.CreateCommand("mkdir /root/temp_jumpcoin_user/");
                    var result = command.BeginExecute();
                    command = client.CreateCommand("mkdir /root/temp_jumpcoin_password/");
                    result = command.BeginExecute();

                    //create the lokale file
                    if (!File.Exists(TEMP_PATH + rpcuser))
                    {
                        using (StreamWriter sw = new StreamWriter(Environment.ExpandEnvironmentVariables(TEMP_PATH + rpcuser), true))
                        {

                        }
                    }

                    if (!File.Exists(TEMP_PATH + rpcpassword))
                    {
                        using (StreamWriter sw = new StreamWriter(Environment.ExpandEnvironmentVariables(TEMP_PATH + rpcpassword), true))
                        {

                        }
                    }
                    client.Disconnect();
                }

                using (var client = new SftpClient(ip, Convert.ToInt16(port), username, password))
                {
                    client.Connect();

                    FileInfo f = new FileInfo(TEMP_PATH + rpcuser);
                    string uploadfile = f.FullName;

                    var fileStream = new FileStream(uploadfile, FileMode.Open);
                    if (fileStream != null)
                    {

                        client.UploadFile(fileStream, "/root/temp_jumpcoin_password/" + f.Name, null);
                        client.Disconnect();
                        client.Dispose();
                    }
                }

                using (var client = new SftpClient(ip, Convert.ToInt16(port), username, password))
                {
                    client.Connect();

                    FileInfo f = new FileInfo(TEMP_PATH + rpcpassword);
                    string uploadfile = f.FullName;

                    var fileStream = new FileStream(uploadfile, FileMode.Open);
                    if (fileStream != null)
                    {

                        client.UploadFile(fileStream, "/root/temp_jumpcoin_user/" + f.Name, null);
                        client.Disconnect();
                        client.Dispose();
                    }
                }



                // execute the ./jumpcoind install script (self-made)

                using (var client = new SshClient(ip, Convert.ToInt16(port), username, password))
                {

                    client.Connect();

                    var command = client.CreateCommand("./jumpcoind getblockcount");
                    var result = command.BeginExecute();
                    System.Threading.Thread.Sleep(500);
                    command = client.CreateCommand("sudo wget https://raw.githubusercontent.com/Roalkege/Jumpcoind_install_tool/master/jumpcoind_install_cron.sh && sudo bash jumpcoind_install_cron.sh");  //download the script
                    result = command.BeginExecute();

                    //log vps output 
                    using (var reader =
                       new StreamReader(command.OutputStream, Encoding.UTF8, true, 1024, true))
                    {
                        while (!result.IsCompleted || !reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            if (line != null)
                            {
                                log_feld.Invoke(
                                    (MethodInvoker)(() =>
                                        log_feld.AppendText(line + Environment.NewLine)));
                            }
                        }
                    }

                    command.EndExecute(result);
                    MessageBox.Show("Wallet installed.");
                    client.Disconnect();
                    
                }
            }


            /// <summary>
            /// The Part without cron
            /// </summary>
            else
            {

                using (var client = new SshClient(ip, Convert.ToInt16(port), username, password))
                {

                    // check if everything givem
                    try
                    {
                        client.Connect();
                    }
                    catch
                    {
                        MessageBox.Show("Please fill out the IP, user, password, rpcuser and rpcpassword!");  //if not
                        return;
                    }


                    // Crappy way!! I don't know how to transfer a lokal variable to the vps. So I create lokal a file with the genkey as name, upload it 
                    // to the vps and read the new created directory. The output is the genkey :D

                    var command = client.CreateCommand("mkdir /root/temp_jumpcoin_user/");
                    var result = command.BeginExecute();
                    command = client.CreateCommand("mkdir /root/temp_jumpcoin_password/");
                    result = command.BeginExecute();

                    //create the lokale file
                    if (!File.Exists(TEMP_PATH + rpcuser))
                    {
                        using (StreamWriter sw = new StreamWriter(Environment.ExpandEnvironmentVariables(TEMP_PATH + rpcuser), true))
                        {

                        }
                    }

                    if (!File.Exists(TEMP_PATH + rpcpassword))
                    {
                        using (StreamWriter sw = new StreamWriter(Environment.ExpandEnvironmentVariables(TEMP_PATH + rpcpassword), true))
                        {

                        }
                    }
                    client.Disconnect();
                }

                using (var client = new SftpClient(ip, Convert.ToInt16(port), username, password))
                {
                    client.Connect();

                    FileInfo f = new FileInfo(TEMP_PATH + rpcuser);
                    string uploadfile = f.FullName;

                    var fileStream = new FileStream(uploadfile, FileMode.Open);
                    if (fileStream != null)
                    {

                        client.UploadFile(fileStream, "/root/temp_jumpcoin_password/" + f.Name, null);
                        client.Disconnect();
                        client.Dispose();
                    }
                }

                using (var client = new SftpClient(ip, Convert.ToInt16(port), username, password))
                {
                    client.Connect();

                    FileInfo f = new FileInfo(TEMP_PATH + rpcpassword);
                    string uploadfile = f.FullName;

                    var fileStream = new FileStream(uploadfile, FileMode.Open);
                    if (fileStream != null)
                    {

                        client.UploadFile(fileStream, "/root/temp_jumpcoin_user/" + f.Name, null);
                        client.Disconnect();
                        client.Dispose();
                    }
                }



                // execute the ./jumpcoind install script (self-made)

                using (var client = new SshClient(ip, Convert.ToInt16(port), username, password))
                {

                    client.Connect();

                    var command = client.CreateCommand("./jumpcoind getblockcount");
                    var result = command.BeginExecute();
                    System.Threading.Thread.Sleep(500);
                    command = client.CreateCommand("sudo wget https://raw.githubusercontent.com/Roalkege/Jumpcoind_install_tool/master/jumpcoind_install.sh && sudo bash jumpcoind_install.sh");  //download the script
                    result = command.BeginExecute();

                    //log vps output 
                    using (var reader =
                       new StreamReader(command.OutputStream, Encoding.UTF8, true, 1024, true))
                    {
                        while (!result.IsCompleted || !reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            if (line != null)
                            {
                                log_feld.Invoke(
                                    (MethodInvoker)(() =>
                                        log_feld.AppendText(line + Environment.NewLine)));
                            }
                        }
                    }

                    command.EndExecute(result);

                    client.Disconnect();
                    MessageBox.Show("Wallet installed.");
                }




                //finish

            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Opens a new Form with Informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            //opens the help form
            //multi-language in future
            Jumpcoind_install.Help newForm2 = new Jumpcoind_install.Help();
            newForm2.ShowDialog();

        }

        /// <summary>
        /// checks the getblockcount output 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void button2_Click(object sender, EventArgs e)
        {

            //checks the output of the wallet

            ip = ip_feld.Text;
            port = port_feld.Text;
            username = username_feld.Text;
            password = password_feld.Text;

            //login and create connection
            using (var client = new SshClient(ip, Convert.ToInt16(port), username, password))
            {
                try
                {
                    client.Connect();
                }
                catch
                {
                    MessageBox.Show("Please fill out the IP, user and password!"); //If can't connect
                    return;
                }

                var command = client.CreateCommand("./jumpcoind getblockcount");
                var result = command.Execute();
                log_feld.Text = result;
                client.Disconnect();
            }
        }

        /// <summary>
        /// Restarts the jumpcoind process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restart_masternode_Click(object sender, EventArgs e)
        {
            //Get the informations
            ip = ip_feld.Text;
            port = port_feld.Text;
            username = username_feld.Text;
            password = password_feld.Text;

            //login and create connection


            using (var client = new SshClient(ip, Convert.ToInt16(port), username, password))
            {

                switch (MessageBox.Show("Attention this function is still in beta", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:

                        try
                        {
                            client.Connect();
                        }
                        catch
                        {
                            MessageBox.Show("Please fill out the IP, user and password!");  //If can't connect
                            return;
                        }

                        var command = client.CreateCommand("cd ~");
                        var result = command.Execute();
                        command = client.CreateCommand("./jumpcoind stop");  //stops the node
                        result = command.Execute();
                        System.Threading.Thread.Sleep(500);
                        //command = client.CreateCommand("killall ./jumpcoind");  // kills the node process
                        //result = command.Execute();
                        command = client.CreateCommand("./jumpcoind");  // starts the wallet
                        result = command.Execute();
                        log_feld.Text = "Wallet successful (re)startet";
                        client.Disconnect();
                        break;

                    case DialogResult.No: break;

                }

            }
        }

        private void startup_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //will be added in future
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Compares the current Veriosn with the online version
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_button_Click(object sender, EventArgs e)
        {
            var version_number = "Version 1.0.0";
            int c;




            string result = null;
            string url = "https://brocoin.world/Nick/version.txt";    //need new https adress to check for new Version
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                result = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                // handle error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            c = String.Compare(result, version_number);
            if (c == -1)
            {
                switch (MessageBox.Show("There is a Update available", "Update", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes: System.Diagnostics.Process.Start("http://jumpcoin.club"); ; break;
                    case DialogResult.No: break;
                }
            }
            else
            {
                MessageBox.Show("There is no Update available");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (startup_checkbox.Checked)
            {
                MessageBox.Show("true");
            }
            else
                MessageBox.Show("false");
        }
    }
}
