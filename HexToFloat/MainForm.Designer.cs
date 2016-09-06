namespace HexToFloat
{
    partial class MainForm
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.sourceBox = new System.Windows.Forms.TextBox();
            this.hexToFloat = new System.Windows.Forms.RadioButton();
            this.floatToHex = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.littleEndianButton = new System.Windows.Forms.RadioButton();
            this.bigEndianButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.singlePrecision = new System.Windows.Forms.RadioButton();
            this.doublePrecision = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 110);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(372, 20);
            this.resultBox.TabIndex = 1;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(312, 40);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 67);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // sourceBox
            // 
            this.sourceBox.Location = new System.Drawing.Point(12, 11);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(372, 20);
            this.sourceBox.TabIndex = 0;
            // 
            // hexToFloat
            // 
            this.hexToFloat.AutoSize = true;
            this.hexToFloat.Checked = true;
            this.hexToFloat.Location = new System.Drawing.Point(6, 19);
            this.hexToFloat.Name = "hexToFloat";
            this.hexToFloat.Size = new System.Drawing.Size(82, 17);
            this.hexToFloat.TabIndex = 3;
            this.hexToFloat.TabStop = true;
            this.hexToFloat.Text = "Hex -> Float";
            this.hexToFloat.UseVisualStyleBackColor = true;
            // 
            // floatToHex
            // 
            this.floatToHex.AutoSize = true;
            this.floatToHex.Location = new System.Drawing.Point(6, 42);
            this.floatToHex.Name = "floatToHex";
            this.floatToHex.Size = new System.Drawing.Size(82, 17);
            this.floatToHex.TabIndex = 4;
            this.floatToHex.Text = "Float -> Hex";
            this.floatToHex.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hexToFloat);
            this.groupBox1.Controls.Add(this.floatToHex);
            this.groupBox1.Location = new System.Drawing.Point(16, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.littleEndianButton);
            this.groupBox2.Controls.Add(this.bigEndianButton);
            this.groupBox2.Location = new System.Drawing.Point(121, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 67);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endianness";
            // 
            // littleEndianButton
            // 
            this.littleEndianButton.AutoSize = true;
            this.littleEndianButton.Checked = true;
            this.littleEndianButton.Location = new System.Drawing.Point(6, 19);
            this.littleEndianButton.Name = "littleEndianButton";
            this.littleEndianButton.Size = new System.Drawing.Size(83, 17);
            this.littleEndianButton.TabIndex = 3;
            this.littleEndianButton.TabStop = true;
            this.littleEndianButton.Text = "Little Endian";
            this.littleEndianButton.UseVisualStyleBackColor = true;
            // 
            // bigEndianButton
            // 
            this.bigEndianButton.AutoSize = true;
            this.bigEndianButton.Location = new System.Drawing.Point(6, 42);
            this.bigEndianButton.Name = "bigEndianButton";
            this.bigEndianButton.Size = new System.Drawing.Size(76, 17);
            this.bigEndianButton.TabIndex = 4;
            this.bigEndianButton.Text = "Big Endian";
            this.bigEndianButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.doublePrecision);
            this.groupBox3.Controls.Add(this.singlePrecision);
            this.groupBox3.Location = new System.Drawing.Point(224, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(80, 64);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precision";
            // 
            // singlePrecision
            // 
            this.singlePrecision.AutoSize = true;
            this.singlePrecision.Location = new System.Drawing.Point(8, 16);
            this.singlePrecision.Name = "singlePrecision";
            this.singlePrecision.Size = new System.Drawing.Size(54, 17);
            this.singlePrecision.TabIndex = 0;
            this.singlePrecision.Text = "Single";
            this.singlePrecision.UseVisualStyleBackColor = true;
            // 
            // doublePrecision
            // 
            this.doublePrecision.AutoSize = true;
            this.doublePrecision.Checked = true;
            this.doublePrecision.Location = new System.Drawing.Point(8, 40);
            this.doublePrecision.Name = "doublePrecision";
            this.doublePrecision.Size = new System.Drawing.Size(59, 17);
            this.doublePrecision.TabIndex = 1;
            this.doublePrecision.TabStop = true;
            this.doublePrecision.Text = "Double";
            this.doublePrecision.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 144);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.resultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hex to Float and vice versa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox sourceBox;
        private System.Windows.Forms.RadioButton hexToFloat;
        private System.Windows.Forms.RadioButton floatToHex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton littleEndianButton;
        private System.Windows.Forms.RadioButton bigEndianButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton doublePrecision;
        private System.Windows.Forms.RadioButton singlePrecision;
    }
}

