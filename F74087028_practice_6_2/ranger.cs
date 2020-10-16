using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74087028_practice_6_2
{
    class ranger:unit
    {
        public ranger()
        {
            set_hp(80);
            set_mp(20);
            set_atk(25);
        }
        public override void skill(ref unit monster, ref Label text_box)
        {
            monster.set_hp(monster.get_hp() - 2 * get_atk());
            text_box.Text += "玩家使用了技能\n"+"敵人受到"+(2*get_atk()).ToString()+"傷害\n";
        }
    }
}
