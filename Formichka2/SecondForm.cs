﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formichka2
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
            
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {

        }

        public SecondForm(string labelText):this()
        {
            lblGreetingText.Text = labelText;
        }
    }
}
