using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Nulo {

    public partial class MainPage : Form {

        public MainPage() {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if(checkBox1.Checked) {
                smartPrimaryButton1.Enabled = true;
                smartSecondaryButton1.Enabled = true;
            } else {
                smartPrimaryButton1.Enabled = false;
                smartSecondaryButton1.Enabled = false;
            }
        }
    }
}