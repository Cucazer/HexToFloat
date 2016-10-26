using System;
using System.Windows.Forms;
using System.Globalization;

namespace HexToFloat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Count()
        {
            try
            {
                resultBox.Text = "";
                if (hexToFloat.Checked)
                {
                    resultBox.Text = this.StringToFloatingPointNumber(sourceBox.Text).ToString();
                }
                else if (floatToHex.Checked)
                {
                    var textToConvert =
                        sourceBox.Text
                            // treat comma and dot both as decimal separators
                            .Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator)
                            .Replace(".", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator)
                            // allow space as digit group separator
                            .Replace(" ", "");

                    var valueBytes = this.singlePrecision.Checked
                                         ? BitConverter.GetBytes(float.Parse(textToConvert, CultureInfo.InvariantCulture))
                                         : BitConverter.GetBytes(double.Parse(textToConvert, CultureInfo.InvariantCulture));
                    // reverse byte array if requested byte order is different from what BitConverter uses for getting bytes
                    if (littleEndianButton.Checked != BitConverter.IsLittleEndian)
                    {
                        Array.Reverse(valueBytes);
                    }
                    // BitConverter uses hyphens to separate single bytes -> replace them with spaces and delete spaces if not needed
                    resultBox.Text = BitConverter.ToString(valueBytes).Replace("-", " ");
                    if (!checkBoxSpaces.Checked)
                    {
                        resultBox.Text = resultBox.Text.Replace(" ", "");
                    }
                    //TODO: copy to clipboard
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Count();
        }

        private object StringToFloatingPointNumber(string hex)
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
                    if (BitConverter.IsLittleEndian == littleEndianButton.Checked)
                    {
                        Array.Reverse(numberBytes);
                    }
                    return BitConverter.ToSingle(numberBytes, 0);
                case 16:
                    numberBytes = BitConverter.GetBytes(Convert.ToInt64(numberToParse, 16));
                    if (BitConverter.IsLittleEndian == littleEndianButton.Checked)
                    {
                        Array.Reverse(numberBytes);
                    }
                    return BitConverter.ToDouble(numberBytes, 0);
                default:
                    throw new Exception("Incorrect digit count. Must be 8 for single precision or 16 for double precision.");
            }
        }

        private void FloatToHexOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (this.floatToHex.Checked)
            {
                this.checkBoxSpaces.Enabled = true;
                this.groupBox3.Enabled = true;
            }
        }

        private void HexToFloatOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (this.hexToFloat.Checked)
            {
                this.checkBoxSpaces.Enabled = false;
                this.groupBox3.Enabled = false;
            }
        }
    }
}
