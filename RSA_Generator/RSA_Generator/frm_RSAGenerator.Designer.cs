namespace RSA_Generator
{
    partial class frm_RSAGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RSAGenerator));
            this.lbl_SourceText = new DevExpress.XtraEditors.LabelControl();
            this.txt_SourceText = new DevExpress.XtraEditors.TextEdit();
            this.menu_SourceText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_Source_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Source_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Source_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Source_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Source_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_TargetText = new DevExpress.XtraEditors.LabelControl();
            this.txt_TargetText = new DevExpress.XtraEditors.TextEdit();
            this.menu_TargetText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_Target_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Target_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Target_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Target_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Target_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Encrypt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Decrypt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SourceText.Properties)).BeginInit();
            this.menu_SourceText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TargetText.Properties)).BeginInit();
            this.menu_TargetText.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SourceText
            // 
            this.lbl_SourceText.Location = new System.Drawing.Point(12, 9);
            this.lbl_SourceText.Name = "lbl_SourceText";
            this.lbl_SourceText.Size = new System.Drawing.Size(58, 13);
            this.lbl_SourceText.TabIndex = 0;
            this.lbl_SourceText.Text = "Source Text";
            // 
            // txt_SourceText
            // 
            this.txt_SourceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SourceText.EditValue = "";
            this.txt_SourceText.Location = new System.Drawing.Point(12, 28);
            this.txt_SourceText.Name = "txt_SourceText";
            this.txt_SourceText.Properties.ContextMenuStrip = this.menu_SourceText;
            this.txt_SourceText.Size = new System.Drawing.Size(448, 20);
            this.txt_SourceText.TabIndex = 2;
            this.txt_SourceText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_SourceText_MouseDown);
            // 
            // menu_SourceText
            // 
            this.menu_SourceText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Source_Cut,
            this.menu_Source_Copy,
            this.menu_Source_Paste,
            this.menu_Source_Clear,
            this.toolStripSeparator1,
            this.menu_Source_SelectAll});
            this.menu_SourceText.Name = "menu_SourceText";
            this.menu_SourceText.Size = new System.Drawing.Size(123, 120);
            // 
            // menu_Source_Cut
            // 
            this.menu_Source_Cut.Enabled = false;
            this.menu_Source_Cut.Image = ((System.Drawing.Image)(resources.GetObject("menu_Source_Cut.Image")));
            this.menu_Source_Cut.Name = "menu_Source_Cut";
            this.menu_Source_Cut.Size = new System.Drawing.Size(122, 22);
            this.menu_Source_Cut.Text = "Cut";
            this.menu_Source_Cut.Click += new System.EventHandler(this.menu_Source_Cut_Click);
            // 
            // menu_Source_Copy
            // 
            this.menu_Source_Copy.Enabled = false;
            this.menu_Source_Copy.Image = ((System.Drawing.Image)(resources.GetObject("menu_Source_Copy.Image")));
            this.menu_Source_Copy.Name = "menu_Source_Copy";
            this.menu_Source_Copy.Size = new System.Drawing.Size(122, 22);
            this.menu_Source_Copy.Text = "Copy";
            this.menu_Source_Copy.Click += new System.EventHandler(this.menu_Source_Copy_Click);
            // 
            // menu_Source_Paste
            // 
            this.menu_Source_Paste.Enabled = false;
            this.menu_Source_Paste.Image = ((System.Drawing.Image)(resources.GetObject("menu_Source_Paste.Image")));
            this.menu_Source_Paste.Name = "menu_Source_Paste";
            this.menu_Source_Paste.Size = new System.Drawing.Size(122, 22);
            this.menu_Source_Paste.Text = "Paste";
            this.menu_Source_Paste.Click += new System.EventHandler(this.menu_Source_Paste_Click);
            // 
            // menu_Source_Clear
            // 
            this.menu_Source_Clear.Enabled = false;
            this.menu_Source_Clear.Image = ((System.Drawing.Image)(resources.GetObject("menu_Source_Clear.Image")));
            this.menu_Source_Clear.Name = "menu_Source_Clear";
            this.menu_Source_Clear.Size = new System.Drawing.Size(122, 22);
            this.menu_Source_Clear.Text = "Clear";
            this.menu_Source_Clear.Click += new System.EventHandler(this.menu_Source_Clear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // menu_Source_SelectAll
            // 
            this.menu_Source_SelectAll.Enabled = false;
            this.menu_Source_SelectAll.Name = "menu_Source_SelectAll";
            this.menu_Source_SelectAll.Size = new System.Drawing.Size(122, 22);
            this.menu_Source_SelectAll.Text = "Select All";
            this.menu_Source_SelectAll.Click += new System.EventHandler(this.menu_Source_SelectAll_Click);
            // 
            // lbl_TargetText
            // 
            this.lbl_TargetText.Location = new System.Drawing.Point(12, 54);
            this.lbl_TargetText.Name = "lbl_TargetText";
            this.lbl_TargetText.Size = new System.Drawing.Size(57, 13);
            this.lbl_TargetText.TabIndex = 3;
            this.lbl_TargetText.Text = "Target Text";
            // 
            // txt_TargetText
            // 
            this.txt_TargetText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TargetText.Location = new System.Drawing.Point(12, 73);
            this.txt_TargetText.Name = "txt_TargetText";
            this.txt_TargetText.Properties.ContextMenuStrip = this.menu_TargetText;
            this.txt_TargetText.Size = new System.Drawing.Size(448, 20);
            this.txt_TargetText.TabIndex = 4;
            this.txt_TargetText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_TargetText_MouseDown);
            // 
            // menu_TargetText
            // 
            this.menu_TargetText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Target_Cut,
            this.menu_Target_Copy,
            this.menu_Target_Paste,
            this.menu_Target_Clear,
            this.toolStripSeparator2,
            this.menu_Target_SelectAll});
            this.menu_TargetText.Name = "contextMenuStrip1";
            this.menu_TargetText.Size = new System.Drawing.Size(123, 120);
            // 
            // menu_Target_Cut
            // 
            this.menu_Target_Cut.Enabled = false;
            this.menu_Target_Cut.Image = ((System.Drawing.Image)(resources.GetObject("menu_Target_Cut.Image")));
            this.menu_Target_Cut.Name = "menu_Target_Cut";
            this.menu_Target_Cut.Size = new System.Drawing.Size(122, 22);
            this.menu_Target_Cut.Text = "Cut";
            this.menu_Target_Cut.Click += new System.EventHandler(this.menu_Target_Cut_Click);
            // 
            // menu_Target_Copy
            // 
            this.menu_Target_Copy.Enabled = false;
            this.menu_Target_Copy.Image = ((System.Drawing.Image)(resources.GetObject("menu_Target_Copy.Image")));
            this.menu_Target_Copy.Name = "menu_Target_Copy";
            this.menu_Target_Copy.Size = new System.Drawing.Size(122, 22);
            this.menu_Target_Copy.Text = "Copy";
            this.menu_Target_Copy.Click += new System.EventHandler(this.menu_Target_Copy_Click);
            // 
            // menu_Target_Paste
            // 
            this.menu_Target_Paste.Enabled = false;
            this.menu_Target_Paste.Image = ((System.Drawing.Image)(resources.GetObject("menu_Target_Paste.Image")));
            this.menu_Target_Paste.Name = "menu_Target_Paste";
            this.menu_Target_Paste.Size = new System.Drawing.Size(122, 22);
            this.menu_Target_Paste.Text = "Paste";
            this.menu_Target_Paste.Click += new System.EventHandler(this.menu_Target_Paste_Click);
            // 
            // menu_Target_Clear
            // 
            this.menu_Target_Clear.Enabled = false;
            this.menu_Target_Clear.Image = ((System.Drawing.Image)(resources.GetObject("menu_Target_Clear.Image")));
            this.menu_Target_Clear.Name = "menu_Target_Clear";
            this.menu_Target_Clear.Size = new System.Drawing.Size(122, 22);
            this.menu_Target_Clear.Text = "Clear";
            this.menu_Target_Clear.Click += new System.EventHandler(this.menu_Target_Clear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // menu_Target_SelectAll
            // 
            this.menu_Target_SelectAll.Enabled = false;
            this.menu_Target_SelectAll.Name = "menu_Target_SelectAll";
            this.menu_Target_SelectAll.Size = new System.Drawing.Size(122, 22);
            this.menu_Target_SelectAll.Text = "Select All";
            this.menu_Target_SelectAll.Click += new System.EventHandler(this.menu_Target_SelectAll_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Encrypt.ImageOptions.Image")));
            this.btn_Encrypt.Location = new System.Drawing.Point(12, 99);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Encrypt.TabIndex = 5;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Decrypt.ImageOptions.Image")));
            this.btn_Decrypt.Location = new System.Drawing.Point(90, 99);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 6;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(385, 99);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_RSAGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 129);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.txt_TargetText);
            this.Controls.Add(this.txt_SourceText);
            this.Controls.Add(this.lbl_TargetText);
            this.Controls.Add(this.lbl_SourceText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_RSAGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Generator";
            this.Load += new System.EventHandler(this.frm_RSAGenerator_Load);
            this.Resize += new System.EventHandler(this.frm_RSAGenerator_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SourceText.Properties)).EndInit();
            this.menu_SourceText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TargetText.Properties)).EndInit();
            this.menu_TargetText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_SourceText;
        private DevExpress.XtraEditors.TextEdit txt_SourceText;
        private DevExpress.XtraEditors.LabelControl lbl_TargetText;
        private DevExpress.XtraEditors.TextEdit txt_TargetText;
        private DevExpress.XtraEditors.SimpleButton btn_Encrypt;
        private DevExpress.XtraEditors.SimpleButton btn_Decrypt;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private System.Windows.Forms.ContextMenuStrip menu_SourceText;
        private System.Windows.Forms.ToolStripMenuItem menu_Source_Cut;
        private System.Windows.Forms.ToolStripMenuItem menu_Source_Copy;
        private System.Windows.Forms.ToolStripMenuItem menu_Source_Paste;
        private System.Windows.Forms.ToolStripMenuItem menu_Source_Clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_Source_SelectAll;
        private System.Windows.Forms.ContextMenuStrip menu_TargetText;
        private System.Windows.Forms.ToolStripMenuItem menu_Target_Cut;
        private System.Windows.Forms.ToolStripMenuItem menu_Target_Copy;
        private System.Windows.Forms.ToolStripMenuItem menu_Target_Paste;
        private System.Windows.Forms.ToolStripMenuItem menu_Target_Clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menu_Target_SelectAll;
    }
}