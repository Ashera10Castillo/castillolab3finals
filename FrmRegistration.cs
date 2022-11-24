using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String getInput = txtStudentNo.Text;
            String getInput1 = txtLastName.Text;
            String getInput2 = txtFirstName.Text;
            String getInput3 = txtMI.Text;
            String getInput4 = txtAge.Text;
            String getInput5 = txtContactNo.Text;
            String getInput6 = cbGender.Text;
            String getInput7 = cbProgram.Text;
            String getInput8 = dateBirthday.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, getInput + ".txt")))
            {
                outputFile.WriteLine("Student No: " + getInput);
                outputFile.WriteLine("Last Name: " + getInput1);
                outputFile.WriteLine("First Name: " + getInput2);
                outputFile.WriteLine("Middle Name: " + getInput3);
                outputFile.WriteLine("Age: " + getInput4);
                outputFile.WriteLine("Contact No: " + getInput5);
                outputFile.WriteLine("Gender: " + getInput6);
                outputFile.WriteLine("Program: " + getInput7);
                outputFile.WriteLine("Birthday: " + getInput8);
                Console.WriteLine(getInput);
                Console.WriteLine(getInput1);
                Console.WriteLine(getInput2);
                Console.WriteLine(getInput3);
                Console.WriteLine(getInput4);
                Console.WriteLine(getInput5);
                Console.WriteLine(getInput6);
                Console.WriteLine(getInput7);
                Console.WriteLine(getInput8);
                Close();
            }
        }

   
    }
}
