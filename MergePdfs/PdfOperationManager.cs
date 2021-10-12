using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergePdfs
{
    public class PdfOperationManager : IPdfMerger
    {
        public Task Merge(string outputFilePath, params string[] filePaths)
        {
            throw new NotImplementedException();
        }
    }
}
