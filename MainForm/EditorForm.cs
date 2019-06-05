using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainForm
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TableLayoutPanel tlp = new TableLayoutPanel();
            gbWorkspace.Controls.Add(tlp);
            tlp.Bounds = new Rectangle(Cursor.Position,new Size(100,40));
        }
    }
}
