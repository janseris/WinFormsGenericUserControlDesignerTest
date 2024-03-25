using Shared;

using System.Data;

namespace Tempus.Pdf.Conversions.GUI.Components
{
    public partial class FilesListViewBase<TFileModel> : UserControl
        where TFileModel : FileModelBase
    {
        public FilesListViewBase()
        {
            InitializeComponent();
        }

        public event EventHandler<TFileModel> ItemDoubleClick;

        private IList<TFileModel> _items = new List<TFileModel>();
        public IList<TFileModel> Items
        {
            get => _items.AsReadOnly();
            set
            {
                _items = value;
                listView.Items.Clear();
                var items = value.Select(ToListViewItem).ToArray();
                listView.Items.AddRange(items);
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private static ListViewItem ToListViewItem(TFileModel file)
        {
            return new ListViewItem
            {
                Text = file.Name,
                Tag = file,
            };
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView.HitTest(e.X, e.Y);
            ListViewItem listViewItem = info.Item;

            if (listViewItem is null)
            {
                return;
            }

            var item = listViewItem.Tag as TFileModel;
            ItemDoubleClick?.Invoke(this, item);
        }
    }
}
