using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1.Entity
{
    public class EmployeeMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleInitial { get; set; } = null;
        public string? HomePhone { get; set; } = null;
        public string? CellPhone { get; set; } = null;
        public string? OfficeExt { get; set; } = null;
        public string? TaxNumber { get; set; } = null;
        public int Status { get; set; }

        [ForeignKey("Manager")]
        public int? ManagerId { get; set; }

        [ForeignKey("StaffType")]
        public int StaffTypeId { get; set; }

        public EmployeeMaster Manager { get; set; }
        public StaffType StaffType { get; set; }
    }

    public class StaffType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffTypeId { get; set; }
        public string Name { get; set; }
    }
}
