using System.Text;

namespace StaffContacts.Helpers
{
    public static class ExportData
    {
        public static string ExportCsv<T>(List<T> dataList, string basePath)
        {
            var sb = new StringBuilder();
            var finalPath = Path.Combine(basePath, $"StaffContacts-{DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss")}.csv");
            var header = "";
            var info = typeof(T).GetProperties();
            if (!File.Exists(finalPath))
            {
                var file = File.Create(finalPath);
                file.Close();
                foreach (var prop in typeof(T).GetProperties())
                {
                    header += prop.Name + ", ";
                }
                header = header.Substring(0, header.Length - 2);
                sb.AppendLine(header);
                TextWriter sw = new StreamWriter(finalPath, true);
                sw.Write(sb.ToString());
                sw.Close();
            }

            foreach (var obj in dataList)
            {
                sb = new StringBuilder();
                var line = "";
                foreach (var prop in info)
                {
                    line += prop.GetValue(obj, null) + ", ";
                }
                line = line.Substring(0, line.Length - 2);
                sb.AppendLine(line);
                TextWriter sw = new StreamWriter(finalPath, true);
                sw.Write(sb.ToString());
                sw.Close();
            }

            return finalPath;
        }
    }
}
