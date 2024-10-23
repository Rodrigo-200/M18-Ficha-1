
namespace M18___Ficha_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mtxt_BirthDate = new System.Windows.Forms.MaskedTextBox();
            this.pb_Picture = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_BrithDate = new System.Windows.Forms.Label();
            this.mtxt_Email = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Class = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.erp_Errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_InsertImage = new System.Windows.Forms.Label();
            this.btn_UploadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Errors)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxt_BirthDate
            // 
            this.mtxt_BirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxt_BirthDate.BackColor = System.Drawing.SystemColors.Control;
            this.mtxt_BirthDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxt_BirthDate.Location = new System.Drawing.Point(217, 88);
            this.mtxt_BirthDate.Mask = "00/00/0000";
            this.mtxt_BirthDate.Name = "mtxt_BirthDate";
            this.mtxt_BirthDate.Size = new System.Drawing.Size(92, 15);
            this.mtxt_BirthDate.TabIndex = 0;
            this.mtxt_BirthDate.ValidatingType = typeof(System.DateTime);
            this.mtxt_BirthDate.TextChanged += new System.EventHandler(this.mtxt_BirthDate_TextChanged);
            // 
            // pb_Picture
            // 
            this.pb_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Picture.Location = new System.Drawing.Point(12, 12);
            this.pb_Picture.Name = "pb_Picture";
            this.pb_Picture.Size = new System.Drawing.Size(183, 153);
            this.pb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Picture.TabIndex = 1;
            this.pb_Picture.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(212, 12);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 17);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Nome";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Name.Location = new System.Drawing.Point(213, 33);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(133, 22);
            this.txt_Name.TabIndex = 3;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // lbl_BrithDate
            // 
            this.lbl_BrithDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BrithDate.AutoSize = true;
            this.lbl_BrithDate.Location = new System.Drawing.Point(212, 67);
            this.lbl_BrithDate.Name = "lbl_BrithDate";
            this.lbl_BrithDate.Size = new System.Drawing.Size(134, 17);
            this.lbl_BrithDate.TabIndex = 4;
            this.lbl_BrithDate.Text = "Data de nascimento";
            // 
            // mtxt_Email
            // 
            this.mtxt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxt_Email.BackColor = System.Drawing.SystemColors.Control;
            this.mtxt_Email.Location = new System.Drawing.Point(213, 140);
            this.mtxt_Email.Mask = "I000000@inete\\.net";
            this.mtxt_Email.Name = "mtxt_Email";
            this.mtxt_Email.Size = new System.Drawing.Size(133, 22);
            this.mtxt_Email.TabIndex = 5;
            this.mtxt_Email.ValidatingType = typeof(System.DateTime);
            this.mtxt_Email.TextChanged += new System.EventHandler(this.mtxt_Email_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // cbb_Class
            // 
            this.cbb_Class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Class.BackColor = System.Drawing.SystemColors.Control;
            this.cbb_Class.FormattingEnabled = true;
            this.cbb_Class.Items.AddRange(new object[] {
            "TGPSI22/01",
            "TGPSI22/02",
            "TGPSI23/01",
            "TGPSI23/02",
            "TGPSI24/01",
            "TGPSI24/02"});
            this.cbb_Class.Location = new System.Drawing.Point(215, 203);
            this.cbb_Class.Name = "cbb_Class";
            this.cbb_Class.Size = new System.Drawing.Size(121, 24);
            this.cbb_Class.TabIndex = 7;
            this.cbb_Class.SelectedIndexChanged += new System.EventHandler(this.cbb_Class_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Turma";
            // 
            // erp_Errors
            // 
            this.erp_Errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp_Errors.ContainerControl = this;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirm.Location = new System.Drawing.Point(215, 251);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(121, 23);
            this.btn_Confirm.TabIndex = 9;
            this.btn_Confirm.Text = "Confirmar";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_InsertImage
            // 
            this.lbl_InsertImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_InsertImage.AutoSize = true;
            this.lbl_InsertImage.Location = new System.Drawing.Point(38, 81);
            this.lbl_InsertImage.Name = "lbl_InsertImage";
            this.lbl_InsertImage.Size = new System.Drawing.Size(126, 17);
            this.lbl_InsertImage.TabIndex = 10;
            this.lbl_InsertImage.Text = "Insira uma imagem";
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UploadImage.Location = new System.Drawing.Point(12, 171);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(183, 23);
            this.btn_UploadImage.TabIndex = 11;
            this.btn_UploadImage.Text = "Inserir uma imagem";
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            this.btn_UploadImage.Click += new System.EventHandler(this.btn_UploadImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_UploadImage);
            this.Controls.Add(this.lbl_InsertImage);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_Class);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxt_Email);
            this.Controls.Add(this.lbl_BrithDate);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pb_Picture);
            this.Controls.Add(this.mtxt_BirthDate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxt_BirthDate;
        private System.Windows.Forms.PictureBox pb_Picture;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_BrithDate;
        private System.Windows.Forms.MaskedTextBox mtxt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider erp_Errors;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_UploadImage;
        private System.Windows.Forms.Label lbl_InsertImage;
    }
}

