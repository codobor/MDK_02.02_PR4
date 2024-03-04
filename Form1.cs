using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antonov4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Выберите строку");
                return;
            }

            string str = listBox1.Items[index].ToString();
            int countOnes = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                    countOnes++;
            }

            label1.Text = "Количество единиц: " + countOnes
                + Environment.NewLine +
                "Количество нулей: " + (str.Length - countOnes);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
