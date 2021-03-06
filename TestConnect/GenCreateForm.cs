using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Degenerators;

namespace TestConnect
{
    public partial class GenCreateForm : Form
    {
        List<string> descs = new List<string>();
        public GenCreateForm()
        {
            InitializeComponent();

            comboBox1.Items.Clear();
            foreach(IRandomGenerator generator in Utils.Generators)
            {
                comboBox1.Items.Add(generator.Name);
                descs.Add(generator.Description);
            }
            
            comboBox1.SelectedIndex = 0;
            DescLabel.Text = "Returns random name from list \n Example : Bruce";
        }
        public bool createAvailable = false;
        private IRandomGenerator generator;

        internal IRandomGenerator Generator { get => generator; set => generator = (IRandomGenerator)value; }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                foreach(IRandomGenerator gen in Utils.Generators)
                {
                    if(gen.Name.Equals(comboBox1.SelectedItem))
                    {

                        Generator = gen.Create();
                        Generator.ColumnName = textBox1.Text;
                        break;
                    }
                }
                createAvailable = true;
                Hide();
            }
            else textBox1.BackColor = Color.LightPink;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescLabel.Text = descs[comboBox1.SelectedIndex];
        }
    }
}