using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74087028_practice_6_2
{
    public partial class Form1 : Form
    {
        private unit u;
        private unit monster;
        private Random random;
        private int round;
        private bool have_shield;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            back_menu();
        }
        
        private void back_menu()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }
            label1.Visible = true;
            warrior_button.Visible = true;
            tank_button.Visible = true;
            ranger_button.Visible = true;
            text_label.Text = "";
            attack_button.Enabled = true;
            skill_button.Enabled = true;
            continue_button.Enabled = false;
            round = 0;
            have_shield = false;
        }

        private void print()
        {
            work_hp_label.Text = u.get_hp().ToString();
            work_mp_label.Text = u.get_mp().ToString();
            work_atk_label.Text = u.get_atk().ToString();
            monster_hp_label.Text = monster.get_hp().ToString();
            monster_mp_label.Text = monster.get_mp().ToString();
            monster_atk_label.Text = monster.get_atk().ToString();
            round_label.Text = round.ToString();
        }
        private void warrior_button_Click(object sender, EventArgs e)
        {
            work_label.Text = warrior_button.Text;
            foreach (Control control in this.Controls)
                control.Visible = true;
            label1.Visible = false;
            warrior_button.Visible = false;
            tank_button.Visible = false;
            ranger_button.Visible = false;
            u = new warrior();           
            monster = new monster();
            round++;
            print();
            text_label.Text += "敵人出現了\n";
        }

        
        private void tank_button_Click(object sender, EventArgs e)
        {
            work_label.Text = tank_button.Text;
            foreach (Control control in this.Controls)
                control.Visible = true;
            label1.Visible = false;
            warrior_button.Visible = false;
            tank_button.Visible = false;
            ranger_button.Visible = false;
            u = new tank();         
            monster = new monster();
            round++;
            print();
            text_label.Text += "敵人出現了\n";
        }

        private void ranger_button_Click(object sender, EventArgs e)
        {
            work_label.Text = ranger_button.Text;
            foreach (Control control in this.Controls)
                control.Visible = true;
            label1.Visible = false;
            warrior_button.Visible = false;
            tank_button.Visible = false;
            ranger_button.Visible = false;
            u = new ranger();           
            monster = new monster();
            round++;
            print();
            text_label.Text += "敵人出現了\n";
        }

        private void continue_button_Click(object sender, EventArgs e)
        {
            if(u.get_hp()<=0)
                back_menu();
            else
            {
                text_label.Text = "";
                monster = new monster();
                text_label.Text += "敵人出現了\n";
                attack_button.Enabled = true;
                skill_button.Enabled = true;
                continue_button.Enabled = false;
                round++;
                print();
            }
        }

        private void attack_button_Click(object sender, EventArgs e)
        {
            monster.set_hp(monster.get_hp()-u.get_atk());
            monster_hp_label.Text = monster.get_hp().ToString();            
            text_label.Text += "玩家攻擊\n" + "敵人受到" + u.get_atk().ToString() + "傷害\n";
            monster_attack();
            if(monster.get_hp()<=0)
            {
                attack_button.Enabled = false;
                skill_button.Enabled = false;
                continue_button.Enabled = true;
                u.set_hp(u.get_hp() + 30);
                u.set_mp(u.get_mp() + 10);
                text_label.Text += "你贏了，你回復了體力和魔力";
                
            }
            else if(u.get_hp()<=0)
            {
                attack_button.Enabled = false;
                skill_button.Enabled = false;
                continue_button.Enabled = true;
                text_label.Text += "你輸了";              
            }
        }

        private void monster_attack()
        {
            random = new Random();
            int next = random.Next(1, 11);
            if (monster.get_hp() > 0)
            {
                if (next <= 8)
                {
                    if (!have_shield)
                    {
                        u.set_hp(u.get_hp() - monster.get_atk());
                        text_label.Text += "敵人攻擊\n" + "玩家受到" + monster.get_atk().ToString() + "傷害\n";
                    }
                    else
                    {
                        u.set_hp(u.get_hp() + monster.get_atk());
                        text_label.Text += "敵人攻擊\n" + "玩家吸收了" + monster.get_atk().ToString() + "傷害\n";
                        have_shield = false;
                    }
                }
                else if (next > 8 && monster.get_mp() >= 5)
                {
                    monster.set_hp(monster.get_hp() + 20);
                    monster.set_atk(monster.get_atk() + 10);
                    monster.set_mp(monster.get_mp() - 5);
                    text_label.Text += "敵人使用了技能，強化了自己\n";
                }
                else
                {
                    text_label.Text += "敵人沒有魔力了\n";
                }
            }
            print();
        }

        private void skill_button_Click(object sender, EventArgs e)
        {
            if (u.get_mp() >= 5)
            {
                u.skill(ref monster, ref text_label);
                u.set_mp(u.get_mp() - 5);
                if (object.ReferenceEquals(u.GetType(), typeof(tank)))
                    have_shield = true;
            }
            else
            {
                text_label.Text += "玩家沒有魔力了\n";
            }
            monster_attack();
            print();
            if (monster.get_hp() <= 0)
            {
                attack_button.Enabled = false;
                skill_button.Enabled = false;
                continue_button.Enabled = true;
                u.set_hp(u.get_hp() + 30);
                u.set_mp(u.get_mp() + 10);
                text_label.Text += "你贏了，你回復了體力和魔力";
                print();
            }
            else if (u.get_hp() <= 0)
            {
                attack_button.Enabled = false;
                skill_button.Enabled = false;
                continue_button.Enabled = true;
                text_label.Text += "你輸了";
                print();
            }
        }
    }
}
