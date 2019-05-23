using FastReport.Data.ConnectionEditors;
using System.Text;

namespace TestConnect
{
    internal class NameConnectionEditor : ConnectionEditorBase
    {

        private void Localize()
        {
            
        }
        protected override string GetConnectionString()
        {
            StringBuilder builder = new StringBuilder();
            
            return builder.ToString();
        }

        public NameConnectionEditor()
        {
            InitializeComponent();
            Localize();
        }

        

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // NameConnectionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.Name = "NameConnectionEditor";
            this.ResumeLayout(false);

        }
    }
}