using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F74087028_practice_6_2
{
    class warrior : unit
    {
        public warrior(){
            set_hp(100);
            set_mp(15);
            set_atk(20);
        }   

        public override void skill(ref unit monster,ref System.Windows.Forms.Label textbox)
        {
            monster.set_hp(monster.get_hp() - get_atk());
            set_hp(get_hp() + get_atk());
            textbox.Text += "玩家使用了技能，造成且吸收了" + get_atk().ToString() + "傷害\n";
        }
    }
}
