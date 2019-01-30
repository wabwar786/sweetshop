using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FSM
{
    public partial class update_check : Form
    {
        public static string status_download = "";
        
        private readonly CheckForUpdate checkForUpdate = null;

        public update_check()
        {
            InitializeComponent();
           this.checkForUpdate = new CheckForUpdate(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.checkForUpdate.OnCheckForUpdate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           this.checkForUpdate.StopThread();
        }

       public bool OnCheckForUpdateFinished(DownloadedVersionInfo versionInfo)
       {
            if ((versionInfo.error) || (versionInfo.installerUrl.Length == 0) || (versionInfo.latestVersion == null))
            {
                MessageBox.Show(this, "Error while looking for the newest version", "Check for updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Version curVer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if (curVer.CompareTo(versionInfo.latestVersion) >= 0)
            {
               lblupdatestatus.Text = "No new version detected, Try again later";
               return false;
            }

           string str = String.Format("New version found!\nYour version: {0}.\nNewest version: {1}.", curVer, versionInfo.latestVersion);
           
          
           return DialogResult.Yes == MessageBox.Show(this, str, "Check for updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
           
        }

        public void OnDownloadInstallerinished(DownloadInstallerInfo info)
        {
            if (info.error)
            {
                MessageBox.Show(this, "Error while downloading the installer", "Check for updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DialogResult.Yes != MessageBox.Show(this, "Do you know to install the newest version?", "Check for updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
               try
                {
                    File.Delete(info.path);
                }
                catch { }
                return;
            }
            try
            {
                Process.Start(info.path);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error while running the installer.", "Check for updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    File.Delete(info.path);
                }
                catch { }
                return;
            }
            return;
        }

       


    }
}
