﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using SpreadsheetGear;
using System.Diagnostics;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;

namespace Replacer
{


    public partial class ReplacerFm : DevExpress.XtraEditors.XtraForm
    {
        public List<File> PathToDirectory = new List<File>();
        public List<File> PathToDirectoryAllFiles = new List<File>();

        public List<string> pathToExcelFile = new List<string>();
        public DevExpress.Spreadsheet.IWorkbook workbook;
        public Worksheet worksheet;
        public SpreadsheetControl spreadsheetControl = new SpreadsheetControl();

        public BindingSource filesBS = new BindingSource();
        public BindingSource filesPathBS = new BindingSource();

        public string pathToDirectory;
        

        public ReplacerFm()
        {
            InitializeComponent();
            pathToDirectoryEdit.EditValue = Properties.Settings.Default.pathToDirectory;
            LoadFiles();

            dxValidationProvider.Validate();

        }

        private void ReplacerFm_Load(object sender, EventArgs e)
        {
            

        }

        public void LoadFiles()
        {
            if (!pathToDirectoryEdit.Text.Equals(String.Empty) && System.IO.Directory.Exists(pathToDirectoryEdit.Text))
            {
                if (System.IO.Directory.GetFiles(pathToDirectoryEdit.Text).Length > 0)
                {    

                    List<string> files = Directory.GetFiles(pathToDirectoryEdit.Text, "*.*", SearchOption.AllDirectories)
                        .Where(file => new string[] { ".xls", ".xlsm", ".xlsx" }
                        .Contains(Path.GetExtension(file)))
                        .ToList();

                    foreach (string file in files)
                    {
                        PathToDirectory.Add(new File() { Path = file });
                    }

                    LoadData();


                }
                else
                {
                    filesGridView.PostEditor();
                    filesGridView.BeginDataUpdate();
                    filesGrid.DataSource = null;
                    filesGridView.EndDataUpdate();
                }
            }
            else
            {
                filesGridView.PostEditor();
                filesGridView.BeginDataUpdate();
                filesGrid.DataSource = null;
                filesGridView.EndDataUpdate();
            }
        }

        public void LoadAllFiles()
        {
            if (!pathToDirectoryAllFilesEdit.Text.Equals(String.Empty) && System.IO.Directory.Exists(pathToDirectoryEdit.Text))
            {
                if (System.IO.Directory.GetFiles(pathToDirectoryAllFilesEdit.Text).Length > 0)
                {

                    List<string> files = Directory.GetFiles(pathToDirectoryAllFilesEdit.Text, "*.*", SearchOption.AllDirectories)
                        .ToList();

                    foreach (string file in files)
                    {
                        PathToDirectoryAllFiles.Add(new File() { Path = file });
                    }

                    LoadDataAlFiles();


                }
                else
                {
                    filesPathGridView.PostEditor();
                    filesPathGridView.BeginDataUpdate();
                    filesPathGrid.DataSource = null;
                    filesPathGridView.EndDataUpdate();
                }
            }
            else
            {
                filesPathGridView.PostEditor();
                filesPathGridView.BeginDataUpdate();
                filesPathGrid.DataSource = null;
                filesPathGridView.EndDataUpdate();
            }
        }

        private void searchPathToDirectoryBtn_Click(object sender, EventArgs e)
        {
            PathToDirectory.Clear();

            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.ShowNewFolderButton = true;
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                pathToDirectoryEdit.Text = folderBrowserDlg.SelectedPath;
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;

                LoadFiles();
            }
        }


        public void LoadData()
        {
            filesGridView.PostEditor();
            filesGridView.BeginDataUpdate();
            filesBS.DataSource = PathToDirectory;
            filesGrid.DataSource = filesBS;
            filesGridView.EndDataUpdate();
        }

        public void LoadDataAlFiles()
        {
            filesPathGridView.PostEditor();
            filesPathGridView.BeginDataUpdate();
            filesPathBS.DataSource = PathToDirectoryAllFiles;
            filesPathGrid.DataSource = filesPathBS;
            filesPathGridView.EndDataUpdate();
        }

        public bool ReplaceSymbol(string data)
        {
            try
            {
                Factory.GetWorkbook(@data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не знайдено шаблон документа!\n" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            var Workbook = Factory.GetWorkbook(@data);
            var Worksheet = Workbook.Worksheets[0];
            var Сells = Worksheet.Cells;

            IRange cells = Worksheet.Cells;

            cells.Replace("а", "a", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("А", "A", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("і", "i",LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("І", "I", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("Р", "P", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("р", "p", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("с", "c", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("С", "C", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("к", "k", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("К", "K", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("Н", "H", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("х", "x", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("е", "e", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("Е", "E", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("Х", "X", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("В", "B", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("а", "a", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("А", "A", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("о", "o", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("О", "O", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("м", "m", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("М", "M", LookAt.Part, SearchOrder.ByRows, true);
            cells.Replace("Т", "T", LookAt.Part, SearchOrder.ByRows, true);

            try
            {
                Workbook.Save();
            }

            catch (System.IO.IOException) { MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (System.ComponentModel.Win32Exception) { MessageBox.Show("Не найдено пакет программ Microsoft Excel!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            return true;
            
        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            if (PathToDirectory.Count > 0)
            {
                ActiveButton(false);
                progressLbl.Text = "Происходит замена данных";
                progressLbl.Refresh();

                updateProgress.Properties.Step = 1;
                updateProgress.Properties.PercentView = true;
                updateProgress.Properties.Maximum = pathToExcelFile.Count;
                updateProgress.Properties.Minimum = 0;

                foreach (var item in PathToDirectory)
                {
                    ReplaceSymbol(item.Path);
                    updateProgress.PerformStep();
                    updateProgress.Update();
                }
                updateProgress.EditValue = 0;

                progressLbl.Text = "Данные обновлены";
                progressLbl.Refresh();
                ActiveButton(true);
            }
            else
            {
                MessageBox.Show("Не найдено файлы в папке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.startBtn.Enabled = false;
            this.markBtn.Enabled = false;
            this.disableMarkBtn.Enabled = false;
            this.searchChar.Enabled = false;
            this.replaceStringBtn.Enabled = false;
            this.searchStringBtn.Enabled = false;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.startBtn.Enabled = isValidate;
            this.markBtn.Enabled = isValidate;
            this.disableMarkBtn.Enabled = isValidate;
            this.searchChar.Enabled = isValidate;
            this.replaceStringBtn.Enabled = isValidate;
            this.searchStringBtn.Enabled = isValidate;
        }

        private void pathToDirectoryEdit_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.pathToDirectory = pathToDirectoryEdit.Text;
            Properties.Settings.Default.Save();

            dxValidationProvider.Validate((Control)sender);
        }

        private void markBtn_Click(object sender, EventArgs e)
        {
            if (PathToDirectory.Count > 0)
            {
                ClearCheck();
                ActiveButton(false);

                progressLbl.Text = "Происходит поиск символов";
                progressLbl.Refresh();

                updateProgress.Properties.Step = 1;
                updateProgress.Properties.PercentView = true;
                updateProgress.Properties.Maximum = PathToDirectory.Count;
                updateProgress.Properties.Minimum = 0;

                foreach (var item in PathToDirectory)
                {
                    if (SearchRussianChar(item.Path))
                    {
                        item.Check = true;
                    }
                    else
                    {
                        item.Check = false;
                    }

                    updateProgress.PerformStep();
                    updateProgress.Update();
                }
                updateProgress.EditValue = 0;

                LoadData();

                progressLbl.Text = "Данные обновлены";
                progressLbl.Refresh();
                ActiveButton(true);
            }
            else
            {
                MessageBox.Show("Не найдено файлы в папке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void  ActiveButton(bool active)
        {
            searchChar.Enabled = active;
            markBtn.Enabled = active;
            disableMarkBtn.Enabled = active;
            startBtn.Enabled = active;
            searchStringBtn.Enabled = active;
            replaceStringBtn.Enabled = active;
            searchCharAllFilesBtn.Enabled = active;
            startAllFilesBtn.Enabled = active;
        }


        public bool SearchRussianChar(string data, bool mark = true)
        {
            bool searchChar = false;
            DevExpress.Spreadsheet.IWorkbook workbook;
            Worksheet worksheet;
            workbook = spreadsheetControl.Document;
            try
            {
                workbook.LoadDocument(data);
            }
            catch (Exception)
            {
                return true;
            }
            
            worksheet = workbook.Worksheets[0];
            //workbookk.LoadDocument(data);

            char[] alphabet = Enumerable.Range('а', 37).Select(x => (char)x).ToArray();
            alphabet[34] = 'і';
            alphabet[35] = 'ї';
            alphabet[36] = 'є';

            SearchOptions options = new SearchOptions();
            options.SearchBy = SearchBy.Rows;
            options.SearchIn = SearchIn.Values;
            options.MatchEntireCellContents = false;
            options.MatchCase = false;

            foreach (var item in alphabet)
            {
                IEnumerable<Cell> searchResult = worksheet.Search(item.ToString(), options);
                foreach (Cell cell in searchResult)
                {
                    if (mark)
                        cell.Fill.BackgroundColor = Color.Bisque;
                }

                if (searchResult.Count() > 0)
                    searchChar = true;

                
                
            }

            try
            {
                workbook.SaveDocument(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Файл: " + data + ". Не был отредактирован так как открыт в проводнике", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return searchChar;
        }

        public bool SearchRussianCharInPath(string data, bool mark = true)
        {
            bool searchChar = false;

            //workbookk.LoadDocument(data);

            char[] alphabet = Enumerable.Range('а', 37).Select(x => (char)x).ToArray();
            alphabet[34] = 'і';
            alphabet[35] = 'ї';
            alphabet[36] = 'є';

            SearchOptions options = new SearchOptions();
            options.SearchBy = SearchBy.Rows;
            options.SearchIn = SearchIn.Values;
            options.MatchEntireCellContents = false;
            options.MatchCase = false;

            foreach (var item in alphabet)
            {
                IEnumerable<Cell> searchResult = worksheet.Search(item.ToString(), options);
                foreach (Cell cell in searchResult)
                {
                    if (mark)
                        cell.Fill.BackgroundColor = Color.Bisque;
                }

                if (searchResult.Count() > 0)
                    searchChar = true;



            }

            try
            {
                workbook.SaveDocument(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Файл: " + data + ". Не был отредактирован так как открыт в проводнике", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return searchChar;
        }

        public void UnMarkCell(string data)
        {
            bool searchChar = false;
            DevExpress.Spreadsheet.IWorkbook workbook;
            Worksheet worksheet;
            workbook = spreadsheetControl.Document;
            try
            {
                workbook.LoadDocument(data);
            }
            catch (Exception)
            {
                return;
            }
            
            worksheet = workbook.Worksheets[0];

            worksheet.Cells.Fill.BackgroundColor = Color.Transparent;

            workbook = spreadsheetControl.Document;
            try
            {
                workbook.SaveDocument(data);
            }
            catch (Exception)
            {
                return;
            }
            
        }

        public bool SearchAndMarkSymbol(string data)
        {
            try
            {
                Factory.GetWorkbook(@data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не знайдено шаблон документа!\n" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            //var Workbook = Factory.GetWorkbook(@data);
            //var Worksheet = Workbook.Worksheets[0];
            //var Сells = Worksheet.Cells;

            //IRange cells = Worksheet.Cells.Range;


            //FindRecurse(cells, null);



            //var fff = cells.Find("а", ff, FindLookIn.Values, LookAt.Part, SearchOrder.ByRows, SearchDirection.Next, true);
            //if (fff != null)
            //{
            //    fff.Interior.Color = System.Drawing.Color.BlueViolet;
            //    //FindRecurse(cells);
            //}
            //var ffff = cells.Find("а", fff, FindLookIn.Values, LookAt.Part, SearchOrder.ByRows, SearchDirection.Next, true);
            //if (ffff != null)
            //{
            //    ffff.Interior.Color = System.Drawing.Color.BlueViolet;
            //    //FindRecurse(cells);
            //}

            try
                {
                //Workbook.Save();
            }

            catch (System.IO.IOException) { MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (System.ComponentModel.Win32Exception) { MessageBox.Show("Не найдено пакет программ Microsoft Excel!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            return true;
        }

        public void FindRecurse(IRange cellss, IRange nextCells)
        {
            if (cellss.Find("а", nextCells, FindLookIn.Values, LookAt.Part, SearchOrder.ByRows, SearchDirection.Next, true) != null)
            {
                IRange kk = cellss.Find("а", nextCells, FindLookIn.Values, LookAt.Part, SearchOrder.ByRows, SearchDirection.Next, true).Cells;
                if (kk != null)
                {
                    kk.Interior.Color = System.Drawing.Color.Aqua;
                    FindRecurse(cellss, kk);
                }
            }


        }

        private void filesGridView_DoubleClick(object sender, EventArgs e)
        {
            var currentRow = filesGridView.GetFocusedRowCellValue("Path");

            Process process = new Process();
            process.StartInfo.Arguments = "\"" + currentRow + "\"";
            process.StartInfo.FileName = "Excel.exe";
            process.Start();
        }

        public void ClearCheck()
        {
            foreach (var item in PathToDirectory)
            {
                item.Check = false;
            }

            foreach (var item in PathToDirectoryAllFiles)
            {
                item.Check = false;
            }
        }

        public void ClearCheckString()
        {
            foreach (var item in PathToDirectory)
            {
                item.CheckString = false;
            }
        }


        private void searchChar_Click(object sender, EventArgs e)
        {
            if (PathToDirectory.Count > 0)
            {
                ClearCheck();
                ActiveButton(false);


                progressLbl.Text = "Происходит поиск символов";
                progressLbl.Refresh();

                updateProgress.Properties.Step = 1;
                updateProgress.Properties.PercentView = true;
                updateProgress.Properties.Maximum = PathToDirectory.Count;
                updateProgress.Properties.Minimum = 0;

                foreach (var item in PathToDirectory)
                {
                    if (SearchRussianChar(item.Path, false))
                        item.Check = true;

                    updateProgress.PerformStep();
                    updateProgress.Update();
                }
                updateProgress.EditValue = 0;

                LoadData();

                progressLbl.Text = "Символы найдены";
                progressLbl.Refresh();
                ActiveButton(true);

            }
            else
            {
                MessageBox.Show("Не найдено файлы в папке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void disableMarkBtn_Click(object sender, EventArgs e)
        {
            if (PathToDirectory.Count > 0)
            {
                ActiveButton(false);

                progressLbl.Text = "Убираем метки";
                progressLbl.Refresh();

                updateProgress.Properties.Step = 1;
                updateProgress.Properties.PercentView = true;
                updateProgress.Properties.Maximum = PathToDirectory.Count;
                updateProgress.Properties.Minimum = 0;

                foreach (var item in PathToDirectory)
                {
                    UnMarkCell(item.Path);


                    updateProgress.PerformStep();
                    updateProgress.Update();
                }
                updateProgress.EditValue = 0;

                LoadData();

                progressLbl.Text = "Метки убраны";
                progressLbl.Refresh();
                ActiveButton(true);
            }
            else
            {
                MessageBox.Show("Не найдено файлы в папке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void replaceStringBtn_Click(object sender, EventArgs e)
        {
            if (PathToDirectory.Count > 0)
            {
                ClearCheckString();
                ActiveButton(false);


                ReplaceString replaceStringModel = new ReplaceString();
                using (ReplaceStringFm replaceStringFm = new ReplaceStringFm(false))
                {
                    if (replaceStringFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        replaceStringModel = replaceStringFm.Return();

                    }
                    else
                    {
                        ActiveButton(true);
                        return;

                    }
                }

                progressLbl.Text = "Производим замену строки";
                progressLbl.Refresh();

                updateProgress.Properties.Step = 1;
                updateProgress.Properties.PercentView = true;
                updateProgress.Properties.Maximum = PathToDirectory.Count;
                updateProgress.Properties.Minimum = 0;

                foreach (var item in PathToDirectory)
                {
                    if (SearchRussianString(item.Path, replaceStringModel.SearchStringText, replaceStringModel.ReplaceStringText))
                        item.CheckString = true;
                    


                    updateProgress.PerformStep();
                    updateProgress.Update();
                }
                updateProgress.EditValue = 0;

                LoadData();

                progressLbl.Text = "Замена произведена, ячейки где была выполнена замена - отмечены";
                progressLbl.Refresh();
                ActiveButton(true);

            }
            else
            {
                MessageBox.Show("Не найдено файлы в папке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        public bool SearchRussianString(string path, string searchString, string replaceSerachString, bool mark = true)
        {
            bool searchStringFlag = false;
            DevExpress.Spreadsheet.IWorkbook workbook;
            Worksheet worksheet;
            workbook = spreadsheetControl.Document;
            try
            {
                workbook.LoadDocument(path);
            }
            catch (Exception)
            {
                return true;
            }

            worksheet = workbook.Worksheets[0];
            //workbookk.LoadDocument(data);

            SearchOptions options = new SearchOptions();
            options.SearchBy = SearchBy.Rows;
            options.SearchIn = SearchIn.Values;
            options.MatchEntireCellContents = false;
            options.MatchCase = false;
            

            IEnumerable<Cell> searchResult = worksheet.Search(searchString, options);
            if (searchResult.Count() > 0)
                searchStringFlag = true;
            else
                return false;

            foreach (Cell cell in searchResult)
            {
                if (mark)
                    cell.Fill.BackgroundColor = Color.LightBlue;

                string value = cell.Value.TextValue;
                cell.Value = value.Replace(searchString, replaceSerachString);
            }

            

            try
            {
                workbook.SaveDocument(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Файл: " + path + ". Не был отредактирован так как открыт в проводнике", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return searchStringFlag;
        }

        public bool MarkRussianString(string path, string searchString)
        {
            bool searchStringFlag = false;
            DevExpress.Spreadsheet.IWorkbook workbook;
            Worksheet worksheet;
            workbook = spreadsheetControl.Document;
            try
            {
                workbook.LoadDocument(path);
            }
            catch (Exception)
            {
                return true;
            }

            worksheet = workbook.Worksheets[0];
            //workbookk.LoadDocument(data);

            SearchOptions options = new SearchOptions();
            options.SearchBy = SearchBy.Rows;
            options.SearchIn = SearchIn.Values;
            options.MatchEntireCellContents = false;
            options.MatchCase = false;


            IEnumerable<Cell> searchResult = worksheet.Search(searchString, options);
            if (searchResult.Count() > 0)
                searchStringFlag = true;
            else
                return false;

            foreach (Cell cell in searchResult)
                    cell.Fill.BackgroundColor = Color.LightBlue;

            try
            {
                workbook.SaveDocument(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Файл: " + path + ". Не был отредактирован так как открыт в проводнике", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return searchStringFlag;
        }

        private void searchStringBtn_Click(object sender, EventArgs e)
        {
            if (PathToDirectory.Count > 0)
            {
                ClearCheckString();
                ActiveButton(false);


                ReplaceString replaceStringModel = new ReplaceString();
                using (ReplaceStringFm replaceStringFm = new ReplaceStringFm())
                {
                    if (replaceStringFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        replaceStringModel = replaceStringFm.Return();

                    }
                    else
                    {
                        return;

                    }
                }

                progressLbl.Text = "Производим поиск строк";
                progressLbl.Refresh();

                updateProgress.Properties.Step = 1;
                updateProgress.Properties.PercentView = true;
                updateProgress.Properties.Maximum = PathToDirectory.Count;
                updateProgress.Properties.Minimum = 0;

                foreach (var item in PathToDirectory)
                {
                    if (MarkRussianString(item.Path, replaceStringModel.SearchStringText))
                        item.CheckString = true;



                    updateProgress.PerformStep();
                    updateProgress.Update();
                }
                updateProgress.EditValue = 0;

                LoadData();

                progressLbl.Text = "Поиск завершен, ячейки где был найден текст - отмечены";
                progressLbl.Refresh();
                ActiveButton(true);

            }
            else
            {
                MessageBox.Show("Не найдено файлы в папке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchPathToDirectoryFilesBtn_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.ShowNewFolderButton = true;
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                pathToDirectoryAllFilesEdit.Text = folderBrowserDlg.SelectedPath;
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;

                LoadAllFiles();
            }
        }

        private void searchCharAllFilesBtn_Click(object sender, EventArgs e)
        {
            if (PathToDirectory.Count > 0)
            {
                ClearCheck();
                ActiveButton(false);


                progressPathLbl.Text = "Происходит поиск символов";
                progressPathLbl.Refresh();

                updateProgressPath.Properties.Step = 1;
                updateProgressPath.Properties.PercentView = true;
                updateProgressPath.Properties.Maximum = PathToDirectoryAllFiles.Count;
                updateProgressPath.Properties.Minimum = 0;

                foreach (var item in PathToDirectoryAllFiles)
                {
                    if (SearchRussianCharInPath(item.Path, false))
                        item.Check = true;

                    updateProgressPath.PerformStep();
                    updateProgressPath.Update();
                }
                updateProgressPath.EditValue = 0;

                LoadDataAlFiles();

                progressPathLbl.Text = "Символы найдены";
                progressPathLbl.Refresh();
                ActiveButton(true);

            }
            else
            {
                MessageBox.Show("Не найдено файлы в папке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}