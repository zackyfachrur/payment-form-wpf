namespace pencarianDekstop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formPendaftaran = new GroupBox();
            labelTelepon = new Label();
            textBoxTelepon = new TextBox();
            labelNama = new Label();
            textBoxNama = new TextBox();
            labelNo = new Label();
            textBoxNo = new TextBox();
            groupKursu = new GroupBox();
            radioButtonNET = new RadioButton();
            radioButtonNetwork = new RadioButton();
            radioButtonWeb = new RadioButton();
            groupBoxBayar = new GroupBox();
            radioButtonCicil = new RadioButton();
            radioButtonCash = new RadioButton();
            groupBoxTotal = new GroupBox();
            labelTotalCicil = new Label();
            textBoxTotalCicilan = new TextBox();
            labelTotalBayar = new Label();
            textBoxTotalBayar = new TextBox();
            buttonOK = new Button();
            buttonClear = new Button();
            formPendaftaran.SuspendLayout();
            groupKursu.SuspendLayout();
            groupBoxBayar.SuspendLayout();
            groupBoxTotal.SuspendLayout();
            SuspendLayout();
            // 
            // formPendaftaran
            // 
            formPendaftaran.Controls.Add(labelTelepon);
            formPendaftaran.Controls.Add(textBoxTelepon);
            formPendaftaran.Controls.Add(labelNama);
            formPendaftaran.Controls.Add(textBoxNama);
            formPendaftaran.Controls.Add(labelNo);
            formPendaftaran.Controls.Add(textBoxNo);
            formPendaftaran.Location = new Point(94, 30);
            formPendaftaran.Name = "formPendaftaran";
            formPendaftaran.Size = new Size(270, 175);
            formPendaftaran.TabIndex = 0;
            formPendaftaran.TabStop = false;
            formPendaftaran.Text = "Form Pendaftaran";
            // 
            // labelTelepon
            // 
            labelTelepon.AutoSize = true;
            labelTelepon.Location = new Point(27, 103);
            labelTelepon.Name = "labelTelepon";
            labelTelepon.Size = new Size(48, 15);
            labelTelepon.TabIndex = 5;
            labelTelepon.Text = "Telepon";
            // 
            // textBoxTelepon
            // 
            textBoxTelepon.Location = new Point(81, 100);
            textBoxTelepon.Name = "textBoxTelepon";
            textBoxTelepon.Size = new Size(100, 23);
            textBoxTelepon.TabIndex = 4;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(36, 74);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(39, 15);
            labelNama.TabIndex = 3;
            labelNama.Text = "Nama";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(81, 71);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(100, 23);
            textBoxNama.TabIndex = 2;
            // 
            // labelNo
            // 
            labelNo.AutoSize = true;
            labelNo.Location = new Point(17, 45);
            labelNo.Name = "labelNo";
            labelNo.Size = new Size(58, 15);
            labelNo.TabIndex = 1;
            labelNo.Text = "No Daftar";
            // 
            // textBoxNo
            // 
            textBoxNo.Location = new Point(81, 42);
            textBoxNo.Name = "textBoxNo";
            textBoxNo.Size = new Size(100, 23);
            textBoxNo.TabIndex = 0;
            // 
            // groupKursu
            // 
            groupKursu.Controls.Add(radioButtonNET);
            groupKursu.Controls.Add(radioButtonNetwork);
            groupKursu.Controls.Add(radioButtonWeb);
            groupKursu.Location = new Point(94, 224);
            groupKursu.Name = "groupKursu";
            groupKursu.Size = new Size(270, 175);
            groupKursu.TabIndex = 6;
            groupKursu.TabStop = false;
            groupKursu.Text = "Jenis Kursus";
            // 
            // radioButtonNET
            // 
            radioButtonNET.AutoSize = true;
            radioButtonNET.Location = new Point(60, 90);
            radioButtonNET.Name = "radioButtonNET";
            radioButtonNET.Size = new Size(116, 19);
            radioButtonNET.TabIndex = 2;
            radioButtonNET.TabStop = true;
            radioButtonNET.Text = "Program C# .NET";
            radioButtonNET.UseVisualStyleBackColor = true;
            // 
            // radioButtonNetwork
            // 
            radioButtonNetwork.AutoSize = true;
            radioButtonNetwork.Location = new Point(60, 65);
            radioButtonNetwork.Name = "radioButtonNetwork";
            radioButtonNetwork.Size = new Size(87, 19);
            radioButtonNetwork.TabIndex = 1;
            radioButtonNetwork.TabStop = true;
            radioButtonNetwork.Text = "Networking";
            radioButtonNetwork.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeb
            // 
            radioButtonWeb.AutoSize = true;
            radioButtonWeb.Location = new Point(60, 40);
            radioButtonWeb.Name = "radioButtonWeb";
            radioButtonWeb.Size = new Size(105, 19);
            radioButtonWeb.TabIndex = 0;
            radioButtonWeb.TabStop = true;
            radioButtonWeb.Text = "Web Developer";
            radioButtonWeb.UseVisualStyleBackColor = true;
            // 
            // groupBoxBayar
            // 
            groupBoxBayar.Controls.Add(radioButtonCicil);
            groupBoxBayar.Controls.Add(radioButtonCash);
            groupBoxBayar.Location = new Point(434, 30);
            groupBoxBayar.Name = "groupBoxBayar";
            groupBoxBayar.Size = new Size(270, 118);
            groupBoxBayar.TabIndex = 7;
            groupBoxBayar.TabStop = false;
            groupBoxBayar.Text = "Jenis Bayar";
            // 
            // radioButtonCicil
            // 
            radioButtonCicil.AutoSize = true;
            radioButtonCicil.Location = new Point(60, 65);
            radioButtonCicil.Name = "radioButtonCicil";
            radioButtonCicil.Size = new Size(63, 19);
            radioButtonCicil.TabIndex = 1;
            radioButtonCicil.TabStop = true;
            radioButtonCicil.Text = "Cicil 3x";
            radioButtonCicil.UseVisualStyleBackColor = true;
            // 
            // radioButtonCash
            // 
            radioButtonCash.AutoSize = true;
            radioButtonCash.Location = new Point(60, 40);
            radioButtonCash.Name = "radioButtonCash";
            radioButtonCash.Size = new Size(51, 19);
            radioButtonCash.TabIndex = 0;
            radioButtonCash.TabStop = true;
            radioButtonCash.Text = "Cash";
            radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // groupBoxTotal
            // 
            groupBoxTotal.Controls.Add(labelTotalCicil);
            groupBoxTotal.Controls.Add(textBoxTotalCicilan);
            groupBoxTotal.Controls.Add(labelTotalBayar);
            groupBoxTotal.Controls.Add(textBoxTotalBayar);
            groupBoxTotal.Location = new Point(434, 167);
            groupBoxTotal.Name = "groupBoxTotal";
            groupBoxTotal.Size = new Size(270, 175);
            groupBoxTotal.TabIndex = 6;
            groupBoxTotal.TabStop = false;
            groupBoxTotal.Text = "Total Bayar";
            // 
            // labelTotalCicil
            // 
            labelTotalCicil.AutoSize = true;
            labelTotalCicil.Location = new Point(36, 74);
            labelTotalCicil.Name = "labelTotalCicil";
            labelTotalCicil.Size = new Size(43, 15);
            labelTotalCicil.TabIndex = 3;
            labelTotalCicil.Text = "Cicilan";
            // 
            // textBoxTotalCicilan
            // 
            textBoxTotalCicilan.Location = new Point(81, 71);
            textBoxTotalCicilan.Name = "textBoxTotalCicilan";
            textBoxTotalCicilan.Size = new Size(100, 23);
            textBoxTotalCicilan.TabIndex = 2;
            // 
            // labelTotalBayar
            // 
            labelTotalBayar.AutoSize = true;
            labelTotalBayar.Location = new Point(15, 45);
            labelTotalBayar.Name = "labelTotalBayar";
            labelTotalBayar.Size = new Size(64, 15);
            labelTotalBayar.TabIndex = 1;
            labelTotalBayar.Text = "Total Bayar";
            // 
            // textBoxTotalBayar
            // 
            textBoxTotalBayar.Location = new Point(81, 42);
            textBoxTotalBayar.Name = "textBoxTotalBayar";
            textBoxTotalBayar.Size = new Size(100, 23);
            textBoxTotalBayar.TabIndex = 0;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(482, 348);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(563, 348);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClear);
            Controls.Add(buttonOK);
            Controls.Add(groupBoxTotal);
            Controls.Add(groupBoxBayar);
            Controls.Add(groupKursu);
            Controls.Add(formPendaftaran);
            Name = "Form1";
            Text = "Form1";
            formPendaftaran.ResumeLayout(false);
            formPendaftaran.PerformLayout();
            groupKursu.ResumeLayout(false);
            groupKursu.PerformLayout();
            groupBoxBayar.ResumeLayout(false);
            groupBoxBayar.PerformLayout();
            groupBoxTotal.ResumeLayout(false);
            groupBoxTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox formPendaftaran;
        private Label labelTelepon;
        private TextBox textBoxTelepon;
        private Label labelNama;
        private TextBox textBoxNama;
        private Label labelNo;
        private TextBox textBoxNo;
        private GroupBox groupKursu;
        private RadioButton radioButtonNET;
        private RadioButton radioButtonNetwork;
        private RadioButton radioButtonWeb;
        private GroupBox groupBoxBayar;
        private RadioButton radioButtonCicil;
        private RadioButton radioButtonCash;
        private GroupBox groupBoxTotal;
        private Label labelTotalCicil;
        private TextBox textBoxTotalCicilan;
        private Label labelTotalBayar;
        private TextBox textBoxTotalBayar;
        private Button buttonOK;
        private Button buttonClear;
    }
}
