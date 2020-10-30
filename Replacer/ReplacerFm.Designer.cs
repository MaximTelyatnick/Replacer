namespace Replacer
{
    partial class ReplacerFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.startBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchPathToDirectoryBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pathToDirectoryEdit = new DevExpress.XtraEditors.TextEdit();
            this.filesGrid = new DevExpress.XtraGrid.GridControl();
            this.filesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pathCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.updateProgress = new DevExpress.XtraEditors.ProgressBarControl();
            this.progressLbl = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.markBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchChar = new DevExpress.XtraEditors.SimpleButton();
            this.disableMarkBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pathToDirectoryEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.AppearanceDisabled.BackColor = System.Drawing.Color.Snow;
            this.startBtn.AppearanceDisabled.Options.UseBackColor = true;
            this.startBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.startBtn.Location = new System.Drawing.Point(405, 323);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(112, 22);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Заменить";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // searchPathToDirectoryBtn
            // 
            this.searchPathToDirectoryBtn.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.searchPathToDirectoryBtn.Appearance.Options.UseBackColor = true;
            this.searchPathToDirectoryBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.searchPathToDirectoryBtn.Location = new System.Drawing.Point(572, 323);
            this.searchPathToDirectoryBtn.Name = "searchPathToDirectoryBtn";
            this.searchPathToDirectoryBtn.Size = new System.Drawing.Size(76, 22);
            this.searchPathToDirectoryBtn.TabIndex = 3;
            this.searchPathToDirectoryBtn.Text = "Выбрать";
            this.searchPathToDirectoryBtn.Click += new System.EventHandler(this.searchPathToDirectoryBtn_Click);
            // 
            // pathToDirectoryEdit
            // 
            this.pathToDirectoryEdit.Location = new System.Drawing.Point(12, 259);
            this.pathToDirectoryEdit.Name = "pathToDirectoryEdit";
            this.pathToDirectoryEdit.Size = new System.Drawing.Size(636, 20);
            this.pathToDirectoryEdit.TabIndex = 4;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Не указано путь к директории";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.pathToDirectoryEdit, conditionValidationRule2);
            this.pathToDirectoryEdit.EditValueChanged += new System.EventHandler(this.pathToDirectoryEdit_EditValueChanged);
            // 
            // filesGrid
            // 
            this.filesGrid.Location = new System.Drawing.Point(12, 12);
            this.filesGrid.MainView = this.filesGridView;
            this.filesGrid.Name = "filesGrid";
            this.filesGrid.Size = new System.Drawing.Size(636, 241);
            this.filesGrid.TabIndex = 5;
            this.filesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.filesGridView});
            // 
            // filesGridView
            // 
            this.filesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pathCol,
            this.gridColumn1});
            this.filesGridView.GridControl = this.filesGrid;
            this.filesGridView.Name = "filesGridView";
            this.filesGridView.DoubleClick += new System.EventHandler(this.filesGridView_DoubleClick);
            // 
            // pathCol
            // 
            this.pathCol.Caption = "Путь";
            this.pathCol.FieldName = "Path";
            this.pathCol.Name = "pathCol";
            this.pathCol.OptionsColumn.AllowEdit = false;
            this.pathCol.OptionsColumn.AllowFocus = false;
            this.pathCol.Visible = true;
            this.pathCol.VisibleIndex = 0;
            this.pathCol.Width = 503;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Наличие символов";
            this.gridColumn1.FieldName = "Check";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 115;
            // 
            // updateProgress
            // 
            this.updateProgress.Location = new System.Drawing.Point(12, 285);
            this.updateProgress.Name = "updateProgress";
            this.updateProgress.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.updateProgress.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.updateProgress.Size = new System.Drawing.Size(636, 32);
            this.updateProgress.TabIndex = 6;
            // 
            // progressLbl
            // 
            this.progressLbl.Location = new System.Drawing.Point(303, 294);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(9, 13);
            this.progressLbl.TabIndex = 7;
            this.progressLbl.Text = "   ";
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.dxValidationProvider_ValidationFailed);
            this.dxValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.dxValidationProvider_ValidationSucceeded);
            // 
            // markBtn
            // 
            this.markBtn.Appearance.BackColor = System.Drawing.Color.Bisque;
            this.markBtn.Appearance.BackColor2 = System.Drawing.Color.Bisque;
            this.markBtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.markBtn.Appearance.Options.UseBackColor = true;
            this.markBtn.Appearance.Options.UseForeColor = true;
            this.markBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.markBtn.Location = new System.Drawing.Point(143, 323);
            this.markBtn.Name = "markBtn";
            this.markBtn.Size = new System.Drawing.Size(125, 22);
            this.markBtn.TabIndex = 8;
            this.markBtn.Text = "Пометить";
            this.markBtn.Click += new System.EventHandler(this.markBtn_Click);
            // 
            // searchChar
            // 
            this.searchChar.Appearance.BackColor = System.Drawing.Color.White;
            this.searchChar.Appearance.BackColor2 = System.Drawing.Color.White;
            this.searchChar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.searchChar.Appearance.Options.UseBackColor = true;
            this.searchChar.Appearance.Options.UseForeColor = true;
            this.searchChar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.searchChar.Location = new System.Drawing.Point(12, 323);
            this.searchChar.Name = "searchChar";
            this.searchChar.Size = new System.Drawing.Size(125, 22);
            this.searchChar.TabIndex = 9;
            this.searchChar.Text = "Найти";
            this.searchChar.Click += new System.EventHandler(this.searchChar_Click);
            // 
            // disableMarkBtn
            // 
            this.disableMarkBtn.Appearance.BackColor = System.Drawing.Color.SeaShell;
            this.disableMarkBtn.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.disableMarkBtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.disableMarkBtn.Appearance.Options.UseBackColor = true;
            this.disableMarkBtn.Appearance.Options.UseForeColor = true;
            this.disableMarkBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.disableMarkBtn.Location = new System.Drawing.Point(274, 323);
            this.disableMarkBtn.Name = "disableMarkBtn";
            this.disableMarkBtn.Size = new System.Drawing.Size(125, 22);
            this.disableMarkBtn.TabIndex = 10;
            this.disableMarkBtn.Text = "Убрать метки";
            this.disableMarkBtn.Click += new System.EventHandler(this.disableMarkBtn_Click);
            // 
            // ReplacerFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 357);
            this.Controls.Add(this.disableMarkBtn);
            this.Controls.Add(this.searchChar);
            this.Controls.Add(this.markBtn);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.updateProgress);
            this.Controls.Add(this.filesGrid);
            this.Controls.Add(this.pathToDirectoryEdit);
            this.Controls.Add(this.searchPathToDirectoryBtn);
            this.Controls.Add(this.startBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplacerFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacer";
            ((System.ComponentModel.ISupportInitialize)(this.pathToDirectoryEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton startBtn;
        private DevExpress.XtraEditors.SimpleButton searchPathToDirectoryBtn;
        private DevExpress.XtraEditors.TextEdit pathToDirectoryEdit;
        private DevExpress.XtraGrid.GridControl filesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView filesGridView;
        private DevExpress.XtraEditors.ProgressBarControl updateProgress;
        private DevExpress.XtraEditors.LabelControl progressLbl;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.SimpleButton markBtn;
        private DevExpress.XtraGrid.Columns.GridColumn pathCol;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton searchChar;
        private DevExpress.XtraEditors.SimpleButton disableMarkBtn;
    }
}