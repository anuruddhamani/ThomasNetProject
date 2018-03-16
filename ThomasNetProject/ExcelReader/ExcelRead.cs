using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasNetProject.ExcelReader
{
    public class ExcelRead
    {
        private static IDictionary<string, IExcelDataReader> _cache;
        private static FileStream stream;
        private static IExcelDataReader reader;
        public static string xlPath;

        static ExcelRead()
        {
            _cache = new Dictionary<string, IExcelDataReader>();
        }

        public static string GetCellData(string xlPath,string sheetname, int row, int col)
        {

            if (_cache.ContainsKey(sheetname))
            {
                reader = _cache[sheetname];

            }
            else
            {
                stream = new FileStream(xlPath, FileMode.Open, FileAccess.Read);
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                _cache.Add(sheetname, reader);
            }
            DataTable table = reader.AsDataSet().Tables[sheetname];
            return table.Rows[row][col].ToString();
        }
    }
}
