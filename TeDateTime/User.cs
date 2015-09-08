using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeDateTime
{
    public class User:IPerson
    {
        public int number1 { get; set; }
        public int number2 { get; set; }

        //private string _uname;
        //public string Uname
        //{
        //    get { return _uname + "11"; }

        //    set { _uname = value + "22"; }
        //}

        public string Uname { get; set; }

        public string Pwd{ get; set; }

        public virtual void Say()
        {
            Console.WriteLine(this.Uname+"说：你好");
        }

        public string GetName()
        {
            return this.Uname;
        }
    }

    public class UserEx : IPerson
    {
        public int number1 { get; set; }
        public int number2 { get; set; }

        //private string _uname;
        //public string Uname
        //{
        //    get { return _uname + "11"; }

        //    set { _uname = value + "22"; }
        //}

        public string Uname { get; set; }

        public string PwdEx { get; set; }

        public virtual void Say()
        {
            Console.WriteLine(this.Uname + "说：你好");
        }

        public string GetName()
        {
            return this.Uname;
        }
    }
}
