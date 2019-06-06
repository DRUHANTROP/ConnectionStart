
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RandomicGenerator;

namespace TestConnect
{
    public partial class PluginForm : Form
    {
        public PluginForm()
        {
            InitializeComponent();
        }
        private List<IRandomGenerator> generators = new List<IRandomGenerator>();
        private void button1_Click(object sender, EventArgs e)
        {
            GenCreateForm genCreate = new GenCreateForm();
            genCreate.ShowDialog();
            if (genCreate.createAvailable)
            {
                generators.Add(genCreate.Generator);
                generatorsLB.Items.Add(genCreate.Generator.Name);
                genCreate.Close();
            }

        }
    }
}