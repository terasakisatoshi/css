namespace MyMemo
{
    partial class MyMemo
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFIleNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFIleSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFIleNew,
            this.MenuItemFileOpen,
            this.MenuItemFileSave,
            this.MenuItemFileSaveAs,
            this.MenuFIleSeparator,
            this.MenuItemFileExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(69, 29);
            this.MenuItemFile.Text = "File(&F)";
            // 
            // MenuItemFIleNew
            // 
            this.MenuItemFIleNew.Name = "MenuItemFIleNew";
            this.MenuItemFIleNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuItemFIleNew.Size = new System.Drawing.Size(230, 30);
            this.MenuItemFIleNew.Text = "New(&N)";
            this.MenuItemFIleNew.Click += new System.EventHandler(this.MenuItemFIleNew_Click);
            // 
            // MenuItemFileOpen
            // 
            this.MenuItemFileOpen.Name = "MenuItemFileOpen";
            this.MenuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemFileOpen.Size = new System.Drawing.Size(230, 30);
            this.MenuItemFileOpen.Text = "Open(&O)";
            this.MenuItemFileOpen.Click += new System.EventHandler(this.MenuItemFileOpen_Click);
            // 
            // MenuItemFileSave
            // 
            this.MenuItemFileSave.Name = "MenuItemFileSave";
            this.MenuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemFileSave.Size = new System.Drawing.Size(230, 30);
            this.MenuItemFileSave.Text = "Save(&S)";
            this.MenuItemFileSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
            // 
            // MenuItemFileSaveAs
            // 
            this.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs";
            this.MenuItemFileSaveAs.Size = new System.Drawing.Size(230, 30);
            this.MenuItemFileSaveAs.Text = "SaveAs(&A)";
            this.MenuItemFileSaveAs.Click += new System.EventHandler(this.MenuItemFileSaveAs_Click);
            // 
            // MenuFIleSeparator
            // 
            this.MenuFIleSeparator.Name = "MenuFIleSeparator";
            this.MenuFIleSeparator.Size = new System.Drawing.Size(227, 6);
            // 
            // MenuItemFileExit
            // 
            this.MenuItemFileExit.Name = "MenuItemFileExit";
            this.MenuItemFileExit.Size = new System.Drawing.Size(230, 30);
            this.MenuItemFileExit.Text = "Exit(&X)";
            this.MenuItemFileExit.Click += new System.EventHandler(this.MenuItemFileExit_Click);
            // 
            // textBoxMain
            // 
            this.textBoxMain.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.textBoxMain.Location = new System.Drawing.Point(12, 36);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(100, 31);
            this.textBoxMain.TabIndex = 2;
            this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MenuItemSetting
            // 
            this.MenuItemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFont});
            this.MenuItemSetting.Name = "MenuItemSetting";
            this.MenuItemSetting.Size = new System.Drawing.Size(100, 29);
            this.MenuItemSetting.Text = "Setting(&S)";
            // 
            // MenuItemFont
            // 
            this.MenuItemFont.Name = "MenuItemFont";
            this.MenuItemFont.Size = new System.Drawing.Size(211, 30);
            this.MenuItemFont.Text = "Font";
            this.MenuItemFont.Click += new System.EventHandler(this.MenuItemFont_Click);
            // 
            // MyMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 471);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyMemo";
            this.Text = "MyMemo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyMemo_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyMemo_FormClosed);
            this.Load += new System.EventHandler(this.MyMemo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileExit;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFIleNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator MenuFIleSeparator;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFont;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

