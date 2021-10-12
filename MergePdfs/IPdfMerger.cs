using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergePdfs
{
    public interface IPdfMerger
    {
        Task Merge(string outputFilePath, params string[] filePaths);
    }
}
