using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formichka2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Здрасти, {txtName.Text}!");
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.ImageLocation = openPictureDialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.Filter = "RTF Files|*.rtf";
            if ((saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && (saveFileDialog1.FileName.Length > 0)))
            {
                try
                {
                    richTxtComment.SaveFile(saveFileDialog1.FileName);
                }
                catch(Exception)
                {

                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //SecondForm secondForm = new SecondForm();
            string str = $"Здравей, {txtName.Text.Trim()}!          Коментар: {richTxtComment.Text}";
            SecondForm secondForm = new SecondForm(str);
            secondForm.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            string str = $"Здравей, {txtName.Text.Trim()}!          Коментар: {richTxtComment.Text}";
            SecondForm secondForm = new SecondForm(str);
            secondForm.ShowDialog();

            if (DialogResult.Yes == secondForm.ShowDialog())
            {
                MessageBox.Show("Вие натиснахте бутона Yes");
            }
            else
            {
                MessageBox.Show("Вие затворихте прозореца без да натиснете бутона Yes");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
