using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
           /* string fileName = Guid.NewGuid().ToString() + ".txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                string line = $"{txtFullName.Text}, {txtYear.Text}, {txtCity.Text}, {txtFaculty.Text}, {txtRole.Text}, {txtRoleSpecific.Text}";
                writer.WriteLine(line);
            }
           */
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.Title = "Odaberi datoteku za spremanje";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(textBox1.Text);
                }
            }

        }

        /* private void label1_Click(object sender, EventArgs e)
         {

         }

         private void label3_Click(object sender, EventArgs e)
         {

         }
        */

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
