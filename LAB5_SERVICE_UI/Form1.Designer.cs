namespace LAB5_SERVICE_UI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInNum1 = new System.Windows.Forms.TextBox();
            this.textBoxResWords = new System.Windows.Forms.TextBox();
            this.textBoxInNum2 = new System.Windows.Forms.TextBox();
            this.textBoxResDollars = new System.Windows.Forms.TextBox();
            this.buttonConvToWords = new System.Windows.Forms.Button();
            this.buttonConvToDollars = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInNum1
            // 
            this.textBoxInNum1.Location = new System.Drawing.Point(9, 109);
            this.textBoxInNum1.Name = "textBoxInNum1";
            this.textBoxInNum1.Size = new System.Drawing.Size(440, 22);
            this.textBoxInNum1.TabIndex = 0;
            this.textBoxInNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressValidator);
            // 
            // textBoxResWords
            // 
            this.textBoxResWords.Location = new System.Drawing.Point(9, 138);
            this.textBoxResWords.Multiline = true;
            this.textBoxResWords.Name = "textBoxResWords";
            this.textBoxResWords.ReadOnly = true;
            this.textBoxResWords.Size = new System.Drawing.Size(593, 81);
            this.textBoxResWords.TabIndex = 1;
            // 
            // textBoxInNum2
            // 
            this.textBoxInNum2.Location = new System.Drawing.Point(9, 325);
            this.textBoxInNum2.Name = "textBoxInNum2";
            this.textBoxInNum2.Size = new System.Drawing.Size(440, 22);
            this.textBoxInNum2.TabIndex = 2;
            this.textBoxInNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressValidator);
            // 
            // textBoxResDollars
            // 
            this.textBoxResDollars.Location = new System.Drawing.Point(9, 353);
            this.textBoxResDollars.Multiline = true;
            this.textBoxResDollars.Name = "textBoxResDollars";
            this.textBoxResDollars.ReadOnly = true;
            this.textBoxResDollars.Size = new System.Drawing.Size(593, 93);
            this.textBoxResDollars.TabIndex = 3;
            // 
            // buttonConvToWords
            // 
            this.buttonConvToWords.Location = new System.Drawing.Point(455, 109);
            this.buttonConvToWords.Name = "buttonConvToWords";
            this.buttonConvToWords.Size = new System.Drawing.Size(147, 23);
            this.buttonConvToWords.TabIndex = 4;
            this.buttonConvToWords.Text = "Convert";
            this.buttonConvToWords.UseVisualStyleBackColor = true;
            this.buttonConvToWords.Click += new System.EventHandler(this.buttonConvToWords_Click);
            // 
            // buttonConvToDollars
            // 
            this.buttonConvToDollars.Location = new System.Drawing.Point(455, 324);
            this.buttonConvToDollars.Name = "buttonConvToDollars";
            this.buttonConvToDollars.Size = new System.Drawing.Size(147, 23);
            this.buttonConvToDollars.TabIndex = 6;
            this.buttonConvToDollars.Text = "Convert";
            this.buttonConvToDollars.UseVisualStyleBackColor = true;
            this.buttonConvToDollars.Click += new System.EventHandler(this.buttonConvToDollars_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number to words:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number to dollars:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConvToDollars);
            this.Controls.Add(this.buttonConvToWords);
            this.Controls.Add(this.textBoxResDollars);
            this.Controls.Add(this.textBoxInNum2);
            this.Controls.Add(this.textBoxResWords);
            this.Controls.Add(this.textBoxInNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInNum1;
        private System.Windows.Forms.TextBox textBoxResWords;
        private System.Windows.Forms.TextBox textBoxInNum2;
        private System.Windows.Forms.TextBox textBoxResDollars;
        private System.Windows.Forms.Button buttonConvToWords;
        private System.Windows.Forms.Button buttonConvToDollars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

