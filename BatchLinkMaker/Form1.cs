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

namespace BatchLinkMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var startIndex = int.Parse(from_txt.Text);
            var endIndex = int.Parse(to_txt.Text);

            result_txt.Text = "";

            if (startIndex<endIndex)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    var tempText = baseURL_txt.Text.Replace("#", i.ToString());
                    result_txt.AppendText(tempText+"\r\n");
                }    
            }
            else
            {
                MessageBox.Show(@"start range cannot be larger than end range!!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            
            saveFileDialog1.Title = "Save Result to a File";
            saveFileDialog1.ShowDialog();


            if (saveFileDialog1.FileName != "")
            {
                var path = Path.GetFullPath(saveFileDialog1.FileName);
                File.WriteAllText(path,result_txt.Text);
            }
        }
    }
}
