using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F74087028_practice_6_2
{
    abstract class unit
    {
        private int hp;
        private int mp;
        private int atk;
        public void set_hp(int number) {
            hp = number;
        }
        public int get_hp()
        {
            return hp;
        }
        public void set_mp(int number)
        {
            mp = number;
        }
        public int get_mp()
        {
            return mp;
        }
        public void set_atk(int number)
        {
            atk = number;
        }
        public int get_atk()
        {
            return atk;
        }

        public virtual void skill(ref unit monster,ref System.Windows.Forms.Label text_box)
        { }

      
    }
}
