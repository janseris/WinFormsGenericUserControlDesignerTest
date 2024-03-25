using System.IO;

namespace Shared
{
    /// <summary>
    /// Useful for cases when we don't want to read files into memory but pass them around as stream (1+GB files etc.)
    /// </summary>
    public class FileStreamModel : FileModelBase
    {
        public FileStream Stream { get; set; }
    }
}
