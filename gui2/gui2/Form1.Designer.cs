namespace gui2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openDialog = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.fileTypeBox = new System.Windows.Forms.ComboBox();
            this.styleButton1 = new System.Windows.Forms.RadioButton();
            this.styleButton2 = new System.Windows.Forms.RadioButton();
            this.styleSheetLabel = new System.Windows.Forms.Label();
            this.styleButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 594);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(330, 852);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(118, 763);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Current Count";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(224, 763);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "On Order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(12, 763);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Item Code";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 747);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sort By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stock Items";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 768);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // openDialog
            // 
            this.openDialog.Location = new System.Drawing.Point(12, 71);
            this.openDialog.Name = "openDialog";
            this.openDialog.Size = new System.Drawing.Size(75, 23);
            this.openDialog.TabIndex = 8;
            this.openDialog.Text = "Open File";
            this.openDialog.UseVisualStyleBackColor = true;
            this.openDialog.Click += new System.EventHandler(this.openDialog_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(12, 45);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.fileNameTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter .csv to open";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "NOTE: File must be located in \"C:\\StockFile\\\" Directory.";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(12, 855);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 839);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "File Name:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 857);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "NOTE: Files can only be saved as type \".csv\" or \".xml\"";
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.AutoSize = true;
            this.currentFileLabel.Location = new System.Drawing.Point(12, 97);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(0, 13);
            this.currentFileLabel.TabIndex = 15;
            // 
            // fileTypeBox
            // 
            this.fileTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileTypeBox.FormattingEnabled = true;
            this.fileTypeBox.Items.AddRange(new object[] {
            ".csv",
            ".xml"});
            this.fileTypeBox.Location = new System.Drawing.Point(249, 854);
            this.fileTypeBox.Name = "fileTypeBox";
            this.fileTypeBox.Size = new System.Drawing.Size(75, 21);
            this.fileTypeBox.TabIndex = 16;
            this.fileTypeBox.Tag = "";
            this.fileTypeBox.Text = "File Type";
            // 
            // styleButton1
            // 
            this.styleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.styleButton1.AutoSize = true;
            this.styleButton1.Location = new System.Drawing.Point(12, 815);
            this.styleButton1.Name = "styleButton1";
            this.styleButton1.Size = new System.Drawing.Size(57, 17);
            this.styleButton1.TabIndex = 17;
            this.styleButton1.TabStop = true;
            this.styleButton1.Text = "Style 1";
            this.styleButton1.UseVisualStyleBackColor = true;
            // 
            // styleButton2
            // 
            this.styleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.styleButton2.AutoSize = true;
            this.styleButton2.Location = new System.Drawing.Point(75, 815);
            this.styleButton2.Name = "styleButton2";
            this.styleButton2.Size = new System.Drawing.Size(57, 17);
            this.styleButton2.TabIndex = 18;
            this.styleButton2.TabStop = true;
            this.styleButton2.Text = "Style 2";
            this.styleButton2.UseVisualStyleBackColor = true;
            // 
            // styleSheetLabel
            // 
            this.styleSheetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.styleSheetLabel.AutoSize = true;
            this.styleSheetLabel.Location = new System.Drawing.Point(9, 799);
            this.styleSheetLabel.Name = "styleSheetLabel";
            this.styleSheetLabel.Size = new System.Drawing.Size(89, 13);
            this.styleSheetLabel.TabIndex = 19;
            this.styleSheetLabel.Text = "XML Style Sheet:";
            // 
            // styleButton3
            // 
            this.styleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.styleButton3.AutoSize = true;
            this.styleButton3.Checked = true;
            this.styleButton3.Location = new System.Drawing.Point(133, 815);
            this.styleButton3.Name = "styleButton3";
            this.styleButton3.Size = new System.Drawing.Size(51, 17);
            this.styleButton3.TabIndex = 20;
            this.styleButton3.TabStop = true;
            this.styleButton3.Text = "None";
            this.styleButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 887);
            this.Controls.Add(this.styleButton3);
            this.Controls.Add(this.styleSheetLabel);
            this.Controls.Add(this.styleButton2);
            this.Controls.Add(this.styleButton1);
            this.Controls.Add(this.fileTypeBox);
            this.Controls.Add(this.currentFileLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.openDialog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(610, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wood Stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openDialog;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label currentFileLabel;
        private System.Windows.Forms.ComboBox fileTypeBox;
        private System.Windows.Forms.RadioButton styleButton1;
        private System.Windows.Forms.RadioButton styleButton2;
        private System.Windows.Forms.Label styleSheetLabel;
        private System.Windows.Forms.RadioButton styleButton3;
    }
}

