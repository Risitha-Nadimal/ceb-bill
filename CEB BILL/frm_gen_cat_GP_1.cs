using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEB_BILL
{
    public partial class frm_gen_cat_GP_1 : Form
    {
        double charge_before_300 = 18.30;
        double charge_after_300 = 22.85;
        double fixed_charge_before_300 = 240;
        double fixed_charge_after_300 = 240;
        double before_300;
        double after_300;
        double total_charge;
        public frm_gen_cat_GP_1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            string temp = tb_unit.Text;
            int value;
            if (int.TryParse(temp, out value))
            {
                int units_consumed = int.Parse(tb_unit.Text);
                if (units_consumed < 301 && units_consumed >= 0)
                {
                    before_300 = units_consumed * charge_before_300;
                    lbl_1.Text = before_300.ToString();
                    lbl_2.Text = "0";
                    lbl_3.Text = fixed_charge_before_300.ToString();
                    total_charge = before_300 + fixed_charge_before_300;
                    lbl_4.Text = total_charge.ToString();
                    tableLayoutPanel2.Visible = true;
                    tb_unit.Text = "";

                }
                else if (units_consumed > 300)
                {
                    before_300 = 300 * charge_before_300;
                    after_300 = (units_consumed - 300) * charge_after_300;
                    lbl_1.Text = "300 * " + charge_before_300 + " = " + before_300.ToString();
                    lbl_2.Text = after_300.ToString();
                    lbl_3.Text = fixed_charge_after_300.ToString();
                    total_charge = before_300 + fixed_charge_after_300 + after_300;
                    lbl_4.Text = total_charge.ToString();
                    tableLayoutPanel2.Visible = true;
                    tb_unit.Text = "";

                }
                else
                {
                    MessageBox.Show("Please enter a Positive Number!", "Negative Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Number!", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_gen_cat_GP_1_Load(object sender, EventArgs e)
        {
            lbl_t_1.Text = charge_before_300.ToString();
            lbl_t_2.Text = charge_after_300.ToString();
            lbl_t_3.Text = fixed_charge_before_300.ToString();
            lbl_t_4.Text = fixed_charge_after_300.ToString();
        }
    }
}
