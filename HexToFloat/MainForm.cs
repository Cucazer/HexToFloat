using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    /*if (singlePrecision.Checked)
                    {*/
                    resultBox.Text = StringToByteArrayFastest(sourceBox.Text).ToString();
                    //ByteArrayToFloat(StringToByteArrayFastest(sourceBox.Text.Replace(" ", ""))).ToString();
                    /*}
                    else 
                    {
                        resultBox.Text = ByteArrayToDouble(StringToByteArrayFastest(sourceBox.Text.Replace(" ", ""))).ToString();
                    }*/
                }
                else if (floatToHex.Checked)
                {
                    var textToConvert = sourceBox.Text.Replace(",", ".");
                        //.Replace(" ", "").Replace(".", ",").Replace("-", " ");
                    byte[] valueBytes;
                    if (singlePrecision.Checked)
                    {
                        valueBytes = BitConverter.GetBytes(float.Parse(textToConvert, CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        valueBytes = BitConverter.GetBytes(double.Parse(textToConvert, CultureInfo.InvariantCulture));
                    }
                    if (bigEndianButton.Checked | !BitConverter.IsLittleEndian) Array.Reverse(valueBytes);
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

        public double ByteArrayToDouble(byte[] source)
        {
            if (bigEndianButton.Checked | !BitConverter.IsLittleEndian)
                Array.Reverse(source);

            return BitConverter.ToDouble(source, 0);
        }

        public float ByteArrayToFloat(byte[] source)
        {
            if (bigEndianButton.Checked | !BitConverter.IsLittleEndian)
                Array.Reverse(source);
            
            return BitConverter.ToSingle(source, 0);
        }

        public object StringToByteArrayFastest(string hex)
        {
            var numberToParse = hex.Replace(" ", "");
            if (numberToParse.StartsWith("0x"))
            {
                numberToParse = numberToParse.Remove(0, 2);
            }

            byte[] numberBytes;
            switch (numberToParse.Length)
            {
                case 8:
                    numberBytes = BitConverter.GetBytes(Convert.ToInt32(numberToParse, 16));
                    if ((BitConverter.IsLittleEndian && littleEndianButton.Checked)
                        || (!BitConverter.IsLittleEndian && bigEndianButton.Checked))
                    {
                        Array.Reverse(numberBytes);
                    }
                    return BitConverter.ToSingle(numberBytes, 0);
                    //break;
                case 16:
                    numberBytes = BitConverter.GetBytes(Convert.ToInt64(numberToParse, 16));
                    if ((BitConverter.IsLittleEndian && littleEndianButton.Checked)
                        || (!BitConverter.IsLittleEndian && bigEndianButton.Checked))
                    {
                        Array.Reverse(numberBytes);
                    }
                    return BitConverter.ToDouble(numberBytes, 0);
                    //break;
                default:
                    throw new Exception("Incorrect digit count. Must be 8 for single precision or 16 for double precision.");
            }
            if (BitConverter.IsLittleEndian)
            {
                return numberBytes.Reverse().ToArray();
            }
            return numberBytes;
            /*if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }
            
            return arr;*/
        }

        public static int GetHexVal(char hex)
        {
            int val = (int)hex;
            //For uppercase A-F letters:
            return val - (val < 58 ? 48 : 55);
            //For lowercase a-f letters:
            //return val - (val < 58 ? 48 : 87);
            //Or the two combined, but a bit slower:
            //return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
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
