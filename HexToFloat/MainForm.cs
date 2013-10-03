using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    resultBox.Text = ByteArrayToFloat(StringToByteArrayFastest(sourceBox.Text.Replace(" ", ""))).ToString();
                else
                    if (floatToHex.Checked)
                    {
                        var bytes = BitConverter.GetBytes(Convert.ToSingle(sourceBox.Text.Replace(" ", "").Replace(".", ",").Replace("-", " ")));
                        if (bigEndianButton.Checked | !BitConverter.IsLittleEndian)
                            Array.Reverse(bytes);
                        resultBox.Text = BitConverter.ToString(bytes).Replace("-"," ");
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

        public float ByteArrayToFloat(byte[] source)
        {
            if (bigEndianButton.Checked | !BitConverter.IsLittleEndian)
                Array.Reverse(source);
            
            return BitConverter.ToInt32(source, 0);
        }

        public static byte[] StringToByteArrayFastest(string hex)
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }

            return arr;
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

        private void sourceBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Count();
            }
        }

    }
}
