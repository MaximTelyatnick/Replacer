using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Replacer
{
    public partial class ReplaceStringFm : DevExpress.XtraEditors.XtraForm
    {
        public bool Search;

        public ReplaceStringFm(bool Search = true)
        {
            InitializeComponent();

            this.Search = Search;

            searchStringEdit.Text = Properties.Settings.Default.searchStringFromLocalDb;
            replaceStringEdit.Text = Properties.Settings.Default.replaceStringFromLocalDb;

            if (Search)
            {
                replaceStringEdit.Visible = false;
                raplaceStringLbl.Visible = false;
                replaceStringEdit.EditValue = " ";
            }
            else
            {
                replaceStringEdit.Visible = true;
                raplaceStringLbl.Visible = true;
                replaceStringEdit.EditValue = "";
            }


            dxValidationProvider.Validate();
        }

        public  ReplaceString Return()
        {
            ReplaceString replaceString = new ReplaceString()
            {
                SearchStringText = searchStringEdit.Text,
                ReplaceStringText = replaceStringEdit.Text

            };

            return replaceString;
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.startReplaceBtn.Enabled = false;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.startReplaceBtn.Enabled = isValidate;
        }

        private void startReplaceBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.searchStringFromLocalDb = searchStringEdit.Text;
            Properties.Settings.Default.replaceStringFromLocalDb = replaceStringEdit.Text;
            Properties.Settings.Default.Save();

            DialogResult = DialogResult.OK;
        }

        private void searchStringEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void replaceStringEdit_EditValueChanged(object sender, EventArgs e)
        {
           dxValidationProvider.Validate((Control)sender);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}