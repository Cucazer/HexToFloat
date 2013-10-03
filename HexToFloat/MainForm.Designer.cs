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
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 83);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(348, 20);
            this.resultBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
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
            this.hexToFloat.Location = new System.Drawing.Point(93, 37);
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
            this.floatToHex.Location = new System.Drawing.Point(93, 60);
            this.floatToHex.Name = "floatToHex";
            this.floatToHex.Size = new System.Drawing.Size(82, 17);
            this.floatToHex.TabIndex = 4;
            this.floatToHex.Text = "Float -> Hex";
            this.floatToHex.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 114);
            this.Controls.Add(this.floatToHex);
            this.Controls.Add(this.hexToFloat);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hex to Float and vice versa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sourceBox;
        private System.Windows.Forms.RadioButton hexToFloat;
        private System.Windows.Forms.RadioButton floatToHex;
    }
}

