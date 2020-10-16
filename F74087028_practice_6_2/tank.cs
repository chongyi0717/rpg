using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74087028_practice_6_2
{
    class tank:unit
    {
        public tank()
        {
            set_hp(150);
            set_mp(15);
            set_atk(15);
        }

        public override void skill(ref unit monster, ref Label text_box)
        {
            text_box.Text += "玩家舉起了盾\n";
        }
    }
}
