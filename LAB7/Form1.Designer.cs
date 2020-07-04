namespace LAB7
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
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.pairsBox = new System.Windows.Forms.ListBox();
            this.replaceable = new System.Windows.Forms.TextBox();
            this.replacement = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.execute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(12, 12);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.ReadOnly = true;
            this.fileNameBox.Size = new System.Drawing.Size(656, 22);
            this.fileNameBox.TabIndex = 0;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(674, 11);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(114, 23);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "open file";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // pairsBox
            // 
            this.pairsBox.FormattingEnabled = true;
            this.pairsBox.ItemHeight = 16;
            this.pairsBox.Location = new System.Drawing.Point(13, 41);
            this.pairsBox.Name = "pairsBox";
            this.pairsBox.Size = new System.Drawing.Size(259, 404);
            this.pairsBox.TabIndex = 2;
            // 
            // replaceable
            // 
            this.replaceable.Location = new System.Drawing.Point(278, 61);
            this.replaceable.Name = "replaceable";
            this.replaceable.Size = new System.Drawing.Size(197, 22);
            this.replaceable.TabIndex = 3;
            // 
            // replacement
            // 
            this.replacement.Location = new System.Drawing.Point(481, 61);
            this.replacement.Name = "replacement";
            this.replacement.Size = new System.Drawing.Size(186, 22);
            this.replacement.TabIndex = 4;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(674, 61);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 23);
            this.add.TabIndex = 5;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Replaceable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Replacement";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(675, 422);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(113, 23);
            this.clear.TabIndex = 8;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(481, 161);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(113, 23);
            this.execute.TabIndex = 9;
            this.execute.Text = "execute";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.replacement);
            this.Controls.Add(this.replaceable);
            this.Controls.Add(this.pairsBox);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.fileNameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.ListBox pairsBox;
        private System.Windows.Forms.TextBox replaceable;
        private System.Windows.Forms.TextBox replacement;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button execute;
    }
}

