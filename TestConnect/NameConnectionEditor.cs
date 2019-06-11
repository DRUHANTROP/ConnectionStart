using FastReport.Data.ConnectionEditors;
using RandomicGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

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
            XmlSerializer formatter = new XmlSerializer(typeof(IRandomGenerator[]));
            generatorsLB.Items.Clear();
            using (FileStream fs = new FileStream("generators.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, generators.ToArray());
                // connectionString;
            }
            return "generators.xml";
        }
        protected override void SetConnectionString(string value)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(IRandomGenerator[]));
            using (FileStream fs = new FileStream("generators.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    generators = new List<IRandomGenerator>(formatter.Deserialize(fs) as IRandomGenerator[]);
                }
                catch
                {
                    generators = new List<IRandomGenerator>();
                }
                foreach(var x in generators)
                {
                    generatorsLB.Items.Add(x);
                }
                ConnectionString = value;
            }
        }

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
        public List<IRandomGenerator> generators = new List<IRandomGenerator>();
        private void button1_Click(object sender, EventArgs e)
        {
            GenCreateForm genCreate = new GenCreateForm();
            genCreate.ShowDialog();
            if (genCreate.createAvailable)
            {
                generators.Add(genCreate.Generator as IRandomGenerator);
                generatorsLB.Items.Add(genCreate.Generator.Name);
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // generatorsLB
            // 
            this.generatorsLB.FormattingEnabled = true;
            this.generatorsLB.Location = new System.Drawing.Point(12, 25);
            this.generatorsLB.Name = "generatorsLB";
            this.generatorsLB.Size = new System.Drawing.Size(184, 212);
            this.generatorsLB.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+ Add Generator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generators";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(202, 104);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count";
            // 
            // NameConnectionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generatorsLB);
            this.Name = "NameConnectionEditor";
            this.Size = new System.Drawing.Size(336, 245);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox generatorsLB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
    }
