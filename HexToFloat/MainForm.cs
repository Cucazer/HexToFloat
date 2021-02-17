using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
// ReSharper disable ArrangeThisQualifier

namespace HexToFloat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string ConvertNumber()
        {
            if (hexToFloat.Checked)
            {
                return HexStringToFloatingPointNumber(sourceBox.Text, this.littleEndianButton.Checked).ToString();
            }

            if (floatToHex.Checked)
            {
                return FloatingPointNumberToHexString(
                    this.sourceBox.Text,
                    this.singlePrecision.Checked,
                    this.littleEndianButton.Checked,
                    this.checkBoxSpaces.Checked);
            }

            return "";
        }

        private void ButtonConvertClick(object sender, EventArgs e)
        {
            if (this.sourceBox.Text.Length == 0)
            {
                return;
            }

            resultBox.Text = "";

            try
            {
                this.resultBox.Text = this.ConvertNumber();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (this.checkBoxClipboard.Checked)
            {
                Clipboard.SetText(this.resultBox.Text);
            }
        }

        private static object HexStringToFloatingPointNumber(string hex, bool isLittleEndian)
        {
            var numberToParse = hex.Replace(" ", "");
            if (numberToParse.StartsWith("0x"))
            {
                // allow 0x only at the beginning, will cause an error if found somewhere else
                numberToParse = numberToParse.Remove(0, 2);
            }

            byte[] numberBytes;
            switch (numberToParse.Length)
            {
                case 8:
                    numberBytes = BitConverter.GetBytes(Convert.ToInt32(numberToParse, 16));
                    // If BitConverter is little endian, then after conversion from hexadecimal to decimal system the first (MSB)
                    // byte described goes to the last position in byte array. Therefore we need to reverse an array if the
                    // hexadecimal value described in string corresponds to the current system endianness - restore actually
                    // described byte order in the hex string.
                    if (BitConverter.IsLittleEndian == isLittleEndian)
                    {
                        Array.Reverse(numberBytes);
                    }
                    return BitConverter.ToSingle(numberBytes, 0);
                case 16:
                    numberBytes = BitConverter.GetBytes(Convert.ToInt64(numberToParse, 16));
                    if (BitConverter.IsLittleEndian == isLittleEndian)
                    {
                        Array.Reverse(numberBytes);
                    }
                    return BitConverter.ToDouble(numberBytes, 0);
                default:
                    if (numberToParse.Length % 16 == 0)
                    {
                        var numberCount = numberToParse.Length / 16;
                        List<double> doubles = new List<double>();
                        for (int i = 0; i < numberCount; i++)
                        {
                            numberBytes = BitConverter.GetBytes(Convert.ToInt64(numberToParse.Substring(16 * i, 16), 16));
                            if (BitConverter.IsLittleEndian == isLittleEndian)
                            {
                                Array.Reverse(numberBytes);
                            }
                            doubles.Add(BitConverter.ToDouble(numberBytes, 0));
                        }

                        return string.Join(" ", doubles);
                    }
                    else
                    {
                        throw new Exception($"Incorrect digit count ({numberToParse.Length}). Must be 8 for single precision or 16 for double precision.");
                    }
            }
        }

        private static string FloatingPointNumberToHexString(string number, bool useSinglePrecision, bool useLittleEndian, bool useSpaces)
        {
            var textToConvert = number
                // treat comma and dot both as decimal separators
                .Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator)
                .Replace(".", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator)
                // allow space as digit group separator
                .Replace(" ", "");

            var valueBytes = useSinglePrecision
                                 ? BitConverter.GetBytes(float.Parse(textToConvert, CultureInfo.InvariantCulture))
                                 : BitConverter.GetBytes(double.Parse(textToConvert, CultureInfo.InvariantCulture));

            // reverse byte array if requested byte order is different from what BitConverter uses for getting bytes
            if (useLittleEndian != BitConverter.IsLittleEndian)
            {
                Array.Reverse(valueBytes);
            }

            // BitConverter uses hyphens to separate single bytes -> replace them with spaces and delete spaces if not needed
            var result = BitConverter.ToString(valueBytes).Replace("-", " ");
            return useSpaces ? result : result.Replace(" ", "");
        }

        private void FloatToHexOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (this.floatToHex.Checked)
            {
                this.checkBoxSpaces.Enabled = true;
                this.groupBoxPrecision.Enabled = true;
            }
        }

        private void HexToFloatOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (this.hexToFloat.Checked)
            {
                this.checkBoxSpaces.Enabled = false;
                this.groupBoxPrecision.Enabled = false;
            }
        }

        private void MainFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.sourceBox.Clear();
                this.sourceBox.Focus();
            }
        }
    }
}
