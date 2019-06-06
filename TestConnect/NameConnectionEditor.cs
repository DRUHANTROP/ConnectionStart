using FastReport.Data.ConnectionEditors;
using System.Text;
namespace TestConnect
{
    internal class NameConnectionEditor : ConnectionEditorBase
    {
        private System.Windows.Forms.Button button1;

        private void Localize()
        {

        }
        protected override string GetConnectionString()
        {
            StringBuilder builder = new StringBuilder();
            
            return builder.ToString();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameConnectionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.Controls.Add(this.button1);
            this.Name = "NameConnectionEditor";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            PluginForm pf = new PluginForm();
            pf.ShowDialog();
        }
    }
}