using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeDateTime
{
    public class VipUser:User
    {
        public override void Say()
        {
            Console.WriteLine(this.Uname + "diaodiao地说：你好！");
            base.Say();
        }
    }
}
