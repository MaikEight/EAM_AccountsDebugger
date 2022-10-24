using MK_EAM_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAM_AccountsDebugger
{
    public partial class FrmMain : Form
    {
        public static readonly string saveFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExaltAccountManager");
        public readonly string accountsPath = Path.Combine(saveFilePath, "EAM.accounts");

        BindingList<MK_EAM_Lib.AccountInfo> accounts = new BindingList<MK_EAM_Lib.AccountInfo>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tbPath.Text = accountsPath;
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            int h = ((btnStart.Top - btnChangePath.Bottom) / 2) + btnChangePath.Bottom;

            using (Pen p = new Pen(this.ForeColor, 1f))
            {
                e.Graphics.DrawLine(p, btnChangePath.Left, h, tbPath.Right, h);
            }
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog()
            {
                Title = "Please select your EAM.accounts file.",
                Multiselect = false,
                InitialDirectory = accountsPath,
                Filter = "Accounts files (EAM.accounts)|EAM.accounts|All files (*.*)|*.*"
            };

            if (diag.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = diag.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            rtbOut.Clear();
            tbPath.ReadOnly = true;

            Log("Start processing the file: " + tbPath.Text);

            if (!File.Exists(tbPath.Text))
            {
                Log("Can't find the selected file, aborting.");
                Log("Please try again.");

                tbPath.ReadOnly = false;
                return;
            }
            Log("File found, reading...");

            try
            {
                byte[] data = File.ReadAllBytes(tbPath.Text);
                Log("Reading: Success");
                Log("Converting to AccountSaveFile...");
                AccountSaveFile saveFile = (AccountSaveFile)ByteArrayToObject(data);
                Log("AccountSaveFile: Success");

                Log($"AccountSaveFile:{Environment.NewLine}" +
                    $"Version: {saveFile.version}{Environment.NewLine}" +
                    $"Error: {saveFile.error}{Environment.NewLine}" +
                    $"Entropy: {saveFile.entropy.Length}");

                Log("Decrypting saveFile...");
                List<AccountInfo> acc = AccountSaveFile.Decrypt(saveFile);
                Log("Decrypting: Success");

                Log($"AccountInfos count: {acc.Count}");

                Log("Creating a new BindingList with AccountInfos...");
                accounts = new BindingList<MK_EAM_Lib.AccountInfo>(acc);
                Log("BindingList creation: Success" + Environment.NewLine);

                Log("Accountlist:");

                for (int i = 0; i < accounts.Count; i++)
                {
                    Log(accounts[i].email);
                    Log(accounts[i].password + Environment.NewLine);
                }

                Log("Done!");
            }
            catch (Exception ex)
            {
                Log("Caught an exception: " + Environment.NewLine + ex.Message + Environment.NewLine + Environment.NewLine + ex.StackTrace);
                Log("Please scramble any account-related informations and forward this log to Maik8.");
            }
            finally
            {
                tbPath.ReadOnly = false;
            }
        }

        private void Log(string msg)
        {
            rtbOut.AppendText($"{DateTime.Now.ToString("HH:mm:ss")}: {msg}{Environment.NewLine}");
        }

        public object ByteArrayToObject(byte[] arrBytes)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                BinaryFormatter binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                object obj = (object)binForm.Deserialize(memStream);

                return obj;
            }
        }
    }
}
