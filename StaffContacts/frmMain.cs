using Microsoft.EntityFrameworkCore;
using StaffContacts.Helpers;
using StaffContacts.ViewModels;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using WinFormsApp1.Common;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class frmMain : Form
    {
        private EmployeeDBContext? dbContext;
        private List<EmployeeViewModel> employeeList = new();

        private string stringToPrint = "";
        private Font printFont;
        private string documentContents = "";

        public frmMain()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }

        public void LoadEmployees()
        {
            try
            {
                this.dbContext = new EmployeeDBContext();
                this.dbContext.Database.EnsureCreated();

                employeeList = dbContext.EmployeeMaster.Include(t => t.StaffType).Include(t => t.Manager)
                    .Where(t => t.Status == (int)EmployeeeStatus.Active).AsEnumerable()
                    .Select(t => new EmployeeViewModel()
                    {
                        Title = t.Title,
                        EmployeeId = t.EmployeeId,
                        FirstName = t.FirstName,
                        LastName = t.LastName,
                        HomePhone = t.HomePhone,
                        OfficeExt = t.OfficeExt,
                        CellPhone = t.CellPhone,
                        MiddleInitial = t.MiddleInitial,
                        StaffTypeName = t.StaffType.Name,
                        TaxNumber = t.TaxNumber,
                        ManagerName = t.Manager != null ? t.Manager.FirstName + " " + t.Manager.LastName : string.Empty,
                        Status = Enum.GetName(typeof(EmployeeeStatus), t.Status),
                    }).ToList();

                dtGridEmployees.DataSource = employeeList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit editForm = new frmAddEdit(this);
            editForm.Show();
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
            dtGridEmployees.Refresh();
        }

        public void RefreshPage()
        {
            LoadEmployees();
            dtGridEmployees.Refresh();
        }

        private void dtGridEmployees_DoubleClick(object sender, EventArgs e)
        {



        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtGridEmployees.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dtGridEmployees.SelectedRows[0];
                int selectedId = Convert.ToInt32(dtGridEmployees.SelectedRows[0].Cells["EmployeeId"].Value);

                frmAddEdit editForm = new frmAddEdit(this);
                editForm.SelectedEmplyeeId = selectedId;
                editForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        var sortedList = employeeList.OrderBy(t => t.StaffTypeName).ThenBy(t => t.FirstName).ToList();
                        var path = ExportData.ExportCsv(sortedList, fbd.SelectedPath);
                        MessageBox.Show($"File {path} export completed", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var sortedList = employeeList.OrderBy(t => t.StaffTypeName).ThenBy(t => t.FirstName).ToList();
                var filePath = ExportData.ExportCsv(sortedList, AppDomain.CurrentDomain.BaseDirectory);

                printDocument1.DocumentName = "Contact List";
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
                {
                    documentContents = reader.ReadToEnd();
                }
                stringToPrint = documentContents;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
            e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);

            // If there are no more pages, reset the string to be printed.
            if (!e.HasMorePages)
                stringToPrint = documentContents;
        }
    }
}