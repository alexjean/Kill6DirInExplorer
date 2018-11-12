using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Kill6DirInExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string subKey64 = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\";
        string subKey32 = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\";
        string key3dObject = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace";
        string propertyBag  = @"\PropertyBag";
        string ThisPCPolicy  = @"ThisPCPolicy";

        string idDesktop   = "{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}";
        string idPictures  = "{0ddd015d-b06c-45d5-8c4c-f59713854639}";
        string idVideos    = "{35286a68-3c57-41a1-bbb1-0eae73d76c95}";
        string idMusic     = "{a0c69a99-21c8-4671-8703-7934162fcf1d}";
        string idDownloads = "{7d83ee9b-2244-4e70-b1f5-5393042af1e4}";
        string idDocuments   = "{f42ee2d3-909f-4907-8871-4c22fc0bf756}";
        string id3DObjects = "{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}";

        void SetPolicyValue(string id,CheckBox box)
        {
            RegistryKey subKey;
            subKey = Registry.LocalMachine.OpenSubKey(subKey64 + id + propertyBag, true);
            string val = "Show";
            if (box.Checked) val = "Hide";
            subKey.SetValue(ThisPCPolicy, val);
            object obj=subKey.GetValue(ThisPCPolicy);
            string[] title=box.Text.Split(' ');
            if (obj!=null && obj.GetType()==typeof(string))
            {
                string result = obj.ToString();
                box.Text = title[0] + " " + result;
            }
            else box.Text = title[0] + " Error";
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            try
            {
                SetPolicyValue(idDesktop    , cBoxDesktop);
                SetPolicyValue(idPictures   , cBoxPictures);
                SetPolicyValue(idVideos     , cBoxVideos);
                SetPolicyValue(idMusic      , cBoxMusic);
                SetPolicyValue(idDownloads  , cBoxDownloads);
                SetPolicyValue(idDocuments  , cBoxDocuments);
                RegistryKey key3d = Registry.LocalMachine.OpenSubKey(key3dObject);
                if (cBox3DObject.Checked)
                    key3d.DeleteSubKey(id3DObjects);
                else
                    key3d.CreateSubKey(id3DObjects);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("本程式必需在系統管理員權限下執行!");
            };

        }
    }
}
