using FastReport.Data.ConnectionEditors;
using System;
using System.Collections.Generic;

namespace TestConnect
{
    internal class NameConnectionEditor : ConnectionEditorBase
    {
       

        private void Localize()
        {

        }
        public NameConnectionEditor()
        {
            InitializeComponent();
            Localize();
        }
        protected override string GetConnectionString()
        {
            
            MeGonnaBeRandomConnectionStringBuilder result = new MeGonnaBeRandomConnectionStringBuilder();
            result.RowCount = (int)numericUpDown1.Value;

            List<string> generators = new List<string>();
            foreach(object generator in generatorsLB.Items)
            {
                generators.Add(generator.ToString());
            }

            result.Generators = generators.ToArray();


            return result.ToString();
        }
        protected override void SetConnectionString(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                MeGonnaBeRandomConnectionStringBuilder sb = new MeGonnaBeRandomConnectionStringBuilder();
                sb.ConnectionString = value;

                numericUpDown1.Value = sb.RowCount;

                generatorsLB.Items.Clear();

                foreach (string generator in sb.Generators)
                {
                    generatorsLB.Items.Add(generator);
                }

            }

        }

        private System.Windows.Forms.GroupBox groupBox1;
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            GenCreateForm genCreate = new GenCreateForm();
            genCreate.ShowDialog();
            if (genCreate.createAvailable)
            {
                
                generatorsLB.Items.Add(genCreate.Generator.ColumnName + " : " + genCreate.Generator.Name);
                genCreate.Close();
            }

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generatorsLB = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generatorsLB
            // 
            this.generatorsLB.FormattingEnabled = true;
            this.generatorsLB.Location = new System.Drawing.Point(10, 19);
            this.generatorsLB.Name = "generatorsLB";
            this.generatorsLB.Size = new System.Drawing.Size(184, 173);
            this.generatorsLB.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "+ Add Generator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(200, 59);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.generatorsLB);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generators";
            // 
            // NameConnectionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBox1);
            this.Name = "NameConnectionEditor";
            this.Size = new System.Drawing.Size(336, 222);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox generatorsLB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
    }
