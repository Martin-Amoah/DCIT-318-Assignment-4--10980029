using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address_Book_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Retrieve the entered information
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;

            // Validate the input (basic validation)
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Save the information (for this example, just show a message box)
            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone Number: {phoneNumber}", "Information Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the text boxes after saving
            txtName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
