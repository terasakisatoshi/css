using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMemo
{
    public partial class MyMemo : Form
    {
        const string ApplicationName = "MyMemo";
        const string emptyFileName = "";
        const string RegistryKey = @"TerasakiSoftware" + ApplicationName;
        private string currentFilePath;
        /*プロパティの五十川にあって値を保持する変数．
        他の部分からは必ずプロパティを介して読み書きすると決める．
        */
        private string currentFileNameValue;
        private string currentFileName
        {
            get { return currentFileNameValue; }
            set
            {
                currentFileNameValue = value;
                if(value != emptyFileName)
                {
                    currentFilePath = System.IO.Path.GetDirectoryName(value);
                }
                Edited = false;
            }
        }

        private bool EditedValue;
        private bool Edited
        {
            get { return EditedValue; }
            set
            {
                EditedValue = value;
                UpdateStatus();
            }
        }

        private void UpdateStatus()
        {
            string s = ApplicationName;
            if (currentFileName != emptyFileName)
            {
                s += " - " + System.IO.Path.GetFileName(currentFileName);
            }
            if (Edited)
            {   
                s += " - " + System.IO.Path.GetFileName(currentFileName) + "*";
                MenuItemFileSave.Enabled = true;
                MenuItemFileSaveAs.Enabled = true;
            }
            else
            {
                MenuItemFileSave.Enabled = false;
                MenuItemFileSaveAs.Enabled = false;
            }
            //Form の名前を読み込んだファイルとする．
            this.Text = s;
        }
        public MyMemo()
        {
            InitializeComponent();
        }

        private void MenuItemFileExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void MyMemo_Load(object sender, EventArgs e)
        {
            // 起動時の初期設定のコードをここに記述してください．
            currentFileName = emptyFileName;
            textBoxMain.Multiline = true;
            textBoxMain.ScrollBars = ScrollBars.Vertical;
            textBoxMain.Dock = DockStyle.Fill;
            saveFileDialog1.Filter = "テキスト文書|*.txt|すべてのファイル|*.*";

            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegistryKey);
            currentFilePath = regKey.GetValue("currentFilePath", System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).ToString();

            fontDialog1.ShowEffects = false;
            fontDialog1.AllowScriptChange = false;

            if (1 < Environment.GetCommandLineArgs().Length)
            {
                string[] args = Environment.GetCommandLineArgs();
                LoadFile(args[1]);
            }
        }

        private void MenuItemFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (!AskGiveUpText())
            {
                return;
            }
            else
            {
                openFileDialog1.InitialDirectory = currentFilePath;
                openFileDialog1.FileName = "";
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    LoadFile(openFileDialog1.FileName);
                }
            }
        }
        /**
        value で指定したPathの存在を確認しファイルをロードする．
        */
        private void LoadFile(string value)
        {
            if (System.IO.File.Exists(value))
            {

            textBoxMain.Text = System.IO.File.ReadAllText(
                value, System.Text.Encoding.GetEncoding("Shift_JIS"));
            currentFileName = value;
            //text の全選択を防ぐための対応
            textBoxMain.Select(0, 0);
            }
            else
            {
                MessageBox.Show(value + " not found",ApplicationName);
            }
        }

        private void MenuItemFileSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = currentFilePath;
            saveFileDialog1.FileName = System.IO.Path.GetFileName(currentFileName);
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                SaveFile(saveFileDialog1.FileName);
            }
        }

        private void SaveFile(string value)
        {
            System.IO.File.WriteAllText(value, textBoxMain.Text, System.Text.Encoding.GetEncoding("Shift_JIS"));
            currentFileName = value;
        }

        private void MenuItemFileSave_Click(object sender, EventArgs e)
        {
            if (System.IO.Path.GetFileName(currentFileName)==emptyFileName)
            {
                MenuItemFileSaveAs_Click(sender, e);
            }
            else
            {
                SaveFile(currentFileName);
            }
        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {
            Edited = true;
        }

        private void MyMemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AskGiveUpText())
            {
                e.Cancel = true;
            }
        }


        private bool AskGiveUpText()
        {
            if (!Edited || textBoxMain.TextLength == 0)
            {
                return true;
            }
            if (DialogResult.Yes == MessageBox.Show("編集内容を破棄しますか？？",ApplicationName,MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
            {
                return true;
            }            
            else
            {
                return false;
            }
        }

        private void MenuItemFIleNew_Click(object sender, EventArgs e)
        {
            if (!AskGiveUpText())
            {
                return;
            }
            textBoxMain.Clear();
            currentFileName = emptyFileName;
        }

        private void MyMemo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegistryKey);
            regKey.SetValue("currentFilePath", currentFilePath);
        }

        private void MenuItemFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBoxMain.Font;
            if (DialogResult.OK == fontDialog1.ShowDialog())
            {
                textBoxMain.Font = fontDialog1.Font;
            }

        }
    }
}
