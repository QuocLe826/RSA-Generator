using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RSAGenerator;

namespace RSA_Generator
{
    public enum RSAType
    {
        Encrypt = 0,
        Decrypt = 1
    }

    public partial class frm_RSAGenerator: XtraForm
    {

        #region Variables

        /// <summary>
        /// Biến lưu kết quả Encrypt-Decrypt
        /// </summary>
        private string _rsaResult = string.Empty;

        private int _maxHeight = 0; 

        #endregion

        #region Constructor

        public frm_RSAGenerator()
        {
            InitializeComponent();
        }

        #endregion

        #region Method

        /// <summary>
        /// Xử lý RSA
        /// </summary>
        /// <param name="sourceText"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public string ProcessRSA(string sourceText, RSAType type)
        {
            return type == RSAType.Encrypt ? RSASecurity.Encrypt(sourceText) : RSASecurity.Decrypt(sourceText);
        }

        #endregion

        #region Events

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SourceText.Text))
            {
                XtraMessageBox.Show("Source text is empty", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SourceText.Focus();
                return;
            }
            _rsaResult = ProcessRSA(txt_SourceText.Text, RSAType.Encrypt);
            if (_rsaResult == "RSAError")
            {
                XtraMessageBox.Show("Cannot encrypt this text!", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SourceText.Focus();
                return;
            }
            txt_TargetText.Text = _rsaResult;
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SourceText.Text))
            {
                XtraMessageBox.Show("Source text is empty", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SourceText.Focus();
                return;
            }
            _rsaResult = ProcessRSA(txt_SourceText.Text, RSAType.Decrypt);
            if (_rsaResult == "RSAError")
            {
                XtraMessageBox.Show("Cannot decrypt this text!", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SourceText.Focus();
                return;
            }
            txt_TargetText.Text = _rsaResult;
        }

        private void frm_RSAGenerator_Load(object sender, EventArgs e)
        {
            _maxHeight = this.Height;
        }

        private void menu_Source_Cut_Click(object sender, EventArgs e)
        {
            Functions.Cut(txt_SourceText);
        }

        private void menu_Source_Copy_Click(object sender, EventArgs e)
        {
            Functions.Copy(txt_SourceText);
        }

        private void menu_Source_Paste_Click(object sender, EventArgs e)
        {
            Functions.Paste(txt_SourceText);
        }

        private void menu_Source_Clear_Click(object sender, EventArgs e)
        {
            Functions.Clear(txt_SourceText);
        }

        private void menu_Source_SelectAll_Click(object sender, EventArgs e)
        {
            Functions.SelectAll(txt_SourceText);
        }

        private void menu_Target_Cut_Click(object sender, EventArgs e)
        {
            Functions.Cut(txt_TargetText);
        }

        private void menu_Target_Copy_Click(object sender, EventArgs e)
        {
            Functions.Copy(txt_TargetText);
        }

        private void menu_Target_Paste_Click(object sender, EventArgs e)
        {
            Functions.Paste(txt_TargetText);
        }

        private void menu_Target_Clear_Click(object sender, EventArgs e)
        {
            Functions.Clear(txt_TargetText);
        }

        private void menu_Target_SelectAll_Click(object sender, EventArgs e)
        {
            Functions.SelectAll(txt_TargetText);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_SourceText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menu_Source_Clear.Enabled = !string.IsNullOrEmpty(txt_SourceText.Text);
                menu_Source_SelectAll.Enabled = !string.IsNullOrEmpty(txt_SourceText.Text);
                menu_Source_Cut.Enabled = !string.IsNullOrEmpty(txt_SourceText.SelectedText);
                menu_Source_Copy.Enabled = !string.IsNullOrEmpty(txt_SourceText.SelectedText);
                menu_Source_Paste.Enabled = !string.IsNullOrEmpty(Clipboard.GetText());
            }
        }

        private void txt_TargetText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menu_Target_Clear.Enabled = !string.IsNullOrEmpty(txt_TargetText.Text);
                menu_Target_SelectAll.Enabled = !string.IsNullOrEmpty(txt_TargetText.Text);
                menu_Target_Cut.Enabled = !string.IsNullOrEmpty(txt_TargetText.SelectedText);
                menu_Target_Copy.Enabled = !string.IsNullOrEmpty(txt_TargetText.SelectedText);
                menu_Target_Paste.Enabled = !string.IsNullOrEmpty(Clipboard.GetText());
            }
        }

        private void frm_RSAGenerator_Resize(object sender, EventArgs e)
        {
            if (this.Height >= _maxHeight)
            {
                this.Height = _maxHeight;
            }
        }

        #endregion
    }
}