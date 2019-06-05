using FastReport.Data.ConnectionEditors;
using System.Text;

namespace TestConnect
{
    internal class NameConnectionEditor : ConnectionEditorBase
    {
        private System.Windows.Forms.Button btnEdit;

        private void Localize()
        {
            
        }
        
        protected override string GetConnectionString()
        {
            StringBuilder builder = new StringBuilder();
            
            return builder.ToString();
        }
        protected override void SetConnectionString(string value)
        {
            this.ConnectionString = value;
        }

        public NameConnectionEditor()
        {
            
            InitializeComponent();
            Localize();
        }
        


        private void InitializeComponent()
        {
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(68, 47);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // NameConnectionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.Controls.Add(this.btnEdit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(224, 533);
            this.MinimumSize = new System.Drawing.Size(224, 0);
            this.Name = "NameConnectionEditor";
            this.Size = new System.Drawing.Size(224, 128);
            this.ResumeLayout(false);

        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            EditorForm editor = new EditorForm();
            editor.Show();
        }
    }
}