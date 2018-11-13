using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Kill6DirInExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 注意 平台目標: X64 ,  否則全設到 SOFTWARE\Wow6432Node
            InitializeComponent();
        }

        static string subKey64 = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\";
        static string subKey32 = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\";
        static string key3dObject = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace";
        static string propertyBag = @"\PropertyBag";
        static string ThisPCPolicy = @"ThisPCPolicy";

        static string idDesktop = "{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}";
        static string idPictures = "{0ddd015d-b06c-45d5-8c4c-f59713854639}";
        static string idVideos = "{35286a68-3c57-41a1-bbb1-0eae73d76c95}";
        static string idMusic = "{a0c69a99-21c8-4671-8703-7934162fcf1d}";
        static string idDownloads = "{7d83ee9b-2244-4e70-b1f5-5393042af1e4}";
        static string idDocuments = "{f42ee2d3-909f-4907-8871-4c22fc0bf756}";
        static string id3dObjects = "{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}";

        RegistryKey key64 = Registry.LocalMachine.OpenSubKey(subKey64);
        RegistryKey key32 = Registry.LocalMachine.OpenSubKey(subKey32);


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ShowPolicy(idDesktop    , cBoxDesktop);
                ShowPolicy(idPictures   , cBoxPictures);
                ShowPolicy(idVideos     , cBoxVideos);
                ShowPolicy(idMusic      , cBoxMusic);
                ShowPolicy(idDownloads  , cBoxDownloads);
                ShowPolicy(idDocuments  , cBoxDocuments);

                RegistryKey key3d = Registry.LocalMachine.OpenSubKey(key3dObject);
                Show3dObjectPolicy(cBox3dObject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("本程式必需在系統管理員權限下執行!");
            };
        }



        void SetCheckBoxStatus(RegistryKey subKey, CheckBox box)
        {
            object obj = subKey.GetValue(ThisPCPolicy);
            string[] title = box.Text.Split(' ');
            if (obj != null && obj.GetType() == typeof(string))
            {
                string result = obj.ToString();
                box.Text = title[0] + " " + result;
                if (result == "Show") box.Checked = false;
                else box.Checked = true;
            }
            else box.Text = title[0] + " Error";
        }

        void ShowPolicy(string id, CheckBox box)
        {
            RegistryKey subKey;
            subKey = key64.OpenSubKey(id + propertyBag, true);
            SetCheckBoxStatus(subKey, box);
        }

        void Show3dObjectPolicy(CheckBox box)
        {
            RegistryKey key3d = Registry.LocalMachine.OpenSubKey(key3dObject);
            RegistryKey key3dSub = key3d.OpenSubKey(id3dObjects);
            if (key3dSub != null)
            {
                box.Text = "3D物件 Show";
                box.Checked = false;
            }
            else
            {
                box.Text = "3D物件 Hide";
                box.Checked = true;
            }
        }

        void SetPolicyValue(string id, CheckBox box)
        {
            string val = "Show";
            if (box.Checked) val = "Hide";
            RegistryKey subKey   = key64.OpenSubKey(id + propertyBag, true);
            RegistryKey subKey32 = key32.OpenSubKey(id + propertyBag, true);
            subKey.SetValue(ThisPCPolicy, val);
            subKey32.SetValue(ThisPCPolicy, val);

            SetCheckBoxStatus(subKey, box);
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
                RegistryKey key3d = Registry.LocalMachine.OpenSubKey(key3dObject,true);
                RegistryKey key3dSub = key3d.OpenSubKey(id3dObjects);
                if (cBox3dObject.Checked)
                {
                    if (key3dSub != null)
                        key3d.DeleteSubKey(id3dObjects, true);
                }
                else
                {
                    if (key3dSub == null)
                        key3d.CreateSubKey(id3dObjects, true);
                }
                Show3dObjectPolicy(cBox3dObject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("本程式必需在系統管理員權限下執行!");
            };

        }

    }
}
