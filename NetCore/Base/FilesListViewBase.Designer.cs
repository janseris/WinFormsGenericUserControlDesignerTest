using Shared;

namespace Tempus.Pdf.Conversions.GUI.Components
{
    public partial class FilesListViewBase<TFileModel> : UserControl
        where TFileModel : FileModelBase
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView.Dock = DockStyle.Fill;
            listView.HeaderStyle = ColumnHeaderStyle.None;
            listView.Location = new Point(0, 0);
            listView.Name = "listView";
            listView.Size = new Size(150, 150);
            listView.TabIndex = 7;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.MouseDoubleClick += listView_MouseDoubleClick;
            // 
            // FilesListUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listView);
            Name = "FilesListUC";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView;
        private ColumnHeader columnHeader1;
    }
}
