using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M18___Ficha_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Trim() == "")
            {
                erp_Errors.SetError(txt_Name, "Campo obrigatório!");
            }
            if(mtxt_BirthDate.MaskFull == false)
            {
                erp_Errors.SetError(mtxt_BirthDate, "Campo obrigtório!");
            }
            if(mtxt_Email.MaskFull == false)
            {
                erp_Errors.SetError(mtxt_Email, "Campo obrigtório!");
            }
            if (cbb_Class.SelectedItem == null)
            {
                erp_Errors.SetError(cbb_Class, "Campo obrigtório!");
            }
            if(pb_Picture.Image == null)
            {
                erp_Errors.SetError(btn_UploadImage, "Tem que inserir uma imagem!");
            }

            if(txt_Name.Text.Trim() != "" && mtxt_BirthDate.MaskFull != false && mtxt_Email.MaskFull != false && cbb_Class.SelectedItem != null)
            {
                string aux = "Nome: " + txt_Name.Text + "\nData de Nascimento: " + mtxt_BirthDate.Text + "\nEmail: " + mtxt_Email.Text + "\nTurma: " + cbb_Class.SelectedItem;

                MessageBox.Show(aux, "Ficha do aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            erp_Errors.SetError(txt_Name, null);
        }

        private void mtxt_Email_TextChanged(object sender, EventArgs e)
        {
            erp_Errors.SetError(mtxt_Email, null);
        }

        private void mtxt_BirthDate_TextChanged(object sender, EventArgs e)
        {
                erp_Errors.SetError(mtxt_BirthDate, null);
        }

        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp; *.gif|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != null)
            {
                pb_Picture.Image = new Bitmap(openFileDialog.FileName);
                lbl_InsertImage.Visible = false;
            }

        }

        private void cbb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            erp_Errors.SetError(cbb_Class, null);
        }
    }
}
