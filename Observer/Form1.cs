using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer {
    public partial class Form1 : Form {
        public Form1() {
            this.InitializeComponent();
        }

        // This method is invoked when a key is pressed on the 'textBox1' textBox.
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            // The sender is the text box.
            var txtBox = (TextBox)sender;
            char pressedKey = e.KeyChar;
            // ..
            // Do some logic here
        }
    }
}