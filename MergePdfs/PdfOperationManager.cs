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
        public Task<string> Merge(List<string> filePaths, string outputFileName)
        {
            filePaths.Sort();

            outputFileName = string.IsNullOrEmpty(outputFileName) ? $"MergedFile_{DateTime.Now:ddmmyyhhsstt}" : outputFileName;

            string outputFilePath = $"{Path.GetDirectoryName(filePaths.FirstOrDefault())}\\{outputFileName}.pdf";

            PdfImportedPage importedPage;

            Document sourceDocument = new Document();
            PdfCopy pdfCopyProvider = new PdfCopy(sourceDocument, new FileStream(outputFilePath, FileMode.Create));

            //output file Open  
            sourceDocument.Open();

            foreach (var file in filePaths)
            {
                PdfReader reader = new PdfReader(file);
                int pages = reader.NumberOfPages;

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
    }
}
