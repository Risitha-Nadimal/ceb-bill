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
    public partial class frm_gov_cat_GV_1 : Form
    {
        double charge = 14.65;
        double fixed_charge = 600;
        double chg_for_units;
        double total_charge;
        public frm_gov_cat_GV_1()
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
                if (units_consumed >= 0)
                {
                    chg_for_units = units_consumed * charge;
                    lbl_1.Text = chg_for_units.ToString();
                    lbl_2.Text = fixed_charge.ToString();
                    total_charge = chg_for_units + fixed_charge;
                    lbl_3.Text = total_charge.ToString();
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void frm_gov_cat_GV_1_Load(object sender, EventArgs e)
        {
            lbl_t_1.Text = charge.ToString();
            lbl_t_2.Text = fixed_charge.ToString();
            lbl_t_3.Text = "0";
        }
    }
}
