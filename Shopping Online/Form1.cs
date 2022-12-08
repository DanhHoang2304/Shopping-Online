using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Online
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int check_men = 0;
        int check_women = 0;
        int check_kid = 0;
        int check_feed_back = 0;
        int check_detail_item = 0;
        string name_size = "";

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_men_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_men.Font;
            label_men.Font = new Font(font, FontStyle.Underline);
            panel_men_category.Visible = true;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;
        }

        private void label_men_MouseLeave(object sender, EventArgs e)
        {
            var font = label_men.Font;
            label_men.Font = new Font(font, FontStyle.Regular);
        }

        private void label_women_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_women.Font;
            label_women.Font = new Font(font, FontStyle.Underline);
            panel_men_category.Visible = false;
            panel_women_category.Visible = true;
            panel_kids_category.Visible = false;
        }

        private void label_women_MouseLeave(object sender, EventArgs e)
        {
            var font = label_women.Font;
            label_women.Font = new Font(font, FontStyle.Regular);
        }

        private void label_kids_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_kids.Font;
            label_kids.Font = new Font(font, FontStyle.Underline);
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = true;
        }

        private void label_kids_MouseLeave(object sender, EventArgs e)
        {
            var font = label_kids.Font;
            label_kids.Font = new Font(font, FontStyle.Regular);
        }

        private void label_shop_men_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shop_men.Font;
            label_shop_men.Font = new Font(font, FontStyle.Underline);
        }

        private void label_shop_men_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shop_men.Font;
            label_shop_men.Font = new Font(font, FontStyle.Regular);
        }

        private void pictureBox_shop_Click(object sender, EventArgs e)
        {
            check_men = 0;
            check_women = 0;
            check_kid = 0; 
            panel_feed_back.Visible = false;

            panel_main_shop.Visible = true;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = false;
            panel_giohang.Visible = false;

            //check_size_SM = 0;
            //check_size_MD = 0;
            //check_size_LG = 0;
            //check_size_XL = 0;
            //check_size_XXL = 0;

            //check_size_shoes_38 = 0;
            //check_size_shoes_39 = 0;
            //check_size_shoes_40 = 0;
            //check_size_shoes_41 = 0;
            //check_size_shoes_42 = 0;

            //check_size_kid_XS = 0;
            //check_size_kid_SM = 0;
            //check_size_kid_MD = 0;
            //check_size_kid_LG = 0;
            //check_size_kid_XL = 0;

            //int_size_kid_shoes_4 = 0;
            //int_size_kid_shoes_4_5 = 0;
            //int_size_kid_shoes_5 = 0;
            //int_size_kid_shoes_5_5 = 0;
            //int_size_kid_shoes_6 = 0;

            name_size = "";

            button_size_accessories_onesize.Visible = false;

            button_size_kid_LG.Visible = false;
            button_size_kid_MD.Visible = false;
            button_size_kid_SM.Visible = false;
            button_size_kid_XL.Visible = false;
            button_size_kid_XS.Visible = false;

            button_size_shoes_38.Visible = false;
            button_size_shoes_39.Visible = false;
            button_size_shoes_40.Visible = false;
            button_size_shoes_41.Visible = false;
            button_size_shoes_42.Visible = false;

            button_size_shoes_kid_4.Visible = false;
            button_size_shoes_kid_4_5.Visible = false;
            button_size_shoes_kid_5.Visible = false;
            button_size_shoes_kid_5_5.Visible = false;
            button_size_shoes_kid_6.Visible = false;

            button_size_small.Visible = false;
            button_size_large.Visible = false;
            button_size_medium.Visible = false;
            button_size_XL.Visible = false;
            button_size_XXL.Visible = false;

            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.White;

            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;
            button_size_shoes_42.BackColor = Color.White;

            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.White;

            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.White;

            button_size_accessories_onesize.BackColor = Color.White;

            //men
            label_amount_item_men.Text = "10";

            label_men_category.Text = "Men";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.outwear_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Insulated \r\nBomber Outwear";
            label_outwear_man_2.Text = "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear";
            label_money_outwear_man_1.Text = "210";
            label_money_outwear_man_2.Text = "100";

            panel_outwear_man_1.Visible = true;
            panel_outwear_man_2.Visible = true;
            panel_pants_man_1.Visible = true;
            panel_pants_man_2.Visible = true;
            panel_shorts_man_1.Visible = true;
            panel_shorts_man_2.Visible = true;
            panel_shirts_man_1.Visible = true;
            panel_shirts_man_2.Visible = true;
            panel_shoes_man_1.Visible = true;
            panel_shoes_man_2.Visible = true;

            //women
            label_amount_item_women.Text = "10";

            label_all_women_category.Text = "Women";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.outwear_women_2_1;
            label_outwear_women_1.Text = "Women's UA Storm ColdGear® \r\nInfrared Down Jacket";
            label_outwear_women_2.Text = "Women's UA OutRun The Storm\r\nJacket";
            label_money_outwear_women_1.Text = "250";
            label_money_outwear_women_2.Text = "100";

            panel_outwear_women_1.Visible = true;
            panel_outwear_women_2.Visible = true;
            panel_pants_women_1.Visible = true;
            panel_pants_women_2.Visible = true;
            panel_shorts_women_1.Visible = true;
            panel_shorts_women_2.Visible = true;
            panel_shirts_women_1.Visible = true;
            panel_shirts_women_2.Visible = true;
            panel_shoes_women_1.Visible = true;
            panel_shoes_women_2.Visible = true;

            //kids
            label_amount_item_kid.Text = "12";

            label_kid_category.Text = "Kids";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
            label_Accessories_kid_1.Text = "UA Hustle Sport Backpack";
            label_Accessories_kid_2.Text = "UA Beyond 18 oz. Water Bottle";
            label_money_Accessories_kid_1.Text = "45";
            label_money_Accessories_kid_2.Text = "30";

            panel_Accessories_kid_1.Visible = true;
            panel_Accessories_kid_2.Visible = true;
            panel_outwear_kid_1.Visible = true;
            panel_outwear_kid_2.Visible = true;
            panel_swimsuits_kid_1.Visible = true;
            panel_swimsuits_kid_2.Visible = true;
            panel_shorts_kid_1.Visible = true;
            panel_shorts_kid_2.Visible = true;
            panel_shirts_kid_1.Visible = true;
            panel_shirts_kid_2.Visible = true;
            panel_shoes_kid_1.Visible = true;
            panel_shoes_kid_2.Visible = true;
        }

        private void panel_main_shop_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;
        }

        private void pictureBox_curry_shoes_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_curry_shoes_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;
        }

        private void panel_title_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;
        }

        private void label_men_Click(object sender, EventArgs e)
        {
            panel_feed_back.Visible = false;
            check_men = 1;
            check_women = 0;
            check_kid = 0;

            name_size = "";

            button_size_accessories_onesize.Visible = false;

            button_size_kid_LG.Visible = false;
            button_size_kid_MD.Visible = false;
            button_size_kid_SM.Visible = false;
            button_size_kid_XL.Visible = false;
            button_size_kid_XS.Visible = false;

            button_size_shoes_38.Visible = false;
            button_size_shoes_39.Visible = false;
            button_size_shoes_40.Visible = false;
            button_size_shoes_41.Visible = false;
            button_size_shoes_42.Visible = false;

            button_size_shoes_kid_4.Visible = false;
            button_size_shoes_kid_4_5.Visible = false;
            button_size_shoes_kid_5.Visible = false;
            button_size_shoes_kid_5_5.Visible = false;
            button_size_shoes_kid_6.Visible = false;

            button_size_small.Visible = false;
            button_size_large.Visible = false;
            button_size_medium.Visible = false;
            button_size_XL.Visible = false;
            button_size_XXL.Visible = false;

            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.White;

            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;
            button_size_shoes_42.BackColor = Color.White;

            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.White;

            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.White;

            button_size_accessories_onesize.BackColor = Color.White;

            panel_men_category.Visible = false;
            panel_men_shop.Visible = true;
            panel_women_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = false;
            panel_giohang.Visible = false;

            //men
            label_amount_item_men.Text = "10";
            label_men_category.Text = "Men";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.outwear_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Insulated \r\nBomber Outwear";
            label_outwear_man_2.Text = "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear";
            label_money_outwear_man_1.Text = "210";
            label_money_outwear_man_2.Text = "100";

            panel_outwear_man_1.Visible = true;
            panel_outwear_man_2.Visible = true;
            panel_pants_man_1.Visible = true;
            panel_pants_man_2.Visible = true;
            panel_shorts_man_1.Visible = true;
            panel_shorts_man_2.Visible = true;
            panel_shirts_man_1.Visible = true;
            panel_shirts_man_2.Visible = true;
            panel_shoes_man_1.Visible = true;
            panel_shoes_man_2.Visible = true;

            //women
            label_amount_item_women.Text = "10";

            label_women_category.Text = "Women";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.outwear_women_2_1;
            label_outwear_women_1.Text = "Women's UA Storm ColdGear® \r\nInfrared Down Jacket";
            label_outwear_women_2.Text = "Women's UA OutRun The Storm\r\nJacket";
            label_money_outwear_women_1.Text = "250";
            label_money_outwear_women_2.Text = "100";

            panel_outwear_women_1.Visible = true;
            panel_outwear_women_2.Visible = true;
            panel_pants_women_1.Visible = true;
            panel_pants_women_2.Visible = true;
            panel_shorts_women_1.Visible = true;
            panel_shorts_women_2.Visible = true;
            panel_shirts_women_1.Visible = true;
            panel_shirts_women_2.Visible = true;
            panel_shoes_women_1.Visible = true;
            panel_shoes_women_2.Visible = true;

            //kids
            label_amount_item_kid.Text = "12";

            label_kid_category.Text = "Kids";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
            label_Accessories_kid_1.Text = "UA Hustle Sport Backpack";
            label_Accessories_kid_2.Text = "UA Beyond 18 oz. Water Bottle";
            label_money_Accessories_kid_1.Text = "45";
            label_money_Accessories_kid_2.Text = "30";

            panel_Accessories_kid_1.Visible = true;
            panel_Accessories_kid_2.Visible = true;
            panel_outwear_kid_1.Visible = true;
            panel_outwear_kid_2.Visible = true;
            panel_swimsuits_kid_1.Visible = true;
            panel_swimsuits_kid_2.Visible = true;
            panel_shorts_kid_1.Visible = true;
            panel_shorts_kid_2.Visible = true;
            panel_shirts_kid_1.Visible = true;
            panel_shirts_kid_2.Visible = true;
            panel_shoes_kid_1.Visible = true;
            panel_shoes_kid_2.Visible = true;
        }

        private void panel_men_shop_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible=false;
            panel_kids_category.Visible = false;
        }

        private void label_outwear_men_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_outwear_men.Font;
            label_outwear_men.Font = new Font(font, FontStyle.Underline);
        }

        private void label_outwear_men_MouseLeave(object sender, EventArgs e)
        {
            var font = label_outwear_men.Font;
            label_outwear_men.Font = new Font(font, FontStyle.Regular);
        }

        private void label_pants_men_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_pants_men.Font;
            label_pants_men.Font = new Font(font, FontStyle.Underline);
        }

        private void label_pants_men_MouseLeave(object sender, EventArgs e)
        {
            var font = label_pants_men.Font;
            label_pants_men.Font = new Font(font, FontStyle.Regular);
        }

        private void label_shorts_men_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shorts_men.Font;
            label_shorts_men.Font = new Font(font, FontStyle.Underline);
        }

        private void label_shorts_men_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shorts_men.Font;
            label_shorts_men.Font = new Font(font, FontStyle.Regular);
        }

        private void label_shirts_men_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shirts_men.Font;
            label_shirts_men.Font = new Font(font, FontStyle.Underline);
        }

        private void label_shirts_men_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shirts_men.Font;
            label_shirts_men.Font = new Font(font, FontStyle.Regular);
        }

        private void label_shoes_man_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shoes_man.Font;
            label_shoes_man.Font = new Font(font, FontStyle.Underline);
        }

        private void label_shoes_man_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shoes_man.Font;
            label_shoes_man.Font = new Font(font, FontStyle.Regular);
        }

        private void label_outwear_women_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_outwear_women.Font;
            label_outwear_women.Font = new Font(font, FontStyle.Underline);
        }

        private void label_outwear_women_MouseLeave(object sender, EventArgs e)
        {
            var font = label_outwear_women.Font;
            label_outwear_women.Font = new Font(font, FontStyle.Regular);
        }

        private void label_pants_women_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_pants_women.Font;
            label_pants_women.Font = new Font(font, FontStyle.Underline);
        }

        private void label_pants_women_MouseLeave(object sender, EventArgs e)
        {
            var font = label_pants_women.Font;
            label_pants_women.Font = new Font(font, FontStyle.Regular);
        }

        private void label_shorts_women_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shorts_women.Font;
            label_shorts_women.Font = new Font(font, FontStyle.Underline);
        }

        private void label_shorts_women_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shorts_women.Font;
            label_shorts_women.Font = new Font(font, FontStyle.Regular);
        }

        private void label1_shirts_women_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label1_shirts_women.Font;
            label1_shirts_women.Font = new Font(font, FontStyle.Underline);
        }

        private void label1_shirts_women_MouseLeave(object sender, EventArgs e)
        {
            var font = label1_shirts_women.Font;
            label1_shirts_women.Font = new Font(font, FontStyle.Regular);
        }

        private void label_shoes_women_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shoes_women.Font;
            label_shoes_women.Font = new Font(font, FontStyle.Underline);
        }

        private void label_shoes_women_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shoes_women.Font;
            label_shoes_women.Font = new Font(font, FontStyle.Regular);
        }

        private void pictureBox_shop_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;
        }

        private void label_accessories_kid_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_accessories_kid.Font;
            label_accessories_kid.Font = new Font(font, FontStyle.Underline);
        }

        private void label_accessories_kid_MouseLeave(object sender, EventArgs e)
        {
            var font = label_accessories_kid.Font;
            label_accessories_kid.Font = new Font(font, FontStyle.Regular);
        }

        private void label_outwear_kids_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_outwear_kids.Font;
            label_outwear_kids.Font = new Font(font, FontStyle.Underline);
        }

        private void label_outwear_kids_MouseLeave(object sender, EventArgs e)
        {
            var font = label_outwear_kids.Font;
            label_outwear_kids.Font = new Font(font, FontStyle.Regular);
        }

        private void label_pants_kids_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_swimsuits_kids.Font;
            label_swimsuits_kids.Font = new Font(font, FontStyle.Underline);
        }

        private void label_pants_kids_MouseLeave(object sender, EventArgs e)
        {
            var font = label_swimsuits_kids.Font;
            label_swimsuits_kids.Font = new Font(font, FontStyle.Regular);
        }

        private void label_shorts_kids_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shorts_kids.Font;
            label_shorts_kids.Font = new Font(font, FontStyle.Underline);
        }

        private void label_shorts_kids_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shorts_kids.Font;
            label_shorts_kids.Font = new Font(font, FontStyle.Regular);
        }

        private void label_shirts_kids_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shirts_kids.Font;
            label_shirts_kids.Font = new Font(font, FontStyle.Underline);
        }

        private void label_shirts_kids_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shirts_kids.Font;
            label_shirts_kids.Font = new Font(font, FontStyle.Regular);
        }

        private void label_shoes_kids_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shoes_kids.Font;
            label_shoes_kids.Font = new Font(font, FontStyle.Underline);
        }

        private void label_shoes_kids_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shoes_kids.Font;
            label_shoes_kids.Font = new Font(font, FontStyle.Regular);
        }

        private void panel_item_man_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;
        }


        private void label_women_Click(object sender, EventArgs e)
        {
            panel_feed_back.Visible = false;
            check_men = 0;
            check_women = 1;
            check_kid = 0;

            //check_size_SM = 0;
            //check_size_MD = 0;
            //check_size_LG = 0;
            //check_size_XL = 0;
            //check_size_XXL = 0;

            //check_size_shoes_38 = 0;
            //check_size_shoes_39 = 0;
            //check_size_shoes_40 = 0;
            //check_size_shoes_41 = 0;
            //check_size_shoes_42 = 0;

            //check_size_kid_XS = 0;
            //check_size_kid_SM = 0;
            //check_size_kid_MD = 0;
            //check_size_kid_LG = 0;
            //check_size_kid_XL = 0;

            //int_size_kid_shoes_4 = 0;
            //int_size_kid_shoes_4_5 = 0;
            //int_size_kid_shoes_5 = 0;
            //int_size_kid_shoes_5_5 = 0;
            //int_size_kid_shoes_6 = 0;

            name_size = "";

            button_size_accessories_onesize.Visible = false;

            button_size_kid_LG.Visible = false;
            button_size_kid_MD.Visible = false;
            button_size_kid_SM.Visible = false;
            button_size_kid_XL.Visible = false;
            button_size_kid_XS.Visible = false;

            button_size_shoes_38.Visible = false;
            button_size_shoes_39.Visible = false;
            button_size_shoes_40.Visible = false;
            button_size_shoes_41.Visible = false;
            button_size_shoes_42.Visible = false;

            button_size_shoes_kid_4.Visible = false;
            button_size_shoes_kid_4_5.Visible = false;
            button_size_shoes_kid_5.Visible = false;
            button_size_shoes_kid_5_5.Visible = false;
            button_size_shoes_kid_6.Visible = false;

            button_size_small.Visible = false;
            button_size_large.Visible = false;
            button_size_medium.Visible = false;
            button_size_XL.Visible = false;
            button_size_XXL.Visible = false;

            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.White;

            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;
            button_size_shoes_42.BackColor = Color.White;

            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.White;

            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.White;

            button_size_accessories_onesize.BackColor = Color.White;

            panel_women_category.Visible = false;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = true;
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = false;
            panel_giohang.Visible = false;

            //men
            label_amount_item_men.Text = "10";
            label_men_category.Text = "Men";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.outwear_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Insulated \r\nBomber Outwear";
            label_outwear_man_2.Text = "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear";
            label_money_outwear_man_1.Text = "210";
            label_money_outwear_man_2.Text = "100";

            panel_outwear_man_1.Visible = true;
            panel_outwear_man_2.Visible = true;
            panel_pants_man_1.Visible = true;
            panel_pants_man_2.Visible = true;
            panel_shorts_man_1.Visible = true;
            panel_shorts_man_2.Visible = true;
            panel_shirts_man_1.Visible = true;
            panel_shirts_man_2.Visible = true;
            panel_shoes_man_1.Visible = true;
            panel_shoes_man_2.Visible = true;

            //women
            label_amount_item_women.Text = "10";

            label_women_category.Text = "Women";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.outwear_women_2_1;
            label_outwear_women_1.Text = "Women's UA Storm ColdGear® \r\nInfrared Down Jacket";
            label_outwear_women_2.Text = "Women's UA OutRun The Storm\r\nJacket";
            label_money_outwear_women_1.Text = "250";
            label_money_outwear_women_2.Text = "100";

            panel_outwear_women_1.Visible = true;
            panel_outwear_women_2.Visible = true;
            panel_pants_women_1.Visible = true;
            panel_pants_women_2.Visible = true;
            panel_shorts_women_1.Visible = true;
            panel_shorts_women_2.Visible = true;
            panel_shirts_women_1.Visible = true;
            panel_shirts_women_2.Visible = true;
            panel_shoes_women_1.Visible = true;
            panel_shoes_women_2.Visible = true;

            //kids
            label_amount_item_kid.Text = "12";

            label_kid_category.Text = "Kids";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
            label_Accessories_kid_1.Text = "UA Hustle Sport Backpack";
            label_Accessories_kid_2.Text = "UA Beyond 18 oz. Water Bottle";
            label_money_Accessories_kid_1.Text = "45";
            label_money_Accessories_kid_2.Text = "30";

            panel_Accessories_kid_1.Visible = true;
            panel_Accessories_kid_2.Visible = true;
            panel_outwear_kid_1.Visible = true;
            panel_outwear_kid_2.Visible = true;
            panel_swimsuits_kid_1.Visible = true;
            panel_swimsuits_kid_2.Visible = true;
            panel_shorts_kid_1.Visible = true;
            panel_shorts_kid_2.Visible = true;
            panel_shirts_kid_1.Visible = true;
            panel_shirts_kid_2.Visible = true;
            panel_shoes_kid_1.Visible = true;
            panel_shoes_kid_2.Visible = true;

        }

        private void label_kids_Click(object sender, EventArgs e)
        {
            panel_feed_back.Visible = false;
            check_men = 0;
            check_women = 0;
            check_kid = 1;

            //check_size_SM = 0;
            //check_size_MD = 0;
            //check_size_LG = 0;
            //check_size_XL = 0;
            //check_size_XXL = 0;

            //check_size_shoes_38 = 0;
            //check_size_shoes_39 = 0;
            //check_size_shoes_40 = 0;
            //check_size_shoes_41 = 0;
            //check_size_shoes_42 = 0;

            //check_size_kid_XS = 0;
            //check_size_kid_SM = 0;
            //check_size_kid_MD = 0;
            //check_size_kid_LG = 0;
            //check_size_kid_XL = 0;

            //int_size_kid_shoes_4 = 0;
            //int_size_kid_shoes_4_5 = 0;
            //int_size_kid_shoes_5 = 0;
            //int_size_kid_shoes_5_5 = 0;
            //int_size_kid_shoes_6 = 0;

            name_size = "";

            button_size_accessories_onesize.Visible = false;

            button_size_kid_LG.Visible = false;
            button_size_kid_MD.Visible = false;
            button_size_kid_SM.Visible = false;
            button_size_kid_XL.Visible = false;
            button_size_kid_XS.Visible = false;

            button_size_shoes_38.Visible = false;
            button_size_shoes_39.Visible = false;
            button_size_shoes_40.Visible = false;
            button_size_shoes_41.Visible = false;
            button_size_shoes_42.Visible = false;

            button_size_shoes_kid_4.Visible = false;
            button_size_shoes_kid_4_5.Visible = false;
            button_size_shoes_kid_5.Visible = false;
            button_size_shoes_kid_5_5.Visible = false;
            button_size_shoes_kid_6.Visible = false;

            button_size_small.Visible = false;
            button_size_large.Visible = false;
            button_size_medium.Visible = false;
            button_size_XL.Visible = false;
            button_size_XXL.Visible = false;

            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.White;

            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;
            button_size_shoes_42.BackColor = Color.White;

            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.White;

            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.White;

            button_size_accessories_onesize.BackColor = Color.White;

            panel_kids_category.Visible = false;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = false;
            panel_kid_shop.Visible = true;
            panel_giohang.Visible = false;

            //men
            label_amount_item_men.Text = "10";
            label_men_category.Text = "Men";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.outwear_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Insulated \r\nBomber Outwear";
            label_outwear_man_2.Text = "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear";
            label_money_outwear_man_1.Text = "210";
            label_money_outwear_man_2.Text = "100";

            panel_outwear_man_1.Visible = true;
            panel_outwear_man_2.Visible = true;
            panel_pants_man_1.Visible = true;
            panel_pants_man_2.Visible = true;
            panel_shorts_man_1.Visible = true;
            panel_shorts_man_2.Visible = true;
            panel_shirts_man_1.Visible = true;
            panel_shirts_man_2.Visible = true;
            panel_shoes_man_1.Visible = true;
            panel_shoes_man_2.Visible = true;

            //women
            label_amount_item_women.Text = "10";

            label_women_category.Text = "Women";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.outwear_women_2_1;
            label_outwear_women_1.Text = "Women's UA Storm ColdGear® \r\nInfrared Down Jacket";
            label_outwear_women_2.Text = "Women's UA OutRun The Storm\r\nJacket";
            label_money_outwear_women_1.Text = "250";
            label_money_outwear_women_2.Text = "100";

            panel_outwear_women_1.Visible = true;
            panel_outwear_women_2.Visible = true;
            panel_pants_women_1.Visible = true;
            panel_pants_women_2.Visible = true;
            panel_shorts_women_1.Visible = true;
            panel_shorts_women_2.Visible = true;
            panel_shirts_women_1.Visible = true;
            panel_shirts_women_2.Visible = true;
            panel_shoes_women_1.Visible = true;
            panel_shoes_women_2.Visible = true;

            //kids
            label_amount_item_kid.Text = "12";

            label_kid_category.Text = "Kids";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
            label_Accessories_kid_1.Text = "UA Hustle Sport Backpack";
            label_Accessories_kid_2.Text = "UA Beyond 18 oz. Water Bottle";
            label_money_Accessories_kid_1.Text = "45";
            label_money_Accessories_kid_2.Text = "30";

            panel_Accessories_kid_1.Visible = true;
            panel_Accessories_kid_2.Visible = true;
            panel_outwear_kid_1.Visible = true;
            panel_outwear_kid_2.Visible = true;
            panel_swimsuits_kid_1.Visible = true;
            panel_swimsuits_kid_2.Visible = true;
            panel_shorts_kid_1.Visible = true;
            panel_shorts_kid_2.Visible = true;
            panel_shirts_kid_1.Visible = true;
            panel_shirts_kid_2.Visible = true;
            panel_shoes_kid_1.Visible = true;
            panel_shoes_kid_2.Visible = true;


        }

        private void panel_item_women_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;

        }

        private void panel_item_kid_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;
        }

        private void label_outwear_men_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_outwear_men_category.Font;
            label_outwear_men_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_outwear_men_category.ForeColor = Color.Black;
        }

        private void label_outwear_men_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_outwear_men_category.Font;
            label_outwear_men_category.Font = new Font(font, FontStyle.Regular);
            label_outwear_men_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_pants_men_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_pants_men_category.Font;
            label_pants_men_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_pants_men_category.ForeColor = Color.Black;
        }

        private void label_pants_men_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_pants_men_category.Font;
            label_pants_men_category.Font = new Font(font, FontStyle.Regular);
            label_pants_men_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_shorts_men_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shorts_men_category.Font;
            label_shorts_men_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shorts_men_category.ForeColor = Color.Black;
        }

        private void label_shorts_men_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shorts_men_category.Font;
            label_shorts_men_category.Font = new Font(font, FontStyle.Regular);
            label_shorts_men_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_shirts_men_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shirts_men_category.Font;
            label_shirts_men_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shirts_men_category.ForeColor = Color.Black;
        }

        private void label_shirts_men_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shirts_men_category.Font;
            label_shirts_men_category.Font = new Font(font, FontStyle.Regular);
            label_shirts_men_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_shoes_men_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shoes_men_category.Font;
            label_shoes_men_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shoes_men_category.ForeColor = Color.Black;
        }

        private void label_shoes_men_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shoes_men_category.Font;
            label_shoes_men_category.Font = new Font(font, FontStyle.Regular);
            label_shoes_men_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_all_men_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_all_men_category.Font;
            label_all_men_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_all_men_category.ForeColor = Color.Black;
        }

        private void label_all_men_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_all_men_category.Font;
            label_all_men_category.Font = new Font(font, FontStyle.Regular);
            label_all_men_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void panel_women_shop_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;
        }

        private void panel_kid_shop_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;
        }

        private void label_outwear_men_category_Click(object sender, EventArgs e)
        {
            var font = label_outwear_men_category.Font;
            label_outwear_men_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_outwear_men_category.ForeColor = Color.Black;
            label_men_category.Text = "Men" + "/" + "Outwear";

            label_amount_item_men.Text = "2";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.outwear_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Insulated \r\nBomber Outwear";
            label_outwear_man_2.Text = "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear";
            label_money_outwear_man_1.Text = "210";
            label_money_outwear_man_2.Text = "100";

            panel_pants_man_1.Visible = false;
            panel_pants_man_2.Visible = false;
            panel_shorts_man_1.Visible=false;
            panel_shorts_man_2.Visible = false;
            panel_shirts_man_1.Visible = false;
            panel_shirts_man_2.Visible = false;
            panel_shoes_man_1.Visible = false;
            panel_shoes_man_2.Visible = false;
        }

        private void label_pants_men_category_Click(object sender, EventArgs e)
        {
            var font = label_pants_men_category.Font;
            label_pants_men_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_pants_men_category.ForeColor = Color.Black;
            label_men_category.Text = "Men" + "/" + "Pants";


            label_amount_item_men.Text = "2";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.pants_man_1_2;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.pants_man_2_2;
            label_outwear_man_1.Text = "Men's UA RUSH™ ColdGear® \r\nLeggings";
            label_outwear_man_2.Text = "Men's UA Meridian Tapered \r\nPants";
            label_money_outwear_man_1.Text = "70";
            label_money_outwear_man_2.Text = "90";

            panel_pants_man_1.Visible = false;
            panel_pants_man_2.Visible = false;
            panel_shorts_man_1.Visible = false;
            panel_shorts_man_2.Visible = false;
            panel_shirts_man_1.Visible = false;
            panel_shirts_man_2.Visible = false;
            panel_shoes_man_1.Visible = false;
            panel_shoes_man_2.Visible = false;
        }

        private void label_shorts_men_category_Click(object sender, EventArgs e)
        {
            var font = label_shorts_men_category.Font;
            label_shorts_men_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shorts_men_category.ForeColor = Color.Black;
            label_men_category.Text = "Men" + "/" + "Shorts";

            label_amount_item_men.Text = "2";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.shorts_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.shorts_man_2_1;
            label_outwear_man_1.Text = "Men's UA Elevated Woven 2.0 \r\nShorts";
            label_outwear_man_2.Text = "Men's UA Rival Fleece Big Logo\r\nShorts";
            label_money_outwear_man_1.Text = "40";
            label_money_outwear_man_2.Text = "40";

            panel_pants_man_1.Visible = false;
            panel_pants_man_2.Visible = false;
            panel_shorts_man_1.Visible = false;
            panel_shorts_man_2.Visible = false;
            panel_shirts_man_1.Visible = false;
            panel_shirts_man_2.Visible = false;
            panel_shoes_man_1.Visible = false;
            panel_shoes_man_2.Visible = false;
        }

        private void label_shirts_men_category_Click(object sender, EventArgs e)
        {
            var font = label_shirts_men_category.Font;
            label_shirts_men_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shirts_men_category.ForeColor = Color.Black;
            label_men_category.Text = "Men" + "/" + "Shirts";

            label_amount_item_men.Text = "2";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.shirts_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.shirts_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Heavyweight \r\nTerry Sleeveless Hoodie";
            label_outwear_man_2.Text = "Men's UA Tech™ Collegiate \r\nSideline Short Sleeve";
            label_money_outwear_man_1.Text = "70";
            label_money_outwear_man_2.Text = "40";

            panel_pants_man_1.Visible = false;
            panel_pants_man_2.Visible = false;
            panel_shorts_man_1.Visible = false;
            panel_shorts_man_2.Visible = false;
            panel_shirts_man_1.Visible = false;
            panel_shirts_man_2.Visible = false;
            panel_shoes_man_1.Visible = false;
            panel_shoes_man_2.Visible = false;
        }

        private void label_shoes_men_category_Click(object sender, EventArgs e)
        {
            var font = label_shoes_men_category.Font;
            label_shoes_men_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shoes_men_category.ForeColor = Color.Black;
            label_men_category.Text = "Men" + "/" + "Shoes";

            label_amount_item_men.Text = "2";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.shoes_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.shoes_man_2_1;
            label_outwear_man_1.Text = "Unisex Curry Flow 10 'Sour \r\nThen Sweet' Basketball Shoes";
            label_outwear_man_2.Text = "Men's Project Rock 5 Veterans \r\nDay Training Shoes";
            label_money_outwear_man_1.Text = "160";
            label_money_outwear_man_2.Text = "150";

            panel_pants_man_1.Visible = false;
            panel_pants_man_2.Visible = false;
            panel_shorts_man_1.Visible = false;
            panel_shorts_man_2.Visible = false;
            panel_shirts_man_1.Visible = false;
            panel_shirts_man_2.Visible = false;
            panel_shoes_man_1.Visible = false;
            panel_shoes_man_2.Visible = false;
        }

        private void label_all_men_category_Click(object sender, EventArgs e)
        {
            label_amount_item_men.Text = "10";

            label_men_category.Text = "Men";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.outwear_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Insulated \r\nBomber Outwear";
            label_outwear_man_2.Text = "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear";
            label_money_outwear_man_1.Text = "210";
            label_money_outwear_man_2.Text = "100";

            panel_outwear_man_1.Visible = true;
            panel_outwear_man_2.Visible = true;
            panel_pants_man_1.Visible = true;
            panel_pants_man_2.Visible = true;
            panel_shorts_man_1.Visible = true;
            panel_shorts_man_2.Visible = true;
            panel_shirts_man_1.Visible = true;
            panel_shirts_man_2.Visible = true;
            panel_shoes_man_1.Visible = true;
            panel_shoes_man_2.Visible = true;

        }

        private void label_outwear_women_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_outwear_women_category.Font;
            label_outwear_women_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_outwear_women_category.ForeColor = Color.Black;
        }

        private void label_outwear_women_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_outwear_women_category.Font;
            label_outwear_women_category.Font = new Font(font, FontStyle.Regular);
            label_outwear_women_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_pants_women_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_pants_women_category.Font;
            label_pants_women_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_pants_women_category.ForeColor = Color.Black;
        }

        private void label_pants_women_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_pants_women_category.Font;
            label_pants_women_category.Font = new Font(font, FontStyle.Regular);
            label_pants_women_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_shorts_women_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shorts_women_category.Font;
            label_shorts_women_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shorts_women_category.ForeColor = Color.Black;
        }

        private void label_shorts_women_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shorts_women_category.Font;
            label_shorts_women_category.Font = new Font(font, FontStyle.Regular);
            label_shorts_women_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_shirts_women_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shirts_women_category.Font;
            label_shirts_women_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shirts_women_category.ForeColor = Color.Black;
        }

        private void label_shirts_women_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shirts_women_category.Font;
            label_shirts_women_category.Font = new Font(font, FontStyle.Regular);
            label_shirts_women_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_shoes_women_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shoes_women_category.Font;
            label_shoes_women_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shoes_women_category.ForeColor = Color.Black;
        }

        private void label_shoes_women_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shoes_women_category.Font;
            label_shoes_women_category.Font = new Font(font, FontStyle.Regular);
            label_shoes_women_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_all_women_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_all_women_category.Font;
            label_all_women_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_all_women_category.ForeColor = Color.Black;
        }

        private void label_all_women_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_all_women_category.Font;
            label_all_women_category.Font = new Font(font, FontStyle.Regular);
            label_all_women_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_outwear_women_category_Click(object sender, EventArgs e)
        {
            var font = label_outwear_women_category.Font;
            label_outwear_women_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_outwear_women_category.ForeColor = Color.Black;
            label_women_category.Text = "Women" + "/" + "Outwear";

            label_amount_item_women.Text = "2";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.outwear_women_2_1;
            label_outwear_women_1.Text = "Women's UA Storm ColdGear® \r\nInfrared Down Jacket";
            label_outwear_women_2.Text = "Women's UA OutRun The Storm\r\nJacket";
            label_money_outwear_women_1.Text = "250";
            label_money_outwear_women_2.Text = "100";

            panel_pants_women_1.Visible = false;
            panel_pants_women_2.Visible = false;
            panel_shorts_women_1.Visible = false;
            panel_shorts_women_2.Visible = false;
            panel_shirts_women_1.Visible = false;
            panel_shirts_women_2.Visible = false;
            panel_shoes_women_1.Visible = false;
            panel_shoes_women_2.Visible = false;
        }

        private void label_pants_women_category_Click(object sender, EventArgs e)
        {
            var font = label_pants_women_category.Font;
            label_pants_women_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_pants_women_category.ForeColor = Color.Black;
            label_women_category.Text = "Women" + "/" + "Pants";

            label_amount_item_women.Text = "2";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.pants_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.pants_women_2_1;
            label_outwear_women_1.Text = "Women's UA Meridian Jacquard\r\nAnkle Leggings";
            label_outwear_women_2.Text = "Women's UA Armour Sport \r\nWoven Pants";
            label_money_outwear_women_1.Text = "70";
            label_money_outwear_women_2.Text = "45";

            panel_pants_women_1.Visible = false;
            panel_pants_women_2.Visible = false;
            panel_shorts_women_1.Visible = false;
            panel_shorts_women_2.Visible = false;
            panel_shirts_women_1.Visible = false;
            panel_shirts_women_2.Visible = false;
            panel_shoes_women_1.Visible = false;
            panel_shoes_women_2.Visible = false;
        }

        private void label_shorts_women_category_Click(object sender, EventArgs e)
        {
            var font = label_shorts_women_category.Font;
            label_shorts_women_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shorts_women_category.ForeColor = Color.Black;
            label_women_category.Text = "Women" + "/" + "Shorts";

            label_amount_item_women.Text = "2";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.shorts_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.shorts_women_2_1;
            label_outwear_women_1.Text = "Women's UA Play Up 2-in-1 \r\nShorts";
            label_outwear_women_2.Text = "Women's UA Links Shorts";
            label_money_outwear_women_1.Text = "35";
            label_money_outwear_women_2.Text = "75";

            panel_pants_women_1.Visible = false;
            panel_pants_women_2.Visible = false;
            panel_shorts_women_1.Visible = false;
            panel_shorts_women_2.Visible = false;
            panel_shirts_women_1.Visible = false;
            panel_shirts_women_2.Visible = false;
            panel_shoes_women_1.Visible = false;
            panel_shoes_women_2.Visible = false;
        }

        private void label_shirts_women_category_Click(object sender, EventArgs e)
        {
            var font = label_shirts_women_category.Font;
            label_shirts_women_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shirts_women_category.ForeColor = Color.Black;
            label_women_category.Text = "Women" + "/" + "Shirts";

            label_amount_item_women.Text = "2";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.shirts_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.shirts_women_2_1;
            label_outwear_women_1.Text = "Women's ColdGear® Authentics\r\nCrew";
            label_outwear_women_2.Text = "Women's Project Rock Veterans\r\nDay Fleece Hoodie";
            label_money_outwear_women_1.Text = "55";
            label_money_outwear_women_2.Text = "100";

            panel_pants_women_1.Visible = false;
            panel_pants_women_2.Visible = false;
            panel_shorts_women_1.Visible = false;
            panel_shorts_women_2.Visible = false;
            panel_shirts_women_1.Visible = false;
            panel_shirts_women_2.Visible = false;
            panel_shoes_women_1.Visible = false;
            panel_shoes_women_2.Visible = false;
        }

        private void label_shoes_women_category_Click(object sender, EventArgs e)
        {
            var font = label_shoes_women_category.Font;
            label_shoes_women_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shoes_women_category.ForeColor = Color.Black;
            label_women_category.Text = "Women" + "/" + "Shoes";

            label_amount_item_women.Text = "2";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.shoes_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.shoes_women_2_1;
            label_outwear_women_1.Text = "Women's UA HOVR™ Machina 3\r\nRunning Shoes";
            label_outwear_women_2.Text = "Women's Project Rock 5 Training\r\nShoes";
            label_money_outwear_women_1.Text = "150";
            label_money_outwear_women_2.Text = "150";

            panel_pants_women_1.Visible = false;
            panel_pants_women_2.Visible = false;
            panel_shorts_women_1.Visible = false;
            panel_shorts_women_2.Visible = false;
            panel_shirts_women_1.Visible = false;
            panel_shirts_women_2.Visible = false;
            panel_shoes_women_1.Visible = false;
            panel_shoes_women_2.Visible = false;
        }

        private void label_all_women_category_Click(object sender, EventArgs e)
        {
            label_amount_item_women.Text = "10";

            label_women_category.Text = "Women";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.outwear_women_2_1;
            label_outwear_women_1.Text = "Women's UA Storm ColdGear® \r\nInfrared Down Jacket";
            label_outwear_women_2.Text = "Women's UA OutRun The Storm\r\nJacket";
            label_money_outwear_women_1.Text = "250";
            label_money_outwear_women_2.Text = "100";

            panel_outwear_women_1.Visible = true;
            panel_outwear_women_2.Visible = true;
            panel_pants_women_1.Visible = true;
            panel_pants_women_2.Visible = true;
            panel_shorts_women_1.Visible = true;
            panel_shorts_women_2.Visible = true;
            panel_shirts_women_1.Visible = true;
            panel_shirts_women_2.Visible = true;
            panel_shoes_women_1.Visible = true;
            panel_shoes_women_2.Visible = true;
        }

        private void label_Accessories_kid_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_Accessories_kid_category.Font;
            label_Accessories_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_Accessories_kid_category.ForeColor = Color.Black;
        }

        private void label_Accessories_kid_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_Accessories_kid_category.Font;
            label_Accessories_kid_category.Font = new Font(font, FontStyle.Regular);
            label_Accessories_kid_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_outwear_kid_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_outwear_kid_category.Font;
            label_outwear_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_outwear_kid_category.ForeColor = Color.Black;
        }

        private void label_outwear_kid_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_outwear_kid_category.Font;
            label_outwear_kid_category.Font = new Font(font, FontStyle.Regular);
            label_outwear_kid_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_swimsuits_kid_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_swimsuits_kid_category.Font;
            label_swimsuits_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_swimsuits_kid_category.ForeColor = Color.Black;
        }

        private void label_swimsuits_kid_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_swimsuits_kid_category.Font;
            label_swimsuits_kid_category.Font = new Font(font, FontStyle.Regular);
            label_swimsuits_kid_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_shorts_kid_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shorts_kid_category.Font;
            label_shorts_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shorts_kid_category.ForeColor = Color.Black;
        }

        private void label_shorts_kid_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shorts_kid_category.Font;
            label_shorts_kid_category.Font = new Font(font, FontStyle.Regular);
            label_shorts_kid_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_shirts_kid_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shirts_kid_category.Font;
            label_shirts_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shirts_kid_category.ForeColor = Color.Black;
        }

        private void label_shirts_kid_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shirts_kid_category.Font;
            label_shirts_kid_category.Font = new Font(font, FontStyle.Regular);
            label_shirts_kid_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_shoes_kid_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_shoes_kid_category.Font;
            label_shoes_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shoes_kid_category.ForeColor = Color.Black;
        }

        private void label_shoes_kid_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_shoes_kid_category.Font;
            label_shoes_kid_category.Font = new Font(font, FontStyle.Regular);
            label_shoes_kid_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_all_kid_category_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_all_kid_category.Font;
            label_all_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_all_kid_category.ForeColor = Color.Black;
        }

        private void label_all_kid_category_MouseLeave(object sender, EventArgs e)
        {
            var font = label_all_kid_category.Font;
            label_all_kid_category.Font = new Font(font, FontStyle.Regular);
            label_all_kid_category.ForeColor = SystemColors.ActiveBorder;
        }

        private void label_Accessories_kid_category_Click(object sender, EventArgs e)
        {
            var font = label_Accessories_kid_category.Font;
            label_Accessories_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_Accessories_kid_category.ForeColor = Color.Black;

            label_kid_category.Text = "Kids" + "/" + "Accessories";

            label_amount_item_kid.Text = "2";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
            label_Accessories_kid_1.Text = "UA Hustle Sport Backpack";
            label_Accessories_kid_2.Text = "UA Beyond 18 oz. Water Bottle";
            label_money_Accessories_kid_1.Text = "45";
            label_money_Accessories_kid_2.Text = "30";

            //panel_Accessories_kid_1.Visible = true;
            //panel_Accessories_kid_2.Visible = true;
            panel_outwear_kid_1.Visible = false;
            panel_outwear_kid_2.Visible = false;
            panel_swimsuits_kid_1.Visible = false;
            panel_swimsuits_kid_2.Visible = false;
            panel_shorts_kid_1.Visible = false;
            panel_shorts_kid_2.Visible = false;
            panel_shirts_kid_1.Visible = false;
            panel_shirts_kid_2.Visible = false;
            panel_shoes_kid_1.Visible = false;
            panel_shoes_kid_2.Visible = false;
        }

        private void label_outwear_kid_category_Click(object sender, EventArgs e)
        {
            var font = label_outwear_kid_category.Font;
            label_outwear_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_outwear_kid_category.ForeColor = Color.Black;
            label_kid_category.Text = "Kids" + "/" + "Outwear";

            label_amount_item_kid.Text = "2";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.outwear_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.outwear_kids_2_1;
            label_Accessories_kid_1.Text = "Boys' UA Powderhound Jacket";
            label_Accessories_kid_2.Text = "Girls' UA Laila Printed Jacket";
            label_money_Accessories_kid_1.Text = "155";
            label_money_Accessories_kid_2.Text = "135";

            panel_outwear_kid_1.Visible = false;
            panel_outwear_kid_2.Visible = false;
            panel_swimsuits_kid_1.Visible = false;
            panel_swimsuits_kid_2.Visible = false;
            panel_shorts_kid_1.Visible = false;
            panel_shorts_kid_2.Visible = false;
            panel_shirts_kid_1.Visible = false;
            panel_shirts_kid_2.Visible = false;
            panel_shoes_kid_1.Visible = false;
            panel_shoes_kid_2.Visible = false;
        }

        private void label_swimsuits_kid_category_Click(object sender, EventArgs e)
        {
            var font = label_swimsuits_kid_category.Font;
            label_swimsuits_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_swimsuits_kid_category.ForeColor = Color.Black;
            label_kid_category.Text = "Kids" + "/" + "Swimsuits";

            label_amount_item_kid.Text = "2";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Swimwear_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Swimwear_kids_2_1;
            label_Accessories_kid_1.Text = "Girls' UA Plant Life Sports Top \r\nand Boyshort 2-Piece Swim Set";
            label_Accessories_kid_2.Text = "Girls' Pre-School UA Stripe \r\nFlutter Bikini";
            label_money_Accessories_kid_1.Text = "40";
            label_money_Accessories_kid_2.Text = "36";

            panel_outwear_kid_1.Visible = false;
            panel_outwear_kid_2.Visible = false;
            panel_swimsuits_kid_1.Visible = false;
            panel_swimsuits_kid_2.Visible = false;
            panel_shorts_kid_1.Visible = false;
            panel_shorts_kid_2.Visible = false;
            panel_shirts_kid_1.Visible = false;
            panel_shirts_kid_2.Visible = false;
            panel_shoes_kid_1.Visible = false;
            panel_shoes_kid_2.Visible = false;
        }

        private void label_shorts_kid_category_Click(object sender, EventArgs e)
        {
            var font = label_shorts_kid_category.Font;
            label_shorts_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shorts_kid_category.ForeColor = Color.Black;
            label_kid_category.Text = "Kids" + "/" + "Shorts";

            label_amount_item_kid.Text = "2";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.shorts_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.shorts_kids_2_1;
            label_Accessories_kid_1.Text = "Girls' Pre-School UA Young Wild \r\nFly By Shorts";
            label_Accessories_kid_2.Text = "Boys' UA Field Shorts";
            label_money_Accessories_kid_1.Text = "25";
            label_money_Accessories_kid_2.Text = "45";

            panel_outwear_kid_1.Visible = false;
            panel_outwear_kid_2.Visible = false;
            panel_swimsuits_kid_1.Visible = false;
            panel_swimsuits_kid_2.Visible = false;
            panel_shorts_kid_1.Visible = false;
            panel_shorts_kid_2.Visible = false;
            panel_shirts_kid_1.Visible = false;
            panel_shirts_kid_2.Visible = false;
            panel_shoes_kid_1.Visible = false;
            panel_shoes_kid_2.Visible = false;
        }

        private void label_shirts_kid_category_Click(object sender, EventArgs e)
        {
            var font = label_shirts_kid_category.Font;
            label_shirts_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shirts_kid_category.ForeColor = Color.Black;
            label_kid_category.Text = "Kids" + "/" + "Shirts";

            label_amount_item_kid.Text = "2";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.shirts_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.shirts_kids_2_1;
            label_Accessories_kid_1.Text = "Boys' Project Rock Veterans Day \r\nShow Camo T-Shirt";
            label_Accessories_kid_2.Text = "Girls' UA Rival Fleece Big Logo \r\nHoodie";
            label_money_Accessories_kid_1.Text = "30";
            label_money_Accessories_kid_2.Text = "40";

            panel_outwear_kid_1.Visible = false;
            panel_outwear_kid_2.Visible = false;
            panel_swimsuits_kid_1.Visible = false;
            panel_swimsuits_kid_2.Visible = false;
            panel_shorts_kid_1.Visible = false;
            panel_shorts_kid_2.Visible = false;
            panel_shirts_kid_1.Visible = false;
            panel_shirts_kid_2.Visible = false;
            panel_shoes_kid_1.Visible = false;
            panel_shoes_kid_2.Visible = false;
        }

        private void label_shoes_kid_category_Click(object sender, EventArgs e)
        {
            var font = label_shoes_kid_category.Font;
            label_shoes_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_shoes_kid_category.ForeColor = Color.Black;
            label_kid_category.Text = "Kids" + "/" + "Shoes";

            label_amount_item_kid.Text = "2";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.shoes_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.shoes_kids_2_1;
            label_Accessories_kid_1.Text = "Girls' Pre-School UA Assert 9 \r\nAC Running Shoes";
            label_Accessories_kid_2.Text = "Boys' Grade School UA Assert 9 \r\nRunning Shoes";
            label_money_Accessories_kid_1.Text = "60";
            label_money_Accessories_kid_2.Text = "55";

            panel_outwear_kid_1.Visible = false;
            panel_outwear_kid_2.Visible = false;
            panel_swimsuits_kid_1.Visible = false;
            panel_swimsuits_kid_2.Visible = false;
            panel_shorts_kid_1.Visible = false;
            panel_shorts_kid_2.Visible = false;
            panel_shirts_kid_1.Visible = false;
            panel_shirts_kid_2.Visible = false;
            panel_shoes_kid_1.Visible = false;
            panel_shoes_kid_2.Visible = false;
        }

        private void label_all_kid_category_Click(object sender, EventArgs e)
        {
            var font = label_all_kid_category.Font;
            label_all_kid_category.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
            label_all_kid_category.ForeColor = Color.Black;
            label_kid_category.Text = "Kids";

            label_amount_item_kid.Text = "12";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
            label_Accessories_kid_1.Text = "UA Hustle Sport Backpack";
            label_Accessories_kid_2.Text = "UA Beyond 18 oz. Water Bottle";
            label_money_Accessories_kid_1.Text = "45";
            label_money_Accessories_kid_2.Text = "30";

            panel_Accessories_kid_1.Visible = true;
            panel_Accessories_kid_2.Visible = true;
            panel_outwear_kid_1.Visible = true;
            panel_outwear_kid_2.Visible = true;
            panel_swimsuits_kid_1.Visible = true;
            panel_swimsuits_kid_2.Visible = true;
            panel_shorts_kid_1.Visible = true;
            panel_shorts_kid_2.Visible = true;
            panel_shirts_kid_1.Visible = true;
            panel_shirts_kid_2.Visible = true;
            panel_shoes_kid_1.Visible = true;
            panel_shoes_kid_2.Visible = true;
        }

        private void label_outwear_men_Click(object sender, EventArgs e)
        {
            check_men = 1;
            check_women = 0;
            check_kid = 0;



            panel_men_shop.Visible = true;
            panel_women_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_men_category.Visible = false;
            panel_detail_item.Visible = false;

            label_men_category.Text = "Men" + "/" + "Outwear";

            label_amount_item_men.Text = "2";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.outwear_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Insulated \r\nBomber Outwear";
            label_outwear_man_2.Text = "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear";
            label_money_outwear_man_1.Text = "210";
            label_money_outwear_man_2.Text = "100";

            panel_pants_man_1.Visible = false;
            panel_pants_man_2.Visible = false;
            panel_shorts_man_1.Visible = false;
            panel_shorts_man_2.Visible = false;
            panel_shirts_man_1.Visible = false;
            panel_shirts_man_2.Visible = false;
            panel_shoes_man_1.Visible = false;
            panel_shoes_man_2.Visible = false;
        }

        private void label_pants_men_Click(object sender, EventArgs e)
        {
            check_men = 1;
            check_women = 0;
            check_kid = 0;

            panel_men_shop.Visible = true;
            panel_women_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_men_category.Visible = false;
            panel_detail_item.Visible = false;


            label_men_category.Text = "Men" + "/" + "Pants";


            label_amount_item_men.Text = "2";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.pants_man_1_2;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.pants_man_2_2;
            label_outwear_man_1.Text = "Men's UA RUSH™ ColdGear® \r\nLeggings";
            label_outwear_man_2.Text = "Men's UA Meridian Tapered \r\nPants";
            label_money_outwear_man_1.Text = "70";
            label_money_outwear_man_2.Text = "90";

            panel_pants_man_1.Visible = false;
            panel_pants_man_2.Visible = false;
            panel_shorts_man_1.Visible = false;
            panel_shorts_man_2.Visible = false;
            panel_shirts_man_1.Visible = false;
            panel_shirts_man_2.Visible = false;
            panel_shoes_man_1.Visible = false;
            panel_shoes_man_2.Visible = false;
        }

        private void label_shorts_men_Click(object sender, EventArgs e)
        {
            check_men = 1;
            check_women = 0;
            check_kid = 0;

            panel_men_shop.Visible = true;
            panel_women_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_men_category.Visible = false;
            panel_detail_item.Visible = false;


            label_men_category.Text = "Men" + "/" + "Shorts";

            label_amount_item_men.Text = "2";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.shorts_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.shorts_man_2_1;
            label_outwear_man_1.Text = "Men's UA Elevated Woven 2.0 \r\nShorts";
            label_outwear_man_2.Text = "Men's UA Rival Fleece Big Logo\r\nShorts";
            label_money_outwear_man_1.Text = "40";
            label_money_outwear_man_2.Text = "40";

            panel_pants_man_1.Visible = false;
            panel_pants_man_2.Visible = false;
            panel_shorts_man_1.Visible = false;
            panel_shorts_man_2.Visible = false;
            panel_shirts_man_1.Visible = false;
            panel_shirts_man_2.Visible = false;
            panel_shoes_man_1.Visible = false;
            panel_shoes_man_2.Visible = false;
        }

        private void label_shirts_men_Click(object sender, EventArgs e)
        {
            check_men = 1;
            check_women = 0;
            check_kid = 0;

            panel_men_shop.Visible = true;
            panel_women_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_men_category.Visible = false;
            panel_detail_item.Visible = false;


            label_men_category.Text = "Men" + "/" + "Shirts";

            label_amount_item_men.Text = "2";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.shirts_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.shirts_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Heavyweight \r\nTerry Sleeveless Hoodie";
            label_outwear_man_2.Text = "Men's UA Tech™ Collegiate \r\nSideline Short Sleeve";
            label_money_outwear_man_1.Text = "70";
            label_money_outwear_man_2.Text = "40";

            panel_pants_man_1.Visible = false;
            panel_pants_man_2.Visible = false;
            panel_shorts_man_1.Visible = false;
            panel_shorts_man_2.Visible = false;
            panel_shirts_man_1.Visible = false;
            panel_shirts_man_2.Visible = false;
            panel_shoes_man_1.Visible = false;
            panel_shoes_man_2.Visible = false;
        }

        private void label_shoes_man_Click(object sender, EventArgs e)
        {
            check_men = 1;
            check_women = 0;
            check_kid = 0;



            panel_men_shop.Visible = true;
            panel_women_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_men_category.Visible = false;
            panel_detail_item.Visible = false;


            label_men_category.Text = "Men" + "/" + "Shoes";

            label_amount_item_men.Text = "2";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.shoes_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.shoes_man_2_1;
            label_outwear_man_1.Text = "Unisex Curry Flow 10 'Sour \r\nThen Sweet' Basketball Shoes";
            label_outwear_man_2.Text = "Men's Project Rock 5 Veterans \r\nDay Training Shoes";
            label_money_outwear_man_1.Text = "160";
            label_money_outwear_man_2.Text = "150";

            panel_pants_man_1.Visible = false;
            panel_pants_man_2.Visible = false;
            panel_shorts_man_1.Visible = false;
            panel_shorts_man_2.Visible = false;
            panel_shirts_man_1.Visible = false;
            panel_shirts_man_2.Visible = false;
            panel_shoes_man_1.Visible = false;
            panel_shoes_man_2.Visible = false;
        }

        private void label_outwear_women_Click(object sender, EventArgs e)
        {
            check_men = 0;
            check_women = 1;
            check_kid = 0;

            panel_women_shop.Visible = true;
            panel_men_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_women_category.Visible = false;
            panel_detail_item.Visible = false;


            label_women_category.Text = "Women" + "/" + "Outwear";

            label_amount_item_women.Text = "2";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.outwear_women_2_1;
            label_outwear_women_1.Text = "Women's UA Storm ColdGear® \r\nInfrared Down Jacket";
            label_outwear_women_2.Text = "Women's UA OutRun The Storm\r\nJacket";
            label_money_outwear_women_1.Text = "250";
            label_money_outwear_women_2.Text = "100";

            panel_pants_women_1.Visible = false;
            panel_pants_women_2.Visible = false;
            panel_shorts_women_1.Visible = false;
            panel_shorts_women_2.Visible = false;
            panel_shirts_women_1.Visible = false;
            panel_shirts_women_2.Visible = false;
            panel_shoes_women_1.Visible = false;
            panel_shoes_women_2.Visible = false;
        }

        private void label_pants_women_Click(object sender, EventArgs e)
        {
            check_men = 0;
            check_women = 1;
            check_kid = 0;

            panel_women_shop.Visible = true;
            panel_men_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = false;
            panel_women_category.Visible = false;

            label_women_category.Text = "Women" + "/" + "Pants";

            label_amount_item_women.Text = "2";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.pants_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.pants_women_2_1;
            label_outwear_women_1.Text = "Women's UA Meridian Jacquard\r\nAnkle Leggings";
            label_outwear_women_2.Text = "Women's UA Armour Sport \r\nWoven Pants";
            label_money_outwear_women_1.Text = "70";
            label_money_outwear_women_2.Text = "45";

            panel_pants_women_1.Visible = false;
            panel_pants_women_2.Visible = false;
            panel_shorts_women_1.Visible = false;
            panel_shorts_women_2.Visible = false;
            panel_shirts_women_1.Visible = false;
            panel_shirts_women_2.Visible = false;
            panel_shoes_women_1.Visible = false;
            panel_shoes_women_2.Visible = false;
        }

        private void label_shorts_women_Click(object sender, EventArgs e)
        {
            check_men = 0;
            check_women = 1;
            check_kid = 0; 
            
            panel_women_shop.Visible = true;
            panel_men_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = false;
            panel_women_category.Visible = false;

            label_women_category.Text = "Women" + "/" + "Shorts";

            label_amount_item_women.Text = "2";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.shorts_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.shorts_women_2_1;
            label_outwear_women_1.Text = "Women's UA Play Up 2-in-1 \r\nShorts";
            label_outwear_women_2.Text = "Women's UA Links Shorts";
            label_money_outwear_women_1.Text = "35";
            label_money_outwear_women_2.Text = "75";

            panel_pants_women_1.Visible = false;
            panel_pants_women_2.Visible = false;
            panel_shorts_women_1.Visible = false;
            panel_shorts_women_2.Visible = false;
            panel_shirts_women_1.Visible = false;
            panel_shirts_women_2.Visible = false;
            panel_shoes_women_1.Visible = false;
            panel_shoes_women_2.Visible = false;
        }

        private void label1_shirts_women_Click(object sender, EventArgs e)
        {
            check_men = 0;
            check_women = 1;
            check_kid = 0;

            panel_women_shop.Visible = true;
            panel_men_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = false;
            panel_women_category.Visible = false;

            label_women_category.Text = "Women" + "/" + "Shirts";

            label_amount_item_women.Text = "2";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.shirts_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.shirts_women_2_1;
            label_outwear_women_1.Text = "Women's ColdGear® Authentics\r\nCrew";
            label_outwear_women_2.Text = "Women's Project Rock Veterans \r\nDay Fleece Hoodie";
            label_money_outwear_women_1.Text = "55";
            label_money_outwear_women_2.Text = "100";

            panel_pants_women_1.Visible = false;
            panel_pants_women_2.Visible = false;
            panel_shorts_women_1.Visible = false;
            panel_shorts_women_2.Visible = false;
            panel_shirts_women_1.Visible = false;
            panel_shirts_women_2.Visible = false;
            panel_shoes_women_1.Visible = false;
            panel_shoes_women_2.Visible = false;
        }

        private void label_shoes_women_Click(object sender, EventArgs e)
        {
            check_men = 0;
            check_women = 1;
            check_kid = 0;

            panel_women_shop.Visible = true;
            panel_men_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = false;
            panel_women_category.Visible = false;

            label_women_category.Text = "Women" + "/" + "Shoes";

            label_amount_item_women.Text = "2";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.shoes_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.shoes_women_2_1;
            label_outwear_women_1.Text = "Women's UA HOVR™ Machina 3\r\nRunning Shoes";
            label_outwear_women_2.Text = "Women's Project Rock 5 Training\r\nShoes";
            label_money_outwear_women_1.Text = "150";
            label_money_outwear_women_2.Text = "150";

            panel_pants_women_1.Visible = false;
            panel_pants_women_2.Visible = false;
            panel_shorts_women_1.Visible = false;
            panel_shorts_women_2.Visible = false;
            panel_shirts_women_1.Visible = false;
            panel_shirts_women_2.Visible = false;
            panel_shoes_women_1.Visible = false;
            panel_shoes_women_2.Visible = false;
        }

        private void label_accessories_kid_Click(object sender, EventArgs e)
        {
            check_men = 0;
            check_women = 0;
            check_kid = 1;

            panel_kids_category.Visible = false;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = false;
            panel_kid_shop.Visible = true;

            label_kid_category.Text = "Kids" + "/" + "Accessories";

            label_amount_item_kid.Text = "2";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
            label_Accessories_kid_1.Text = "UA Hustle Sport Backpack";
            label_Accessories_kid_2.Text = "UA Beyond 18 oz. Water Bottle";
            label_money_Accessories_kid_1.Text = "45";
            label_money_Accessories_kid_2.Text = "30";

            panel_outwear_kid_1.Visible = false;
            panel_outwear_kid_2.Visible = false;
            panel_swimsuits_kid_1.Visible = false;
            panel_swimsuits_kid_2.Visible = false;
            panel_shorts_kid_1.Visible = false;
            panel_shorts_kid_2.Visible = false;
            panel_shirts_kid_1.Visible = false;
            panel_shirts_kid_2.Visible = false;
            panel_shoes_kid_1.Visible = false;
            panel_shoes_kid_2.Visible = false;
        }

        private void label_outwear_kids_Click(object sender, EventArgs e)
        {
            check_men = 0;
            check_women = 0;
            check_kid = 1;

            panel_kids_category.Visible = false;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = false ;
            panel_detail_item.Visible = false;
            panel_kid_shop.Visible = true;

            label_kid_category.Text = "Kids" + "/" + "Outwear";

            label_amount_item_kid.Text = "2";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.outwear_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.outwear_kids_2_1;
            label_Accessories_kid_1.Text = "Boys' UA Powderhound Jacket";
            label_Accessories_kid_2.Text = "Girls' UA Laila Printed Jacket";
            label_money_Accessories_kid_1.Text = "155";
            label_money_Accessories_kid_2.Text = "135";

            panel_outwear_kid_1.Visible = false;
            panel_outwear_kid_2.Visible = false;
            panel_swimsuits_kid_1.Visible = false;
            panel_swimsuits_kid_2.Visible = false;
            panel_shorts_kid_1.Visible = false;
            panel_shorts_kid_2.Visible = false;
            panel_shirts_kid_1.Visible = false;
            panel_shirts_kid_2.Visible = false;
            panel_shoes_kid_1.Visible = false;
            panel_shoes_kid_2.Visible = false;
        }

        private void label_swimsuits_kids_Click(object sender, EventArgs e)
        {
            check_men = 0;
            check_women = 0;
            check_kid = 1;

            panel_kids_category.Visible = false;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = false;
            panel_kid_shop.Visible = true;

            label_kid_category.Text = "Kids" + "/" + "Swimsuits";

            label_amount_item_kid.Text = "2";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Swimwear_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Swimwear_kids_2_1;
            label_Accessories_kid_1.Text = "Girls' UA Plant Life Sports Top \r\nand Boyshort 2-Piece Swim Set";
            label_Accessories_kid_2.Text = "Girls' Pre-School UA Stripe \r\nFlutter Bikini";
            label_money_Accessories_kid_1.Text = "40";
            label_money_Accessories_kid_2.Text = "36";

            panel_outwear_kid_1.Visible = false;
            panel_outwear_kid_2.Visible = false;
            panel_swimsuits_kid_1.Visible = false;
            panel_swimsuits_kid_2.Visible = false;
            panel_shorts_kid_1.Visible = false;
            panel_shorts_kid_2.Visible = false;
            panel_shirts_kid_1.Visible = false;
            panel_shirts_kid_2.Visible = false;
            panel_shoes_kid_1.Visible = false;
            panel_shoes_kid_2.Visible = false;
        }

        private void label_shorts_kids_Click(object sender, EventArgs e)
        {
            check_men = 0;
            check_women = 0;
            check_kid = 1;

            panel_kids_category.Visible = false;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = false;
            panel_kid_shop.Visible = true;

            label_kid_category.Text = "Kids" + "/" + "Shorts";

            label_amount_item_kid.Text = "2";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.shorts_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.shorts_kids_2_1;
            label_Accessories_kid_1.Text = "Girls' Pre-School UA Young Wild \r\nFly By Shorts";
            label_Accessories_kid_2.Text = "Boys' UA Field Shorts";
            label_money_Accessories_kid_1.Text = "25";
            label_money_Accessories_kid_2.Text = "45";

            panel_outwear_kid_1.Visible = false;
            panel_outwear_kid_2.Visible = false;
            panel_swimsuits_kid_1.Visible = false;
            panel_swimsuits_kid_2.Visible = false;
            panel_shorts_kid_1.Visible = false;
            panel_shorts_kid_2.Visible = false;
            panel_shirts_kid_1.Visible = false;
            panel_shirts_kid_2.Visible = false;
            panel_shoes_kid_1.Visible = false;
            panel_shoes_kid_2.Visible = false; 
        }

        private void label_shirts_kids_Click(object sender, EventArgs e)
        {
            check_men = 0;
            check_women = 0;
            check_kid = 1;

            panel_kids_category.Visible = false;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = false;
            panel_kid_shop.Visible = true;

            label_kid_category.Text = "Kids" + "/" + "Shirts";

            label_amount_item_kid.Text = "2";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.shirts_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.shirts_kids_2_1;
            label_Accessories_kid_1.Text = "Boys' Project Rock Veterans Day \r\nShow Camo T-Shirt";
            label_Accessories_kid_2.Text = "Girls' UA Rival Fleece Big Logo \r\nHoodie";
            label_money_Accessories_kid_1.Text = "30";
            label_money_Accessories_kid_2.Text = "40";

            panel_outwear_kid_1.Visible = false;
            panel_outwear_kid_2.Visible = false;
            panel_swimsuits_kid_1.Visible = false;
            panel_swimsuits_kid_2.Visible = false;
            panel_shorts_kid_1.Visible = false;
            panel_shorts_kid_2.Visible = false;
            panel_shirts_kid_1.Visible = false;
            panel_shirts_kid_2.Visible = false;
            panel_shoes_kid_1.Visible = false;
            panel_shoes_kid_2.Visible = false;
        }

        private void label_shoes_kids_Click(object sender, EventArgs e)
        {
            check_men = 0;
            check_women = 0;
            check_kid = 1;

            panel_kids_category.Visible = false;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = false;
            panel_kid_shop.Visible = true;

            label_kid_category.Text = "Kids" + "/" + "Shoes";

            label_amount_item_kid.Text = "2";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.shoes_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.shoes_kids_2_1;
            label_Accessories_kid_1.Text = "Girls' Pre-School UA Assert 9 \r\nAC Running Shoes";
            label_Accessories_kid_2.Text = "Boys' Grade School UA Assert 9 \r\nRunning Shoes";
            label_money_Accessories_kid_1.Text = "60";
            label_money_Accessories_kid_2.Text = "55";

            panel_outwear_kid_1.Visible = false;
            panel_outwear_kid_2.Visible = false;
            panel_swimsuits_kid_1.Visible = false;
            panel_swimsuits_kid_2.Visible = false;
            panel_shorts_kid_1.Visible = false;
            panel_shorts_kid_2.Visible = false;
            panel_shirts_kid_1.Visible = false;
            panel_shirts_kid_2.Visible = false;
            panel_shoes_kid_1.Visible = false;
            panel_shoes_kid_2.Visible = false;
        }

        private void button_picture_detail_item_1_Click(object sender, EventArgs e)
        {
            pictureBox_detail_item.BackgroundImage = button_picture_detail_item_1.BackgroundImage;
        }

        private void button_picture_detail_item_2_Click(object sender, EventArgs e)
        {
            pictureBox_detail_item.BackgroundImage = button_picture_detail_item_2.BackgroundImage;
        }

        private void pictureBox_outwear_man_1_Click(object sender, EventArgs e)
        {
            panel_men_shop.Visible = false;
            panel_detail_item.Visible = true;

            switch(label_outwear_man_1.Text)
            {

                case "Men's Project Rock Insulated \r\nBomber Outwear":
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_man_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_man_1_2;

                    label_category_detail_item.Text = "Men" + '/' + "Outwear";
                    label_name_detail_item.Text = label_outwear_man_1.Text;
                    label_money_detail_item.Text = label_money_outwear_man_1.Text;
                    label_color_detail_item.Text = "Thyme / Black - 346";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_man_1;

                    label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right through" +
                        "\r\nthem. Everything in this collection was personally approved by Dwayne Johnson, the hardest" +
                        "\r\nworker in the room. ANY room.";
                    label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                        "\r\n• Smooth woven fabric is lightweight & extremely durable" +
                        "\r\n• Windproof materials shield you from the elements" +
                        "\r\n• All-over 200g synthetic insulation for ultimate warmth without excess bulk" +
                        "\r\n• Secure hand & sleeve pockets" +
                        "\r\n• 2-way front zip" +
                        "\r\n• Ribbed collar, cuffs & bottom hem";
                    label_Specs_detail_item.Text = "• Style #: 1374425" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";

                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Garment should be washed & dried fully zipped & turned inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not dry clean";
                    break;
                case "Men's UA RUSH™ ColdGear® \r\nLeggings":
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.pants_man_1_2;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.pants_man_1_2;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.pants_man_1_3;

                    label_category_detail_item.Text = "Men" + '/' + "Pants";
                    label_name_detail_item.Text = label_pants_man_1.Text;
                    label_money_detail_item.Text = label_money_pants_man_1.Text;
                    label_color_detail_item.Text = "Black - 001";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_pants_man_1;

                    label_info_detail_item.Text = "UA RUSH™ powers your toughest workouts, your biggest games, your most intense training." +
                        "\r\nIt gives you back energy, fits great, keeps you dry, and makes you feel like you can" +
                        "\r\ncrush every PR.";
                    label_DNA_detail_item.Text = "• UA RUSH™ is infrared technology that reflects your body's energy to help you work" +
                        "\r\n   harder and recover faster" +
                        "\r\n• Super-soft ColdGear® fabric is breathable and stretches for superior mobility but" +
                        "\r\n   is still incredibly warm" +
                        "\r\n• ColdGear® mesh panels provide breathability where you need it without sacrificing warmth" +
                        "\r\n• Strategic seam placement to eliminate pressure points and chafing" +
                        "\r\n• Updated gusset design provides ultimate support and comfort" +
                        "\r\n• Exposed elastic waistband" +
                        "\r\n• Drop-in Strength Pocket™ on right side for easy storage";
                    label_Specs_detail_item.Text = "• Style #: 1366060" +
                        "\r\n• Inseam: 28.25 inches" +
                        "\r\n• Pockets: Yes" +
                        "\r\n• Powered by Celliant" +
                        "\r\n• Body: 84% Polyester/16% Elastane" +
                        "\r\n• Mesh: 82% Polyester/18% Elastane" +
                        "\r\n• Imported";

                    label_Fit_detail_item.Text = "• Compression: Ultra-tight, second-skin fit." +
                        "\r\n• Wash garment inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Men's UA Elevated Woven 2.0 \r\nShorts"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_man_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_man_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_man_1_2;

                    label_category_detail_item.Text = "Men" + '/' + "Shorts";
                    label_name_detail_item.Text = label_shorts_man_1.Text;
                    label_money_detail_item.Text = label_money_shorts_man_1.Text;
                    label_color_detail_item.Text = "League Red / Black-626";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_man_1;

                    label_info_detail_item.Text = "The goal with the UA Woven collection was to make the perfect set of warm-ups that keep" +
                        "\r\nyour muscles ready, work for any sport, and also pack up super-small in your bag, so you" +
                        "\r\ncan take them anywhere.";
                    label_DNA_detail_item.Text = "• Ultra-durable woven fabric, built for the most intense workouts" +
                        "\r\n• Mesh side panels for strategic ventilation" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Material wicks sweat & dries really fast" +
                        "\r\n• Encased elastic waistband with internal drawcord" +
                        "\r\n• Open hand pockets";
                    label_Specs_detail_item.Text = "• Style #: 1362289" +
                        "\r\n• Inseam: 8.25 inches" +
                        "\r\n• No liner" +
                        "\r\n• Pockets: Yes" +
                        "\r\n• 89% Polyester/11% Elastane" +
                        "\r\n• Imported";

                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose.";
                    break;
                case ("Men's Project Rock Heavyweight \r\nTerry Sleeveless Hoodie"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_man_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_man_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_man_1_2;

                    label_category_detail_item.Text = "Men" + '/' + "Shirts";
                    label_name_detail_item.Text = label_shirts_man_1.Text;
                    label_money_detail_item.Text = label_money_shirts_man_1.Text;
                    label_color_detail_item.Text = "Tent / Vermillion-361";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_man_1;

                    label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right" +
                        "\r\nthrough them. Everything in this collection was personally approved by Dwayne Johnson," +
                        "\r\nthe hardest worker in the room. ANY room.";
                    label_DNA_detail_item.Text = "• Cotton-blend heavyweight Terry is super-soft & comfortable with a classic" +
                        "\r\n   athletic feel​" +
                        "\r\n• Front kangaroo pocket";
                    label_Specs_detail_item.Text = "• Style #: 1370462" +
                        "\r\n• 73% Cotton/27% Polyester" +
                        "\r\n• Imported";

                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Wash garment inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Unisex Curry Flow 10 'Sour \r\nThen Sweet' Basketball Shoes"):
                    button_size_shoes_38.Visible = true;
                    button_size_shoes_39.Visible = true;
                    button_size_shoes_40.Visible = true;
                    button_size_shoes_41.Visible = true;
                    button_size_shoes_42.Visible = true;


                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_man_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_man_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_man_1_2;

                    label_category_detail_item.Text = "Men" + '/' + "Shoes";
                    label_name_detail_item.Text = label_shoes_man_1.Text;
                    label_money_detail_item.Text = label_money_shoes_man_1.Text;
                    label_color_detail_item.Text = "Capri / Yellow Ray - 300";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_man_1;

                    label_info_detail_item.Text = "Change directions—fast. UA Flow cushioning is totally rubberless, making these" +
                        "\r\nshoes light and ridiculously grippy. The UA Warp upper works like mini seat belts" +
                        "\r\nlocking you in. Together, you get stop and go speed + control.";
                    label_DNA_detail_item.Text = "• UA WARP upper technology provides enhanced comfort and control throughout" +
                        "\r\n   dynamic basketball movements" +
                        "\r\n• Half-bootie upper lining for superior fit, comfort and lockdown" +
                        "\r\n• TPE-blend sockliner with low compression set for energy return and longevity" +
                        "\r\n• UA Flow cushioning technology is super-light, bouncy and provides insane grip" +
                        "\r\n• Internal midfoot shank adds support and stability to every move" +
                        "\r\n• Durable UA Flow outsole provides better court feel so you can cut and stop/start" +
                        "\r\n   faster than ever before";
                    label_Specs_detail_item.Text = "• Style #: 3025622" +
                        "\r\n• Weight: 12.5 oz" +
                        "\r\n• Lace type: Standard tie" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Regular";
                    break;
            }
            
        }

        private void pictureBox_outwear_man_2_Click(object sender, EventArgs e)
        {
            panel_men_shop.Visible = false;
            panel_detail_item.Visible = true;

            switch(label_outwear_man_2.Text)
            {
                case ("Men's UA Storm ColdGear®\r\nInfrared Shield Outwear"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_man_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_man_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_man_2_2;

                    label_category_detail_item.Text = "Men" + '/' + "Outwear";
                    label_name_detail_item.Text = label_outwear_man_2.Text;
                    label_money_detail_item.Text = label_money_outwear_man_2.Text;
                    label_color_detail_item.Text = "Tech Blue / Indigo-432";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_man_2;

                    label_info_detail_item.Text = "This men's Under Armour ColdGear® jacket is windproof, light, and warm. It's powered by" +
                        "\r\nour nearly weightless ColdGear® Infrared technology that actually traps your body warmth" +
                        "\r\nas you move.";
                    label_DNA_detail_item.Text = "• ColdGear® Infrared lining uses a soft, thermo-conductive inner coating to absorb and" +
                        "\r\n   retain body heat" +
                        "\r\n• Windproof construction shields you from the elements" +
                        "\r\n• Durable, bonded 3-layer softershell material has a quiet outer layer and superior" +
                        "\r\n   stretch 4-way stretch material moves better in every direction" +
                        "\r\n• Secure, zip chest & hand pockets" +
                        "\r\n• 100% Polyester";
                    label_Specs_detail_item.Text = "• Style #: 1321438" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose.";
                    break;
                case ("Men's UA Meridian Tapered \r\nPants"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.pants_man_2_3;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.pants_man_2_3;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.pants_man_2_2;

                    label_category_detail_item.Text = "Men" + '/' + "Pants";
                    label_name_detail_item.Text = label_pants_man_2.Text;
                    label_money_detail_item.Text = label_money_pants_man_2.Text;
                    label_color_detail_item.Text = "Fresh Clay - 176";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_pants_man_2;

                    label_info_detail_item.Text = "This specially engineered fabric delivers a unique type of softness that can still wick" +
                        "\r\nsweat like a champ. It's lightweight, it's breathable, and it's ready to work.";
                    label_DNA_detail_item.Text = "• Super-soft & stretchy performance knit fabric delivers support & lasting comfort" +
                        "\r\n• Material wicks sweat & dries really fast" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Encased elastic waistband with external drawcord" +
                        "\r\n• Secure, zip hand pockets";
                    label_Specs_detail_item.Text = "• Style #: 1373730" +
                        "\r\n• Inseam: 28.75 inches" +
                        "\r\n• Pockets: Yes" +
                        "\r\n• 83% Nylon/17% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose." +
                        "\r\n• Tapered leg fit with a high-low cuff hem that is slightly longer in the back" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Men's UA Rival Fleece Big Logo\r\nShorts"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_man_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_man_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_man_2_2;

                    label_category_detail_item.Text = "Men" + '/' + "Shorts";
                    label_name_detail_item.Text = label_shorts_man_2.Text;
                    label_money_detail_item.Text = label_money_shorts_man_2.Text;
                    label_color_detail_item.Text = "Black / Onyx White - 001";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_man_2;

                    label_info_detail_item.Text = "These are your new favorite warm-up pants for pretty much everything you do—they're" +
                        "\r\nlight, comfy, and are super-soft on the inside.";
                    label_DNA_detail_item.Text = "• Ultra-soft, mid-weight cotton-blend fleece" +
                        "\r\n• Brushed interior for extra warmth" +
                        "\r\n• Encased elastic waistband with external drawcord" +
                        "\r\n• Open hand pockets & secure, snap back pocket";
                    label_Specs_detail_item.Text = "• Style #: 1357118" +
                        "\r\n• Inseam: 10 inches" +
                        "\r\n• 80% Cotton/20% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Wash garment inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Men's UA Tech™ Collegiate \r\nSideline Short Sleeve"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_man_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_man_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_man_2_2;

                    label_category_detail_item.Text = "Men" + '/' + "Shirts";
                    label_name_detail_item.Text = label_shirts_man_2.Text;
                    label_money_detail_item.Text = label_money_shirts_man_2.Text;
                    label_color_detail_item.Text = "Colorado State University-301";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_man_2;

                    label_info_detail_item.Text = "Even our fan gear is built for performance—so you can wear it on the field just as" +
                        "\r\neasily as you wear it in the stands.";
                    label_DNA_detail_item.Text = "• UA Tech™ fabric is quick drying, ultra-soft & has a more natural feel" +
                        "\r\n• Material wicks sweat & dries really fast";
                    label_Specs_detail_item.Text = "• Style #: 5111867" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort.";
                    break;
                case ("Men's Project Rock 5 Veterans \r\nDay Training Shoes"):
                    button_size_shoes_38.Visible = true;
                    button_size_shoes_39.Visible = true;
                    button_size_shoes_40.Visible = true;
                    button_size_shoes_41.Visible = true;
                    button_size_shoes_42.Visible = true;


                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_man_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_man_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_man_2_2jpg;

                    label_category_detail_item.Text = "Men" + '/' + "Shoes";
                    label_name_detail_item.Text = label_shoes_man_2.Text;
                    label_money_detail_item.Text = label_money_shoes_man_2.Text;
                    label_color_detail_item.Text = "Canyon Clay / Khaki Base - 301";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_man_2;

                    label_info_detail_item.Text = "\\\"The Project Rock 5s are the most innovative training shoes we've ever made—they give" +
                        "\r\nyou power, energy, support with an amazing comfort level.\\\" – Dwayne Johnson";
                    label_DNA_detail_item.Text = "• Durable engineered mesh upper is lightweight & breathable with stretch & structure where" +
                        "\r\n   you need it" +
                        "\r\n• Plush knit collar for maximum comfort" +
                        "\r\n• Molded TPU heel-to-midfoot strap to stabilize & lock down your heel while enabling" +
                        "\r\n   forefoot mobility" +
                        "\r\n• Responsive UA HOVR™ cushioning reduces impact, returns energy & helps propel you forward" +
                        "\r\n• UA TriBase™ maximizes ground contact, promotes natural motion & provides flexibility to" +
                        "\r\n   grip during lifts";
                    label_Specs_detail_item.Text = "• Style #: 3025556" +
                        "\r\n• Offset: 8mm" +
                        "\r\n• Weight: 13.5 oz." +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Regular";
                    break;
            }
    
        }

        private void pictureBox_pants_man_1_Click(object sender, EventArgs e)
        {
            panel_men_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.pants_man_1_2;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.pants_man_1_2;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.pants_man_1_3;

            label_category_detail_item.Text = "Men" + '/' + "Pants";
            label_name_detail_item.Text = label_pants_man_1.Text;
            label_money_detail_item.Text = label_money_pants_man_1.Text;
            label_color_detail_item.Text = "Black - 001";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_pants_man_1;

            label_info_detail_item.Text = "UA RUSH™ powers your toughest workouts, your biggest games, your most intense training." +
                "\r\nIt gives you back energy, fits great, keeps you dry, and makes you feel like you can" +
                "\r\ncrush every PR.";
            label_DNA_detail_item.Text = "• UA RUSH™ is infrared technology that reflects your body's energy to help you work" +
                "\r\n   harder and recover faster" +
                "\r\n• Super-soft ColdGear® fabric is breathable and stretches for superior mobility but" +
                "\r\n   is still incredibly warm" +
                "\r\n• ColdGear® mesh panels provide breathability where you need it without sacrificing warmth" +
                "\r\n• Strategic seam placement to eliminate pressure points and chafing" +
                "\r\n• Updated gusset design provides ultimate support and comfort" +
                "\r\n• Exposed elastic waistband" +
                "\r\n• Drop-in Strength Pocket™ on right side for easy storage";
            label_Specs_detail_item.Text = "• Style #: 1366060" +
                "\r\n• Inseam: 28.25 inches" +
                "\r\n• Pockets: Yes" +
                "\r\n• Powered by Celliant" +
                "\r\n• Body: 84% Polyester/16% Elastane" +
                "\r\n• Mesh: 82% Polyester/18% Elastane" +
                "\r\n• Imported";

            label_Fit_detail_item.Text = "• Compression: Ultra-tight, second-skin fit." +
                "\r\n• Wash garment inside out" +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Use only non-chlorine bleach when needed" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_pants_man_2_Click(object sender, EventArgs e)
        {
            panel_men_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.pants_man_2_3;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.pants_man_2_3;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.pants_man_2_2;

            label_category_detail_item.Text = "Men" + '/' + "Pants";
            label_name_detail_item.Text = label_pants_man_2.Text;
            label_money_detail_item.Text = label_money_pants_man_2.Text;
            label_color_detail_item.Text = "Fresh Clay - 176";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_pants_man_2;

            label_info_detail_item.Text = "This specially engineered fabric delivers a unique type of softness that can still wick" +
                "\r\nsweat like a champ. It's lightweight, it's breathable, and it's ready to work.";
            label_DNA_detail_item.Text = "• Super-soft & stretchy performance knit fabric delivers support & lasting comfort" +
                "\r\n• Material wicks sweat & dries really fast" +
                "\r\n• 4-way stretch material moves better in every direction" +
                "\r\n• Encased elastic waistband with external drawcord" +
                "\r\n• Secure, zip hand pockets";
            label_Specs_detail_item.Text = "• Style #: 1373730" +
                "\r\n• Inseam: 28.75 inches" +
                "\r\n• Pockets: Yes" +
                "\r\n• 83% Nylon/17% Elastane" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose." +
                "\r\n• Tapered leg fit with a high-low cuff hem that is slightly longer in the back" +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Do not bleach" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_shorts_man_1_Click(object sender, EventArgs e)
        {
            panel_men_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_man_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_man_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_man_1_2;

            label_category_detail_item.Text = "Men" + '/' + "Shorts";
            label_name_detail_item.Text = label_shorts_man_1.Text;
            label_money_detail_item.Text = label_money_shorts_man_1.Text;
            label_color_detail_item.Text = "League Red / Black-626";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_man_1;

            label_info_detail_item.Text = "The goal with the UA Woven collection was to make the perfect set of warm-ups that keep" +
                "\r\nyour muscles ready, work for any sport, and also pack up super-small in your bag, so you" +
                "\r\ncan take them anywhere.";
            label_DNA_detail_item.Text = "• Ultra-durable woven fabric, built for the most intense workouts" +
                "\r\n• Mesh side panels for strategic ventilation" +
                "\r\n• 4-way stretch material moves better in every direction" +
                "\r\n• Material wicks sweat & dries really fast" +
                "\r\n• Encased elastic waistband with internal drawcord" +
                "\r\n• Open hand pockets";
            label_Specs_detail_item.Text = "• Style #: 1362289" +
                "\r\n• Inseam: 8.25 inches" +
                "\r\n• No liner" +
                "\r\n• Pockets: Yes" +
                "\r\n• 89% Polyester/11% Elastane" +
                "\r\n• Imported";

            label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose.";
        }

        private void pictureBox_shorts_man_2_Click(object sender, EventArgs e)
        {
            panel_men_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_man_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_man_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_man_2_2;

            label_category_detail_item.Text = "Men" + '/' + "Shorts";
            label_name_detail_item.Text = label_shorts_man_2.Text;
            label_money_detail_item.Text = label_money_shorts_man_2.Text;
            label_color_detail_item.Text = "Black / Onyx White - 001";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_man_2;

            label_info_detail_item.Text = "These are your new favorite warm-up pants for pretty much everything you do—they're" +
                "\r\nlight, comfy, and are super-soft on the inside.";
            label_DNA_detail_item.Text = "• Ultra-soft, mid-weight cotton-blend fleece" +
                "\r\n• Brushed interior for extra warmth" +
                "\r\n• Encased elastic waistband with external drawcord" +
                "\r\n• Open hand pockets & secure, snap back pocket";
            label_Specs_detail_item.Text = "• Style #: 1357118" +
                "\r\n• Inseam: 10 inches" +
                "\r\n• 80% Cotton/20% Polyester" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Wash garment inside out" +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Do not bleach" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_shirts_man_1_Click(object sender, EventArgs e)
        {
            panel_men_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_man_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_man_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_man_1_2;

            label_category_detail_item.Text = "Men" + '/' + "Shirts";
            label_name_detail_item.Text = label_shirts_man_1.Text;
            label_money_detail_item.Text = label_money_shirts_man_1.Text;
            label_color_detail_item.Text = "Tent / Vermillion-361";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_man_1;

            label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right" +
                "\r\nthrough them. Everything in this collection was personally approved by Dwayne Johnson," +
                "\r\nthe hardest worker in the room. ANY room.";
            label_DNA_detail_item.Text = "• Cotton-blend heavyweight Terry is super-soft & comfortable with a classic" +
                "\r\n   athletic feel​" +
                "\r\n• Front kangaroo pocket";
            label_Specs_detail_item.Text = "• Style #: 1370462" +
                "\r\n• 73% Cotton/27% Polyester" +
                "\r\n• Imported";

            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Wash garment inside out" +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Do not bleach" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_shirts_man_2_Click(object sender, EventArgs e)
        {
            panel_men_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_man_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_man_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_man_2_2;

            label_category_detail_item.Text = "Men" + '/' + "Shirts";
            label_name_detail_item.Text = label_shirts_man_2.Text;
            label_money_detail_item.Text = label_money_shirts_man_2.Text;
            label_color_detail_item.Text = "Colorado State University-301";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_man_2;

            label_info_detail_item.Text = "Even our fan gear is built for performance—so you can wear it on the field just as" +
                "\r\neasily as you wear it in the stands.";
            label_DNA_detail_item.Text = "• UA Tech™ fabric is quick drying, ultra-soft & has a more natural feel" +
                "\r\n• Material wicks sweat & dries really fast";
            label_Specs_detail_item.Text = "• Style #: 5111867" +
                "\r\n• 100% Polyester" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort.";
        }

        private void pictureBox_shoes_man_2_Click(object sender, EventArgs e)
        {
            panel_men_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_shoes_38.Visible = true;
            button_size_shoes_39.Visible = true;
            button_size_shoes_40.Visible = true;
            button_size_shoes_41.Visible = true;
            button_size_shoes_42.Visible = true;


            pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_man_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_man_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_man_2_2jpg;

            label_category_detail_item.Text = "Men" + '/' + "Shoes";
            label_name_detail_item.Text = label_shoes_man_2.Text;
            label_money_detail_item.Text = label_money_shoes_man_2.Text;
            label_color_detail_item.Text = "Canyon Clay / Khaki Base - 301";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_man_2;

            label_info_detail_item.Text = " \"The Project Rock 5s are the most innovative training shoes we've ever made—they give" +
                "\r\nyou power, energy, support with an amazing comfort level.\" – Dwayne Johnson";
            label_DNA_detail_item.Text = "• Durable engineered mesh upper is lightweight & breathable with stretch & structure where" +
                "\r\n   you need it" +
                "\r\n• Plush knit collar for maximum comfort" +
                "\r\n• Molded TPU heel-to-midfoot strap to stabilize & lock down your heel while enabling" +
                "\r\n   forefoot mobility" +
                "\r\n• Responsive UA HOVR™ cushioning reduces impact, returns energy & helps propel you " +
                "\r\nforward" +
                "\r\n• UA TriBase™ maximizes ground contact, promotes natural motion & provides flexibility to" +
                "\r\n   grip during lifts";
            label_Specs_detail_item.Text = "• Style #: 3025556" +
                "\r\n• Offset: 8mm" +
                "\r\n• Weight: 13.5 oz." +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Regular";
        }

        private void button_return_Click(object sender, EventArgs e)
        {

            name_size = "";

            button_size_accessories_onesize.Visible = false;

            button_size_kid_LG.Visible = false;
            button_size_kid_MD.Visible = false;
            button_size_kid_SM.Visible = false;
            button_size_kid_XL.Visible = false;
            button_size_kid_XS.Visible = false;

            button_size_shoes_38.Visible = false;
            button_size_shoes_39.Visible = false;
            button_size_shoes_40.Visible = false;
            button_size_shoes_41.Visible = false;
            button_size_shoes_42.Visible = false;

            button_size_shoes_kid_4.Visible = false;
            button_size_shoes_kid_4_5.Visible = false;
            button_size_shoes_kid_5.Visible = false;
            button_size_shoes_kid_5_5.Visible = false;
            button_size_shoes_kid_6.Visible = false;

            button_size_small.Visible = false;
            button_size_large.Visible = false;
            button_size_medium.Visible = false;
            button_size_XL.Visible = false;
            button_size_XXL.Visible = false;

            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.White;

            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;
            button_size_shoes_42.BackColor = Color.White;

            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.White;

            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.White;

            button_size_accessories_onesize.BackColor = Color.White;

            if (check_men == 1)
            {
                panel_men_shop.Visible = true;
                panel_detail_item.Visible = false;
            }

            if (check_women == 1)
            {
                panel_women_shop.Visible = true;
                panel_detail_item.Visible = false;

            }

            if (check_kid == 1)
            {
                panel_kid_shop.Visible = true;
                panel_detail_item.Visible = false;

            }

            if (check_men == 0 && check_women == 0 && check_kid == 0)
            {
                panel_men_shop.Visible = false;
                panel_women_shop.Visible = false;
                panel_kid_shop.Visible = false;
                panel_detail_item.Visible = false;
                panel_main_shop.Visible = true;
            }

        }

        private void panel_detail_item_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;
        }

        private void pictureBox_detail_item_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;
        }

        private void panel_detail_info_item_MouseMove(object sender, MouseEventArgs e)
        {
            panel_men_category.Visible = false;
            panel_women_category.Visible = false;
            panel_kids_category.Visible = false;
        }

        private void pictureBox_outwear_women_1_Click(object sender, EventArgs e)
        {
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = true;

            switch(label_outwear_women_1.Text)
            {
                case ("Women's UA Storm ColdGear® \r\nInfrared Down Jacket"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;


                    pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_women_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_women_1_2;

                    label_category_detail_item.Text = "Women" + '/' + "Outwear";
                    label_name_detail_item.Text = label_outwear_women_1.Text;
                    label_money_detail_item.Text = label_money_outwear_women_1.Text;
                    label_color_detail_item.Text = "Canyon Clay / Khaki Base - 301";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_women_1;

                    label_info_detail_item.Text = "Keeping your muscles warm in cold weather is key—to your performance AND recovery." +
                        "\r\nColdGear® Infrared Down provides warmth, protection, and breathability, so you maintain" +
                        "\r\nfocus, clarity, and forward momentum. Cold can't stop you.";
                    label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                        "\r\n   700-fill Allied duck down insulation provides extreme warmth & is ethically sourced" +
                        "\r\n   and traceable via tag\r\n• Lightweight woven fabric delivers superior comfort & durability" +
                        "\r\n• ColdGear® Infrared lining uses a soft, thermo-conductive coating to absorb and retain" +
                        "\r\n   your body heat" +
                        "\r\n• Roomy hood design with bungee adjust & extended, bonded brim" +
                        "\r\n• Full zip front with snap-closure Storm flap" +
                        "\r\n• Secure, zip hand & chest pockets";
                    label_Specs_detail_item.Text = "• Style #: 1375442" +
                        "\r\n• Woven patch logo on left sleeve" +
                        "\r\n• 100% Nylon" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Garment should be washed & dried fully zipped & turned inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Women's UA Meridian Jacquard\r\nAnkle Leggings"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;


                    pictureBox_detail_item.BackgroundImage = Properties.Resources.pants_women_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.pants_women_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.pants_women_1_2;

                    label_category_detail_item.Text = "Women" + '/' + "Pants";
                    label_name_detail_item.Text = label_pants_women_1.Text;
                    label_money_detail_item.Text = label_money_pants_women_1.Text;
                    label_color_detail_item.Text = "Opal Green / Metallic Silver - 781";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_pants_women_1;

                    label_info_detail_item.Text = "This specially engineered fabric delivers a unique type of softness that can still wick" +
                        "\r\nsweat like a champ. It's lightweight, it's breathable, and it's ready to work.";
                    label_DNA_detail_item.Text = "• Super-soft & stretchy performance knit fabric delivers support & lasting comfort" +
                        "\r\n• Material wicks sweat & dries really fast" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• High-rise waistband with built-in side pockets";
                    label_Specs_detail_item.Text = "• Style #: 1376340" +
                        "\r\n• Inseam: 26\"" +
                        "\r\n• Pockets: Yes" +
                        "\r\n• 72% Nylon/28% Elastane";
                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose." +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Women's ColdGear® Authentics\r\nCrew"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;


                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_women_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_women_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_women_1_2;

                    label_category_detail_item.Text = "Women" + '/' + "Shirts";
                    label_name_detail_item.Text = label_shirts_women_1.Text;
                    label_money_detail_item.Text = label_money_shirts_women_1.Text;
                    label_color_detail_item.Text = "White / Black-100";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_women_1;

                    label_info_detail_item.Text = "We all hate it. That stiff, distracted feeling you get when you're out in the cold." +
                        "\r\nThat's why, we built a baselayer that keeps you warm and dry without being bulky or" +
                        "\r\nriding up, so you can stay focused all season long.";
                    label_DNA_detail_item.Text = "• Dual-layer fabric with an ultra-warm, brushed interior & a smooth, fast-drying exterior" +
                        "\r\n• Material wicks sweat & dries really fast" +
                        "\r\n• Mesh underarm panels for added ventilation where you need it" +
                        "\r\n• Raglan sleeves";
                    label_Specs_detail_item.Text = "• Style #: 1368701" +
                        "\r\n• 87% Polyester/13% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose." +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Women's UA Play Up 2-in-1 \r\nShorts"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;


                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_women_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_women_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_women_1_2;

                    label_category_detail_item.Text = "Women" + '/' + "Shorts";
                    label_name_detail_item.Text = label_shorts_women_1.Text;
                    label_money_detail_item.Text = label_money_shorts_women_1.Text;
                    label_color_detail_item.Text = "Black / White - 001";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_women_1;

                    label_info_detail_item.Text = "Everyone needs a go-to pair of shorts. These feature a lightweight fabric that keeps" +
                        "\r\nyou cool and comfortable at all times. You'll love the way they look and the way they" +
                        "\r\nfeel even more.";
                    label_DNA_detail_item.Text = "• Soft, lightweight knit fabric on outer shorts delivers superior comfort and" +
                        "\r\n   breathability" +
                        "\r\n• Material wicks sweat & dries really fast" +
                        "\r\n• Anti-pill/anti-pick finish adds extra durability" +
                        "\r\n• Built-in, knit compression shorts for relentless coverage and support" +
                        "\r\n• Mesh panels for added breathability" +
                        "\r\n• Soft, exposed elastic waistband with wordmark detail" +
                        "\r\n• Convenient side hand pockets";
                    label_Specs_detail_item.Text = "• Style #: 1351981" +
                        "\r\n• Inseam (outer short): 3\"" +
                        "\r\n• Inseam (inner short): 5.5\"" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Women's UA HOVR™ Machina 3\r\nRunning Shoes"):
                    button_size_shoes_38.Visible = true;
                    button_size_shoes_39.Visible = true;
                    button_size_shoes_40.Visible = true;
                    button_size_shoes_41.Visible = true;
                    button_size_shoes_42.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_women_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_women_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_women_1_2;

                    label_category_detail_item.Text = "Women" + '/' + "Shoes";
                    label_name_detail_item.Text = label_shoes_women_1.Text;
                    label_money_detail_item.Text = label_money_shoes_women_1.Text;
                    label_color_detail_item.Text = "Pace Pink / Prime Pink - 601";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_women_1;

                    label_info_detail_item.Text = "UA HOVR™ Machina 3 is more than a running shoe. Yes, it gives you the energy return of" +
                        "\r\nUA HOVR®, but it also coaches you in real-time to help you run better when you connect" +
                        "\r\nthem to UA MapMyRun™.";
                    label_DNA_detail_item.Text = "• CONNECTS TO UA MAPMYRUN™: tracks & analyzes your running metrics to help make you" +
                        "\r\n   a better runner (Connectivity expires on December 31, 2024)" +
                        "\r\n• Engineered warp spacer upper for optimal lightweight containment & breathability" +
                        "\r\n• Strategically-mapped design without any overlays or seams so you can put in the miles" +
                        "\r\n   without irritation" +
                        "\r\n• Aerodynamic heel design & external TPU heel wrap for added support & lockdown fit" +
                        "\r\n• Molded EVA sockliner provides added comfort, resiliency & cushioning for high-mileage" +
                        "\r\n   performance" +
                        "\r\n• Responsive UA HOVR™ cushioning reduces impact, returns energy & helps propel you forward" +
                        "\r\n• Channeled rubber outsole mapped for durability in high-wear areas & flex zones to promote" +
                        "\r\n   natural movement";
                    label_Specs_detail_item.Text = "• Style #: 3024907" +
                        "\r\n• Offset: 8mm" +
                        "\r\n• Weight: 9.5 oz." +
                        "\r\n• Lace type: Standard tie" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Regular" +
                        "\r\n• NEUTRAL: For runners who need a balance of flexibility & cushioning";
                    break;
            }
        }


        private void pictureBox_outwear_women_2_Click(object sender, EventArgs e)
        {
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = true;

            switch (label_outwear_women_2.Text)
            {
                case ("Women's UA OutRun The Storm\r\nJacket"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_women_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_women_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_women_2_2;

                    label_category_detail_item.Text = "Women" + '/' + "Outwear";
                    label_name_detail_item.Text = label_outwear_women_2.Text;
                    label_money_detail_item.Text = label_money_outwear_women_2.Text;
                    label_color_detail_item.Text = "Illusion Green / Opal Green-592";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_women_2;

                    label_info_detail_item.Text = "The UA Outrun The Storm series isn't just water-resistant—it's super-water-resistant," +
                        "\r\nmeaning it protects better and lasts longer than other run rain gear. And it's more" +
                        "\r\nstretchy and comfortable, so you'll be more focused.";
                    label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                        "\r\n• Wind-resistant construction protects you from the elements" +
                        "\r\n• Durable, lightweight, stretch-woven fabric" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Back vent construction for added breathability" +
                        "\r\n• Secure, zip hand pockets with right-side interior media pocket" +
                        "\r\n• Bungee adjust hood & bottom hem for a secure fit";
                    label_Specs_detail_item.Text = "• Style #: 1361384" +
                        "\r\n• Raglan sleeves" +
                        "\r\n• Reflective details for low-light runs" +
                        "\r\n• 87% Polyester/13% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose." +
                        "\r\n• Garment should be washed & dried zipped up" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Wash garment inside out" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Women's UA Armour Sport \r\nWoven Pants"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.pants_women_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.pants_women_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.pants_women_2_2jpg;

                    label_category_detail_item.Text = "Women" + '/' + "Pants";
                    label_name_detail_item.Text = label_pants_women_2.Text;
                    label_money_detail_item.Text = label_money_pants_women_2.Text;
                    label_color_detail_item.Text = "Black / Metallic Silver - 001";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_pants_women_2;

                    label_info_detail_item.Text = "The goal with the UA Woven collection was to make the perfect set of warm-ups that keep" +
                        "\r\nyour muscles ready, work for any sport, and also pack up super-small in your bag, so you" +
                        "\r\ncan take them anywhere.";
                    label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                        "\r\n• Light, durable & super-comfortable stretch-woven fabric" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Stretchy encased elastic waistband with external drawcord";
                    label_Specs_detail_item.Text = "•Style #: 1348447" +
                        "\r\n• Open hand pockets" +
                        "\r\n• 2-ply cuffs" +
                        "\r\n• Inseam: 28\"" +
                        "\r\n• 87% Polyester/13% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Women's Project Rock Veterans\r\nDay Fleece Hoodie"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_women_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_women_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_women_2_2;

                    label_category_detail_item.Text = "Women" + '/' + "Shirts";
                    label_name_detail_item.Text = label_shirts_women_2.Text;
                    label_money_detail_item.Text = label_money_shirts_women_2.Text;
                    label_color_detail_item.Text = "Thyme / Black - 346";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_women_2;

                    label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right" +
                        "\r\nthrough them. Everything in this collection was personally approved by Dwayne Johnson," +
                        "\r\nthe hardest worker in the room. ANY room.";
                    label_DNA_detail_item.Text = "• Ultra-soft cotton-blend fleece with brushed inside for extra warmth" +
                        "\r\n• Front kangaroo pocket" +
                        "\r\n• Drop hem shoulder & slightly oversized sleeves" +
                        "\r\n• Ribbed cuffs & bottom hem";
                    label_Specs_detail_item.Text = "• Style #: 1373610" +
                        "\r\n• 80% Cotton/20% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Women's UA Links Shorts"):
                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_women_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_women_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_women_2_2;

                    label_category_detail_item.Text = "Women" + '/' + "Shorts";
                    label_name_detail_item.Text = label_shorts_women_2.Text;
                    label_money_detail_item.Text = label_money_shorts_women_2.Text;
                    label_color_detail_item.Text = "Black / Metallic Silver-001";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_women_2;

                    label_info_detail_item.Text = "This is the best women's golf gear in the game, plain and simple. Flexible, lightweight" +
                        "\r\nfabrics stretch with every swing to keep you comfortable and performing your best from" +
                        "\r\nthe first hole to the last.";
                    label_DNA_detail_item.Text = "• Light, durable & super-comfortable stretch-woven fabric" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Stretch-engineered waistband with adjustable inner elastic for a perfect fit" +
                        "\r\n• 4-pocket design with working fly";
                    label_Specs_detail_item.Text = "• Style #: 1362774" +
                        "\r\n• Inseam: 9\"" +
                        "\r\n• Pockets: Yes" +
                        "\r\n• 90% Polyester/10% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Wash garment inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Women's Project Rock 5 Training\r\nShoes"):
                    button_size_shoes_38.Visible = true;
                    button_size_shoes_39.Visible = true;
                    button_size_shoes_40.Visible = true;
                    button_size_shoes_41.Visible = true;
                    button_size_shoes_42.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_women_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_women_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_women_2_2;

                    label_category_detail_item.Text = "Women" + '/' + "Shoes";
                    label_name_detail_item.Text = label_shoes_women_2.Text;
                    label_money_detail_item.Text = label_money_shoes_women_2.Text;
                    label_color_detail_item.Text = "White - 100";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_women_2;

                    label_info_detail_item.Text = "\"The Project Rock 5s are the most innovative training shoes we've ever made—they give" +
                        "\r\nyou power, energy, support with an amazing comfort level.\" – Dwayne Johnson";
                    label_DNA_detail_item.Text = "• Durable engineered mesh upper is lightweight and breathable with stretch and structure" +
                        "\r\n   where you need it" +
                        "\r\n• Plush knit collar for maximum comfort" +
                        "\r\n• Molded TPU heel-to-midfoot strap to stabilize and lock down your heel while enabling" +
                        "\r\n   forefoot mobility" +
                        "\r\n• Responsive UA HOVR™ cushioning reduces impact, returns energy and helps propel" +
                        "\r\n   you forward" +
                        "\r\n• UA TriBase™ maximizes ground contact, promotes natural motion and provides flexibility" +
                        "\r\n   to grip during lifts";
                    label_Specs_detail_item.Text = "• Style #: 3025436" +
                        "\r\n• Offset: 8mm" +
                        "\r\n• Weight: 13.5 oz." +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Regular";
                    break;
            }
        }

        private void pictureBox_pants_women_1_Click(object sender, EventArgs e)
        {
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;


            pictureBox_detail_item.BackgroundImage = Properties.Resources.pants_women_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.pants_women_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.pants_women_1_2;

            label_category_detail_item.Text = "Women" + '/' + "Pants";
            label_name_detail_item.Text = label_pants_women_1.Text;
            label_money_detail_item.Text = label_money_pants_women_1.Text;
            label_color_detail_item.Text = "Opal Green / Metallic Silver - 781";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_pants_women_1;

            label_info_detail_item.Text = "This specially engineered fabric delivers a unique type of softness that can still wick" +
                "\r\nsweat like a champ. It's lightweight, it's breathable, and it's ready to work.";
            label_DNA_detail_item.Text = "• Super-soft & stretchy performance knit fabric delivers support & lasting comfort" +
                "\r\n• Material wicks sweat & dries really fast" +
                "\r\n• 4-way stretch material moves better in every direction" +
                "\r\n• High-rise waistband with built-in side pockets";
            label_Specs_detail_item.Text = "• Style #: 1376340" +
                "\r\n• Inseam: 26\"" +
                "\r\n• Pockets: Yes" +
                "\r\n• 72% Nylon/28% Elastane";
            label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose." +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Use only non-chlorine bleach when needed" +
                "\r\n• Do not use softeners" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_pants_women_2_Click(object sender, EventArgs e)
        {
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.pants_women_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.pants_women_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.pants_women_2_2jpg;

            label_category_detail_item.Text = "Women" + '/' + "Pants";
            label_name_detail_item.Text = label_pants_women_2.Text;
            label_money_detail_item.Text = label_money_pants_women_2.Text;
            label_color_detail_item.Text = "Black / Metallic Silver - 001";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_pants_women_2;

            label_info_detail_item.Text = "The goal with the UA Woven collection was to make the perfect set of warm-ups that keep" +
                "\r\nyour muscles ready, work for any sport, and also pack up super-small in your bag, so you" +
                "\r\ncan take them anywhere.";
            label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                "\r\n• Light, durable & super-comfortable stretch-woven fabric" +
                "\r\n• 4-way stretch material moves better in every direction" +
                "\r\n• Stretchy encased elastic waistband with external drawcord";
            label_Specs_detail_item.Text = "•Style #: 1348447" +
                "\r\n• Open hand pockets" +
                "\r\n• 2-ply cuffs" +
                "\r\n• Inseam: 28\"" +
                "\r\n• 87% Polyester/13% Elastane" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Use only non-chlorine bleach when needed" +
                "\r\n• Tumble dry low\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_shirts_women_1_Click(object sender, EventArgs e)
        {
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;


            pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_women_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_women_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_women_1_2;

            label_category_detail_item.Text = "Women" + '/' + "Shirts";
            label_name_detail_item.Text = label_shirts_women_1.Text;
            label_money_detail_item.Text = label_money_shirts_women_1.Text;
            label_color_detail_item.Text = "White / Black-100";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_women_1;

            label_info_detail_item.Text = "We all hate it. That stiff, distracted feeling you get when you're out in the cold." +
                "\r\nThat's why, we built a baselayer that keeps you warm and dry without being bulky or" +
                "\r\nriding up, so you can stay focused all season long.";
            label_DNA_detail_item.Text = "• Dual-layer fabric with an ultra-warm, brushed interior & a smooth, fast-drying exterior" +
                "\r\n• Material wicks sweat & dries really fast" +
                "\r\n• Mesh underarm panels for added ventilation where you need it" +
                "\r\n• Raglan sleeves";
            label_Specs_detail_item.Text = "• Style #: 1368701" +
                "\r\n• 87% Polyester/13% Elastane" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose." +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Do not bleach" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_shirts_women_2_Click(object sender, EventArgs e)
        {
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_women_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_women_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_women_2_2;

            label_category_detail_item.Text = "Women" + '/' + "Shirts";
            label_name_detail_item.Text = label_shirts_women_2.Text;
            label_money_detail_item.Text = label_money_shirts_women_2.Text;
            label_color_detail_item.Text = "Thyme / Black - 346";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_women_2;

            label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right" +
                "\r\nthrough them. Everything in this collection was personally approved by Dwayne Johnson," +
                "\r\nthe hardest worker in the room. ANY room.";
            label_DNA_detail_item.Text = "• Ultra-soft cotton-blend fleece with brushed inside for extra warmth" +
                "\r\n• Front kangaroo pocket" +
                "\r\n• Drop hem shoulder & slightly oversized sleeves" +
                "\r\n• Ribbed cuffs & bottom hem";
            label_Specs_detail_item.Text = "• Style #: 1373610" +
                "\r\n• 80% Cotton/20% Polyester" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Do not bleach" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_shorts_women_1_Click(object sender, EventArgs e)
        {
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;


            pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_women_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_women_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_women_1_2;

            label_category_detail_item.Text = "Women" + '/' + "Shorts";
            label_name_detail_item.Text = label_shorts_women_1.Text;
            label_money_detail_item.Text = label_money_shorts_women_1.Text;
            label_color_detail_item.Text = "Black / White - 001";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_women_1;

            label_info_detail_item.Text = "Everyone needs a go-to pair of shorts. These feature a lightweight fabric that keeps" +
                "\r\nyou cool and comfortable at all times. You'll love the way they look and the way they" +
                "\r\nfeel even more.";
            label_DNA_detail_item.Text = "• Soft, lightweight knit fabric on outer shorts delivers superior comfort and" +
                "\r\n   breathability" +
                "\r\n• Material wicks sweat & dries really fast" +
                "\r\n• Anti-pill/anti-pick finish adds extra durability" +
                "\r\n• Built-in, knit compression shorts for relentless coverage and support" +
                "\r\n• Mesh panels for added breathability" +
                "\r\n• Soft, exposed elastic waistband with wordmark detail" +
                "\r\n• Convenient side hand pockets";
            label_Specs_detail_item.Text = "• Style #: 1351981" +
                "\r\n• Inseam (outer short): 3\"" +
                "\r\n• Inseam (inner short): 5.5\"" +
                "\r\n• 100% Polyester" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Do not bleach" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_shorts_women_2_Click(object sender, EventArgs e)
        {
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_women_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_women_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_women_2_2;

            label_category_detail_item.Text = "Women" + '/' + "Shorts";
            label_name_detail_item.Text = label_shorts_women_2.Text;
            label_money_detail_item.Text = label_money_shorts_women_2.Text;
            label_color_detail_item.Text = "Black / Metallic Silver-001";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_women_2;

            label_info_detail_item.Text = "This is the best women's golf gear in the game, plain and simple. Flexible, lightweight" +
                "\r\nfabrics stretch with every swing to keep you comfortable and performing your best from" +
                "\r\nthe first hole to the last.";
            label_DNA_detail_item.Text = "• Light, durable & super-comfortable stretch-woven fabric" +
                "\r\n• 4-way stretch material moves better in every direction" +
                "\r\n• Stretch-engineered waistband with adjustable inner elastic for a perfect fit" +
                "\r\n• 4-pocket design with working fly";
            label_Specs_detail_item.Text = "• Style #: 1362774" +
                "\r\n• Inseam: 9\"" +
                "\r\n• Pockets: Yes" +
                "\r\n• 90% Polyester/10% Elastane" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Wash garment inside out" +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Do not bleach" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_shoes_women_1_Click(object sender, EventArgs e)
        {
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_shoes_38.Visible = true;
            button_size_shoes_39.Visible = true;
            button_size_shoes_40.Visible = true;
            button_size_shoes_41.Visible = true;
            button_size_shoes_42.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_women_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_women_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_women_1_2;

            label_category_detail_item.Text = "Women" + '/' + "Shoes";
            label_name_detail_item.Text = label_shoes_women_1.Text;
            label_money_detail_item.Text = label_money_shoes_women_1.Text;
            label_color_detail_item.Text = "Pace Pink / Prime Pink - 601";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_women_1;

            label_info_detail_item.Text = "UA HOVR™ Machina 3 is more than a running shoe. Yes, it gives you the energy return of" +
                "\r\nUA HOVR®, but it also coaches you in real-time to help you run better when you connect" +
                "\r\nthem to UA MapMyRun™.";
            label_DNA_detail_item.Text = "• CONNECTS TO UA MAPMYRUN™: tracks & analyzes your running metrics to help make you" +
                "\r\n   a better runner (Connectivity expires on December 31, 2024)" +
                "\r\n• Engineered warp spacer upper for optimal lightweight containment & breathability" +
                "\r\n• Strategically-mapped design without any overlays or seams so you can put in the miles" +
                "\r\n   without irritation" +
                "\r\n• Aerodynamic heel design & external TPU heel wrap for added support & lockdown fit" +
                "\r\n• Molded EVA sockliner provides added comfort, resiliency & cushioning for high-mileage" +
                "\r\n   performance" +
                "\r\n• Responsive UA HOVR™ cushioning reduces impact, returns energy & helps propel you forward" +
                "\r\n• Channeled rubber outsole mapped for durability in high-wear areas & flex zones to promote" +
                "\r\n   natural movement";
            label_Specs_detail_item.Text = "• Style #: 3024907" +
                "\r\n• Offset: 8mm" +
                "\r\n• Weight: 9.5 oz." +
                "\r\n• Lace type: Standard tie" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Regular" +
                "\r\n• NEUTRAL: For runners who need a balance of flexibility & cushioning";
        }

        private void pictureBox_shoes_women_2_Click(object sender, EventArgs e)
        {
            panel_women_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_shoes_38.Visible = true;
            button_size_shoes_39.Visible = true;
            button_size_shoes_40.Visible = true;
            button_size_shoes_41.Visible = true;
            button_size_shoes_42.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_women_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_women_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_women_2_2;

            label_category_detail_item.Text = "Women" + '/' + "Shoes";
            label_name_detail_item.Text = label_shoes_women_2.Text;
            label_money_detail_item.Text = label_money_shoes_women_2.Text;
            label_color_detail_item.Text = "White - 100";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_women_2;

            label_info_detail_item.Text = "\"The Project Rock 5s are the most innovative training shoes we've ever made—they give" +
                "\r\nyou power, energy, support with an amazing comfort level.\" – Dwayne Johnson";
            label_DNA_detail_item.Text = "• Durable engineered mesh upper is lightweight and breathable with stretch and structure" +
                "\r\n   where you need it" +
                "\r\n• Plush knit collar for maximum comfort" +
                "\r\n• Molded TPU heel-to-midfoot strap to stabilize and lock down your heel while enabling" +
                "\r\n   forefoot mobility" +
                "\r\n• Responsive UA HOVR™ cushioning reduces impact, returns energy and helps propel" +
                "\r\n   you forward" +
                "\r\n• UA TriBase™ maximizes ground contact, promotes natural motion and provides flexibility" +
                "\r\n   to grip during lifts";
            label_Specs_detail_item.Text = "• Style #: 3025436" +
                "\r\n• Offset: 8mm" +
                "\r\n• Weight: 13.5 oz." +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Regular";
        }

        private void pictureBox_Accessories_kid_1_Click(object sender, EventArgs e)
        {
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = true;

            switch (label_Accessories_kid_1.Text)
            {
                case ("UA Hustle Sport Backpack"):
                    button_size_accessories_onesize.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.Accessories_kids_1_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Accessories";
                    label_name_detail_item.Text = label_Accessories_kid_1.Text;
                    label_money_detail_item.Text = label_money_Accessories_kid_1.Text;
                    label_color_detail_item.Text = "Bauhaus Blue / White - 457";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_Accessories_kids_1;

                    label_info_detail_item.Text = "These bags are tough, light, and water rolls right off them—and those bungee sleeves" +
                        "\r\nmake it easy to stow things like a warm-up jacket quickly.";
                    label_DNA_detail_item.Text = "• Water-resistant UA Storm technology keeps your stuff dry" +
                        "\r\n• Padded back panel & shaped straps make it more comfortable to carry" +
                        "\r\n• Soft-lined laptop sleeve with organization panel—holds up to 15\" MacBook Pro® or" +
                        "\r\n   similarly sized laptop" +
                        "\r\n• Front sleeve with bungee adjust closure for easily stashing a jacket, pair of shoes" +
                        "\r\n   or ball" +
                        "\r\n• Large, zippered front valuables pocket" +
                        "\r\n• Durable, abrasion-resistant coated bottom";
                    label_Specs_detail_item.Text = "• Style #: 1364181" +
                        "\r\n• 2 side water bottle pockets" +
                        "\r\n• Top grab handle" +
                        "\r\n• Dimensions When Full: 12.6\"W x 7.4\"H x 18.5\"L" +
                        "\r\n• Volume: 26L" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• One Size Fits All";
                    break;
                case ("Boys' UA Powderhound Jacket"):
                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_kids_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_kids_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_kids_1_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Outwear";
                    label_name_detail_item.Text = label_outwear_kid_1.Text;
                    label_money_detail_item.Text = label_money_outwear_kid_1.Text;
                    label_color_detail_item.Text = "Versa Blue / BLACK - 486";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_kids_1;

                    label_info_detail_item.Text = "As at home in the powder as you are, with the features and performance you need to keep" +
                        "\r\nat it all day, warm, dry, and comfortable.";
                    label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                        "\r\n• 100% waterproof & breathable fabric with critically taped seams" +
                        "\r\n• Windproof materials & design shield you from the elements" +
                        "\r\n• 3M™ Thinsulate™ insulation is warm yet lightweight, trapping body heat while allowing" +
                        "\r\n   moisture to escape\r\n• UA UGrow system allows sleeves to grow 2\" to last an extra season" +
                        "\r\n• Helmet compatible hood with adjustable tab for a secure fit" +
                        "\r\n• Secure, zip hand warmer pockets with interior media pocket, chest pocket and interior" +
                        "\r\n   goggle pockets" +
                        "\r\n• Secure ski pass pocket on sleeve & adjustable powder skirt";
                    label_Specs_detail_item.Text = "• Style #: 5112817" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Wash inside out" +
                        "\r\n• Machine wash cold with like colors on gentle cycle" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Cool iron if needed" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Girls' UA Plant Life Sports Top \r\nand Boyshort 2-Piece Swim Set"):
                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.Swimwear_kids_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.Swimwear_kids_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.Swimwear_kids_1_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Swimsuits";
                    label_name_detail_item.Text = label_swimsuits_kid_1.Text;
                    label_money_detail_item.Text = label_money_swimsuits_kid_1.Text;
                    label_color_detail_item.Text = "MIDNIGHT NAVY / OPAL BLUE - 410";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_Swimwear_kids_1;

                    label_info_detail_item.Text = "Swimwear built with athletic innovation. Stretchy, light, quick-drying—everything" +
                        "\r\nyou need.";
                    label_DNA_detail_item.Text = "• Lightweight, 4-way stretch fabric for comfort & mobility" +
                        "\r\n• Built-in UPF 30 sun protection" +
                        "\r\n• Fully lined for extra coverage" +
                        "\r\n• Crossback sports bra style top with boyshort cut bottom";
                    label_Specs_detail_item.Text = "• Style #: 5106470" +
                        "\r\n• Sold as a set" +
                        "\r\n• Polyester/Spandex" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Wash garment inside out" +
                        "\r\n• Machine wash cold on gentle cycle with like colors" +
                        "\r\n• Use only non-chlorine bleach if needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Cool iron if needed";
                    break;
                case ("Girls' Pre-School UA Young Wild \r\nFly By Shorts"):
                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_kids_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_kids_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_kids_1_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Shorts";
                    label_name_detail_item.Text = label_shorts_kid_1.Text;
                    label_money_detail_item.Text = label_money_shorts_kid_1.Text;
                    label_color_detail_item.Text = "Cerise / WHITE - 653";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_kids_1;

                    label_info_detail_item.Text = "We took the materials from our go-to performance gear and made clothes for the youngest" +
                        "\r\nmembers of your team. Why? Because they're at least as active as the big kids.";
                    label_DNA_detail_item.Text = "• Lightweight, durable woven fabric is breathable & comfortable" +
                        "\r\n• Split leg design withmesh panels for more room to move" +
                        "\r\n• Soft, super-stretchy covered elastic waistband";
                    label_Specs_detail_item.Text = "• Style #: 5086560" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort";
                    break;
                case ("Boys' Project Rock Veterans Day \r\nShow Camo T-Shirt"):
                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_kids_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_kids_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_kids_1_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Shirts";
                    label_name_detail_item.Text = label_shirts_kid_1.Text;
                    label_money_detail_item.Text = label_money_shirts_kid_1.Text;
                    label_color_detail_item.Text = "Khaki Base / Black - 289";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_kids_1_1;

                    label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right" +
                        "\r\nthrough them. Everything in this collection was personally approved by Dwayne Johnson," +
                        "\r\nthe hardest worker in the room. ANY room.";
                    label_DNA_detail_item.Text = "• Super-soft, cotton-blend fabric provides all-day comfort" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Graphic appears when exposed to moisture so everyone knows who's working hardest" +
                        "\r\n   out there";
                    label_Specs_detail_item.Text = "• Style #: 1373622" +
                        "\r\n• 57% Cotton/38% Polyester/5% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Wash garment inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Girls' Pre-School UA Assert 9 \r\nAC Running Shoes"):
                    button_size_shoes_kid_4.Visible = true;
                    button_size_shoes_kid_4_5.Visible = true;
                    button_size_shoes_kid_5.Visible = true;
                    button_size_shoes_kid_5_5.Visible = true;
                    button_size_shoes_kid_6.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_kids_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_kids_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_kids_1_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Shoes";
                    label_name_detail_item.Text = label_shoes_kid_1.Text;
                    label_money_detail_item.Text = label_money_shoes_kid_1.Text;
                    label_color_detail_item.Text = "Halo Gray / White - 106";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_kids_1;

                    label_info_detail_item.Text = "Your ultimate lightweight, do-everything shoe—with soft cushioning for a smooth ride" +
                        "\r\nand synthetic overlays for more support.";
                    label_DNA_detail_item.Text = "• Lightweight mesh upper with 3-color digital print delivers complete breathability" +
                        "\r\n• Durable leather overlays for stability and that locks in your midfoot" +
                        "\r\n• Hook and loop strap for easy on and off" +
                        "\r\n• EVA sockliner provides soft, step-in comfort" +
                        "\r\n• One-piece EVA midsole turns cushioned landings into explosive takeoffs" +
                        "\r\n• Lightweight, durable outsole";
                    label_Specs_detail_item.Text = "• Style #: 3024636" +
                        "\r\n• Lace type: Standard tie with hook & loop strap" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Regular";
                    break;
            }
        }

        private void pictureBox_Accessories_kid_2_Click(object sender, EventArgs e)
        {
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = true;

            switch (label_Accessories_kid_2.Text)
            {
                case ("UA Beyond 18 oz. Water Bottle"):
                    button_size_accessories_onesize.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.Accessories_kids_2_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Accessories";
                    label_name_detail_item.Text = label_Accessories_kid_2.Text;
                    label_money_detail_item.Text = label_money_Accessories_kid_2.Text;
                    label_color_detail_item.Text = "Breeze / Chrome-441";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_Accessories_kids_2;

                    label_info_detail_item.Text = "When you're running or training, you don't always have a spare hand when you need" +
                        "\r\nto hydrate. That's why we made this—the pop top lid only needs one hand to work.";
                    label_DNA_detail_item.Text = "• Vacuum-insulated for maximum temperature retention keeps beverages cold for 18 hours" +
                        "\r\n• Unbreakable stainless steel interior and exterior provide durability that you can" +
                        "\r\n   count on" +
                        "\r\n• One-hand operation for hydration on the go" +
                        "\r\n• Carry loop for easy transport can be locked down when not in use" +
                        "\r\n• Lockable, leak-resistant lid also helps keep spout clean" +
                        "\r\n• Non-slip silicone bottom provides quiet set-down on any surface" +
                        "\r\n• BPA & lead free";
                    label_Specs_detail_item.Text = "• Style #: 1367747" +
                        "\r\n• Capacity: 18 oz." +
                        "\r\n• Dimensions: 10\"H x 3\"W x 3.2\"D" +
                        "\r\n• Compatible with UA Pro & UA Rise lids" +
                        "\r\n• Manufactured by USB, exclusive licensee of Under Armour®" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• One Size Fits All";
                    break;
                case ("Girls' UA Laila Printed Jacket"):
                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_kids_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_kids_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_kids_2_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Outwear";
                    label_name_detail_item.Text = label_outwear_kid_2.Text;
                    label_money_detail_item.Text = label_money_outwear_kid_2.Text;
                    label_color_detail_item.Text = "Aurora Purple / BLACK - 767";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_kids_2;

                    label_info_detail_item.Text = "The jacket you grab when you've gotta be out on the coldest days. Rain or snow in the" +
                        "\r\nforecast? We've got you covered there, too.";
                    label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                        "\r\n• 100% waterproof and breathable fabric with critically taped seams" +
                        "\r\n• Cozy microfleece lining insulated with lightweight heat technology for optimal warmth" +
                        "\r\n• 3-piece hood with adjustable tab for superior fit" +
                        "\r\n• Secure, zip hand warmer pockets and interior media pocket";
                    label_Specs_detail_item.Text = "• Style #: 5112576" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Wash inside out" +
                        "\r\n• Machine wash cold with like colors on gentle cycle" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Cool iron if needed" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Boys' UA Field Shorts"):
                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_kids_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_kids_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_kids_2_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Shorts";
                    label_name_detail_item.Text = label_shorts_kid_2.Text;
                    label_money_detail_item.Text = label_money_shorts_kid_2.Text;
                    label_color_detail_item.Text = "Cerulean / Neptune - 452";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_kids_2;

                    label_info_detail_item.Text = "Lightweight golf shorts with a drawstring instead of belt loops, to give you" +
                        "\r\na dialed-in fit.";
                    label_DNA_detail_item.Text = "• Light, durable stretch-woven twill fabric" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Encased elastic waistband with external drawcord" +
                        "\r\n• Open hand & back pockets";
                    label_Specs_detail_item.Text = "• Style #: 1370143" +
                        "\r\n• Inseam: YMD 7\" (+/- .5\" per size)" +
                        "\r\n• Pockets: Yes" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Wash garment inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Girls' UA Rival Fleece Big Logo \r\nHoodie"):
                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_kids_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_kids_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_kids_2_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Shirts";
                    label_name_detail_item.Text = label_shirts_kid_2.Text;
                    label_money_detail_item.Text = label_money_shirts_kid_2.Text;
                    label_color_detail_item.Text = "Prime Pink / Pink Punk - 647";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_kids_2;

                    label_info_detail_item.Text = "This gear keeps you warmed up and ready for pretty much everything you do—it's light," +
                        "\r\ncomfy, and super-soft on the inside.";
                    label_DNA_detail_item.Text = "• Ultra-soft cotton-blend fleece with brushed inside for extra warmth" +
                        "\r\n• Front kangaroo pocket" +
                        "\r\n• Ribbed cuffs & bottom hem" +
                        "\r\n• Raglan sleeves";
                    label_Specs_detail_item.Text = "• Style #: 1373127" +
                        "\r\n• 80% Cotton/20% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("Girls' Pre-School UA Stripe \r\nFlutter Bikini"):
                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.Swimwear_kids_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.Swimwear_kids_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.Swimwear_kids_2_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Swimsuits";
                    label_name_detail_item.Text = label_swimsuits_kid_2.Text;
                    label_money_detail_item.Text = label_money__swimsuits_kid_2.Text;
                    label_color_detail_item.Text = "CREST BLUE / REFLECTIVE - 446";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_Swimwear_kids_2;

                    label_info_detail_item.Text = "Swimwear built with athletic innovation. Stretchy, light, quick-drying—everything" +
                        "\r\nyou need.";
                    label_DNA_detail_item.Text = "• Lightweight, 4-way stretch fabric for comfort & mobility" +
                        "\r\n• Built-in UPF 30 sun protection" +
                        "\r\n• Fully lined for extra coverage";
                    label_Specs_detail_item.Text = "• Style #: 5037053" +
                        "\r\n• 85% Polyester/15% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose.";
                    break;
                case ("Boys' Grade School UA Assert 9 \r\nRunning Shoes"):
                    button_size_shoes_kid_4.Visible = true;
                    button_size_shoes_kid_4_5.Visible = true;
                    button_size_shoes_kid_5.Visible = true;
                    button_size_shoes_kid_5_5.Visible = true;
                    button_size_shoes_kid_6.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_kids_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_kids_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_kids_2_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Shoes";
                    label_name_detail_item.Text = label_shoes_kid_2.Text;
                    label_money_detail_item.Text = label_money_shoes_kid_2.Text;
                    label_color_detail_item.Text = "Red / White - 600";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_kids_2;

                    label_info_detail_item.Text = "Your ultimate lightweight, do-everything shoe—with soft cushioning for a smooth ride" +
                        "\r\nand synthetic overlays for more support.";
                    label_DNA_detail_item.Text = "• Lightweight mesh upper with 3-color digital print delivers complete breathability" +
                        "\r\n• Durable leather overlays for stability that locks in your midfoot" +
                        "\r\n• EVA sockliner provides soft, step-in comfort" +
                        "\r\n• One-piece EVA midsole turns cushioned landings into explosive takeoffs" +
                        "\r\n• Solid rubber outsole covers high impact zones for greater durability with less weight";
                    label_Specs_detail_item.Text = "• Style #: 3024633" +
                        "\r\n• Lace type: Standard tie" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Regular";
                    break;
            }
        }

        private void pictureBox_outwear_kid_1_Click(object sender, EventArgs e)
        {
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_kid_XS.Visible = true;
            button_size_kid_SM.Visible = true;
            button_size_kid_MD.Visible = true;
            button_size_kid_LG.Visible = true;
            button_size_kid_XL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_kids_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_kids_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_kids_1_2;

            label_category_detail_item.Text = "Kids" + '/' + "Outwear";
            label_name_detail_item.Text = label_outwear_kid_1.Text;
            label_money_detail_item.Text = label_money_outwear_kid_1.Text;
            label_color_detail_item.Text = "Versa Blue / BLACK - 486";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_kids_1;

            label_info_detail_item.Text = "As at home in the powder as you are, with the features and performance you need to keep" +
                "\r\nat it all day, warm, dry, and comfortable.";
            label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                "\r\n• 100% waterproof & breathable fabric with critically taped seams" +
                "\r\n• Windproof materials & design shield you from the elements" +
                "\r\n• 3M™ Thinsulate™ insulation is warm yet lightweight, trapping body heat while allowing" +
                "\r\n   moisture to escape\r\n• UA UGrow system allows sleeves to grow 2\" to last an extra season" +
                "\r\n• Helmet compatible hood with adjustable tab for a secure fit" +
                "\r\n• Secure, zip hand warmer pockets with interior media pocket, chest pocket and interior" +
                "\r\n   goggle pockets" +
                "\r\n• Secure ski pass pocket on sleeve & adjustable powder skirt";
            label_Specs_detail_item.Text = "• Style #: 5112817" +
                "\r\n• 100% Polyester" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Wash inside out" +
                "\r\n• Machine wash cold with like colors on gentle cycle" +
                "\r\n• Use only non-chlorine bleach when needed" +
                "\r\n• Tumble dry low" +
                "\r\n• Cool iron if needed" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_outwear_kid_2_Click(object sender, EventArgs e)
        {
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_kid_XS.Visible = true;
            button_size_kid_SM.Visible = true;
            button_size_kid_MD.Visible = true;
            button_size_kid_LG.Visible = true;
            button_size_kid_XL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_kids_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_kids_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_kids_2_2;

            label_category_detail_item.Text = "Kids" + '/' + "Outwear";
            label_name_detail_item.Text = label_outwear_kid_2.Text;
            label_money_detail_item.Text = label_money_outwear_kid_2.Text;
            label_color_detail_item.Text = "Aurora Purple / BLACK - 767";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_kids_2;

            label_info_detail_item.Text = "The jacket you grab when you've gotta be out on the coldest days. Rain or snow in the" +
                "\r\nforecast? We've got you covered there, too.";
            label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                "\r\n• 100% waterproof and breathable fabric with critically taped seams" +
                "\r\n• Cozy microfleece lining insulated with lightweight heat technology for optimal warmth" +
                "\r\n• 3-piece hood with adjustable tab for superior fit" +
                "\r\n• Secure, zip hand warmer pockets and interior media pocket";
            label_Specs_detail_item.Text = "• Style #: 5112576" +
                "\r\n• 100% Polyester" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Wash inside out" +
                "\r\n• Machine wash cold with like colors on gentle cycle" +
                "\r\n• Use only non-chlorine bleach when needed" +
                "\r\n• Tumble dry low" +
                "\r\n• Cool iron if needed" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_swimsuits_kid_1_Click(object sender, EventArgs e)
        {
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_kid_XS.Visible = true;
            button_size_kid_SM.Visible = true;
            button_size_kid_MD.Visible = true;
            button_size_kid_LG.Visible = true;
            button_size_kid_XL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.Swimwear_kids_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.Swimwear_kids_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.Swimwear_kids_1_2;

            label_category_detail_item.Text = "Kids" + '/' + "Swimsuits";
            label_name_detail_item.Text = label_swimsuits_kid_1.Text;
            label_money_detail_item.Text = label_money_swimsuits_kid_1.Text;
            label_color_detail_item.Text = "MIDNIGHT NAVY / OPAL BLUE - 410";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_Swimwear_kids_1;

            label_info_detail_item.Text = "Swimwear built with athletic innovation. Stretchy, light, quick-drying—everything" +
                "\r\nyou need.";
            label_DNA_detail_item.Text = "• Lightweight, 4-way stretch fabric for comfort & mobility" +
                "\r\n• Built-in UPF 30 sun protection" +
                "\r\n• Fully lined for extra coverage" +
                "\r\n• Crossback sports bra style top with boyshort cut bottom";
            label_Specs_detail_item.Text = "• Style #: 5106470" +
                "\r\n• Sold as a set" +
                "\r\n• Polyester/Spandex" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Wash garment inside out" +
                "\r\n• Machine wash cold on gentle cycle with like colors" +
                "\r\n• Use only non-chlorine bleach if needed" +
                "\r\n• Tumble dry low" +
                "\r\n• Cool iron if needed";
        }

        private void pictureBox_swimsuits_kid_2_Click(object sender, EventArgs e)
        {
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_kid_XS.Visible = true;
            button_size_kid_SM.Visible = true;
            button_size_kid_MD.Visible = true;
            button_size_kid_LG.Visible = true;
            button_size_kid_XL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.Swimwear_kids_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.Swimwear_kids_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.Swimwear_kids_2_2;

            label_category_detail_item.Text = "Kids" + '/' + "Swimsuits";
            label_name_detail_item.Text = label_swimsuits_kid_2.Text;
            label_money_detail_item.Text = label_money__swimsuits_kid_2.Text;
            label_color_detail_item.Text = "CREST BLUE / REFLECTIVE - 446";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_Swimwear_kids_2;

            label_info_detail_item.Text = "Swimwear built with athletic innovation. Stretchy, light, quick-drying—everything" +
                "\r\nyou need.";
            label_DNA_detail_item.Text = "• Lightweight, 4-way stretch fabric for comfort & mobility" +
                "\r\n• Built-in UPF 30 sun protection" +
                "\r\n• Fully lined for extra coverage";
            label_Specs_detail_item.Text = "• Style #: 5037053" +
                "\r\n• 85% Polyester/15% Elastane" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose.";
        }

        private void pictureBox_shorts_kid_1_Click(object sender, EventArgs e)
        {
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_kid_XS.Visible = true;
            button_size_kid_SM.Visible = true;
            button_size_kid_MD.Visible = true;
            button_size_kid_LG.Visible = true;
            button_size_kid_XL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_kids_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_kids_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_kids_1_2;

            label_category_detail_item.Text = "Kids" + '/' + "Shorts";
            label_name_detail_item.Text = label_shorts_kid_1.Text;
            label_money_detail_item.Text = label_money_shorts_kid_1.Text;
            label_color_detail_item.Text = "Cerise / WHITE - 653";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_kids_1;

            label_info_detail_item.Text = "We took the materials from our go-to performance gear and made clothes for the youngest" +
                "\r\nmembers of your team. Why? Because they're at least as active as the big kids.";
            label_DNA_detail_item.Text = "• Lightweight, durable woven fabric is breathable & comfortable" +
                "\r\n• Split leg design withmesh panels for more room to move" +
                "\r\n• Soft, super-stretchy covered elastic waistband";
            label_Specs_detail_item.Text = "• Style #: 5086560" +
                "\r\n• 100% Polyester" +
                "\r\n• Imported";
        }

        private void pictureBox_shorts_kid_2_Click(object sender, EventArgs e)
        {
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_kid_XS.Visible = true;
            button_size_kid_SM.Visible = true;
            button_size_kid_MD.Visible = true;
            button_size_kid_LG.Visible = true;
            button_size_kid_XL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_kids_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_kids_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_kids_2_2;

            label_category_detail_item.Text = "Kids" + '/' + "Shorts";
            label_name_detail_item.Text = label_shorts_kid_2.Text;
            label_money_detail_item.Text = label_money_shorts_kid_2.Text;
            label_color_detail_item.Text = "Cerulean / Neptune - 452";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_kids_2;

            label_info_detail_item.Text = "Lightweight golf shorts with a drawstring instead of belt loops, to give you" +
                "\r\na dialed-in fit.";
            label_DNA_detail_item.Text = "• Light, durable stretch-woven twill fabric" +
                "\r\n• 4-way stretch material moves better in every direction" +
                "\r\n• Encased elastic waistband with external drawcord" +
                "\r\n• Open hand & back pockets";
            label_Specs_detail_item.Text = "• Style #: 1370143" +
                "\r\n• Inseam: YMD 7\" (+/- .5\" per size)" +
                "\r\n• Pockets: Yes" +
                "\r\n• 100% Polyester" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Wash garment inside out" +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Use only non-chlorine bleach when needed" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_shirts_kid_1_Click(object sender, EventArgs e)
        {
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_kid_XS.Visible = true;
            button_size_kid_SM.Visible = true;
            button_size_kid_MD.Visible = true;
            button_size_kid_LG.Visible = true;
            button_size_kid_XL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_kids_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_kids_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_kids_1_2;

            label_category_detail_item.Text = "Kids" + '/' + "Shirts";
            label_name_detail_item.Text = label_shirts_kid_1.Text;
            label_money_detail_item.Text = label_money_shirts_kid_1.Text;
            label_color_detail_item.Text = "Khaki Base / Black - 289";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_kids_1_1;

            label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right" +
                "\r\nthrough them. Everything in this collection was personally approved by Dwayne Johnson," +
                "\r\nthe hardest worker in the room. ANY room.";
            label_DNA_detail_item.Text = "• Super-soft, cotton-blend fabric provides all-day comfort" +
                "\r\n• 4-way stretch material moves better in every direction" +
                "\r\n• Graphic appears when exposed to moisture so everyone knows who's working hardest" +
                "\r\n   out there";
            label_Specs_detail_item.Text = "• Style #: 1373622" +
                "\r\n• 57% Cotton/38% Polyester/5% Elastane" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Wash garment inside out" +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Do not bleach" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_shirts_kid_2_Click(object sender, EventArgs e)
        {
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_kid_XS.Visible = true;
            button_size_kid_SM.Visible = true;
            button_size_kid_MD.Visible = true;
            button_size_kid_LG.Visible = true;
            button_size_kid_XL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_kids_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_kids_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_kids_2_2;

            label_category_detail_item.Text = "Kids" + '/' + "Shirts";
            label_name_detail_item.Text = label_shirts_kid_2.Text;
            label_money_detail_item.Text = label_money_shirts_kid_2.Text;
            label_color_detail_item.Text = "Prime Pink / Pink Punk - 647";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_kids_2;

            label_info_detail_item.Text = "This gear keeps you warmed up and ready for pretty much everything you do—it's light," +
                "\r\ncomfy, and super-soft on the inside.";
            label_DNA_detail_item.Text = "• Ultra-soft cotton-blend fleece with brushed inside for extra warmth" +
                "\r\n• Front kangaroo pocket" +
                "\r\n• Ribbed cuffs & bottom hem" +
                "\r\n• Raglan sleeves";
            label_Specs_detail_item.Text = "• Style #: 1373127" +
                "\r\n• 80% Cotton/20% Polyester" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Do not bleach" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_shoes_kid_1_Click(object sender, EventArgs e)
        {
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_shoes_kid_4.Visible = true;
            button_size_shoes_kid_4_5.Visible = true;
            button_size_shoes_kid_5.Visible = true;
            button_size_shoes_kid_5_5.Visible = true;
            button_size_shoes_kid_6.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_kids_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_kids_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_kids_1_2;

            label_category_detail_item.Text = "Kids" + '/' + "Shoes";
            label_name_detail_item.Text = label_shoes_kid_1.Text;
            label_money_detail_item.Text = label_money_shoes_kid_1.Text;
            label_color_detail_item.Text = "Halo Gray / White - 106";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_kids_1;

            label_info_detail_item.Text = "Your ultimate lightweight, do-everything shoe—with soft cushioning for a smooth ride" +
                "\r\nand synthetic overlays for more support.";
            label_DNA_detail_item.Text = "• Lightweight mesh upper with 3-color digital print delivers complete breathability" +
                "\r\n• Durable leather overlays for stability and that locks in your midfoot" +
                "\r\n• Hook and loop strap for easy on and off" +
                "\r\n• EVA sockliner provides soft, step-in comfort" +
                "\r\n• One-piece EVA midsole turns cushioned landings into explosive takeoffs" +
                "\r\n• Lightweight, durable outsole";
            label_Specs_detail_item.Text = "• Style #: 3024636" +
                "\r\n• Lace type: Standard tie with hook & loop strap" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Regular";
        }

        private void pictureBox_shoes_kid_2_Click(object sender, EventArgs e)
        {
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_shoes_kid_4.Visible = true;
            button_size_shoes_kid_4_5.Visible = true;
            button_size_shoes_kid_5.Visible = true;
            button_size_shoes_kid_5_5.Visible = true;
            button_size_shoes_kid_6.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_kids_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_kids_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_kids_2_2;

            label_category_detail_item.Text = "Kids" + '/' + "Shoes";
            label_name_detail_item.Text = label_shoes_kid_2.Text;
            label_money_detail_item.Text = label_money_shoes_kid_2.Text;
            label_color_detail_item.Text = "Red / White - 600";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_kids_2;

            label_info_detail_item.Text = "Your ultimate lightweight, do-everything shoe—with soft cushioning for a smooth ride" +
                "\r\nand synthetic overlays for more support.";
            label_DNA_detail_item.Text = "• Lightweight mesh upper with 3-color digital print delivers complete breathability" +
                "\r\n• Durable leather overlays for stability that locks in your midfoot" +
                "\r\n• EVA sockliner provides soft, step-in comfort" +
                "\r\n• One-piece EVA midsole turns cushioned landings into explosive takeoffs" +
                "\r\n• Solid rubber outsole covers high impact zones for greater durability with less weight";
            label_Specs_detail_item.Text = "• Style #: 3024633" +
                "\r\n• Lace type: Standard tie" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Regular";
        }

        private void pictureBox_shoes_man_1_Click(object sender, EventArgs e)
        {
            panel_men_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_shoes_38.Visible = true;
            button_size_shoes_39.Visible = true;
            button_size_shoes_40.Visible = true;
            button_size_shoes_41.Visible = true;
            button_size_shoes_42.Visible = true;


            pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_man_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_man_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_man_1_2;

            label_category_detail_item.Text = "Men" + '/' + "Shoes";
            label_name_detail_item.Text = label_shoes_man_1.Text;
            label_money_detail_item.Text = label_money_shoes_man_1.Text;
            label_color_detail_item.Text = "Capri / Yellow Ray - 300";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_man_1;

            label_info_detail_item.Text = "Change directions—fast. UA Flow cushioning is totally rubberless, making these" +
                "\r\nshoes light and ridiculously grippy. The UA Warp upper works like mini seat belts" +
                "\r\nlocking you in. Together, you get stop and go speed + control.";
            label_DNA_detail_item.Text = "• UA WARP upper technology provides enhanced comfort and control throughout" +
                "\r\n   dynamic basketball movements" +
                "\r\n• Half-bootie upper lining for superior fit, comfort and lockdown" +
                "\r\n• TPE-blend sockliner with low compression set for energy return and longevity" +
                "\r\n• UA Flow cushioning technology is super-light, bouncy and provides insane grip" +
                "\r\n• Internal midfoot shank adds support and stability to every move" +
                "\r\n• Durable UA Flow outsole provides better court feel so you can cut and stop/start" +
                "\r\n   faster than ever before";
            label_Specs_detail_item.Text = "• Style #: 3025622" +
                "\r\n• Weight: 12.5 oz" +
                "\r\n• Lace type: Standard tie" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Regular";
        }

        private void button_size_small_Click(object sender, EventArgs e)
        {
            button_size_small.BackColor = Color.Lime;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.White;
            
            name_size = button_size_small.Text;
            
        }

        private void button_size_medium_Click(object sender, EventArgs e)
        {
            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.Lime;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.White;

            name_size = button_size_medium.Text;
        }

        private void button_size_large_Click(object sender, EventArgs e)
        {
            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.Lime;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.White;

            name_size = button_size_large.Text;
        }

        private void button_size_XL_Click(object sender, EventArgs e)
        {
            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.Lime;
            button_size_XXL.BackColor = Color.White;

            name_size = button_size_XL.Text;

        }

        private void button_size_XXL_Click(object sender, EventArgs e)
        {
            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.Lime;

            name_size = button_size_XXL.Text;

        }

        private void button_size_shoes_38_Click(object sender, EventArgs e)
        {
            button_size_shoes_38.BackColor = Color.Lime;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_42.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;


            name_size = button_size_shoes_38.Text;

        }

        private void button_size_shoes_39_Click(object sender, EventArgs e)
        {
            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.Lime;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_42.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;

            name_size = button_size_shoes_39.Text;

        }

        private void button_size_shoes_40_Click(object sender, EventArgs e)
        {
            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.Lime;
            button_size_shoes_42.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;
            name_size = button_size_shoes_40.Text;

        }

        private void button_size_shoes_41_Click(object sender, EventArgs e)
        {
            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.Lime;
            button_size_shoes_42.BackColor = Color.White;
            name_size = button_size_shoes_41.Text;

        }

        private void button_size_shoes_42_Click(object sender, EventArgs e)
        {
            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;
            button_size_shoes_42.BackColor = Color.Lime;
            name_size = button_size_shoes_42.Text;

        }

        private void button_size_kid_XS_Click(object sender, EventArgs e)
        {
            button_size_kid_XS.BackColor = Color.Lime;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.White;

            name_size = button_size_kid_XS.Text;

        }

        private void button_size_kid_SM_Click(object sender, EventArgs e)
        {
            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.Lime;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.White;

            name_size = button_size_kid_SM.Text;

        }

        private void button_size_kid_MD_Click(object sender, EventArgs e)
        {
            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.Lime;
            button_size_kid_XL.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.White;

            name_size = button_size_kid_MD.Text;

        }

        private void button_size_kid_LG_Click(object sender, EventArgs e)
        {
            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.Lime;
            button_size_kid_LG.BackColor = Color.White;

            name_size = button_size_kid_LG.Text;

        }

        private void button_size_kid_XL_Click(object sender, EventArgs e)
        {
            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.Lime;

            name_size = button_size_kid_XL.Text;

        }

        private void button_size_shoes_kid_4_Click(object sender, EventArgs e)
        {
            button_size_shoes_kid_4.BackColor = Color.Lime;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.White;

            name_size = button_size_shoes_kid_4.Text;

        }

        private void button_size_shoes_kid_4_5_Click(object sender, EventArgs e)
        {
            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.Lime;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.White;

            name_size = button_size_shoes_kid_4_5.Text;

        }

        private void button_size_shoes_kid_5_5_Click(object sender, EventArgs e)
        {
            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_5_5.BackColor = Color.Lime;
            button_size_shoes_kid_6.BackColor = Color.White;

            name_size = button_size_shoes_kid_5_5.Text;

        }

        private void button_size_shoes_kid_5_Click(object sender, EventArgs e)
        {
            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.Lime;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.White;

            name_size = button_size_shoes_kid_5.Text;

        }

        private void button_size_shoes_kid_6_Click(object sender, EventArgs e)
        {
            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.Lime;

            name_size = button_size_shoes_kid_6.Text;

        }

        private void button_size_accessories_onesize_Click(object sender, EventArgs e)
        {
            button_size_accessories_onesize.BackColor = Color.Lime;
            name_size = button_size_accessories_onesize.Text;

        }

        private void button_add_to_bag_Click(object sender, EventArgs e)
        {
            if (name_size == "")
                MessageBox.Show("Please choose size to continue!!!", "Notification");
            else
            {
                //panel_giohang.Visible = true;
                Add_sanpham();
            }
        }

        private void button_shop_Click(object sender, EventArgs e)
        {
            panel_giohang.Visible = true;
            panel_main_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = false;
            panel_feed_back.Visible = false ;
            panel_detail_item.Visible = false ;

        }

        private void pictureBox_curry_shoes_Click(object sender, EventArgs e)
        {
            panel_main_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_shoes_38.Visible = true;
            button_size_shoes_39.Visible = true;
            button_size_shoes_40.Visible = true;
            button_size_shoes_41.Visible = true;
            button_size_shoes_42.Visible = true;


            pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_man_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_man_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_man_1_2;

            label_category_detail_item.Text = "Curry Brand Shoes and Gear";
            label_name_detail_item.Text = label_shoes_man_1.Text;
            label_money_detail_item.Text = label_money_shoes_man_1.Text;
            label_color_detail_item.Text = "Capri / Yellow Ray - 300";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_man_1;

            label_info_detail_item.Text = "Change directions—fast. UA Flow cushioning is totally rubberless, making these" +
                "\r\nshoes light and ridiculously grippy. The UA Warp upper works like mini seat belts" +
                "\r\nlocking you in. Together, you get stop and go speed + control.";
            label_DNA_detail_item.Text = "• UA WARP upper technology provides enhanced comfort and control throughout" +
                "\r\n   dynamic basketball movements" +
                "\r\n• Half-bootie upper lining for superior fit, comfort and lockdown" +
                "\r\n• TPE-blend sockliner with low compression set for energy return and longevity" +
                "\r\n• UA Flow cushioning technology is super-light, bouncy and provides insane grip" +
                "\r\n• Internal midfoot shank adds support and stability to every move" +
                "\r\n• Durable UA Flow outsole provides better court feel so you can cut and stop/start" +
                "\r\n   faster than ever before";
            label_Specs_detail_item.Text = "• Style #: 3025622" +
                "\r\n• Weight: 12.5 oz" +
                "\r\n• Lace type: Standard tie" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Regular";
        }

        private void button_shop_new_curry_shoes_Click(object sender, EventArgs e)
        {
            panel_main_shop.Visible = false;

            panel_detail_item.Visible = true;

            button_size_shoes_38.Visible = true;
            button_size_shoes_39.Visible = true;
            button_size_shoes_40.Visible = true;
            button_size_shoes_41.Visible = true;
            button_size_shoes_42.Visible = true;


            pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_man_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_man_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_man_1_2;

            label_category_detail_item.Text = "Curry Brand Shoes and Gear";
            label_name_detail_item.Text = label_shoes_man_1.Text;
            label_money_detail_item.Text = label_money_shoes_man_1.Text;
            label_color_detail_item.Text = "Capri / Yellow Ray - 300";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_man_1;

            label_info_detail_item.Text = "Change directions—fast. UA Flow cushioning is totally rubberless, making these" +
                "\r\nshoes light and ridiculously grippy. The UA Warp upper works like mini seat belts" +
                "\r\nlocking you in. Together, you get stop and go speed + control.";
            label_DNA_detail_item.Text = "• UA WARP upper technology provides enhanced comfort and control throughout" +
                "\r\n   dynamic basketball movements" +
                "\r\n• Half-bootie upper lining for superior fit, comfort and lockdown" +
                "\r\n• TPE-blend sockliner with low compression set for energy return and longevity" +
                "\r\n• UA Flow cushioning technology is super-light, bouncy and provides insane grip" +
                "\r\n• Internal midfoot shank adds support and stability to every move" +
                "\r\n• Durable UA Flow outsole provides better court feel so you can cut and stop/start" +
                "\r\n   faster than ever before";
            label_Specs_detail_item.Text = "• Style #: 3025622" +
                "\r\n• Weight: 12.5 oz" +
                "\r\n• Lace type: Standard tie" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Regular";
        }

        private void pictureBox_shop_men_Click(object sender, EventArgs e)
        {
            panel_main_shop.Visible = false;

            check_men = 1;
            check_women = 0;
            check_kid = 0;

            name_size = "";

            button_size_accessories_onesize.Visible = false;

            button_size_kid_LG.Visible = false;
            button_size_kid_MD.Visible = false;
            button_size_kid_SM.Visible = false;
            button_size_kid_XL.Visible = false;
            button_size_kid_XS.Visible = false;

            button_size_shoes_38.Visible = false;
            button_size_shoes_39.Visible = false;
            button_size_shoes_40.Visible = false;
            button_size_shoes_41.Visible = false;
            button_size_shoes_42.Visible = false;

            button_size_shoes_kid_4.Visible = false;
            button_size_shoes_kid_4_5.Visible = false;
            button_size_shoes_kid_5.Visible = false;
            button_size_shoes_kid_5_5.Visible = false;
            button_size_shoes_kid_6.Visible = false;

            button_size_small.Visible = false;
            button_size_large.Visible = false;
            button_size_medium.Visible = false;
            button_size_XL.Visible = false;
            button_size_XXL.Visible = false;

            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.White;

            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;
            button_size_shoes_42.BackColor = Color.White;

            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.White;

            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.White;

            button_size_accessories_onesize.BackColor = Color.White;

            panel_men_category.Visible = false;
            panel_men_shop.Visible = true;
            panel_women_shop.Visible = false;
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = false;

            //men
            label_amount_item_men.Text = "10";
            label_men_category.Text = "Men";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.outwear_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Insulated \r\nBomber Outwear";
            label_outwear_man_2.Text = "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear";
            label_money_outwear_man_1.Text = "210";
            label_money_outwear_man_2.Text = "100";

            panel_outwear_man_1.Visible = true;
            panel_outwear_man_2.Visible = true;
            panel_pants_man_1.Visible = true;
            panel_pants_man_2.Visible = true;
            panel_shorts_man_1.Visible = true;
            panel_shorts_man_2.Visible = true;
            panel_shirts_man_1.Visible = true;
            panel_shirts_man_2.Visible = true;
            panel_shoes_man_1.Visible = true;
            panel_shoes_man_2.Visible = true;

            //women
            label_amount_item_women.Text = "10";

            label_women_category.Text = "Women";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.outwear_women_2_1;
            label_outwear_women_1.Text = "Women's UA Storm ColdGear® \r\nInfrared Down Jacket";
            label_outwear_women_2.Text = "Women's UA OutRun The Storm\r\nJacket";
            label_money_outwear_women_1.Text = "250";
            label_money_outwear_women_2.Text = "100";

            panel_outwear_women_1.Visible = true;
            panel_outwear_women_2.Visible = true;
            panel_pants_women_1.Visible = true;
            panel_pants_women_2.Visible = true;
            panel_shorts_women_1.Visible = true;
            panel_shorts_women_2.Visible = true;
            panel_shirts_women_1.Visible = true;
            panel_shirts_women_2.Visible = true;
            panel_shoes_women_1.Visible = true;
            panel_shoes_women_2.Visible = true;

            //kids
            label_amount_item_kid.Text = "12";

            label_kid_category.Text = "Kids";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
            label_Accessories_kid_1.Text = "UA Hustle Sport Backpack";
            label_Accessories_kid_2.Text = "UA Beyond 18 oz. Water Bottle";
            label_money_Accessories_kid_1.Text = "45";
            label_money_Accessories_kid_2.Text = "30";

            panel_Accessories_kid_1.Visible = true;
            panel_Accessories_kid_2.Visible = true;
            panel_outwear_kid_1.Visible = true;
            panel_outwear_kid_2.Visible = true;
            panel_swimsuits_kid_1.Visible = true;
            panel_swimsuits_kid_2.Visible = true;
            panel_shorts_kid_1.Visible = true;
            panel_shorts_kid_2.Visible = true;
            panel_shirts_kid_1.Visible = true;
            panel_shirts_kid_2.Visible = true;
            panel_shoes_kid_1.Visible = true;
            panel_shoes_kid_2.Visible = true;
        }

        private void pictureBox_shop_women_Click(object sender, EventArgs e)
        {
            panel_main_shop.Visible = false;

            check_men = 0;
            check_women = 1;
            check_kid = 0;

            name_size = "";

            button_size_accessories_onesize.Visible = false;

            button_size_kid_LG.Visible = false;
            button_size_kid_MD.Visible = false;
            button_size_kid_SM.Visible = false;
            button_size_kid_XL.Visible = false;
            button_size_kid_XS.Visible = false;

            button_size_shoes_38.Visible = false;
            button_size_shoes_39.Visible = false;
            button_size_shoes_40.Visible = false;
            button_size_shoes_41.Visible = false;
            button_size_shoes_42.Visible = false;

            button_size_shoes_kid_4.Visible = false;
            button_size_shoes_kid_4_5.Visible = false;
            button_size_shoes_kid_5.Visible = false;
            button_size_shoes_kid_5_5.Visible = false;
            button_size_shoes_kid_6.Visible = false;

            button_size_small.Visible = false;
            button_size_large.Visible = false;
            button_size_medium.Visible = false;
            button_size_XL.Visible = false;
            button_size_XXL.Visible = false;

            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.White;

            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;
            button_size_shoes_42.BackColor = Color.White;

            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.White;

            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.White;

            button_size_accessories_onesize.BackColor = Color.White;

            panel_women_category.Visible = false;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = true;
            panel_kid_shop.Visible = false;
            panel_detail_item.Visible = false;

            //men
            label_amount_item_men.Text = "10";
            label_men_category.Text = "Men";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.outwear_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Insulated \r\nBomber Outwear";
            label_outwear_man_2.Text = "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear";
            label_money_outwear_man_1.Text = "210";
            label_money_outwear_man_2.Text = "100";

            panel_outwear_man_1.Visible = true;
            panel_outwear_man_2.Visible = true;
            panel_pants_man_1.Visible = true;
            panel_pants_man_2.Visible = true;
            panel_shorts_man_1.Visible = true;
            panel_shorts_man_2.Visible = true;
            panel_shirts_man_1.Visible = true;
            panel_shirts_man_2.Visible = true;
            panel_shoes_man_1.Visible = true;
            panel_shoes_man_2.Visible = true;

            //women
            label_amount_item_women.Text = "10";

            label_women_category.Text = "Women";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.outwear_women_2_1;
            label_outwear_women_1.Text = "Women's UA Storm ColdGear® \r\nInfrared Down Jacket";
            label_outwear_women_2.Text = "Women's UA OutRun The Storm\r\nJacket";
            label_money_outwear_women_1.Text = "250";
            label_money_outwear_women_2.Text = "100";

            panel_outwear_women_1.Visible = true;
            panel_outwear_women_2.Visible = true;
            panel_pants_women_1.Visible = true;
            panel_pants_women_2.Visible = true;
            panel_shorts_women_1.Visible = true;
            panel_shorts_women_2.Visible = true;
            panel_shirts_women_1.Visible = true;
            panel_shirts_women_2.Visible = true;
            panel_shoes_women_1.Visible = true;
            panel_shoes_women_2.Visible = true;

            //kids
            label_amount_item_kid.Text = "12";

            label_kid_category.Text = "Kids";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
            label_Accessories_kid_1.Text = "UA Hustle Sport Backpack";
            label_Accessories_kid_2.Text = "UA Beyond 18 oz. Water Bottle";
            label_money_Accessories_kid_1.Text = "45";
            label_money_Accessories_kid_2.Text = "30";

            panel_Accessories_kid_1.Visible = true;
            panel_Accessories_kid_2.Visible = true;
            panel_outwear_kid_1.Visible = true;
            panel_outwear_kid_2.Visible = true;
            panel_swimsuits_kid_1.Visible = true;
            panel_swimsuits_kid_2.Visible = true;
            panel_shorts_kid_1.Visible = true;
            panel_shorts_kid_2.Visible = true;
            panel_shirts_kid_1.Visible = true;
            panel_shirts_kid_2.Visible = true;
            panel_shoes_kid_1.Visible = true;
            panel_shoes_kid_2.Visible = true;
        }

        private void pictureBox_shop_boy_Click(object sender, EventArgs e)
        {
            panel_main_shop.Visible = false;

            check_men = 0;
            check_women = 0;
            check_kid = 1;

            name_size = "";

            button_size_accessories_onesize.Visible = false;

            button_size_kid_LG.Visible = false;
            button_size_kid_MD.Visible = false;
            button_size_kid_SM.Visible = false;
            button_size_kid_XL.Visible = false;
            button_size_kid_XS.Visible = false;

            button_size_shoes_38.Visible = false;
            button_size_shoes_39.Visible = false;
            button_size_shoes_40.Visible = false;
            button_size_shoes_41.Visible = false;
            button_size_shoes_42.Visible = false;

            button_size_shoes_kid_4.Visible = false;
            button_size_shoes_kid_4_5.Visible = false;
            button_size_shoes_kid_5.Visible = false;
            button_size_shoes_kid_5_5.Visible = false;
            button_size_shoes_kid_6.Visible = false;

            button_size_small.Visible = false;
            button_size_large.Visible = false;
            button_size_medium.Visible = false;
            button_size_XL.Visible = false;
            button_size_XXL.Visible = false;

            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.White;

            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;
            button_size_shoes_42.BackColor = Color.White;

            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.White;

            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.White;

            button_size_accessories_onesize.BackColor = Color.White;

            panel_kids_category.Visible = false;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = false;
            panel_kid_shop.Visible = true;

            //men
            label_amount_item_men.Text = "10";
            label_men_category.Text = "Men";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.outwear_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Insulated \r\nBomber Outwear";
            label_outwear_man_2.Text = "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear";
            label_money_outwear_man_1.Text = "210";
            label_money_outwear_man_2.Text = "100";

            panel_outwear_man_1.Visible = true;
            panel_outwear_man_2.Visible = true;
            panel_pants_man_1.Visible = true;
            panel_pants_man_2.Visible = true;
            panel_shorts_man_1.Visible = true;
            panel_shorts_man_2.Visible = true;
            panel_shirts_man_1.Visible = true;
            panel_shirts_man_2.Visible = true;
            panel_shoes_man_1.Visible = true;
            panel_shoes_man_2.Visible = true;

            //women
            label_amount_item_women.Text = "10";

            label_women_category.Text = "Women";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.outwear_women_2_1;
            label_outwear_women_1.Text = "Women's UA Storm ColdGear® \r\nInfrared Down Jacket";
            label_outwear_women_2.Text = "Women's UA OutRun The Storm\r\nJacket";
            label_money_outwear_women_1.Text = "250";
            label_money_outwear_women_2.Text = "100";

            panel_outwear_women_1.Visible = true;
            panel_outwear_women_2.Visible = true;
            panel_pants_women_1.Visible = true;
            panel_pants_women_2.Visible = true;
            panel_shorts_women_1.Visible = true;
            panel_shorts_women_2.Visible = true;
            panel_shirts_women_1.Visible = true;
            panel_shirts_women_2.Visible = true;
            panel_shoes_women_1.Visible = true;
            panel_shoes_women_2.Visible = true;

            //kids
            label_amount_item_kid.Text = "12";

            label_kid_category.Text = "Kids";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
            label_Accessories_kid_1.Text = "UA Hustle Sport Backpack";
            label_Accessories_kid_2.Text = "UA Beyond 18 oz. Water Bottle";
            label_money_Accessories_kid_1.Text = "45";
            label_money_Accessories_kid_2.Text = "30";

            panel_Accessories_kid_1.Visible = true;
            panel_Accessories_kid_2.Visible = true;
            panel_outwear_kid_1.Visible = true;
            panel_outwear_kid_2.Visible = true;
            panel_swimsuits_kid_1.Visible = true;
            panel_swimsuits_kid_2.Visible = true;
            panel_shorts_kid_1.Visible = true;
            panel_shorts_kid_2.Visible = true;
            panel_shirts_kid_1.Visible = true;
            panel_shirts_kid_2.Visible = true;
            panel_shoes_kid_1.Visible = true;
            panel_shoes_kid_2.Visible = true;
        }

        private void pictureBox_shop_girl_Click(object sender, EventArgs e)
        {
            panel_main_shop.Visible = false;

            check_men = 0;
            check_women = 0;
            check_kid = 1;

            name_size = "";

            button_size_accessories_onesize.Visible = false;

            button_size_kid_LG.Visible = false;
            button_size_kid_MD.Visible = false;
            button_size_kid_SM.Visible = false;
            button_size_kid_XL.Visible = false;
            button_size_kid_XS.Visible = false;

            button_size_shoes_38.Visible = false;
            button_size_shoes_39.Visible = false;
            button_size_shoes_40.Visible = false;
            button_size_shoes_41.Visible = false;
            button_size_shoes_42.Visible = false;

            button_size_shoes_kid_4.Visible = false;
            button_size_shoes_kid_4_5.Visible = false;
            button_size_shoes_kid_5.Visible = false;
            button_size_shoes_kid_5_5.Visible = false;
            button_size_shoes_kid_6.Visible = false;

            button_size_small.Visible = false;
            button_size_large.Visible = false;
            button_size_medium.Visible = false;
            button_size_XL.Visible = false;
            button_size_XXL.Visible = false;

            button_size_small.BackColor = Color.White;
            button_size_medium.BackColor = Color.White;
            button_size_large.BackColor = Color.White;
            button_size_XL.BackColor = Color.White;
            button_size_XXL.BackColor = Color.White;

            button_size_shoes_38.BackColor = Color.White;
            button_size_shoes_39.BackColor = Color.White;
            button_size_shoes_40.BackColor = Color.White;
            button_size_shoes_41.BackColor = Color.White;
            button_size_shoes_42.BackColor = Color.White;

            button_size_kid_XS.BackColor = Color.White;
            button_size_kid_SM.BackColor = Color.White;
            button_size_kid_MD.BackColor = Color.White;
            button_size_kid_LG.BackColor = Color.White;
            button_size_kid_XL.BackColor = Color.White;

            button_size_shoes_kid_4.BackColor = Color.White;
            button_size_shoes_kid_4_5.BackColor = Color.White;
            button_size_shoes_kid_5_5.BackColor = Color.White;
            button_size_shoes_kid_5.BackColor = Color.White;
            button_size_shoes_kid_6.BackColor = Color.White;

            button_size_accessories_onesize.BackColor = Color.White;

            panel_kids_category.Visible = false;
            panel_men_shop.Visible = false;
            panel_women_shop.Visible = false;
            panel_kid_shop.Visible = true;


            //men
            label_amount_item_men.Text = "10";
            label_men_category.Text = "Men";

            pictureBox_outwear_man_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
            pictureBox_outwear_man_2.BackgroundImage = Properties.Resources.outwear_man_2_1;
            label_outwear_man_1.Text = "Men's Project Rock Insulated \r\nBomber Outwear";
            label_outwear_man_2.Text = "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear";
            label_money_outwear_man_1.Text = "210";
            label_money_outwear_man_2.Text = "100";

            panel_outwear_man_1.Visible = true;
            panel_outwear_man_2.Visible = true;
            panel_pants_man_1.Visible = true;
            panel_pants_man_2.Visible = true;
            panel_shorts_man_1.Visible = true;
            panel_shorts_man_2.Visible = true;
            panel_shirts_man_1.Visible = true;
            panel_shirts_man_2.Visible = true;
            panel_shoes_man_1.Visible = true;
            panel_shoes_man_2.Visible = true;

            //women
            label_amount_item_women.Text = "10";

            label_women_category.Text = "Women";

            pictureBox_outwear_women_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
            pictureBox_outwear_women_2.BackgroundImage = Properties.Resources.outwear_women_2_1;
            label_outwear_women_1.Text = "Women's UA Storm ColdGear® \r\nInfrared Down Jacket";
            label_outwear_women_2.Text = "Women's UA OutRun The Storm\r\nJacket";
            label_money_outwear_women_1.Text = "250";
            label_money_outwear_women_2.Text = "100";

            panel_outwear_women_1.Visible = true;
            panel_outwear_women_2.Visible = true;
            panel_pants_women_1.Visible = true;
            panel_pants_women_2.Visible = true;
            panel_shorts_women_1.Visible = true;
            panel_shorts_women_2.Visible = true;
            panel_shirts_women_1.Visible = true;
            panel_shirts_women_2.Visible = true;
            panel_shoes_women_1.Visible = true;
            panel_shoes_women_2.Visible = true;

            //kids
            label_amount_item_kid.Text = "12";

            label_kid_category.Text = "Kids";

            pictureBox_Accessories_kid_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
            pictureBox_Accessories_kid_2.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
            label_Accessories_kid_1.Text = "UA Hustle Sport Backpack";
            label_Accessories_kid_2.Text = "UA Beyond 18 oz. Water Bottle";
            label_money_Accessories_kid_1.Text = "45";
            label_money_Accessories_kid_2.Text = "30";

            panel_Accessories_kid_1.Visible = true;
            panel_Accessories_kid_2.Visible = true;
            panel_outwear_kid_1.Visible = true;
            panel_outwear_kid_2.Visible = true;
            panel_swimsuits_kid_1.Visible = true;
            panel_swimsuits_kid_2.Visible = true;
            panel_shorts_kid_1.Visible = true;
            panel_shorts_kid_2.Visible = true;
            panel_shirts_kid_1.Visible = true;
            panel_shirts_kid_2.Visible = true;
            panel_shoes_kid_1.Visible = true;
            panel_shoes_kid_2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel_main_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_women_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_women_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_women_2_2;

            label_category_detail_item.Text = "Women" + '/' + "Shirts";
            label_name_detail_item.Text = label_shirts_women_2.Text;
            label_money_detail_item.Text = label_money_shirts_women_2.Text;
            label_color_detail_item.Text = "Thyme / Black - 346";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_women_2;

            label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right" +
                "\r\nthrough them. Everything in this collection was personally approved by Dwayne Johnson," +
                "\r\nthe hardest worker in the room. ANY room.";
            label_DNA_detail_item.Text = "• Ultra-soft cotton-blend fleece with brushed inside for extra warmth" +
                "\r\n• Front kangaroo pocket" +
                "\r\n• Drop hem shoulder & slightly oversized sleeves" +
                "\r\n• Ribbed cuffs & bottom hem";
            label_Specs_detail_item.Text = "• Style #: 1373610" +
                "\r\n• 80% Cotton/20% Polyester" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Do not bleach" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox_new_jacket_man_Click(object sender, EventArgs e)
        {
            panel_main_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_small.Visible = true;
            button_size_large.Visible = true;
            button_size_medium.Visible = true;
            button_size_XL.Visible = true;
            button_size_XXL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_man_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_man_1_2;

            label_category_detail_item.Text = "Men" + '/' + "Outwear";
            label_name_detail_item.Text = label_outwear_man_1.Text;
            label_money_detail_item.Text = label_money_outwear_man_1.Text;
            label_color_detail_item.Text = "Thyme / Black - 346";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_man_1;

            label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right through" +
                "\r\nthem. Everything in this collection was personally approved by Dwayne Johnson, the hardest" +
                "\r\nworker in the room. ANY room.";
            label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                "\r\n• Smooth woven fabric is lightweight & extremely durable" +
                "\r\n• Windproof materials shield you from the elements" +
                "\r\n• All-over 200g synthetic insulation for ultimate warmth without excess bulk" +
                "\r\n• Secure hand & sleeve pockets" +
                "\r\n• 2-way front zip" +
                "\r\n• Ribbed collar, cuffs & bottom hem";
            label_Specs_detail_item.Text = "• Style #: 1374425" +
                "\r\n• 100% Polyester" +
                "\r\n• Imported";

            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Garment should be washed & dried fully zipped & turned inside out" +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Do not use softeners" +
                "\r\n• Use only non-chlorine bleach when needed" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not dry clean";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel_main_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_shoes_38.Visible = true;
            button_size_shoes_39.Visible = true;
            button_size_shoes_40.Visible = true;
            button_size_shoes_41.Visible = true;
            button_size_shoes_42.Visible = true;


            pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_man_2_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_man_2_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_man_2_2jpg;

            label_category_detail_item.Text = "Men" + '/' + "Shoes";
            label_name_detail_item.Text = label_shoes_man_2.Text;
            label_money_detail_item.Text = label_money_shoes_man_2.Text;
            label_color_detail_item.Text = "Canyon Clay / Khaki Base - 301";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_man_2;

            label_info_detail_item.Text = " \"The Project Rock 5s are the most innovative training shoes we've ever made—they give" +
                "\r\nyou power, energy, support with an amazing comfort level.\" – Dwayne Johnson";
            label_DNA_detail_item.Text = "• Durable engineered mesh upper is lightweight & breathable with stretch & structure where" +
                "\r\n   you need it" +
                "\r\n• Plush knit collar for maximum comfort" +
                "\r\n• Molded TPU heel-to-midfoot strap to stabilize & lock down your heel while enabling" +
                "\r\n   forefoot mobility" +
                "\r\n• Responsive UA HOVR™ cushioning reduces impact, returns energy & helps propel you " +
                "\r\nforward" +
                "\r\n• UA TriBase™ maximizes ground contact, promotes natural motion & provides flexibility to" +
                "\r\n   grip during lifts";
            label_Specs_detail_item.Text = "• Style #: 3025556" +
                "\r\n• Offset: 8mm" +
                "\r\n• Weight: 13.5 oz." +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Regular";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel_main_shop.Visible = false;
            panel_detail_item.Visible = true;

            button_size_kid_XS.Visible = true;
            button_size_kid_SM.Visible = true;
            button_size_kid_MD.Visible = true;
            button_size_kid_LG.Visible = true;
            button_size_kid_XL.Visible = true;

            pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_kids_1_1;
            button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_kids_1_1;
            button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_kids_1_2;

            label_category_detail_item.Text = "Kids" + '/' + "Shirts";
            label_name_detail_item.Text = label_shirts_kid_1.Text;
            label_money_detail_item.Text = label_money_shirts_kid_1.Text;
            label_color_detail_item.Text = "Khaki Base / Black - 289";

            pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_kids_1_1;

            label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right" +
                "\r\nthrough them. Everything in this collection was personally approved by Dwayne Johnson," +
                "\r\nthe hardest worker in the room. ANY room.";
            label_DNA_detail_item.Text = "• Super-soft, cotton-blend fabric provides all-day comfort" +
                "\r\n• 4-way stretch material moves better in every direction" +
                "\r\n• Graphic appears when exposed to moisture so everyone knows who's working hardest" +
                "\r\n   out there";
            label_Specs_detail_item.Text = "• Style #: 1373622" +
                "\r\n• 57% Cotton/38% Polyester/5% Elastane" +
                "\r\n• Imported";
            label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                "\r\n• Wash garment inside out" +
                "\r\n• Machine wash cold with like colors" +
                "\r\n• Do not bleach" +
                "\r\n• Tumble dry low" +
                "\r\n• Do not iron" +
                "\r\n• Do not use softeners" +
                "\r\n• Do not dry clean";
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            switch (comboBox_search.Text.ToLower())
            {
                case ("men's project rock insulated bomber outwear"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_man_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_man_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_man_1_2;

                    label_category_detail_item.Text = "Men" + '/' + "Outwear";
                    label_name_detail_item.Text = label_outwear_man_1.Text;
                    label_money_detail_item.Text = label_money_outwear_man_1.Text;
                    label_color_detail_item.Text = "Thyme / Black - 346";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_man_1;

                    label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right through" +
                        "\r\nthem. Everything in this collection was personally approved by Dwayne Johnson, the hardest" +
                        "\r\nworker in the room. ANY room.";
                    label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                        "\r\n• Smooth woven fabric is lightweight & extremely durable" +
                        "\r\n• Windproof materials shield you from the elements" +
                        "\r\n• All-over 200g synthetic insulation for ultimate warmth without excess bulk" +
                        "\r\n• Secure hand & sleeve pockets" +
                        "\r\n• 2-way front zip" +
                        "\r\n• Ribbed collar, cuffs & bottom hem";
                    label_Specs_detail_item.Text = "• Style #: 1374425" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";

                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Garment should be washed & dried fully zipped & turned inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not dry clean";
                    break;
                case ("men's ua storm coldgear infrared shield outwear"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_man_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_man_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_man_2_2;

                    label_category_detail_item.Text = "Men" + '/' + "Outwear";
                    label_name_detail_item.Text = label_outwear_man_2.Text;
                    label_money_detail_item.Text = label_money_outwear_man_2.Text;
                    label_color_detail_item.Text = "Tech Blue / Indigo-432";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_man_2;

                    label_info_detail_item.Text = "This men's Under Armour ColdGear® jacket is windproof, light, and warm. It's powered by" +
                        "\r\nour nearly weightless ColdGear® Infrared technology that actually traps your body warmth" +
                        "\r\nas you move.";
                    label_DNA_detail_item.Text = "• ColdGear® Infrared lining uses a soft, thermo-conductive inner coating to absorb and" +
                        "\r\n   retain body heat" +
                        "\r\n• Windproof construction shields you from the elements" +
                        "\r\n• Durable, bonded 3-layer softershell material has a quiet outer layer and superior" +
                        "\r\n   stretch 4-way stretch material moves better in every direction" +
                        "\r\n• Secure, zip chest & hand pockets" +
                        "\r\n• 100% Polyester";
                    label_Specs_detail_item.Text = "• Style #: 1321438" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose.";
                    break;
                case ("men's ua rush coldgear leggings"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.pants_man_1_2;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.pants_man_1_2;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.pants_man_1_3;

                    label_category_detail_item.Text = "Men" + '/' + "Pants";
                    label_name_detail_item.Text = label_pants_man_1.Text;
                    label_money_detail_item.Text = label_money_pants_man_1.Text;
                    label_color_detail_item.Text = "Black - 001";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_pants_man_1;

                    label_info_detail_item.Text = "UA RUSH™ powers your toughest workouts, your biggest games, your most intense training." +
                        "\r\nIt gives you back energy, fits great, keeps you dry, and makes you feel like you can" +
                        "\r\ncrush every PR.";
                    label_DNA_detail_item.Text = "• UA RUSH™ is infrared technology that reflects your body's energy to help you work" +
                        "\r\n   harder and recover faster" +
                        "\r\n• Super-soft ColdGear® fabric is breathable and stretches for superior mobility but" +
                        "\r\n   is still incredibly warm" +
                        "\r\n• ColdGear® mesh panels provide breathability where you need it without sacrificing warmth" +
                        "\r\n• Strategic seam placement to eliminate pressure points and chafing" +
                        "\r\n• Updated gusset design provides ultimate support and comfort" +
                        "\r\n• Exposed elastic waistband" +
                        "\r\n• Drop-in Strength Pocket™ on right side for easy storage";
                    label_Specs_detail_item.Text = "• Style #: 1366060" +
                        "\r\n• Inseam: 28.25 inches" +
                        "\r\n• Pockets: Yes" +
                        "\r\n• Powered by Celliant" +
                        "\r\n• Body: 84% Polyester/16% Elastane" +
                        "\r\n• Mesh: 82% Polyester/18% Elastane" +
                        "\r\n• Imported";

                    label_Fit_detail_item.Text = "• Compression: Ultra-tight, second-skin fit." +
                        "\r\n• Wash garment inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("men's ua meridian tapered pants"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.pants_man_2_3;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.pants_man_2_3;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.pants_man_2_2;

                    label_category_detail_item.Text = "Men" + '/' + "Pants";
                    label_name_detail_item.Text = label_pants_man_2.Text;
                    label_money_detail_item.Text = label_money_pants_man_2.Text;
                    label_color_detail_item.Text = "Fresh Clay - 176";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_pants_man_2;

                    label_info_detail_item.Text = "This specially engineered fabric delivers a unique type of softness that can still wick" +
                        "\r\nsweat like a champ. It's lightweight, it's breathable, and it's ready to work.";
                    label_DNA_detail_item.Text = "• Super-soft & stretchy performance knit fabric delivers support & lasting comfort" +
                        "\r\n• Material wicks sweat & dries really fast" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Encased elastic waistband with external drawcord" +
                        "\r\n• Secure, zip hand pockets";
                    label_Specs_detail_item.Text = "• Style #: 1373730" +
                        "\r\n• Inseam: 28.75 inches" +
                        "\r\n• Pockets: Yes" +
                        "\r\n• 83% Nylon/17% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose." +
                        "\r\n• Tapered leg fit with a high-low cuff hem that is slightly longer in the back" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("men's ua elevated woven 2.0 shorts"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_man_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_man_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_man_1_2;

                    label_category_detail_item.Text = "Men" + '/' + "Shorts";
                    label_name_detail_item.Text = label_shorts_man_1.Text;
                    label_money_detail_item.Text = label_money_shorts_man_1.Text;
                    label_color_detail_item.Text = "League Red / Black-626";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_man_1;

                    label_info_detail_item.Text = "The goal with the UA Woven collection was to make the perfect set of warm-ups that keep" +
                        "\r\nyour muscles ready, work for any sport, and also pack up super-small in your bag, so you" +
                        "\r\ncan take them anywhere.";
                    label_DNA_detail_item.Text = "• Ultra-durable woven fabric, built for the most intense workouts" +
                        "\r\n• Mesh side panels for strategic ventilation" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Material wicks sweat & dries really fast" +
                        "\r\n• Encased elastic waistband with internal drawcord" +
                        "\r\n• Open hand pockets";
                    label_Specs_detail_item.Text = "• Style #: 1362289" +
                        "\r\n• Inseam: 8.25 inches" +
                        "\r\n• No liner" +
                        "\r\n• Pockets: Yes" +
                        "\r\n• 89% Polyester/11% Elastane" +
                        "\r\n• Imported";

                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose.";
                    break;
                case ("men's ua rival fleece big logoshorts"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_man_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_man_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_man_2_2;

                    label_category_detail_item.Text = "Men" + '/' + "Shorts";
                    label_name_detail_item.Text = label_shorts_man_2.Text;
                    label_money_detail_item.Text = label_money_shorts_man_2.Text;
                    label_color_detail_item.Text = "Black / Onyx White - 001";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_man_2;

                    label_info_detail_item.Text = "These are your new favorite warm-up pants for pretty much everything you do—they're" +
                        "\r\nlight, comfy, and are super-soft on the inside.";
                    label_DNA_detail_item.Text = "• Ultra-soft, mid-weight cotton-blend fleece" +
                        "\r\n• Brushed interior for extra warmth" +
                        "\r\n• Encased elastic waistband with external drawcord" +
                        "\r\n• Open hand pockets & secure, snap back pocket";
                    label_Specs_detail_item.Text = "• Style #: 1357118" +
                        "\r\n• Inseam: 10 inches" +
                        "\r\n• 80% Cotton/20% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Wash garment inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("men's project rock heavyweight terry sleeveless hoodie"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_man_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_man_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_man_1_2;

                    label_category_detail_item.Text = "Men" + '/' + "Shirts";
                    label_name_detail_item.Text = label_shirts_man_1.Text;
                    label_money_detail_item.Text = label_money_shirts_man_1.Text;
                    label_color_detail_item.Text = "Tent / Vermillion-361";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_man_1;

                    label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right" +
                        "\r\nthrough them. Everything in this collection was personally approved by Dwayne Johnson," +
                        "\r\nthe hardest worker in the room. ANY room.";
                    label_DNA_detail_item.Text = "• Cotton-blend heavyweight Terry is super-soft & comfortable with a classic" +
                        "\r\n   athletic feel​" +
                        "\r\n• Front kangaroo pocket";
                    label_Specs_detail_item.Text = "• Style #: 1370462" +
                        "\r\n• 73% Cotton/27% Polyester" +
                        "\r\n• Imported";

                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Wash garment inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("men's ua tech collegiate sideline short sleeve"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_man_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_man_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_man_2_2;

                    label_category_detail_item.Text = "Men" + '/' + "Shirts";
                    label_name_detail_item.Text = label_shirts_man_2.Text;
                    label_money_detail_item.Text = label_money_shirts_man_2.Text;
                    label_color_detail_item.Text = "Colorado State University-301";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_man_2;

                    label_info_detail_item.Text = "Even our fan gear is built for performance—so you can wear it on the field just as" +
                        "\r\neasily as you wear it in the stands.";
                    label_DNA_detail_item.Text = "• UA Tech™ fabric is quick drying, ultra-soft & has a more natural feel" +
                        "\r\n• Material wicks sweat & dries really fast";
                    label_Specs_detail_item.Text = "• Style #: 5111867" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort.";
                    break;
                case ("unisex curry flow 10 'sour then sweet' basketball shoes"):
                    panel_detail_item.Visible = true;

                    button_size_shoes_38.Visible = true;
                    button_size_shoes_39.Visible = true;
                    button_size_shoes_40.Visible = true;
                    button_size_shoes_41.Visible = true;
                    button_size_shoes_42.Visible = true;


                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_man_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_man_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_man_1_2;

                    label_category_detail_item.Text = "Men" + '/' + "Shoes";
                    label_name_detail_item.Text = label_shoes_man_1.Text;
                    label_money_detail_item.Text = label_money_shoes_man_1.Text;
                    label_color_detail_item.Text = "Capri / Yellow Ray - 300";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_man_1;

                    label_info_detail_item.Text = "Change directions—fast. UA Flow cushioning is totally rubberless, making these" +
                        "\r\nshoes light and ridiculously grippy. The UA Warp upper works like mini seat belts" +
                        "\r\nlocking you in. Together, you get stop and go speed + control.";
                    label_DNA_detail_item.Text = "• UA WARP upper technology provides enhanced comfort and control throughout" +
                        "\r\n   dynamic basketball movements" +
                        "\r\n• Half-bootie upper lining for superior fit, comfort and lockdown" +
                        "\r\n• TPE-blend sockliner with low compression set for energy return and longevity" +
                        "\r\n• UA Flow cushioning technology is super-light, bouncy and provides insane grip" +
                        "\r\n• Internal midfoot shank adds support and stability to every move" +
                        "\r\n• Durable UA Flow outsole provides better court feel so you can cut and stop/start" +
                        "\r\n   faster than ever before";
                    label_Specs_detail_item.Text = "• Style #: 3025622" +
                        "\r\n• Weight: 12.5 oz" +
                        "\r\n• Lace type: Standard tie" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Regular";
                    break;
                case ("men's project rock 5 veterans day training shoes"):
                    panel_detail_item.Visible = true;

                    button_size_shoes_38.Visible = true;
                    button_size_shoes_39.Visible = true;
                    button_size_shoes_40.Visible = true;
                    button_size_shoes_41.Visible = true;
                    button_size_shoes_42.Visible = true;


                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_man_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_man_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_man_2_2jpg;

                    label_category_detail_item.Text = "Men" + '/' + "Shoes";
                    label_name_detail_item.Text = label_shoes_man_2.Text;
                    label_money_detail_item.Text = label_money_shoes_man_2.Text;
                    label_color_detail_item.Text = "Canyon Clay / Khaki Base - 301";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_man_2;

                    label_info_detail_item.Text = "\\\"The Project Rock 5s are the most innovative training shoes we've ever made—they give" +
                        "\r\nyou power, energy, support with an amazing comfort level.\\\" – Dwayne Johnson";
                    label_DNA_detail_item.Text = "• Durable engineered mesh upper is lightweight & breathable with stretch & structure where" +
                        "\r\n   you need it" +
                        "\r\n• Plush knit collar for maximum comfort" +
                        "\r\n• Molded TPU heel-to-midfoot strap to stabilize & lock down your heel while enabling" +
                        "\r\n   forefoot mobility" +
                        "\r\n• Responsive UA HOVR™ cushioning reduces impact, returns energy & helps propel you forward" +
                        "\r\n• UA TriBase™ maximizes ground contact, promotes natural motion & provides flexibility to" +
                        "\r\n   grip during lifts";
                    label_Specs_detail_item.Text = "• Style #: 3025556" +
                        "\r\n• Offset: 8mm" +
                        "\r\n• Weight: 13.5 oz." +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Regular";
                    break;
                case ("women's ua storm coldgear infrared down jacket"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;


                    pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_women_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_women_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_women_1_2;

                    label_category_detail_item.Text = "Women" + '/' + "Outwear";
                    label_name_detail_item.Text = label_outwear_women_1.Text;
                    label_money_detail_item.Text = label_money_outwear_women_1.Text;
                    label_color_detail_item.Text = "Canyon Clay / Khaki Base - 301";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_women_1;

                    label_info_detail_item.Text = "Keeping your muscles warm in cold weather is key—to your performance AND recovery." +
                        "\r\nColdGear® Infrared Down provides warmth, protection, and breathability, so you maintain" +
                        "\r\nfocus, clarity, and forward momentum. Cold can't stop you.";
                    label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                        "\r\n   700-fill Allied duck down insulation provides extreme warmth & is ethically sourced" +
                        "\r\n   and traceable via tag\r\n• Lightweight woven fabric delivers superior comfort & durability" +
                        "\r\n• ColdGear® Infrared lining uses a soft, thermo-conductive coating to absorb and retain" +
                        "\r\n   your body heat" +
                        "\r\n• Roomy hood design with bungee adjust & extended, bonded brim" +
                        "\r\n• Full zip front with snap-closure Storm flap" +
                        "\r\n• Secure, zip hand & chest pockets";
                    label_Specs_detail_item.Text = "• Style #: 1375442" +
                        "\r\n• Woven patch logo on left sleeve" +
                        "\r\n• 100% Nylon" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Garment should be washed & dried fully zipped & turned inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not dry clean";
                    break;
                case ("women's ua outrun the storm jacket"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_women_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_women_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_women_2_2;

                    label_category_detail_item.Text = "Women" + '/' + "Outwear";
                    label_name_detail_item.Text = label_outwear_women_2.Text;
                    label_money_detail_item.Text = label_money_outwear_women_2.Text;
                    label_color_detail_item.Text = "Illusion Green / Opal Green-592";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_women_2;

                    label_info_detail_item.Text = "The UA Outrun The Storm series isn't just water-resistant—it's super-water-resistant," +
                        "\r\nmeaning it protects better and lasts longer than other run rain gear. And it's more" +
                        "\r\nstretchy and comfortable, so you'll be more focused.";
                    label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                        "\r\n• Wind-resistant construction protects you from the elements" +
                        "\r\n• Durable, lightweight, stretch-woven fabric" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Back vent construction for added breathability" +
                        "\r\n• Secure, zip hand pockets with right-side interior media pocket" +
                        "\r\n• Bungee adjust hood & bottom hem for a secure fit";
                    label_Specs_detail_item.Text = "• Style #: 1361384" +
                        "\r\n• Raglan sleeves" +
                        "\r\n• Reflective details for low-light runs" +
                        "\r\n• 87% Polyester/13% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose." +
                        "\r\n• Garment should be washed & dried zipped up" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Wash garment inside out" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("women's ua meridian jacquard ankle leggings"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;


                    pictureBox_detail_item.BackgroundImage = Properties.Resources.pants_women_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.pants_women_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.pants_women_1_2;

                    label_category_detail_item.Text = "Women" + '/' + "Pants";
                    label_name_detail_item.Text = label_pants_women_1.Text;
                    label_money_detail_item.Text = label_money_pants_women_1.Text;
                    label_color_detail_item.Text = "Opal Green / Metallic Silver - 781";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_pants_women_1;

                    label_info_detail_item.Text = "This specially engineered fabric delivers a unique type of softness that can still wick" +
                        "\r\nsweat like a champ. It's lightweight, it's breathable, and it's ready to work.";
                    label_DNA_detail_item.Text = "• Super-soft & stretchy performance knit fabric delivers support & lasting comfort" +
                        "\r\n• Material wicks sweat & dries really fast" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• High-rise waistband with built-in side pockets";
                    label_Specs_detail_item.Text = "• Style #: 1376340" +
                        "\r\n• Inseam: 26\"" +
                        "\r\n• Pockets: Yes" +
                        "\r\n• 72% Nylon/28% Elastane";
                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose." +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not dry clean";
                    break;
                case ("women's ua armour sport woven pants"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.pants_women_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.pants_women_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.pants_women_2_2jpg;

                    label_category_detail_item.Text = "Women" + '/' + "Pants";
                    label_name_detail_item.Text = label_pants_women_2.Text;
                    label_money_detail_item.Text = label_money_pants_women_2.Text;
                    label_color_detail_item.Text = "Black / Metallic Silver - 001";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_pants_women_2;

                    label_info_detail_item.Text = "The goal with the UA Woven collection was to make the perfect set of warm-ups that keep" +
                        "\r\nyour muscles ready, work for any sport, and also pack up super-small in your bag, so you" +
                        "\r\ncan take them anywhere.";
                    label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                        "\r\n• Light, durable & super-comfortable stretch-woven fabric" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Stretchy encased elastic waistband with external drawcord";
                    label_Specs_detail_item.Text = "•Style #: 1348447" +
                        "\r\n• Open hand pockets" +
                        "\r\n• 2-ply cuffs" +
                        "\r\n• Inseam: 28\"" +
                        "\r\n• 87% Polyester/13% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("women's coldgear authentics crew"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;


                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_women_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_women_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_women_1_2;

                    label_category_detail_item.Text = "Women" + '/' + "Shirts";
                    label_name_detail_item.Text = label_shirts_women_1.Text;
                    label_money_detail_item.Text = label_money_shirts_women_1.Text;
                    label_color_detail_item.Text = "White / Black-100";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_women_1;

                    label_info_detail_item.Text = "We all hate it. That stiff, distracted feeling you get when you're out in the cold." +
                        "\r\nThat's why, we built a baselayer that keeps you warm and dry without being bulky or" +
                        "\r\nriding up, so you can stay focused all season long.";
                    label_DNA_detail_item.Text = "• Dual-layer fabric with an ultra-warm, brushed interior & a smooth, fast-drying exterior" +
                        "\r\n• Material wicks sweat & dries really fast" +
                        "\r\n• Mesh underarm panels for added ventilation where you need it" +
                        "\r\n• Raglan sleeves";
                    label_Specs_detail_item.Text = "• Style #: 1368701" +
                        "\r\n• 87% Polyester/13% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose." +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("women's project rock veterans day fleece hoodie"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_women_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_women_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_women_2_2;

                    label_category_detail_item.Text = "Women" + '/' + "Shirts";
                    label_name_detail_item.Text = label_shirts_women_2.Text;
                    label_money_detail_item.Text = label_money_shirts_women_2.Text;
                    label_color_detail_item.Text = "Thyme / Black - 346";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_women_2;

                    label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right" +
                        "\r\nthrough them. Everything in this collection was personally approved by Dwayne Johnson," +
                        "\r\nthe hardest worker in the room. ANY room.";
                    label_DNA_detail_item.Text = "• Ultra-soft cotton-blend fleece with brushed inside for extra warmth" +
                        "\r\n• Front kangaroo pocket" +
                        "\r\n• Drop hem shoulder & slightly oversized sleeves" +
                        "\r\n• Ribbed cuffs & bottom hem";
                    label_Specs_detail_item.Text = "• Style #: 1373610" +
                        "\r\n• 80% Cotton/20% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("women's ua play up 2-in-1 shorts"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;


                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_women_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_women_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_women_1_2;

                    label_category_detail_item.Text = "Women" + '/' + "Shorts";
                    label_name_detail_item.Text = label_shorts_women_1.Text;
                    label_money_detail_item.Text = label_money_shorts_women_1.Text;
                    label_color_detail_item.Text = "Black / White - 001";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_women_1;

                    label_info_detail_item.Text = "Everyone needs a go-to pair of shorts. These feature a lightweight fabric that keeps" +
                        "\r\nyou cool and comfortable at all times. You'll love the way they look and the way they" +
                        "\r\nfeel even more.";
                    label_DNA_detail_item.Text = "• Soft, lightweight knit fabric on outer shorts delivers superior comfort and" +
                        "\r\n   breathability" +
                        "\r\n• Material wicks sweat & dries really fast" +
                        "\r\n• Anti-pill/anti-pick finish adds extra durability" +
                        "\r\n• Built-in, knit compression shorts for relentless coverage and support" +
                        "\r\n• Mesh panels for added breathability" +
                        "\r\n• Soft, exposed elastic waistband with wordmark detail" +
                        "\r\n• Convenient side hand pockets";
                    label_Specs_detail_item.Text = "• Style #: 1351981" +
                        "\r\n• Inseam (outer short): 3\"" +
                        "\r\n• Inseam (inner short): 5.5\"" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("women's ua links shorts"):
                    panel_detail_item.Visible = true;

                    button_size_small.Visible = true;
                    button_size_large.Visible = true;
                    button_size_medium.Visible = true;
                    button_size_XL.Visible = true;
                    button_size_XXL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_women_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_women_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_women_2_2;

                    label_category_detail_item.Text = "Women" + '/' + "Shorts";
                    label_name_detail_item.Text = label_shorts_women_2.Text;
                    label_money_detail_item.Text = label_money_shorts_women_2.Text;
                    label_color_detail_item.Text = "Black / Metallic Silver-001";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_women_2;

                    label_info_detail_item.Text = "This is the best women's golf gear in the game, plain and simple. Flexible, lightweight" +
                        "\r\nfabrics stretch with every swing to keep you comfortable and performing your best from" +
                        "\r\nthe first hole to the last.";
                    label_DNA_detail_item.Text = "• Light, durable & super-comfortable stretch-woven fabric" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Stretch-engineered waistband with adjustable inner elastic for a perfect fit" +
                        "\r\n• 4-pocket design with working fly";
                    label_Specs_detail_item.Text = "• Style #: 1362774" +
                        "\r\n• Inseam: 9\"" +
                        "\r\n• Pockets: Yes" +
                        "\r\n• 90% Polyester/10% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Wash garment inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("women's ua hovr machina 3 running shoes"):
                    panel_detail_item.Visible = true;

                    button_size_shoes_38.Visible = true;
                    button_size_shoes_39.Visible = true;
                    button_size_shoes_40.Visible = true;
                    button_size_shoes_41.Visible = true;
                    button_size_shoes_42.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_women_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_women_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_women_1_2;

                    label_category_detail_item.Text = "Women" + '/' + "Shoes";
                    label_name_detail_item.Text = label_shoes_women_1.Text;
                    label_money_detail_item.Text = label_money_shoes_women_1.Text;
                    label_color_detail_item.Text = "Pace Pink / Prime Pink - 601";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_women_1;

                    label_info_detail_item.Text = "UA HOVR™ Machina 3 is more than a running shoe. Yes, it gives you the energy return of" +
                        "\r\nUA HOVR®, but it also coaches you in real-time to help you run better when you connect" +
                        "\r\nthem to UA MapMyRun™.";
                    label_DNA_detail_item.Text = "• CONNECTS TO UA MAPMYRUN™: tracks & analyzes your running metrics to help make you" +
                        "\r\n   a better runner (Connectivity expires on December 31, 2024)" +
                        "\r\n• Engineered warp spacer upper for optimal lightweight containment & breathability" +
                        "\r\n• Strategically-mapped design without any overlays or seams so you can put in the miles" +
                        "\r\n   without irritation" +
                        "\r\n• Aerodynamic heel design & external TPU heel wrap for added support & lockdown fit" +
                        "\r\n• Molded EVA sockliner provides added comfort, resiliency & cushioning for high-mileage" +
                        "\r\n   performance" +
                        "\r\n• Responsive UA HOVR™ cushioning reduces impact, returns energy & helps propel you forward" +
                        "\r\n• Channeled rubber outsole mapped for durability in high-wear areas & flex zones to promote" +
                        "\r\n   natural movement";
                    label_Specs_detail_item.Text = "• Style #: 3024907" +
                        "\r\n• Offset: 8mm" +
                        "\r\n• Weight: 9.5 oz." +
                        "\r\n• Lace type: Standard tie" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Regular" +
                        "\r\n• NEUTRAL: For runners who need a balance of flexibility & cushioning";
                    break;
                case ("women's project rock 5 training shoes"):
                    panel_detail_item.Visible = true;

                    button_size_shoes_38.Visible = true;
                    button_size_shoes_39.Visible = true;
                    button_size_shoes_40.Visible = true;
                    button_size_shoes_41.Visible = true;
                    button_size_shoes_42.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_women_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_women_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_women_2_2;

                    label_category_detail_item.Text = "Women" + '/' + "Shoes";
                    label_name_detail_item.Text = label_shoes_women_2.Text;
                    label_money_detail_item.Text = label_money_shoes_women_2.Text;
                    label_color_detail_item.Text = "White - 100";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shoes_women_2;

                    label_info_detail_item.Text = "\"The Project Rock 5s are the most innovative training shoes we've ever made—they give" +
                        "\r\nyou power, energy, support with an amazing comfort level.\" – Dwayne Johnson";
                    label_DNA_detail_item.Text = "• Durable engineered mesh upper is lightweight and breathable with stretch and structure" +
                        "\r\n   where you need it" +
                        "\r\n• Plush knit collar for maximum comfort" +
                        "\r\n• Molded TPU heel-to-midfoot strap to stabilize and lock down your heel while enabling" +
                        "\r\n   forefoot mobility" +
                        "\r\n• Responsive UA HOVR™ cushioning reduces impact, returns energy and helps propel" +
                        "\r\n   you forward" +
                        "\r\n• UA TriBase™ maximizes ground contact, promotes natural motion and provides flexibility" +
                        "\r\n   to grip during lifts";
                    label_Specs_detail_item.Text = "• Style #: 3025436" +
                        "\r\n• Offset: 8mm" +
                        "\r\n• Weight: 13.5 oz." +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Regular";
                    break;
                case ("ua hustle sport backpack"):
                    panel_detail_item.Visible = true;

                    button_size_accessories_onesize.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.Accessories_kids_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.Accessories_kids_1_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Accessories";
                    label_name_detail_item.Text = label_Accessories_kid_1.Text;
                    label_money_detail_item.Text = label_money_Accessories_kid_1.Text;
                    label_color_detail_item.Text = "Bauhaus Blue / White - 457";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_Accessories_kids_1;

                    label_info_detail_item.Text = "These bags are tough, light, and water rolls right off them—and those bungee sleeves" +
                        "\r\nmake it easy to stow things like a warm-up jacket quickly.";
                    label_DNA_detail_item.Text = "• Water-resistant UA Storm technology keeps your stuff dry" +
                        "\r\n• Padded back panel & shaped straps make it more comfortable to carry" +
                        "\r\n• Soft-lined laptop sleeve with organization panel—holds up to 15\" MacBook Pro® or" +
                        "\r\n   similarly sized laptop" +
                        "\r\n• Front sleeve with bungee adjust closure for easily stashing a jacket, pair of shoes" +
                        "\r\n   or ball" +
                        "\r\n• Large, zippered front valuables pocket" +
                        "\r\n• Durable, abrasion-resistant coated bottom";
                    label_Specs_detail_item.Text = "• Style #: 1364181" +
                        "\r\n• 2 side water bottle pockets" +
                        "\r\n• Top grab handle" +
                        "\r\n• Dimensions When Full: 12.6\"W x 7.4\"H x 18.5\"L" +
                        "\r\n• Volume: 26L" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• One Size Fits All";
                    break;
                case ("ua beyond 18 oz. water bottle"):
                    panel_detail_item.Visible = true;

                    button_size_accessories_onesize.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.Accessories_kids_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.Accessories_kids_2_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Accessories";
                    label_name_detail_item.Text = label_Accessories_kid_2.Text;
                    label_money_detail_item.Text = label_money_Accessories_kid_2.Text;
                    label_color_detail_item.Text = "Breeze / Chrome-441";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_Accessories_kids_2;

                    label_info_detail_item.Text = "When you're running or training, you don't always have a spare hand when you need" +
                        "\r\nto hydrate. That's why we made this—the pop top lid only needs one hand to work.";
                    label_DNA_detail_item.Text = "• Vacuum-insulated for maximum temperature retention keeps beverages cold for 18 hours" +
                        "\r\n• Unbreakable stainless steel interior and exterior provide durability that you can" +
                        "\r\n   count on" +
                        "\r\n• One-hand operation for hydration on the go" +
                        "\r\n• Carry loop for easy transport can be locked down when not in use" +
                        "\r\n• Lockable, leak-resistant lid also helps keep spout clean" +
                        "\r\n• Non-slip silicone bottom provides quiet set-down on any surface" +
                        "\r\n• BPA & lead free";
                    label_Specs_detail_item.Text = "• Style #: 1367747" +
                        "\r\n• Capacity: 18 oz." +
                        "\r\n• Dimensions: 10\"H x 3\"W x 3.2\"D" +
                        "\r\n• Compatible with UA Pro & UA Rise lids" +
                        "\r\n• Manufactured by USB, exclusive licensee of Under Armour®" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• One Size Fits All";
                    break;
                case ("boys' ua powderhound jacket"):
                    panel_detail_item.Visible = true;

                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_kids_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_kids_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_kids_1_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Outwear";
                    label_name_detail_item.Text = label_outwear_kid_1.Text;
                    label_money_detail_item.Text = label_money_outwear_kid_1.Text;
                    label_color_detail_item.Text = "Versa Blue / BLACK - 486";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_kids_1;

                    label_info_detail_item.Text = "As at home in the powder as you are, with the features and performance you need to keep" +
                        "\r\nat it all day, warm, dry, and comfortable.";
                    label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                        "\r\n• 100% waterproof & breathable fabric with critically taped seams" +
                        "\r\n• Windproof materials & design shield you from the elements" +
                        "\r\n• 3M™ Thinsulate™ insulation is warm yet lightweight, trapping body heat while allowing" +
                        "\r\n   moisture to escape\r\n• UA UGrow system allows sleeves to grow 2\" to last an extra season" +
                        "\r\n• Helmet compatible hood with adjustable tab for a secure fit" +
                        "\r\n• Secure, zip hand warmer pockets with interior media pocket, chest pocket and interior" +
                        "\r\n   goggle pockets" +
                        "\r\n• Secure ski pass pocket on sleeve & adjustable powder skirt";
                    label_Specs_detail_item.Text = "• Style #: 5112817" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Wash inside out" +
                        "\r\n• Machine wash cold with like colors on gentle cycle" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Cool iron if needed" +
                        "\r\n• Do not dry clean";
                    break;
                case ("girls' ua laila printed jacket"):
                    panel_detail_item.Visible = true;

                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.outwear_kids_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.outwear_kids_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.outwear_kids_2_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Outwear";
                    label_name_detail_item.Text = label_outwear_kid_2.Text;
                    label_money_detail_item.Text = label_money_outwear_kid_2.Text;
                    label_color_detail_item.Text = "Aurora Purple / BLACK - 767";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_outwear_kids_2;

                    label_info_detail_item.Text = "The jacket you grab when you've gotta be out on the coldest days. Rain or snow in the" +
                        "\r\nforecast? We've got you covered there, too.";
                    label_DNA_detail_item.Text = "• UA Storm technology repels water without sacrificing breathability" +
                        "\r\n• 100% waterproof and breathable fabric with critically taped seams" +
                        "\r\n• Cozy microfleece lining insulated with lightweight heat technology for optimal warmth" +
                        "\r\n• 3-piece hood with adjustable tab for superior fit" +
                        "\r\n• Secure, zip hand warmer pockets and interior media pocket";
                    label_Specs_detail_item.Text = "• Style #: 5112576" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Wash inside out" +
                        "\r\n• Machine wash cold with like colors on gentle cycle" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Cool iron if needed" +
                        "\r\n• Do not dry clean";
                    break;
                case ("girls' ua plant life sports top and boyshort 2-piece swim set"):
                    panel_detail_item.Visible = true;

                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.Swimwear_kids_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.Swimwear_kids_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.Swimwear_kids_1_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Swimsuits";
                    label_name_detail_item.Text = label_swimsuits_kid_1.Text;
                    label_money_detail_item.Text = label_money_swimsuits_kid_1.Text;
                    label_color_detail_item.Text = "MIDNIGHT NAVY / OPAL BLUE - 410";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_Swimwear_kids_1;

                    label_info_detail_item.Text = "Swimwear built with athletic innovation. Stretchy, light, quick-drying—everything" +
                        "\r\nyou need.";
                    label_DNA_detail_item.Text = "• Lightweight, 4-way stretch fabric for comfort & mobility" +
                        "\r\n• Built-in UPF 30 sun protection" +
                        "\r\n• Fully lined for extra coverage" +
                        "\r\n• Crossback sports bra style top with boyshort cut bottom";
                    label_Specs_detail_item.Text = "• Style #: 5106470" +
                        "\r\n• Sold as a set" +
                        "\r\n• Polyester/Spandex" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Wash garment inside out" +
                        "\r\n• Machine wash cold on gentle cycle with like colors" +
                        "\r\n• Use only non-chlorine bleach if needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Cool iron if needed";
                    break;
                case ("girls' pre-school ua stripe flutter bikini"):
                    panel_detail_item.Visible = true;

                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.Swimwear_kids_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.Swimwear_kids_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.Swimwear_kids_2_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Swimsuits";
                    label_name_detail_item.Text = label_swimsuits_kid_2.Text;
                    label_money_detail_item.Text = label_money__swimsuits_kid_2.Text;
                    label_color_detail_item.Text = "CREST BLUE / REFLECTIVE - 446";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_Swimwear_kids_2;

                    label_info_detail_item.Text = "Swimwear built with athletic innovation. Stretchy, light, quick-drying—everything" +
                        "\r\nyou need.";
                    label_DNA_detail_item.Text = "• Lightweight, 4-way stretch fabric for comfort & mobility" +
                        "\r\n• Built-in UPF 30 sun protection" +
                        "\r\n• Fully lined for extra coverage";
                    label_Specs_detail_item.Text = "• Style #: 5037053" +
                        "\r\n• 85% Polyester/15% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Fitted: Streamlined fit that’s not too tight or too loose.";
                    break;
                case ("girls' pre-school ua young wild fly by shorts"):
                    panel_detail_item.Visible = true;

                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_kids_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_kids_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_kids_1_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Shorts";
                    label_name_detail_item.Text = label_shorts_kid_1.Text;
                    label_money_detail_item.Text = label_money_shorts_kid_1.Text;
                    label_color_detail_item.Text = "Cerise / WHITE - 653";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_kids_1;

                    label_info_detail_item.Text = "We took the materials from our go-to performance gear and made clothes for the youngest" +
                        "\r\nmembers of your team. Why? Because they're at least as active as the big kids.";
                    label_DNA_detail_item.Text = "• Lightweight, durable woven fabric is breathable & comfortable" +
                        "\r\n• Split leg design withmesh panels for more room to move" +
                        "\r\n• Soft, super-stretchy covered elastic waistband";
                    label_Specs_detail_item.Text = "• Style #: 5086560" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort";
                    break;
                case ("boys' ua field shorts"):
                    panel_detail_item.Visible = true;

                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shorts_kids_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shorts_kids_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shorts_kids_2_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Shorts";
                    label_name_detail_item.Text = label_shorts_kid_2.Text;
                    label_money_detail_item.Text = label_money_shorts_kid_2.Text;
                    label_color_detail_item.Text = "Cerulean / Neptune - 452";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shorts_kids_2;

                    label_info_detail_item.Text = "Lightweight golf shorts with a drawstring instead of belt loops, to give you" +
                        "\r\na dialed-in fit.";
                    label_DNA_detail_item.Text = "• Light, durable stretch-woven twill fabric" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Encased elastic waistband with external drawcord" +
                        "\r\n• Open hand & back pockets";
                    label_Specs_detail_item.Text = "• Style #: 1370143" +
                        "\r\n• Inseam: YMD 7\" (+/- .5\" per size)" +
                        "\r\n• Pockets: Yes" +
                        "\r\n• 100% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Wash garment inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Use only non-chlorine bleach when needed" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("boys' project rock veterans day show camo t-shirt"):
                    panel_detail_item.Visible = true;

                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_kids_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_kids_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_kids_1_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Shirts";
                    label_name_detail_item.Text = label_shirts_kid_1.Text;
                    label_money_detail_item.Text = label_money_shirts_kid_1.Text;
                    label_color_detail_item.Text = "Khaki Base / Black - 289";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_kids_1_1;

                    label_info_detail_item.Text = "Project Rock training gear was built to help you find boundaries, then push right" +
                        "\r\nthrough them. Everything in this collection was personally approved by Dwayne Johnson," +
                        "\r\nthe hardest worker in the room. ANY room.";
                    label_DNA_detail_item.Text = "• Super-soft, cotton-blend fabric provides all-day comfort" +
                        "\r\n• 4-way stretch material moves better in every direction" +
                        "\r\n• Graphic appears when exposed to moisture so everyone knows who's working hardest" +
                        "\r\n   out there";
                    label_Specs_detail_item.Text = "• Style #: 1373622" +
                        "\r\n• 57% Cotton/38% Polyester/5% Elastane" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Wash garment inside out" +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("girls' ua rival fleece big logo hoodie"):
                    panel_detail_item.Visible = true;

                    button_size_kid_XS.Visible = true;
                    button_size_kid_SM.Visible = true;
                    button_size_kid_MD.Visible = true;
                    button_size_kid_LG.Visible = true;
                    button_size_kid_XL.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shirts_kids_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shirts_kids_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shirts_kids_2_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Shirts";
                    label_name_detail_item.Text = label_shirts_kid_2.Text;
                    label_money_detail_item.Text = label_money_shirts_kid_2.Text;
                    label_color_detail_item.Text = "Prime Pink / Pink Punk - 647";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_kids_2;

                    label_info_detail_item.Text = "This gear keeps you warmed up and ready for pretty much everything you do—it's light," +
                        "\r\ncomfy, and super-soft on the inside.";
                    label_DNA_detail_item.Text = "• Ultra-soft cotton-blend fleece with brushed inside for extra warmth" +
                        "\r\n• Front kangaroo pocket" +
                        "\r\n• Ribbed cuffs & bottom hem" +
                        "\r\n• Raglan sleeves";
                    label_Specs_detail_item.Text = "• Style #: 1373127" +
                        "\r\n• 80% Cotton/20% Polyester" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Loose: Fuller cut for complete comfort." +
                        "\r\n• Machine wash cold with like colors" +
                        "\r\n• Do not bleach" +
                        "\r\n• Tumble dry low" +
                        "\r\n• Do not iron" +
                        "\r\n• Do not use softeners" +
                        "\r\n• Do not dry clean";
                    break;
                case ("girls' pre-school ua assert 9 ac running shoes"):
                    panel_detail_item.Visible = true;

                    button_size_shoes_kid_4.Visible = true;
                    button_size_shoes_kid_4_5.Visible = true;
                    button_size_shoes_kid_5.Visible = true;
                    button_size_shoes_kid_5_5.Visible = true;
                    button_size_shoes_kid_6.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_kids_1_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_kids_1_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_kids_1_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Shoes";
                    label_name_detail_item.Text = label_shoes_kid_1.Text;
                    label_money_detail_item.Text = label_money_shoes_kid_1.Text;
                    label_color_detail_item.Text = "Halo Gray / White - 106";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_kids_1_1;

                    label_info_detail_item.Text = "Your ultimate lightweight, do-everything shoe—with soft cushioning for a smooth ride" +
                        "\r\nand synthetic overlays for more support.";
                    label_DNA_detail_item.Text = "• Lightweight mesh upper with 3-color digital print delivers complete breathability" +
                        "\r\n• Durable leather overlays for stability and that locks in your midfoot" +
                        "\r\n• Hook and loop strap for easy on and off" +
                        "\r\n• EVA sockliner provides soft, step-in comfort" +
                        "\r\n• One-piece EVA midsole turns cushioned landings into explosive takeoffs" +
                        "\r\n• Lightweight, durable outsole";
                    label_Specs_detail_item.Text = "• Style #: 3024636" +
                        "\r\n• Lace type: Standard tie with hook & loop strap" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Regular";
                    break;
                case ("boys' grade school ua assert 9 running shoes"):
                    panel_detail_item.Visible = true;

                    button_size_shoes_kid_4.Visible = true;
                    button_size_shoes_kid_4_5.Visible = true;
                    button_size_shoes_kid_5.Visible = true;
                    button_size_shoes_kid_5_5.Visible = true;
                    button_size_shoes_kid_6.Visible = true;

                    pictureBox_detail_item.BackgroundImage = Properties.Resources.shoes_kids_2_1;
                    button_picture_detail_item_1.BackgroundImage = Properties.Resources.shoes_kids_2_1;
                    button_picture_detail_item_2.BackgroundImage = Properties.Resources.shoes_kids_2_2;

                    label_category_detail_item.Text = "Kids" + '/' + "Shoes";
                    label_name_detail_item.Text = label_shoes_kid_2.Text;
                    label_money_detail_item.Text = label_money_shoes_kid_2.Text;
                    label_color_detail_item.Text = "Red / White - 600";

                    pictureBox_color_detail_item.BackgroundImage = Properties.Resources.color_shirts_kids_2;

                    label_info_detail_item.Text = "Your ultimate lightweight, do-everything shoe—with soft cushioning for a smooth ride" +
                        "\r\nand synthetic overlays for more support.";
                    label_DNA_detail_item.Text = "• Lightweight mesh upper with 3-color digital print delivers complete breathability" +
                        "\r\n• Durable leather overlays for stability that locks in your midfoot" +
                        "\r\n• EVA sockliner provides soft, step-in comfort" +
                        "\r\n• One-piece EVA midsole turns cushioned landings into explosive takeoffs" +
                        "\r\n• Solid rubber outsole covers high impact zones for greater durability with less weight";
                    label_Specs_detail_item.Text = "• Style #: 3024633" +
                        "\r\n• Lace type: Standard tie" +
                        "\r\n• Imported";
                    label_Fit_detail_item.Text = "• Regular";
                    break;
            }
        }

        int y = 6;
        int count_hang = 0;
        int tong_tien = 0;
        List<string> hoadon = new List<string>();
        List<int> soluonghoadon = new List<int>();

        void Add_sanpham()
        {
            Panel sanpham = new Panel();
            sanpham.BorderStyle = BorderStyle.FixedSingle;
            sanpham.Width = 690;
            sanpham.Height = 250;
            sanpham.Location = new Point(5, y);

            Label name_item = new Label();
            Label label_size = new Label();
            Label label_size_item = new Label();
            Label label_color = new Label();
            Label label_color_item = new Label();
            
            Label money = new Label();
            Label cash = new Label();
            Label amount_total = new Label();
            Label items = new Label();

            Label remove_item = new Label();

            PictureBox photo = new PictureBox();

            ComboBox amount = new ComboBox();
            amount.Items.Add(1);
            amount.Items.Add(2);
            amount.Items.Add(3);
            amount.Items.Add(4);
            amount.Items.Add(5);
            amount.Font = new Font("UTM Avo", 10, FontStyle.Bold);
            amount.Location = new Point(205, 174);

            name_item.Width = 533;
            name_item.Height = 24;
            name_item.Font = new Font("UTM Avo", 10, FontStyle.Bold);
            name_item.ForeColor = Color.Black;
            name_item.Text = label_name_detail_item.Text.Replace("\n", "").Replace("\r", "");
            name_item.Location = new Point(205, 5);

            photo.Location = new Point(5, 10);
            photo.BorderStyle = BorderStyle.FixedSingle;
            photo.Width = 190;
            photo.Height = 223;
            photo.BackgroundImageLayout = ImageLayout.Stretch;

            label_size.Width = 43;
            label_size.Height = 20;
            label_size.Font = new Font("Yu Gothic UI", 9, FontStyle.Regular);
            label_size.ForeColor =  Color.Gray;
            label_size.Text = "Size:";
            label_size.Location = new Point(200, 105);

            label_size_item.Width = 99;
            label_size_item.Height = 20;
            label_size_item.Font = new Font("Yu Gothic UI", 9, FontStyle.Regular);
            label_size_item.ForeColor = Color.Gray;
            label_size_item.Text = name_size;
            label_size_item.Location = new Point(260, 105);

            label_color.Width = 48;
            label_color.Height = 20;
            label_color.Font = new Font("Yu Gothic UI", 9, FontStyle.Regular);
            label_color.ForeColor = Color.Gray;
            label_color.Text = "Color:";
            label_color.Location = new Point(200, 75);

            label_color_item.Width = 244;
            label_color_item.Height = 20;
            label_color_item.Font = new Font("Yu Gothic UI", 9, FontStyle.Regular);
            label_color_item.ForeColor = Color.Gray;
            label_color_item.Text = label_color_detail_item.Text;
            label_color_item.Location = new Point(260, 75);

            amount_total.Width = 46;
            amount_total.Height = 23;
            amount_total.Font = new Font("Yu Gothic UI", 10, FontStyle.Regular);
            amount_total.ForeColor = Color.Gray;
            amount_total.Text = "0";
            amount_total.Location = new Point(550, 50);

            items.Width = 51;
            items.Height = 23;
            items.Font = new Font("Yu Gothic UI", 10, FontStyle.Regular);
            items.ForeColor = Color.Gray;
            items.Text = "items";
            items.Location = new Point(600, 50);

            cash.Width = 51;
            cash.Height = 23;
            cash.Font = new Font("UTM Avo", 11, FontStyle.Regular);
            cash.ForeColor = Color.Black;
            cash.Text = label_cash_outwear_man_1.Text;
            cash.Location = new Point(550, 80);

            money.Width = 51;
            money.Height = 23;
            money.Font = new Font("UTM Avo", 11, FontStyle.Regular);
            money.ForeColor = Color.Black;
            money.Text = label_money_detail_item.Text;
            money.Location = new Point(600, 80);

            remove_item.Width = 100;
            remove_item.Height = 23;
            remove_item.Font = new Font("UTM Avo", 11, FontStyle.Bold);
            remove_item.ForeColor = Color.Black;
            remove_item.Text = "Remove";
            remove_item.Location = new Point(550, 200);

            int money_total = Convert.ToInt32(money.Text);
            int cur_val = 0;
            amount.TextChanged += (s, e) =>
            {
                amount_total.Text = amount.Text;
                int last_val = Convert.ToInt32(amount_total.Text);
                if (cur_val == 0 && last_val == 1)
                {
                    tong_tien += money_total;
                    cur_val = 1;
                }
                if (cur_val == 1 && last_val == 0)
                {
                    tong_tien -= money_total;
                    cur_val = 0;
                    
                }
                if (cur_val == 1 && last_val == 2)
                {
                    tong_tien += money_total;
                    cur_val = 2;
                }
                if (cur_val == 2 && last_val == 1)
                {
                    tong_tien -= money_total;
                    cur_val = 1;
                    
                }
                if (cur_val == 2 && last_val == 3)
                {
                    tong_tien += money_total;
                    cur_val = 3;  
                }
                if (cur_val == 3 && last_val == 2)
                {
                    tong_tien -= money_total;
                    cur_val = 2;      
                }
                if (cur_val == 3 && last_val == 4)
                {
                    tong_tien += money_total;
                    cur_val = 4;
                }
                if (cur_val == 4 && last_val == 3)
                {
                    tong_tien -= money_total;
                    cur_val = 3;
                }
                if (cur_val == 4 && last_val == 5)
                {
                    tong_tien += money_total;
                    cur_val = 5;
                }
                if (cur_val == 5 && last_val == 4)
                {
                    tong_tien -= money_total;
                    cur_val = 4;
                }
                label_total_money.Text = tong_tien.ToString();
                label_final_money.Text = tong_tien.ToString();
            };

            switch (label_name_detail_item.Text)
            {
                //sanpham1
                case "Men's Project Rock Insulated \r\nBomber Outwear":
                    photo.BackgroundImage = Properties.Resources.color_outwear_man_1;
                    break;
                //sanpham2
                case "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear":
                    photo.BackgroundImage = Properties.Resources.color_outwear_man_2;
                    break;
                //sanpham3
                case "Men's UA RUSH™ ColdGear® \r\nLeggings":
                    photo.BackgroundImage = Properties.Resources.color_pants_man_1;
                    break;
                //sanpham4
                case "Men's UA Meridian Tapered \r\nPants":
                    photo.BackgroundImage = Properties.Resources.color_pants_man_2;
                    break;
                //sanpham5
                case "Men's UA Elevated Woven 2.0 \r\nShorts":
                    photo.BackgroundImage = Properties.Resources.color_shorts_man_1;
                    break;
                //sanpham6
                case "Men's UA Rival Fleece Big Logo\r\nShorts":
                    photo.BackgroundImage = Properties.Resources.color_shorts_man_2;
                    break;
                //sanpham7
                case "Men's Project Rock Heavyweight \r\nTerry Sleeveless Hoodie":
                    photo.BackgroundImage = Properties.Resources.color_shirts_man_1;
                    break;
                //sanpham8
                case "Men's UA Tech™ Collegiate \r\nSideline Short Sleeve":
                    photo.BackgroundImage = Properties.Resources.color_shirts_man_2;
                    break;
                //sanpham9
                case "Unisex Curry Flow 10 'Sour \r\nThen Sweet' Basketball Shoes":
                    photo.BackgroundImage = Properties.Resources.color_shoes_man_1;
                    break;
                //sanpham10
                case "Men's Project Rock 5 Veterans \r\nDay Training Shoes":
                    photo.BackgroundImage = Properties.Resources.color_shoes_man_2;
                    break;
                //sanpham11
                case "Women's UA Storm ColdGear® \r\nInfrared Down Jacket":
                    photo.BackgroundImage = Properties.Resources.color_outwear_women_1;
                    break;
                //sanpham12
                case "Women's UA OutRun The Storm\r\nJacket":
                    photo.BackgroundImage = Properties.Resources.color_outwear_women_1;
                    break;
                //sanpham13
                case "Women's UA Meridian Jacquard\r\nAnkle Leggings":
                    photo.BackgroundImage = Properties.Resources.color_pants_women_1;
                    break;
                //sanpham14
                case "Women's UA Armour Sport \r\nWoven Pants":
                    photo.BackgroundImage = Properties.Resources.color_pants_women_2;
                    break;
                //sanpham15
                case "Women's ColdGear® Authentics\r\nCrew":
                    photo.BackgroundImage = Properties.Resources.color_shirts_women_1;
                    break;
                //sanpham16
                case "Women's Project Rock Veterans\r\nDay Fleece Hoodie":
                    photo.BackgroundImage = Properties.Resources.color_shirts_women_2;
                    break;
                //sanpham17
                case "Women's UA Play Up 2-in-1 \r\nShorts":
                    photo.BackgroundImage = Properties.Resources.color_shorts_women_1;
                    break;
                //sanpham18
                case "Women's UA Links Shorts":
                    photo.BackgroundImage = Properties.Resources.color_shorts_women_2;
                    break;
                //sanpham19
                case "Women's UA HOVR™ Machina 3\r\nRunning Shoes":
                    photo.BackgroundImage = Properties.Resources.color_shoes_women_1;
                    break;
                //sanpham20
                case "Women's Project Rock 5 Training\r\nShoes":
                    photo.BackgroundImage = Properties.Resources.color_shoes_women_2;
                    break;
                //sanpahm21
                case "UA Hustle Sport Backpack":
                    photo.BackgroundImage = Properties.Resources.color_Accessories_kids_1;
                    break;
                //sanpham22
                case "UA Beyond 18 oz. Water Bottle":
                    photo.BackgroundImage = Properties.Resources.color_Accessories_kids_2;
                    break;
                //sanpham23
                case "Boys' UA Powderhound Jacket":
                    photo.BackgroundImage = Properties.Resources.color_outwear_kids_1;
                    break;
                //sanpham24
                case "Girls' UA Laila Printed Jacket":
                    photo.BackgroundImage = Properties.Resources.color_outwear_kids_2;
                    break;
                //sanpham25
                case "Girls' UA Plant Life Sports Top \r\nand Boyshort 2-Piece Swim Set":
                    photo.BackgroundImage = Properties.Resources.color_Swimwear_kids_1;
                    break;
                //sanpham26
                case "Girls' Pre-School UA Stripe \r\nFlutter Bikini":
                    photo.BackgroundImage = Properties.Resources.color_Swimwear_kids_2;
                    break;
                //sanpham27
                case "Girls' Pre-School UA Young Wild \r\nFly By Shorts":
                    photo.BackgroundImage = Properties.Resources.color_shorts_kids_1;
                    break;
                //sanpham28
                case "Boys' UA Field Shorts":
                    photo.BackgroundImage = Properties.Resources.color_shorts_kids_2;
                    break;
                //sapham29
                case "Boys' Project Rock Veterans Day \r\nShow Camo T-Shirt":
                    photo.BackgroundImage = Properties.Resources.color_shirts_kids_1_1;
                    break;
                //sanpham30
                case "Girls' UA Rival Fleece Big Logo \r\nHoodie":
                    photo.BackgroundImage = Properties.Resources.color_shirts_kids_2;
                    break;
                //sanpham31
                case "Girls' Pre-School UA Assert 9 \r\nAC Running Shoes":
                    photo.BackgroundImage = Properties.Resources.color_shoes_kids_1;
                    break;
                //sanpham32
                case "Boys' Grade School UA Assert 9 \r\nRunning Shoes":
                    photo.BackgroundImage = Properties.Resources.color_shoes_kids_2;
                    break;
            }

            sanpham.Controls.Add(name_item);
            sanpham.Controls.Add(label_size);
            sanpham.Controls.Add(label_size_item);
            sanpham.Controls.Add(label_color);
            sanpham.Controls.Add(label_color_item);
            sanpham.Controls.Add(remove_item);
            sanpham.Controls.Add(money);
            sanpham.Controls.Add(cash);
            sanpham.Controls.Add(items);
            sanpham.Controls.Add(amount_total);
            sanpham.Controls.Add(amount);
            sanpham.Controls.Add(photo);

            remove_item.Click += (s, e) =>
            {
                y -= 260;
                tong_tien -= money_total * Convert.ToInt32(amount_total.Text);
                count_hang--;
                label_total_money.Text = tong_tien.ToString();
                label_final_money.Text = tong_tien.ToString();
                label_amount_item.Text = count_hang.ToString();
                panel_info_giohang.Controls.Remove(sanpham);
                //hoadon.Remove(ten.Text);
            };

            panel_info_giohang.Controls.Add(sanpham);
            y += 260;
            count_hang++;
            label_amount_item.Text = count_hang.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_giohang.Visible = false;
            panel_main_shop.Visible = true;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            panel_feed_back.Visible = true;
            panel_detail_item.Visible = false;
            label_item_feed_back.Text = label_name_detail_item.Text;
        }
        int amount_star = 0;

        private void pictureBox_start_1_Click(object sender, EventArgs e)
        {
            pictureBox_start_1.BackColor = Color.Lime;
            pictureBox_start_2.BackColor = Color.White;
            pictureBox_start_3.BackColor = Color.White;
            pictureBox_start_4.BackColor = Color.White;
            pictureBox_start_5.BackColor = Color.White;
            amount_star = 1;
        }

        private void pictureBox_start_2_Click(object sender, EventArgs e)
        {
            pictureBox_start_1.BackColor = Color.Lime;
            pictureBox_start_2.BackColor = Color.Lime;
            pictureBox_start_3.BackColor = Color.White;
            pictureBox_start_4.BackColor = Color.White;
            pictureBox_start_5.BackColor = Color.White;
            amount_star = 2;

        }

        private void pictureBox_start_3_Click(object sender, EventArgs e)
        {
            pictureBox_start_1.BackColor = Color.Lime;
            pictureBox_start_2.BackColor = Color.Lime;
            pictureBox_start_3.BackColor = Color.Lime;
            pictureBox_start_4.BackColor = Color.White;
            pictureBox_start_5.BackColor = Color.White;
            amount_star = 3;

        }

        private void pictureBox_start_4_Click(object sender, EventArgs e)
        {
            pictureBox_start_1.BackColor = Color.Lime;
            pictureBox_start_2.BackColor = Color.Lime;
            pictureBox_start_3.BackColor = Color.Lime;
            pictureBox_start_4.BackColor = Color.Lime;
            pictureBox_start_5.BackColor = Color.White;
            amount_star = 4;

        }

        private void pictureBox_start_5_Click(object sender, EventArgs e)
        {
            pictureBox_start_1.BackColor = Color.Lime;
            pictureBox_start_2.BackColor = Color.Lime;
            pictureBox_start_3.BackColor = Color.Lime;
            pictureBox_start_4.BackColor = Color.Lime;
            pictureBox_start_5.BackColor = Color.Lime;
            amount_star = 5;

        }

        private void button_submit_feedback_Click(object sender, EventArgs e)
        {
           
            if (label_item_feed_back.Text == "")
                MessageBox.Show("Please choose item to review", "Notification");
            if(amount_star == 0)
                MessageBox.Show("Please select amount star","Notification");
            if(label_item_feed_back.Text != "" && amount_star != 0)
            {
                Add_feedback();
                pictureBox_start_1.BackColor = Color.White;
                pictureBox_start_2.BackColor = Color.White;
                pictureBox_start_3.BackColor = Color.White;
                pictureBox_start_4.BackColor = Color.White;
                pictureBox_start_5.BackColor = Color.White;
                textBox_review.Text = "";
                textBox_review_title.Text = "";
                amount_star = 0;
            }
        }

        int x = 6;
        void Add_feedback()
        {
            Panel feeedback = new Panel();
            feeedback.BorderStyle = BorderStyle.FixedSingle;
            feeedback.Width = 690;
            feeedback.Height = 250;
            feeedback.Location = new Point(5, x);

            Label review_title = new Label();
            Label name_item = new Label();
            Label review_post = new Label();
            Label number_star = new Label();


            PictureBox photo = new PictureBox();


            name_item.Width = 533;
            name_item.Height = 24;
            name_item.Font = new Font("UTM Avo", 10, FontStyle.Bold);
            name_item.ForeColor = Color.Black;
            name_item.Text = label_name_detail_item.Text.Replace("\n", "").Replace("\r", "");
            name_item.Location = new Point(205, 45);

            number_star.Width = 533;
            number_star.Height = 24;
            number_star.Font = new Font("UTM Avo", 10, FontStyle.Bold);
            number_star.ForeColor = Color.Black;
            number_star.Location = new Point(205, 5);
            if (amount_star == 1)
                number_star.Text = "★";
            if (amount_star == 2)
                number_star.Text = "★★";
            if (amount_star == 3)
                number_star.Text = "★★★";
            if (amount_star == 4)
                number_star.Text = "★★★★";
            if (amount_star == 5)
                number_star.Text = "★★★★★";

            review_title.Width = 533;
            review_title.Height = 24;
            review_title.Font = new Font("UTM Avo", 10, FontStyle.Bold);
            review_title.ForeColor = Color.Black;
            review_title.Text = textBox_review_title.Text;
            review_title.Location = new Point(205, 95);

            review_post.Width = 533;
            review_post.Height = 24;
            review_post.Font = new Font("UTM Avo", 10, FontStyle.Regular);
            review_post.ForeColor = Color.Black;
            review_post.Text = textBox_review.Text;
            review_post.Location = new Point(205, 120);

            photo.Location = new Point(5, 10);
            photo.BorderStyle = BorderStyle.FixedSingle;
            photo.Width = 190;
            photo.Height = 223;
            photo.BackgroundImageLayout = ImageLayout.Stretch;

            //label_item_feed_back.Text = label_name_detail_item.Text;
            switch (label_item_feed_back.Text)
            {
                //sanpham1
                case "Men's Project Rock Insulated \r\nBomber Outwear":
                    photo.BackgroundImage = Properties.Resources.color_outwear_man_1;
                    name_item.Text = "Men's Project Rock Insulated \r\nBomber Outwear";
                    break;
                //sanpham2
                case "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear":
                    photo.BackgroundImage = Properties.Resources.color_outwear_man_2;
                    name_item.Text = "Men's UA Storm ColdGear®\r\nInfrared Shield Outwear";

                    break;
                //sanpham3
                case "Men's UA RUSH™ ColdGear® \r\nLeggings":
                    photo.BackgroundImage = Properties.Resources.color_pants_man_1;
                    name_item.Text = "Men's UA RUSH™ ColdGear® \r\nLeggings";

                    break;
                //sanpham4
                case "Men's UA Meridian Tapered \r\nPants":
                    photo.BackgroundImage = Properties.Resources.color_pants_man_2;
                    name_item.Text = "Men's UA Meridian Tapered \r\nPants";

                    break;
                //sanpham5
                case "Men's UA Elevated Woven 2.0 \r\nShorts":
                    photo.BackgroundImage = Properties.Resources.color_shorts_man_1;
                    name_item.Text = "Men's UA Elevated Woven 2.0 \r\nShorts";

                    break;
                //sanpham6
                case "Men's UA Rival Fleece Big Logo\r\nShorts":
                    photo.BackgroundImage = Properties.Resources.color_shorts_man_2;
                    name_item.Text = "Men's UA Rival Fleece Big Logo\r\nShorts";

                    break;
                //sanpham7
                case "Men's Project Rock Heavyweight \r\nTerry Sleeveless Hoodie":
                    photo.BackgroundImage = Properties.Resources.color_shirts_man_1;
                    name_item.Text = "Men's Project Rock Heavyweight \r\nTerry Sleeveless Hoodie";

                    break;
                //sanpham8
                case "Men's UA Tech™ Collegiate \r\nSideline Short Sleeve":
                    photo.BackgroundImage = Properties.Resources.color_shirts_man_2;
                    name_item.Text = "Men's UA Tech™ Collegiate \r\nSideline Short Sleeve";

                    break;
                //sanpham9
                case "Unisex Curry Flow 10 'Sour \r\nThen Sweet' Basketball Shoes":
                    photo.BackgroundImage = Properties.Resources.color_shoes_man_1;
                    name_item.Text = "Unisex Curry Flow 10 'Sour \r\nThen Sweet' Basketball Shoes";

                    break;
                //sanpham10
                case "Men's Project Rock 5 Veterans \r\nDay Training Shoes":
                    photo.BackgroundImage = Properties.Resources.color_shoes_man_2;
                    name_item.Text = "Men's Project Rock 5 Veterans \r\nDay Training Shoes";

                    break;
                //sanpham11
                case "Women's UA Storm ColdGear® \r\nInfrared Down Jacket":
                    photo.BackgroundImage = Properties.Resources.color_outwear_women_1;
                    name_item.Text = "Women's UA Storm ColdGear® \r\nInfrared Down Jacket";

                    break;
                //sanpham12
                case "Women's UA OutRun The Storm\r\nJacket":
                    photo.BackgroundImage = Properties.Resources.color_outwear_women_1;
                    name_item.Text = "Women's UA OutRun The Storm\r\nJacket";

                    break;
                //sanpham13
                case "Women's UA Meridian Jacquard\r\nAnkle Leggings":
                    photo.BackgroundImage = Properties.Resources.color_pants_women_1;
                    name_item.Text = "Women's UA Meridian Jacquard\r\nAnkle Leggings";

                    break;
                //sanpham14
                case "Women's UA Armour Sport \r\nWoven Pants":
                    photo.BackgroundImage = Properties.Resources.color_pants_women_2;
                    name_item.Text = "Women's UA Armour Sport \r\nWoven Pants";

                    break;
                //sanpham15
                case "Women's ColdGear® Authentics\r\nCrew":
                    photo.BackgroundImage = Properties.Resources.color_shirts_women_1;
                    name_item.Text = "Women's ColdGear® Authentics\r\nCrew";

                    break;
                //sanpham16
                case "Women's Project Rock Veterans\r\nDay Fleece Hoodie":
                    photo.BackgroundImage = Properties.Resources.color_shirts_women_2;
                    name_item.Text = "Women's Project Rock Veterans\r\nDay Fleece Hoodie";

                    break;
                //sanpham17
                case "Women's UA Play Up 2-in-1 \r\nShorts":
                    photo.BackgroundImage = Properties.Resources.color_shorts_women_1;
                    name_item.Text = "Women's UA Play Up 2-in-1 \r\nShorts";

                    break;
                //sanpham18
                case "Women's UA Links Shorts":
                    photo.BackgroundImage = Properties.Resources.color_shorts_women_2;
                    name_item.Text = "Women's UA Links Shorts";

                    break;
                //sanpham19
                case "Women's UA HOVR™ Machina 3\r\nRunning Shoes":
                    photo.BackgroundImage = Properties.Resources.color_shoes_women_1;
                    name_item.Text = "Women's UA HOVR™ Machina 3\r\nRunning Shoes";

                    break;
                //sanpham20
                case "Women's Project Rock 5 Training\r\nShoes":
                    photo.BackgroundImage = Properties.Resources.color_shoes_women_2;
                    name_item.Text = "Women's Project Rock 5 Training\r\nShoes";

                    break;
                //sanpahm21
                case "UA Hustle Sport Backpack":
                    photo.BackgroundImage = Properties.Resources.color_Accessories_kids_1;
                    name_item.Text = "UA Hustle Sport Backpack";

                    break;
                //sanpham22
                case "UA Beyond 18 oz. Water Bottle":
                    photo.BackgroundImage = Properties.Resources.color_Accessories_kids_2;
                    name_item.Text = "UA Beyond 18 oz. Water Bottle";

                    break;
                //sanpham23
                case "Boys' UA Powderhound Jacket":
                    photo.BackgroundImage = Properties.Resources.color_outwear_kids_1;
                    name_item.Text = "Boys' UA Powderhound Jacket";

                    break;
                //sanpham24
                case "Girls' UA Laila Printed Jacket":
                    photo.BackgroundImage = Properties.Resources.color_outwear_kids_2;
                    name_item.Text = "Girls' UA Laila Printed Jacket";

                    break;
                //sanpham25
                case "Girls' UA Plant Life Sports Top \r\nand Boyshort 2-Piece Swim Set":
                    photo.BackgroundImage = Properties.Resources.color_Swimwear_kids_1;
                    name_item.Text = "Girls' UA Plant Life Sports Top \r\nand Boyshort 2-Piece Swim Set";

                    break;
                //sanpham26
                case "Girls' Pre-School UA Stripe \r\nFlutter Bikini":
                    photo.BackgroundImage = Properties.Resources.color_Swimwear_kids_2;
                    name_item.Text = "Girls' Pre-School UA Stripe \r\nFlutter Bikini";

                    break;
                //sanpham27
                case "Girls' Pre-School UA Young Wild \r\nFly By Shorts":
                    photo.BackgroundImage = Properties.Resources.color_shorts_kids_1;
                    name_item.Text = "Girls' Pre-School UA Young Wild \r\nFly By Shorts";

                    break;
                //sanpham28
                case "Boys' UA Field Shorts":
                    photo.BackgroundImage = Properties.Resources.color_shorts_kids_2;
                    name_item.Text = "Boys' UA Field Shorts";

                    break;
                //sapham29
                case "Boys' Project Rock Veterans Day \r\nShow Camo T-Shirt":
                    photo.BackgroundImage = Properties.Resources.color_shirts_kids_1_1;
                    name_item.Text = "Boys' Project Rock Veterans Day \r\nShow Camo T-Shirt";

                    break;
                //sanpham30
                case "Girls' UA Rival Fleece Big Logo \r\nHoodie":
                    photo.BackgroundImage = Properties.Resources.color_shirts_kids_2;
                    name_item.Text = "Girls' UA Rival Fleece Big Logo \r\nHoodie";

                    break;
                //sanpham31
                case "Girls' Pre-School UA Assert 9 \r\nAC Running Shoes":
                    photo.BackgroundImage = Properties.Resources.color_shoes_kids_1;
                    name_item.Text = "Girls' Pre-School UA Assert 9 \r\nAC Running Shoes";

                    break;
                //sanpham32
                case "Boys' Grade School UA Assert 9 \r\nRunning Shoes":
                    photo.BackgroundImage = Properties.Resources.color_shoes_kids_2;
                    name_item.Text = "Boys' Grade School UA Assert 9 \r\nRunning Shoes";

                    break;
            }

            feeedback.Controls.Add(name_item);
            feeedback.Controls.Add(photo);
            feeedback.Controls.Add(review_post);
            feeedback.Controls.Add(review_title);
            feeedback.Controls.Add(number_star);


            panel_info_feedback.Controls.Add(feeedback);

            x += 260;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_feed_back.Visible = false;
            panel_detail_item.Visible = true;
            pictureBox_start_1.BackColor = Color.White;
            pictureBox_start_2.BackColor = Color.White;
            pictureBox_start_3.BackColor = Color.White;
            pictureBox_start_4.BackColor = Color.White;
            pictureBox_start_5.BackColor = Color.White;
            textBox_review.Text = "";
            textBox_review_title.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button_back_bag_item.Visible = true;
            panel_info_giohang.Visible = true;
        }

        private void button_back_bag_item_Click(object sender, EventArgs e)
        {

        }
    }
}
