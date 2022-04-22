
namespace Lab_3_WindowsForms
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
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.currDataTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.pLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.kLabel = new System.Windows.Forms.Label();
            this.currDataLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.chooseGLabel = new System.Windows.Forms.Label();
            this.chooseGListBox = new System.Windows.Forms.ListBox();
            this.countOfGTextBox = new System.Windows.Forms.TextBox();
            this.countOfGLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // pTextBox
            // 
            this.pTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pTextBox.Location = new System.Drawing.Point(77, 104);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(151, 35);
            this.pTextBox.TabIndex = 0;
            this.pTextBox.Leave += new System.EventHandler(this.pTextBox_Leave);
            // 
            // xTextBox
            // 
            this.xTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xTextBox.Location = new System.Drawing.Point(281, 104);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(151, 35);
            this.xTextBox.TabIndex = 1;
            // 
            // kTextBox
            // 
            this.kTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kTextBox.Location = new System.Drawing.Point(483, 104);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(151, 35);
            this.kTextBox.TabIndex = 2;
            // 
            // currDataTextBox
            // 
            this.currDataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currDataTextBox.Location = new System.Drawing.Point(77, 346);
            this.currDataTextBox.Name = "currDataTextBox";
            this.currDataTextBox.Size = new System.Drawing.Size(930, 35);
            this.currDataTextBox.TabIndex = 3;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.Location = new System.Drawing.Point(77, 434);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(930, 35);
            this.resultTextBox.TabIndex = 4;
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptButton.Location = new System.Drawing.Point(77, 521);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(126, 60);
            this.encryptButton.TabIndex = 5;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptButton.Location = new System.Drawing.Point(281, 521);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(126, 60);
            this.decryptButton.TabIndex = 6;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFileButton.Location = new System.Drawing.Point(492, 521);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(165, 60);
            this.chooseFileButton.TabIndex = 7;
            this.chooseFileButton.Text = "Choose File";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pLabel.Location = new System.Drawing.Point(72, 72);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(96, 29);
            this.pLabel.TabIndex = 8;
            this.pLabel.Text = "Enter p:";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xLabel.Location = new System.Drawing.Point(276, 72);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(93, 29);
            this.xLabel.TabIndex = 9;
            this.xLabel.Text = "Enter x:";
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kLabel.Location = new System.Drawing.Point(478, 72);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(94, 29);
            this.kLabel.TabIndex = 10;
            this.kLabel.Text = "Enter k:";
            // 
            // currDataLabel
            // 
            this.currDataLabel.AutoSize = true;
            this.currDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currDataLabel.Location = new System.Drawing.Point(72, 314);
            this.currDataLabel.Name = "currDataLabel";
            this.currDataLabel.Size = new System.Drawing.Size(150, 29);
            this.currDataLabel.TabIndex = 11;
            this.currDataLabel.Text = "Current data:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(72, 402);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(87, 29);
            this.resultLabel.TabIndex = 12;
            this.resultLabel.Text = "Result:";
            // 
            // chooseGLabel
            // 
            this.chooseGLabel.AutoSize = true;
            this.chooseGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseGLabel.Location = new System.Drawing.Point(679, 72);
            this.chooseGLabel.Name = "chooseGLabel";
            this.chooseGLabel.Size = new System.Drawing.Size(123, 29);
            this.chooseGLabel.TabIndex = 13;
            this.chooseGLabel.Text = "Choose g:";
            // 
            // chooseGListBox
            // 
            this.chooseGListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseGListBox.FormattingEnabled = true;
            this.chooseGListBox.ItemHeight = 29;
            this.chooseGListBox.Location = new System.Drawing.Point(684, 104);
            this.chooseGListBox.Name = "chooseGListBox";
            this.chooseGListBox.Size = new System.Drawing.Size(185, 207);
            this.chooseGListBox.TabIndex = 14;
            this.chooseGListBox.SelectedIndexChanged += new System.EventHandler(this.chooseGListBox_SelectedIndexChanged);
            // 
            // countOfGTextBox
            // 
            this.countOfGTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOfGTextBox.Location = new System.Drawing.Point(917, 104);
            this.countOfGTextBox.Name = "countOfGTextBox";
            this.countOfGTextBox.ReadOnly = true;
            this.countOfGTextBox.Size = new System.Drawing.Size(151, 35);
            this.countOfGTextBox.TabIndex = 15;
            // 
            // countOfGLabel
            // 
            this.countOfGLabel.AutoSize = true;
            this.countOfGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOfGLabel.Location = new System.Drawing.Point(912, 72);
            this.countOfGLabel.Name = "countOfGLabel";
            this.countOfGLabel.Size = new System.Drawing.Size(128, 29);
            this.countOfGLabel.TabIndex = 16;
            this.countOfGLabel.Text = "Count of g:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 680);
            this.Controls.Add(this.countOfGLabel);
            this.Controls.Add(this.countOfGTextBox);
            this.Controls.Add(this.chooseGListBox);
            this.Controls.Add(this.chooseGLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.currDataLabel);
            this.Controls.Add(this.kLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.currDataTextBox);
            this.Controls.Add(this.kTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.pTextBox);
            this.Name = "Form1";
            this.Text = "Lab_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.TextBox currDataTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label currDataLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label chooseGLabel;
        private System.Windows.Forms.ListBox chooseGListBox;
        private System.Windows.Forms.TextBox countOfGTextBox;
        private System.Windows.Forms.Label countOfGLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

