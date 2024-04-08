using System.ComponentModel;
using WinFormsApp1.Common;
using WinFormsApp1.Data;
using WinFormsApp1.Entity;
using WinFormsApp1.ViewModels;

namespace WinFormsApp1
{
    public partial class frmAddEdit : Form
    {
        public int? SelectedEmplyeeId { get; set; }
        frmMain _owner;
        public frmAddEdit(frmMain owner)
        {
            InitializeComponent();
            _owner = owner;
            this.FormClosed += new FormClosedEventHandler(this.frmAddEdit_FormClosed);
        }

        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            try
            {
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;

                cmbTitle.DataSource = new DropdownItems[] {
                    new DropdownItems{ Value = 1, Text = "Mr" },
                    new DropdownItems{ Value = 2, Text = "Mrs" },
                    new DropdownItems{ Value = 3, Text = "Miss" },
                    new DropdownItems{ Value = 4, Text = "Sir" }
                    };

                cmbTitle.DisplayMember = "Text";
                cmbTitle.ValueMember = "Value";

                using (var dbContext = new EmployeeDBContext())
                {
                    var staffTypes = dbContext.StaffType.ToList();
                    var managers = dbContext.EmployeeMaster.Where(t => t.StaffTypeId == 1).ToList();

                    cmbStaffType.DataSource = staffTypes;
                    cmbStaffType.DisplayMember = "Name";
                    cmbStaffType.ValueMember = "StaffTypeId";

                    cmbManager.DataSource = managers;
                    cmbManager.DisplayMember = "FirstName";
                    cmbManager.ValueMember = "EmployeeId";

                    if (SelectedEmplyeeId.HasValue)
                    {
                        var employee = dbContext.EmployeeMaster.FirstOrDefault(t => t.EmployeeId == SelectedEmplyeeId.Value);

                        cmbStaffType.SelectedValue = employee.StaffTypeId;
                        if (employee.ManagerId.HasValue)
                        {
                            cmbManager.SelectedValue = employee.ManagerId.Value;
                        }
                        cmbTitle.SelectedIndex = cmbTitle.FindStringExact(employee.Title.Trim());
                        txtFirstName.Text = employee.FirstName;
                        txtLastName.Text = employee.LastName;
                        txtHomePhone.Text = employee.HomePhone;
                        txtCellPhone.Text = employee.CellPhone;
                        txtMiddleIntial.Text = employee.MiddleInitial;
                        txtOfficeExt.Text = employee.OfficeExt;
                        txtIrdNo.Text = employee.TaxNumber;

                        var status = Enum.GetName(typeof(EmployeeeStatus), employee.Status);
                        var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                                      .Where(t => t.Text == status).FirstOrDefault();

                        checkedButton.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtFirstName.Text))
                {
                    this.errorProvider1.SetError(this.txtFirstName, "First name is required");
                    return;
                }
                else
                {
                    this.errorProvider1.SetError(this.txtFirstName, null);
                }

                if (string.IsNullOrEmpty(this.txtLastName.Text))
                {
                    this.errorProvider1.SetError(this.txtLastName, "Last name is required");
                    return;
                }
                else
                {
                    this.errorProvider1.SetError(this.txtLastName, null);
                }

                if ((int)cmbStaffType.SelectedValue == 2 && cmbManager.SelectedValue == null)
                {
                    this.errorProvider1.SetError(this.cmbManager, "Manager is required");
                    return;
                }
                else
                {
                    this.errorProvider1.SetError(this.cmbManager, null);
                }

                StaffType staffType = (StaffType)cmbStaffType.SelectedItem;

                using (var dbContext = new EmployeeDBContext())
                {
                    if (SelectedEmplyeeId.HasValue)
                    {
                        var existingEmployee = dbContext.EmployeeMaster.FirstOrDefault(t => t.EmployeeId == SelectedEmplyeeId.Value);

                        existingEmployee.StaffTypeId = (int)cmbStaffType.SelectedValue;
                        existingEmployee.FirstName = txtFirstName.Text.Trim();
                        existingEmployee.LastName = txtLastName.Text.Trim();
                        existingEmployee.CellPhone = txtCellPhone.Text.Trim();
                        existingEmployee.HomePhone = txtHomePhone.Text.Trim();
                        existingEmployee.Title = ((DropdownItems)cmbTitle.SelectedItem).Text.Trim();
                        existingEmployee.MiddleInitial = txtMiddleIntial.Text.Trim();
                        existingEmployee.OfficeExt = txtOfficeExt.Text.Trim();
                        existingEmployee.TaxNumber = txtIrdNo.Text.Trim();
                        existingEmployee.Status = GetStatusValue();
                        existingEmployee.ManagerId = (int)cmbStaffType.SelectedValue == 2 ? (int)cmbManager.SelectedValue : null;

                        dbContext.EmployeeMaster.Attach(existingEmployee);
                    }
                    else
                    {
                        var employee = new EmployeeMaster
                        {
                            StaffTypeId = (int)cmbStaffType.SelectedValue,
                            FirstName = txtFirstName.Text.Trim(),
                            LastName = txtLastName.Text.Trim(),
                            CellPhone = txtCellPhone.Text.Trim(),
                            HomePhone = txtHomePhone.Text.Trim(),
                            Title = cmbTitle.Text.Trim(),
                            MiddleInitial = txtMiddleIntial.Text.Trim(),
                            OfficeExt = txtOfficeExt.Text.Trim(),
                            TaxNumber = txtIrdNo.Text.Trim(),
                            Status = GetStatusValue(),
                            ManagerId = (int)cmbStaffType.SelectedValue != 1 ? (int)cmbManager.SelectedValue : null,
                        };

                        dbContext.EmployeeMaster.Add(employee);
                    }

                    dbContext.SaveChanges();
                }

                MessageBox.Show("contact saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);


                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetStatusValue()
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                                  .FirstOrDefault(r => r.Checked);
            int value = (int)Enum.Parse(typeof(EmployeeeStatus), checkedButton.Text);
            return value;
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFirstName.Text))
            {
                this.errorProvider1.SetError(this.txtFirstName, "First name is required");
            }
            else
            {
                this.errorProvider1.SetError(this.txtFirstName, null);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtLastName.Text))
            {
                this.errorProvider1.SetError(this.txtLastName, "Last name is required");
            }
            else
            {
                this.errorProvider1.SetError(this.txtLastName, null);
            }
        }

        private void cmbStaffType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                StaffType cmb = (StaffType)cmbStaffType.SelectedItem;
                int selectedValue = cmb.StaffTypeId;

                if (selectedValue == 1)
                {
                    panel1.Hide();
                }
                else
                {
                    panel1.Show();
                }
            }
            catch
            {
            }

        }

        private void frmAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.RefreshPage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
