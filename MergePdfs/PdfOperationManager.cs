using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MergePdfs
{
    public class PdfOperationManager : IPdfMerger
    {
        public Task<string> Merge(List<string> filePaths)
        {
            filePaths.Sort();

            string outputFilePath = $"{Path.GetDirectoryName(filePaths.FirstOrDefault())}\\MergedFile_{DateTime.Now:ddmmyyhhsstt}.pdf";

            PdfImportedPage importedPage;

            Document sourceDocument = new Document();
            PdfCopy pdfCopyProvider = new PdfCopy(sourceDocument, new FileStream(outputFilePath, FileMode.Create));

            //output file Open  
            sourceDocument.Open();

            foreach (var file in filePaths)
            {
                int pages = TotalPageCount(file);

                PdfReader reader = new PdfReader(file);
                //Add pages in new file  
                for (int i = 1; i <= pages; i++)
                {
                    importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                    pdfCopyProvider.AddPage(importedPage);
                }

                reader.Close();
            }

            //save the output file  
            sourceDocument.Close();

            return Task.FromResult(outputFilePath);
        }

        private static int TotalPageCount(string file)
        {
            using (StreamReader sr = new StreamReader(System.IO.File.OpenRead(file)))
            {
                Regex regex = new Regex(@"/Type\s*/Page[^s]");
                MatchCollection matches = regex.Matches(sr.ReadToEnd());

                return matches.Count;
            }
        }
    }
}
