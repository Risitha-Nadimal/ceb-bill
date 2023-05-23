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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void customDesign()
        {
            pnl_btn_submenu.Visible = false; // panal menu sub menu eka visibale eka false kara gannawa
        }
        private void showSubmenu(Panel subMenu)
        {   if(subMenu.Visible ==false)
            {
               // hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
               subMenu.Visible = false;
            }
            
        }
        private void hideSubmenu()
        {
            pnl_btn_submenu.Visible = false;  // sub menu eka hide kannawa
        }

        private void showSubmenu1(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu1();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
        private void hideSubmenu1()
        {
            pnl_dom_submenu.Visible = false;
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {  if(activeForm != null)
            {
                activeForm.Close();  // form ekk active wela thiyenm eka close karagannawa
            }
           
            activeForm = childForm;  // active karanna oni form eka pass kirima
            childForm.TopLevel = false; // ena form eka wenama open wenne nathi wenna hadaganna
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; // sampurna kotuwema penna hadaganna
            pnl_right.Controls.Add(childForm); // hadapu pnl_right kiyana ekat childform eka add kirima
            pnl_right.Tag = childForm; // pnl_right ekat tag kirima
            childForm.BringToFront(); // pnl eka idiriyat ganima
            childForm.Show(); // show kirima
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_billcalculator_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_btn_submenu);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_billtate_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_dom_billrate());
        }

        private void btn_dom_cat_1_Click(object sender, EventArgs e)
        {
            showSubmenu1(pnl_dom_submenu);
        }

        private void btn_rel_cat_R_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_rel_cat_R_1());
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_dom_cal());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            customDesign();
        }

        private void btn_ind_cat_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_ind_cat_I_1());
        }

        private void btn_gen_cat_GP_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_gen_cat_GP_1());
        }

        private void btn_hot__cat_H_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_hot_cat_H_1());
        }

        private void btn_GV_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_gov_cat_GV_1());
        }
    }
}
