<<<<<<< HEAD
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
    public partial class GenCreateForm : Form
    {
        public GenCreateForm()
        {
            InitializeComponent();
            string[] arr = {"First Name","Last Name","Full Name","Integer","Date","Mixed (in progress)" };
            comboBox1.Items.AddRange(arr);
            comboBox1.SelectedIndex = 0;
        }
        public bool createAvailable = false;
        private IRandomGenerator generator;

        internal IRandomGenerator Generator { get => generator; set => generator = value; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        Generator = new FirstNameGenerator();
                        Generator.Name = textBox1.Text + "; First name";
                        break;
                    case 1:
                        Generator = new LastNameGenerator();
                        Generator.Name = textBox1.Text + "; Last name";
                        break;
                    case 2:
                        Generator = new FullNameGenerator();
                        Generator.Name = textBox1.Text + "; Full name";
                        break;
                    case 3:
                        Generator = new IntGenerator();
                        Generator.Name = textBox1.Text + "; Integer";
                        break;
                    case 4:
                        Generator = new DateGenerator();
                        Generator.Name = textBox1.Text + "; Date";
                        break;
                    case 5:
                        Generator = new MixedGenerator();
                        Generator.Name = textBox1.Text + "; Mixed";
                        break;
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
    }
}
=======
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
    public partial class GenCreateForm : Form
    {
        public GenCreateForm()
        {
            InitializeComponent();
            string[] arr = {"First Name","Last Name","Full Name","Integer","Date","Mixed (in progress)" };
            comboBox1.Items.AddRange(arr);
            comboBox1.SelectedIndex = 0;
        }
        public bool createAvailable = false;
        private IRandomGenerator generator;

        internal IRandomGenerator Generator { get => generator; set => generator = value; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        Generator = new FirstNameGenerator();
                        Generator.Name = textBox1.Text + "; First name";
                        break;
                    case 1:
                        Generator = new LastNameGenerator();
                        Generator.Name = textBox1.Text + "; Last name";
                        break;
                    case 2:
                        Generator = new FullNameGenerator();
                        Generator.Name = textBox1.Text + "; Full name";
                        break;
                    case 3:
                        Generator = new IntGenerator();
                        Generator.Name = textBox1.Text + "; Integer";
                        break;
                    case 4:
                        Generator = new DateGenerator();
                        Generator.Name = textBox1.Text + "; Date";
                        break;
                    case 5:
                        Generator = new MixedGenerator();
                        Generator.Name = textBox1.Text + "; Mixed";
                        break;
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
    }
}
>>>>>>> 0c7653ce58b613fb77733e43695e44721ddfed95
