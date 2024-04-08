using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.Data
{
    public static class DataInitializer
    {
        public static void SeedData()
        {
            var context = new EmployeeDBContext();
            context.Database.Migrate();
        }
    }
}
