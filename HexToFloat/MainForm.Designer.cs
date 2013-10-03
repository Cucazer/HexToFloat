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
            this.button1 = new System.Windows.Forms.Button();
            this.sourceBox = new System.Windows.Forms.TextBox();
            this.hexToFloat = new System.Windows.Forms.RadioButton();
            this.floatToHex = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.littleEndianButton = new System.Windows.Forms.RadioButton();
            this.bigEndianButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 110);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(348, 20);
            this.resultBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sourceBox
            // 
            this.sourceBox.Location = new System.Drawing.Point(12, 11);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(348, 20);
            this.sourceBox.TabIndex = 0;
            this.sourceBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sourceBox_KeyDown);
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
            this.groupBox1.Location = new System.Drawing.Point(93, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convertion type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.littleEndianButton);
            this.groupBox2.Controls.Add(this.bigEndianButton);
            this.groupBox2.Location = new System.Drawing.Point(198, 37);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 142);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.button1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sourceBox;
        private System.Windows.Forms.RadioButton hexToFloat;
        private System.Windows.Forms.RadioButton floatToHex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton littleEndianButton;
        private System.Windows.Forms.RadioButton bigEndianButton;
    }
}

