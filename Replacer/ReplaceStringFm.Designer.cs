namespace Replacer
{
    partial class ReplaceStringFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.searchStringEdit = new DevExpress.XtraEditors.TextEdit();
            this.replaceStringEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.raplaceStringLbl = new DevExpress.XtraEditors.LabelControl();
            this.startReplaceBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.searchStringEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceStringEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // searchStringEdit
            // 
            this.searchStringEdit.Location = new System.Drawing.Point(99, 24);
            this.searchStringEdit.Name = "searchStringEdit";
            this.searchStringEdit.Size = new System.Drawing.Size(218, 20);
            this.searchStringEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Нужно ввести текст!";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.searchStringEdit, conditionValidationRule1);
            this.searchStringEdit.EditValueChanged += new System.EventHandler(this.searchStringEdit_EditValueChanged);
            // 
            // replaceStringEdit
            // 
            this.replaceStringEdit.Location = new System.Drawing.Point(99, 50);
            this.replaceStringEdit.Name = "replaceStringEdit";
            this.replaceStringEdit.Size = new System.Drawing.Size(218, 20);
            this.replaceStringEdit.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Нужно ввести текст!";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.replaceStringEdit, conditionValidationRule2);
            this.replaceStringEdit.EditValueChanged += new System.EventHandler(this.replaceStringEdit_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Искомая строка:";
            // 
            // raplaceStringLbl
            // 
            this.raplaceStringLbl.Location = new System.Drawing.Point(13, 53);
            this.raplaceStringLbl.Name = "raplaceStringLbl";
            this.raplaceStringLbl.Size = new System.Drawing.Size(67, 13);
            this.raplaceStringLbl.TabIndex = 3;
            this.raplaceStringLbl.Text = "Заменить на:";
            // 
            // startReplaceBtn
            // 
            this.startReplaceBtn.Location = new System.Drawing.Point(191, 76);
            this.startReplaceBtn.Name = "startReplaceBtn";
            this.startReplaceBtn.Size = new System.Drawing.Size(60, 23);
            this.startReplaceBtn.TabIndex = 4;
            this.startReplaceBtn.Text = "Ок";
            this.startReplaceBtn.Click += new System.EventHandler(this.startReplaceBtn_Click);
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.dxValidationProvider_ValidationFailed);
            this.dxValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.dxValidationProvider_ValidationSucceeded);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(257, 76);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(60, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Отмена";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ReplaceStringFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 107);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.startReplaceBtn);
            this.Controls.Add(this.raplaceStringLbl);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.replaceStringEdit);
            this.Controls.Add(this.searchStringEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceStringFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Укажите параметры поиска";
            ((System.ComponentModel.ISupportInitialize)(this.searchStringEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceStringEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit searchStringEdit;
        private DevExpress.XtraEditors.TextEdit replaceStringEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl raplaceStringLbl;
        private DevExpress.XtraEditors.SimpleButton startReplaceBtn;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}