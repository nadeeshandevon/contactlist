namespace StaffContacts.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleInitial { get; set; } = null;
        public string? HomePhone { get; set; } = null;
        public string? CellPhone { get; set; } = null;
        public string? OfficeExt { get; set; } = null;
        public string? TaxNumber { get; set; } = null;
        public string Status { get; set; }
        public string ManagerName { get; set; }
        public string StaffTypeName { get; set; }
    }
}
