// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace HexToFloat
{
    using System;

    #region Windows Form Designer generated code
    public partial class MainForm
    {
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.sourceBox = new System.Windows.Forms.TextBox();
            this.hexToFloat = new System.Windows.Forms.RadioButton();
            this.floatToHex = new System.Windows.Forms.RadioButton();
            this.groupBoxConversion = new System.Windows.Forms.GroupBox();
            this.groupBoxEndianness = new System.Windows.Forms.GroupBox();
            this.littleEndianButton = new System.Windows.Forms.RadioButton();
            this.bigEndianButton = new System.Windows.Forms.RadioButton();
            this.groupBoxPrecision = new System.Windows.Forms.GroupBox();
            this.doublePrecision = new System.Windows.Forms.RadioButton();
            this.singlePrecision = new System.Windows.Forms.RadioButton();
            this.checkBoxSpaces = new System.Windows.Forms.CheckBox();
            this.checkBoxClipboard = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxConversion.SuspendLayout();
            this.groupBoxEndianness.SuspendLayout();
            this.groupBoxPrecision.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resultBox.Location = new System.Drawing.Point(12, 118);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(372, 20);
            this.resultBox.TabIndex = 1;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(312, 88);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 27);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.ButtonConvertClick);
            // 
            // sourceBox
            // 
            this.sourceBox.BackColor = System.Drawing.SystemColors.Window;
            this.sourceBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sourceBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sourceBox.Location = new System.Drawing.Point(12, 12);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(372, 20);
            this.sourceBox.TabIndex = 0;
            this.sourceBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            // 
            // hexToFloat
            // 
            this.hexToFloat.AutoSize = true;
            this.hexToFloat.Checked = true;
            this.hexToFloat.Location = new System.Drawing.Point(6, 20);
            this.hexToFloat.Name = "hexToFloat";
            this.hexToFloat.Size = new System.Drawing.Size(82, 17);
            this.hexToFloat.TabIndex = 3;
            this.hexToFloat.TabStop = true;
            this.hexToFloat.Text = "Hex -> Float";
            this.hexToFloat.UseVisualStyleBackColor = true;
            this.hexToFloat.CheckedChanged += new System.EventHandler(this.HexToFloatOnCheckedChanged);
            // 
            // floatToHex
            // 
            this.floatToHex.AutoSize = true;
            this.floatToHex.Location = new System.Drawing.Point(6, 45);
            this.floatToHex.Name = "floatToHex";
            this.floatToHex.Size = new System.Drawing.Size(82, 17);
            this.floatToHex.TabIndex = 4;
            this.floatToHex.Text = "Float -> Hex";
            this.floatToHex.UseVisualStyleBackColor = true;
            this.floatToHex.CheckedChanged += new System.EventHandler(this.FloatToHexOnCheckedChanged);
            // 
            // groupBoxConversion
            // 
            this.groupBoxConversion.Controls.Add(this.hexToFloat);
            this.groupBoxConversion.Controls.Add(this.floatToHex);
            this.groupBoxConversion.Location = new System.Drawing.Point(16, 43);
            this.groupBoxConversion.Name = "groupBoxConversion";
            this.groupBoxConversion.Size = new System.Drawing.Size(99, 72);
            this.groupBoxConversion.TabIndex = 5;
            this.groupBoxConversion.TabStop = false;
            this.groupBoxConversion.Text = "Conversion type";
            // 
            // groupBoxEndianness
            // 
            this.groupBoxEndianness.Controls.Add(this.littleEndianButton);
            this.groupBoxEndianness.Controls.Add(this.bigEndianButton);
            this.groupBoxEndianness.Location = new System.Drawing.Point(121, 43);
            this.groupBoxEndianness.Name = "groupBoxEndianness";
            this.groupBoxEndianness.Size = new System.Drawing.Size(99, 72);
            this.groupBoxEndianness.TabIndex = 6;
            this.groupBoxEndianness.TabStop = false;
            this.groupBoxEndianness.Text = "Endianness";
            // 
            // littleEndianButton
            // 
            this.littleEndianButton.AutoSize = true;
            this.littleEndianButton.Checked = true;
            this.littleEndianButton.Location = new System.Drawing.Point(6, 20);
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
            this.bigEndianButton.Location = new System.Drawing.Point(6, 45);
            this.bigEndianButton.Name = "bigEndianButton";
            this.bigEndianButton.Size = new System.Drawing.Size(76, 17);
            this.bigEndianButton.TabIndex = 4;
            this.bigEndianButton.Text = "Big Endian";
            this.bigEndianButton.UseVisualStyleBackColor = true;
            // 
            // groupBoxPrecision
            // 
            this.groupBoxPrecision.Controls.Add(this.doublePrecision);
            this.groupBoxPrecision.Controls.Add(this.singlePrecision);
            this.groupBoxPrecision.Enabled = false;
            this.groupBoxPrecision.Location = new System.Drawing.Point(224, 43);
            this.groupBoxPrecision.Name = "groupBoxPrecision";
            this.groupBoxPrecision.Size = new System.Drawing.Size(80, 72);
            this.groupBoxPrecision.TabIndex = 7;
            this.groupBoxPrecision.TabStop = false;
            this.groupBoxPrecision.Text = "Precision";
            // 
            // doublePrecision
            // 
            this.doublePrecision.AutoSize = true;
            this.doublePrecision.Checked = true;
            this.doublePrecision.Location = new System.Drawing.Point(8, 43);
            this.doublePrecision.Name = "doublePrecision";
            this.doublePrecision.Size = new System.Drawing.Size(59, 17);
            this.doublePrecision.TabIndex = 1;
            this.doublePrecision.TabStop = true;
            this.doublePrecision.Text = "Double";
            this.doublePrecision.UseVisualStyleBackColor = true;
            // 
            // singlePrecision
            // 
            this.singlePrecision.AutoSize = true;
            this.singlePrecision.Location = new System.Drawing.Point(8, 17);
            this.singlePrecision.Name = "singlePrecision";
            this.singlePrecision.Size = new System.Drawing.Size(54, 17);
            this.singlePrecision.TabIndex = 0;
            this.singlePrecision.Text = "Single";
            this.singlePrecision.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpaces
            // 
            this.checkBoxSpaces.Checked = true;
            this.checkBoxSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSpaces.Enabled = false;
            this.checkBoxSpaces.Location = new System.Drawing.Point(312, 40);
            this.checkBoxSpaces.Name = "checkBoxSpaces";
            this.checkBoxSpaces.Size = new System.Drawing.Size(72, 24);
            this.checkBoxSpaces.TabIndex = 8;
            this.checkBoxSpaces.Text = "Spaces";
            this.toolTip1.SetToolTip(this.checkBoxSpaces, "Use spaces to separate bytes\r\nin hexadecimal representation");
            this.checkBoxSpaces.UseVisualStyleBackColor = true;
            // 
            // checkBoxClipboard
            // 
            this.checkBoxClipboard.AutoSize = true;
            this.checkBoxClipboard.Location = new System.Drawing.Point(312, 64);
            this.checkBoxClipboard.Name = "checkBoxClipboard";
            this.checkBoxClipboard.Size = new System.Drawing.Size(85, 17);
            this.checkBoxClipboard.TabIndex = 9;
            this.checkBoxClipboard.Text = "To clipboard";
            this.toolTip1.SetToolTip(this.checkBoxClipboard, "Copy conversion result to clipboard");
            this.checkBoxClipboard.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonConvert;
            this.ClientSize = new System.Drawing.Size(395, 155);
            this.Controls.Add(this.checkBoxClipboard);
            this.Controls.Add(this.groupBoxPrecision);
            this.Controls.Add(this.groupBoxEndianness);
            this.Controls.Add(this.groupBoxConversion);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.checkBoxSpaces);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hex to Float and vice versa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            this.groupBoxConversion.ResumeLayout(false);
            this.groupBoxConversion.PerformLayout();
            this.groupBoxEndianness.ResumeLayout(false);
            this.groupBoxEndianness.PerformLayout();
            this.groupBoxPrecision.ResumeLayout(false);
            this.groupBoxPrecision.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox sourceBox;
        private System.Windows.Forms.RadioButton hexToFloat;
        private System.Windows.Forms.RadioButton floatToHex;
        private System.Windows.Forms.GroupBox groupBoxConversion;
        private System.Windows.Forms.GroupBox groupBoxEndianness;
        private System.Windows.Forms.RadioButton littleEndianButton;
        private System.Windows.Forms.RadioButton bigEndianButton;
        private System.Windows.Forms.GroupBox groupBoxPrecision;
        private System.Windows.Forms.RadioButton singlePrecision;
        private System.Windows.Forms.RadioButton doublePrecision;
        private System.Windows.Forms.CheckBox checkBoxSpaces;
        private System.Windows.Forms.CheckBox checkBoxClipboard;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
    }
    #endregion
}
