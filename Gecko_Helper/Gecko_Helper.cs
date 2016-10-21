using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gecko_Helper
{
    public partial class Gecko_Helper : Form
    {
        public Gecko_Helper()
        {
            InitializeComponent();
        }
        string code = null;
        private void bConvert_Click(object sender, EventArgs e)
        {
            SetAddressToRegister();
            if (cLoad.Checked)
                LoadFromAddress();
            textBox3.Text = code;
        }

        //Set Memory Address to Registry / Also has Option to Load said Address value to said Registry
        private void SetAddressToRegister()
        {
            try
            {
                string AddressA = tAddress.Text.Substring(0, 4);
                string AddressB = tAddress.Text.Substring(4, 4);

                code = $"lis {tRegister.Text}, 0x{AddressA}{System.Environment.NewLine}ori {tRegister.Text}, {tRegister.Text}, 0x{AddressB}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadFromAddress()
        {
            if (cLoad.Checked)
                code += $"{System.Environment.NewLine}lwz {tRegister.Text}, 0({tRegister.Text})";

        }
        //Convert  line count to memory adress offset
        private void bConvertOffset_Click(object sender, EventArgs e)
        {
            int offset = 0;
            int.TryParse(tOffset.Text, out offset);


            string hexValue = (offset * 4).ToString("X");
            tOffsetResult.Text = "0x" + hexValue;
        }

        private void bToHex_Click(object sender, EventArgs e)
        {
            int Decimal = 0;
            int.TryParse(tDectoHex.Text, out Decimal);


            string hex = Decimal.ToString("X");
            tHextoDec.Text = "0x" + hex;
        }

        private void bToDec_Click(object sender, EventArgs e)
        { try
            {
                int Decimal = 0;
                string Hex = tHextoDec.Text.Substring(2, tHextoDec.Text.Length - 2);

                Decimal = Convert.ToInt32(Hex, 16);
                tDectoHex.Text = Decimal.ToString();
                long Decimal2 = Convert.ToInt64(tHextoDec.Text, 16);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bFloattoHex_Click(object sender, EventArgs e)
        {
            var f = float.Parse(tFloatToHex.Text);
            int d = BitConverter.ToInt32(BitConverter.GetBytes(f), 0);
            string hex = d.ToString("X");
            tHextoFloat.Text = "0x" + hex;

        }

        private void bHextoFloat_Click(object sender, EventArgs e)
        {
            string Hex = tHextoFloat.Text.Substring(2, tHextoFloat.Text.Length - 2);
            int num = int.Parse(Hex, System.Globalization.NumberStyles.AllowHexSpecifier);

            byte[] floatVals = BitConverter.GetBytes(num);
            float f = BitConverter.ToSingle(floatVals, 0);
            tFloatToHex.Text = f.ToString();
        }
    }
}
