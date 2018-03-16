using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasNetProject.PageUtility.PDFReaderFolder
{
    public class PDFReaderP
    {
        public static StringBuilder result=null;
        public static PdfReader reader=null;
        //public static string PDFFilePath;
        public static string ExtractPDF(string PDFFilePath)
        {
            result = new StringBuilder();
            using(reader=new PdfReader(PDFFilePath))
            {
                for(int page = 1; page <= reader.NumberOfPages; page++)
                {
                    SimpleTextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string pageText = PdfTextExtractor.GetTextFromPage(reader, page, strategy);
                    result.Append(pageText);
                }
            }
            return result.ToString();
        }
    }
}
