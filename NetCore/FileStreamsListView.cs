using Shared;

using Tempus.Pdf.Conversions.GUI.Components;

namespace NetCoreWinForms
{
    /// <summary>
    /// For large files which cannot be loaded into <see cref="byte[]"/> - <see cref="FileStream"/> must be used
    /// </summary>
    public class FileStreamsListView : FilesListViewBase<FileStreamModel>
    {
    }
}
