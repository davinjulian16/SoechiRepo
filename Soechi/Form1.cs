using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soechi
{
    public partial class Form1 : Form
    {
        List<KeyValuePair<string, int>> listUOM = new List<KeyValuePair<string, int>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("PCS", 1);
            dataGridView1.Rows.Add("LUSIN", 12);
            dataGridView1.Rows.Add("BOX", 24);

            listUOM = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("PCS", 1),
                new KeyValuePair<string, int>("LUSIN", 12),
                new KeyValuePair<string, int>("BOX", 24)
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Qty Kecil
            if (!string.IsNullOrEmpty(txtRate.Text) && !string.IsNullOrEmpty(txtQty.Text))
                HitungQtyKecil();
            else
            {
                lblError.Text = "Qty atau Rate are empty";
                return;
            }
            #endregion

            #region Discount Amt
            if (!string.IsNullOrEmpty(txtUnitPrice.Text) && !string.IsNullOrEmpty(txtQty.Text) && !string.IsNullOrEmpty(txtDiscount.Text))
                HitungDiscAmt();
            else
            {
                lblError.Text = "Unit Price or Discount or Qty are empty";
                return;
            }
            #endregion

            #region Total
            if (!string.IsNullOrEmpty(txtUnitPrice.Text) && !string.IsNullOrEmpty(txtQty.Text) && !string.IsNullOrEmpty(txtDiscAmount.Text))
                HitungTotal();
            else
            {
                lblError.Text = "Unit Price or Qty are empty";
                return;
            }
            #endregion
        }

        private void txtUom_TextChanged(object sender, EventArgs e)
        {
            var values = listUOM.Where(x => x.Key == txtUom.Text).Select(x => x).ToList();
            if (values.Count > 0)
                txtRate.Text = values[0].Value.ToString();
            else
                txtRate.Text = "";
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            var keys = listUOM.Where(x => x.Value.ToString() == txtRate.Text).Select(x => x).ToList();
            if (keys.Count > 0)
                txtUom.Text = keys[0].Key.ToString();
            else
                txtUom.Text = "";
        }

        private void HitungQtyKecil()
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtRate.Text, "^[0-9]+$")
                && System.Text.RegularExpressions.Regex.IsMatch(txtQty.Text, "^[0-9]+$"))
                txtQtyKecil.Text = (Convert.ToInt32(txtRate.Text) * Convert.ToInt32(txtQty.Text)).ToString();
            else
                lblError.Text = "Please enter Number for Qty and Rate";
        }

        private void HitungDiscAmt()
        {
            try
            {
                List<string> lDisc = new List<string>();
                char[] cDisc = txtDiscount.Text.ToCharArray();
                string tempDisc = "";
                for (int i = 0; i < cDisc.Count(); i++)
                {
                    if (cDisc[i] == '+')
                    {
                        lDisc.Add(tempDisc);
                        tempDisc = "";
                    }
                    else
                        tempDisc = tempDisc + cDisc[i].ToString();

                    if (i == cDisc.Count()-1)
                        lDisc.Add(tempDisc);
                }

                int discAmt = 0, tempDiscon = 0;
                int qty = Convert.ToInt32(txtQty.Text);
                int unitPrice = Convert.ToInt32(txtUnitPrice.Text);
                for (int i = 0; i < lDisc.Count(); i++)
                {
                    if (lDisc[i].Contains('%'))
                    {
                        if (i == 0)
                        {
                            int discPrcnt = Convert.ToInt32(lDisc[i].Trim('%'));
                            discAmt = discAmt + ((qty * unitPrice) * discPrcnt / 100);
                            tempDiscon = qty * unitPrice - discAmt;
                        }
                        else
                        {
                            int discPrcnt = Convert.ToInt32(lDisc[i].Trim('%'));
                            discAmt = discAmt + (tempDiscon * discPrcnt / 100);
                            tempDiscon = qty * unitPrice - discAmt;
                        }
                    }
                    else
                    {
                        discAmt = discAmt + Convert.ToInt32(lDisc[i]);
                    }
                }

                txtDiscAmount.Text = discAmt.ToString();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        private void HitungTotal()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtUnitPrice.Text, "^[0-9]+$")
                && System.Text.RegularExpressions.Regex.IsMatch(txtQty.Text, "^[0-9]+$")
                 && System.Text.RegularExpressions.Regex.IsMatch(txtDiscAmount.Text, "^[0-9]+$"))
                txtTotal.Text = (Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtUnitPrice.Text) - Convert.ToInt32(txtDiscAmount.Text)).ToString();
            else
                lblError.Text = "Please enter Number for Qty and Unit Price or Inccorect Format Disc Amt";

        }
    }
}
