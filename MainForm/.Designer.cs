namespace MainForm
{
    public partial class EditorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbWorkspace = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbWorkspace
            // 
            this.gbWorkspace.Location = new System.Drawing.Point(12, 12);
            this.gbWorkspace.Name = "gbWorkspace";
            this.gbWorkspace.Size = new System.Drawing.Size(630, 426);
            this.gbWorkspace.TabIndex = 0;
            this.gbWorkspace.TabStop = false;
            this.gbWorkspace.Text = "Workspace";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(680, 35);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "create table";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbWorkspace);
            this.Name = "EditorForm";
            this.Text = "EditorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWorkspace;
        private System.Windows.Forms.Button btnCreate;
    }
}