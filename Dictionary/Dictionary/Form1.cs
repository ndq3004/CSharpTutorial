using Dictionary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        DictionaryManager dictionary;
        public Form1()
        {
            InitializeComponent();

            cbWord.DisplayMember = "Key";
            dictionary = new DictionaryManager();
            dictionary.LoadDataToCombo(cbWord);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

            dictionary.Serialize();
        }

        private void cbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.DataSource == null)
            {
                return;
            }
            DictionaryData data = cb.SelectedItem as DictionaryData;
            txbMeaning.Text = data.Meaning;
            txbExplanation.Text = data.Explaination;
        }
    }
}
