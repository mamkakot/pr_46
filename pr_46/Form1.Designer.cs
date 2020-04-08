namespace pr_46
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
            this.Btn_OpenFile = new System.Windows.Forms.Button();
            this.Rtb_Main = new System.Windows.Forms.RichTextBox();
            this.Btn_SaveFile = new System.Windows.Forms.Button();
            this.Tb_Keyword = new System.Windows.Forms.TextBox();
            this.Btn_Decode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.Location = new System.Drawing.Point(419, 83);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Size = new System.Drawing.Size(112, 23);
            this.Btn_OpenFile.TabIndex = 0;
            this.Btn_OpenFile.Text = "Открыть файл";
            this.Btn_OpenFile.UseVisualStyleBackColor = true;
            this.Btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFile_Click);
            // 
            // Rtb_Main
            // 
            this.Rtb_Main.Location = new System.Drawing.Point(13, 31);
            this.Rtb_Main.Name = "Rtb_Main";
            this.Rtb_Main.Size = new System.Drawing.Size(365, 131);
            this.Rtb_Main.TabIndex = 1;
            this.Rtb_Main.Text = "пососёш ок?))";
            // 
            // Btn_SaveFile
            // 
            this.Btn_SaveFile.Location = new System.Drawing.Point(419, 54);
            this.Btn_SaveFile.Name = "Btn_SaveFile";
            this.Btn_SaveFile.Size = new System.Drawing.Size(112, 23);
            this.Btn_SaveFile.TabIndex = 2;
            this.Btn_SaveFile.Text = "Сохранить файл";
            this.Btn_SaveFile.UseVisualStyleBackColor = true;
            this.Btn_SaveFile.Click += new System.EventHandler(this.Btn_SaveFile_Click);
            // 
            // Tb_Keyword
            // 
            this.Tb_Keyword.Location = new System.Drawing.Point(240, 227);
            this.Tb_Keyword.Name = "Tb_Keyword";
            this.Tb_Keyword.Size = new System.Drawing.Size(138, 23);
            this.Tb_Keyword.TabIndex = 3;
            // 
            // Btn_Decode
            // 
            this.Btn_Decode.Location = new System.Drawing.Point(419, 226);
            this.Btn_Decode.Name = "Btn_Decode";
            this.Btn_Decode.Size = new System.Drawing.Size(112, 23);
            this.Btn_Decode.TabIndex = 4;
            this.Btn_Decode.Text = "Расшифровать";
            this.Btn_Decode.UseVisualStyleBackColor = true;
            this.Btn_Decode.Click += new System.EventHandler(this.Btn_Decode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кодовое слово:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Текст сообщения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Decode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_Keyword);
            this.Controls.Add(this.Rtb_Main);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_SaveFile);
            this.Controls.Add(this.Btn_OpenFile);
            this.Name = "Form1";
            this.Text = "Криптография";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_OpenFile;
        private System.Windows.Forms.RichTextBox Rtb_Main;
        private System.Windows.Forms.Button Btn_;
        private System.Windows.Forms.Button Btn_SaveFile;
        private System.Windows.Forms.TextBox Tb_Keyword;
        private System.Windows.Forms.Button Btn_Decode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

