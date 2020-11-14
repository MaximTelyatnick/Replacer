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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplacerFm));
            this.startBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchPathToDirectoryBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pathToDirectoryEdit = new DevExpress.XtraEditors.TextEdit();
            this.filesGrid = new DevExpress.XtraGrid.GridControl();
            this.filesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pathCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.charSearchCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stringSearchCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.updateProgress = new DevExpress.XtraEditors.ProgressBarControl();
            this.progressLbl = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.pathToDirectoryAllFilesEdit = new DevExpress.XtraEditors.TextEdit();
            this.markBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchChar = new DevExpress.XtraEditors.SimpleButton();
            this.disableMarkBtn = new DevExpress.XtraEditors.SimpleButton();
            this.replaceStringBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchStringBtn = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.updateProgressPath = new DevExpress.XtraEditors.ProgressBarControl();
            this.progressPathLbl = new DevExpress.XtraEditors.LabelControl();
            this.startAllFilesBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchCharAllFilesBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchPathToDirectoryFilesBtn = new DevExpress.XtraEditors.SimpleButton();
            this.filesPathGrid = new DevExpress.XtraGrid.GridControl();
            this.filesPathGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pathToDirectoryEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathToDirectoryAllFilesEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateProgressPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesPathGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesPathGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.AppearanceDisabled.BackColor = System.Drawing.Color.Snow;
            this.startBtn.AppearanceDisabled.Options.UseBackColor = true;
            this.startBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.startBtn.Location = new System.Drawing.Point(396, 314);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(112, 22);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Заменить символы";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // searchPathToDirectoryBtn
            // 
            this.searchPathToDirectoryBtn.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.searchPathToDirectoryBtn.Appearance.Options.UseBackColor = true;
            this.searchPathToDirectoryBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.searchPathToDirectoryBtn.Location = new System.Drawing.Point(803, 314);
            this.searchPathToDirectoryBtn.Name = "searchPathToDirectoryBtn";
            this.searchPathToDirectoryBtn.Size = new System.Drawing.Size(76, 22);
            this.searchPathToDirectoryBtn.TabIndex = 3;
            this.searchPathToDirectoryBtn.Text = "Выбрать";
            this.searchPathToDirectoryBtn.Click += new System.EventHandler(this.searchPathToDirectoryBtn_Click);
            // 
            // pathToDirectoryEdit
            // 
            this.pathToDirectoryEdit.Location = new System.Drawing.Point(3, 250);
            this.pathToDirectoryEdit.Name = "pathToDirectoryEdit";
            this.pathToDirectoryEdit.Size = new System.Drawing.Size(876, 20);
            this.pathToDirectoryEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Не указано путь к директории";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.pathToDirectoryEdit, conditionValidationRule1);
            this.pathToDirectoryEdit.EditValueChanged += new System.EventHandler(this.pathToDirectoryEdit_EditValueChanged);
            // 
            // filesGrid
            // 
            this.filesGrid.Location = new System.Drawing.Point(3, 3);
            this.filesGrid.MainView = this.filesGridView;
            this.filesGrid.Name = "filesGrid";
            this.filesGrid.Size = new System.Drawing.Size(876, 241);
            this.filesGrid.TabIndex = 5;
            this.filesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.filesGridView});
            // 
            // filesGridView
            // 
            this.filesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pathCol,
            this.charSearchCol,
            this.stringSearchCol});
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
            // charSearchCol
            // 
            this.charSearchCol.Caption = "Наличие символов";
            this.charSearchCol.FieldName = "Check";
            this.charSearchCol.Name = "charSearchCol";
            this.charSearchCol.OptionsColumn.AllowEdit = false;
            this.charSearchCol.OptionsColumn.AllowFocus = false;
            this.charSearchCol.Visible = true;
            this.charSearchCol.VisibleIndex = 1;
            this.charSearchCol.Width = 115;
            // 
            // stringSearchCol
            // 
            this.stringSearchCol.Caption = "Наличие строки";
            this.stringSearchCol.FieldName = "CheckString";
            this.stringSearchCol.Name = "stringSearchCol";
            this.stringSearchCol.OptionsColumn.AllowEdit = false;
            this.stringSearchCol.OptionsColumn.AllowFocus = false;
            this.stringSearchCol.Visible = true;
            this.stringSearchCol.VisibleIndex = 2;
            // 
            // updateProgress
            // 
            this.updateProgress.Location = new System.Drawing.Point(3, 276);
            this.updateProgress.Name = "updateProgress";
            this.updateProgress.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.updateProgress.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.updateProgress.Size = new System.Drawing.Size(876, 32);
            this.updateProgress.TabIndex = 6;
            // 
            // progressLbl
            // 
            this.progressLbl.Location = new System.Drawing.Point(316, 285);
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
            // pathToDirectoryAllFilesEdit
            // 
            this.pathToDirectoryAllFilesEdit.Location = new System.Drawing.Point(3, 250);
            this.pathToDirectoryAllFilesEdit.Name = "pathToDirectoryAllFilesEdit";
            this.pathToDirectoryAllFilesEdit.Size = new System.Drawing.Size(876, 20);
            this.pathToDirectoryAllFilesEdit.TabIndex = 7;
            // 
            // markBtn
            // 
            this.markBtn.Appearance.BackColor = System.Drawing.Color.Bisque;
            this.markBtn.Appearance.BackColor2 = System.Drawing.Color.Bisque;
            this.markBtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.markBtn.Appearance.Options.UseBackColor = true;
            this.markBtn.Appearance.Options.UseForeColor = true;
            this.markBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.markBtn.Location = new System.Drawing.Point(134, 314);
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
            this.searchChar.Location = new System.Drawing.Point(3, 314);
            this.searchChar.Name = "searchChar";
            this.searchChar.Size = new System.Drawing.Size(125, 22);
            this.searchChar.TabIndex = 9;
            this.searchChar.Text = "Найти";
            this.searchChar.Click += new System.EventHandler(this.searchChar_Click);
            // 
            // disableMarkBtn
            // 
            this.disableMarkBtn.Appearance.BackColor = System.Drawing.Color.White;
            this.disableMarkBtn.Appearance.BackColor2 = System.Drawing.Color.White;
            this.disableMarkBtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.disableMarkBtn.Appearance.Options.UseBackColor = true;
            this.disableMarkBtn.Appearance.Options.UseForeColor = true;
            this.disableMarkBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.disableMarkBtn.Location = new System.Drawing.Point(265, 314);
            this.disableMarkBtn.Name = "disableMarkBtn";
            this.disableMarkBtn.Size = new System.Drawing.Size(125, 22);
            this.disableMarkBtn.TabIndex = 10;
            this.disableMarkBtn.Text = "Убрать метки";
            this.disableMarkBtn.Click += new System.EventHandler(this.disableMarkBtn_Click);
            // 
            // replaceStringBtn
            // 
            this.replaceStringBtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.replaceStringBtn.Appearance.Options.UseBackColor = true;
            this.replaceStringBtn.Appearance.Options.UseForeColor = true;
            this.replaceStringBtn.AppearanceDisabled.BackColor = System.Drawing.Color.Snow;
            this.replaceStringBtn.AppearanceDisabled.Options.UseBackColor = true;
            this.replaceStringBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.replaceStringBtn.Location = new System.Drawing.Point(641, 314);
            this.replaceStringBtn.Name = "replaceStringBtn";
            this.replaceStringBtn.Size = new System.Drawing.Size(156, 22);
            this.replaceStringBtn.TabIndex = 11;
            this.replaceStringBtn.Text = "Заменить строку и отметить";
            this.replaceStringBtn.Click += new System.EventHandler(this.replaceStringBtn_Click);
            // 
            // searchStringBtn
            // 
            this.searchStringBtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.searchStringBtn.Appearance.BackColor2 = System.Drawing.Color.LightBlue;
            this.searchStringBtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.searchStringBtn.Appearance.Options.UseBackColor = true;
            this.searchStringBtn.Appearance.Options.UseForeColor = true;
            this.searchStringBtn.AppearanceDisabled.BackColor = System.Drawing.Color.Snow;
            this.searchStringBtn.AppearanceDisabled.Options.UseBackColor = true;
            this.searchStringBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.searchStringBtn.Location = new System.Drawing.Point(514, 314);
            this.searchStringBtn.Name = "searchStringBtn";
            this.searchStringBtn.Size = new System.Drawing.Size(121, 22);
            this.searchStringBtn.TabIndex = 12;
            this.searchStringBtn.Text = "Найти строку ";
            this.searchStringBtn.Click += new System.EventHandler(this.searchStringBtn_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(888, 372);
            this.xtraTabControl1.TabIndex = 13;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.filesGrid);
            this.xtraTabPage1.Controls.Add(this.searchStringBtn);
            this.xtraTabPage1.Controls.Add(this.startBtn);
            this.xtraTabPage1.Controls.Add(this.replaceStringBtn);
            this.xtraTabPage1.Controls.Add(this.searchPathToDirectoryBtn);
            this.xtraTabPage1.Controls.Add(this.disableMarkBtn);
            this.xtraTabPage1.Controls.Add(this.pathToDirectoryEdit);
            this.xtraTabPage1.Controls.Add(this.searchChar);
            this.xtraTabPage1.Controls.Add(this.markBtn);
            this.xtraTabPage1.Controls.Add(this.progressLbl);
            this.xtraTabPage1.Controls.Add(this.updateProgress);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(882, 341);
            this.xtraTabPage1.Text = "Поиск в файлах excel";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Controls.Add(this.progressPathLbl);
            this.xtraTabPage2.Controls.Add(this.startAllFilesBtn);
            this.xtraTabPage2.Controls.Add(this.searchCharAllFilesBtn);
            this.xtraTabPage2.Controls.Add(this.searchPathToDirectoryFilesBtn);
            this.xtraTabPage2.Controls.Add(this.pathToDirectoryAllFilesEdit);
            this.xtraTabPage2.Controls.Add(this.filesPathGrid);
            this.xtraTabPage2.Controls.Add(this.updateProgressPath);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(882, 341);
            this.xtraTabPage2.Text = "Поиск в имени файлов";
            // 
            // updateProgressPath
            // 
            this.updateProgressPath.Location = new System.Drawing.Point(3, 276);
            this.updateProgressPath.Name = "updateProgressPath";
            this.updateProgressPath.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.updateProgressPath.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.updateProgressPath.Size = new System.Drawing.Size(876, 32);
            this.updateProgressPath.TabIndex = 16;
            // 
            // progressPathLbl
            // 
            this.progressPathLbl.Location = new System.Drawing.Point(316, 285);
            this.progressPathLbl.Name = "progressPathLbl";
            this.progressPathLbl.Size = new System.Drawing.Size(9, 13);
            this.progressPathLbl.TabIndex = 17;
            this.progressPathLbl.Text = "   ";
            // 
            // startAllFilesBtn
            // 
            this.startAllFilesBtn.AppearanceDisabled.BackColor = System.Drawing.Color.Snow;
            this.startAllFilesBtn.AppearanceDisabled.Options.UseBackColor = true;
            this.startAllFilesBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.startAllFilesBtn.Location = new System.Drawing.Point(134, 314);
            this.startAllFilesBtn.Name = "startAllFilesBtn";
            this.startAllFilesBtn.Size = new System.Drawing.Size(112, 22);
            this.startAllFilesBtn.TabIndex = 13;
            this.startAllFilesBtn.Text = "Заменить символы";
            // 
            // searchCharAllFilesBtn
            // 
            this.searchCharAllFilesBtn.Appearance.BackColor = System.Drawing.Color.White;
            this.searchCharAllFilesBtn.Appearance.BackColor2 = System.Drawing.Color.White;
            this.searchCharAllFilesBtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.searchCharAllFilesBtn.Appearance.Options.UseBackColor = true;
            this.searchCharAllFilesBtn.Appearance.Options.UseForeColor = true;
            this.searchCharAllFilesBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.searchCharAllFilesBtn.Location = new System.Drawing.Point(3, 314);
            this.searchCharAllFilesBtn.Name = "searchCharAllFilesBtn";
            this.searchCharAllFilesBtn.Size = new System.Drawing.Size(125, 22);
            this.searchCharAllFilesBtn.TabIndex = 15;
            this.searchCharAllFilesBtn.Text = "Найти";
            this.searchCharAllFilesBtn.Click += new System.EventHandler(this.searchCharAllFilesBtn_Click);
            // 
            // searchPathToDirectoryFilesBtn
            // 
            this.searchPathToDirectoryFilesBtn.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.searchPathToDirectoryFilesBtn.Appearance.Options.UseBackColor = true;
            this.searchPathToDirectoryFilesBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.searchPathToDirectoryFilesBtn.Location = new System.Drawing.Point(803, 314);
            this.searchPathToDirectoryFilesBtn.Name = "searchPathToDirectoryFilesBtn";
            this.searchPathToDirectoryFilesBtn.Size = new System.Drawing.Size(76, 22);
            this.searchPathToDirectoryFilesBtn.TabIndex = 9;
            this.searchPathToDirectoryFilesBtn.Text = "Выбрать";
            this.searchPathToDirectoryFilesBtn.Click += new System.EventHandler(this.searchPathToDirectoryFilesBtn_Click);
            // 
            // filesPathGrid
            // 
            this.filesPathGrid.Location = new System.Drawing.Point(3, 3);
            this.filesPathGrid.MainView = this.filesPathGridView;
            this.filesPathGrid.Name = "filesPathGrid";
            this.filesPathGrid.Size = new System.Drawing.Size(876, 241);
            this.filesPathGrid.TabIndex = 6;
            this.filesPathGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.filesPathGridView});
            // 
            // filesPathGridView
            // 
            this.filesPathGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.filesPathGridView.GridControl = this.filesPathGrid;
            this.filesPathGridView.Name = "filesPathGridView";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Путь";
            this.gridColumn1.FieldName = "Path";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 503;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Наличие символов";
            this.gridColumn2.FieldName = "Check";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 115;
            // 
            // ReplacerFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 369);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplacerFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacer";
            this.Load += new System.EventHandler(this.ReplacerFm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pathToDirectoryEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathToDirectoryAllFilesEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateProgressPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesPathGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesPathGridView)).EndInit();
            this.ResumeLayout(false);

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
        private DevExpress.XtraGrid.Columns.GridColumn charSearchCol;
        private DevExpress.XtraEditors.SimpleButton searchChar;
        private DevExpress.XtraEditors.SimpleButton disableMarkBtn;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn stringSearchCol;
        private DevExpress.XtraEditors.SimpleButton replaceStringBtn;
        private DevExpress.XtraEditors.SimpleButton searchStringBtn;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton startAllFilesBtn;
        private DevExpress.XtraEditors.SimpleButton searchCharAllFilesBtn;
        private DevExpress.XtraEditors.SimpleButton searchPathToDirectoryFilesBtn;
        private DevExpress.XtraEditors.TextEdit pathToDirectoryAllFilesEdit;
        private DevExpress.XtraGrid.GridControl filesPathGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView filesPathGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.ProgressBarControl updateProgressPath;
        private DevExpress.XtraEditors.LabelControl progressPathLbl;
    }
}