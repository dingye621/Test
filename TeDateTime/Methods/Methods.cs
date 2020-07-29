using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeDateTime;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;

namespace VS2010TeDate
{
    public partial class Methods
    {

        public Nullable<DateTime> testDate = DateTime.Now; 
        public static int TicketCount = 100;
        readonly static object sync = new object();

        #region 反射
        public static void TeReflection()
        {
            User u = new User();
            PropertyInfo[] prs = u.GetType().GetProperties();
            Console.WriteLine(prs[0].GetCustomAttributes(false).Length);
        }

        public static void TeCustom()
        {
            User u1 = new User() { Uname="tom"};
            UserEx u2 = new UserEx();
            Clone cl = new Clone();
            cl.CloneProperty(u1,u2);
            Console.WriteLine(u2.Uname);
        }

        public static void TeRefelectionMain()
        {
            User user = new User()
            {
                number1 = 1,
                number2 = 2
            };
            TeRefelction<User>(user);
        }

        public static void TeRefelction<T>(T t)
        {
            Type type = t.GetType();
            // Type type = typeof(T);
            var properties = type.GetProperties();
            // foreach (var item in properties)
            // Console.WriteLine("属性名：" + item.PropertyType.Name + "|值：" + item.GetValue(t));
        }
        #endregion

        public static void Teppcc()
        {
            int i = -1;
            i = --i;
            Console.WriteLine(i);
        }
        public static void TeFinally(){

            Console.WriteLine( GetNum());
           
    }

        public static int GetNum()
        {
            int c=-1;
            try
            {
                int a = 1, b = 0;
                 c = a / b;
                return c;
            }
            catch
            {
                c = 8;
                return c;
            }
            finally
            {
                c = 20;
                Console.WriteLine("fil");
            }

        }

        #region 位运算
        public static void TeWei()
        {
            int a = 2;
            Console.WriteLine(a << 2);
            Console.WriteLine(a >> 2);
        }
        
        #endregion
        public static void TestIPP()
        {
            int i = 2;
            int b = i++ + ++i;
            Console.WriteLine(b);
        }

        public static void TestGoto()
        {
            //goto可读性不高，一般不建议使用
        outer: for (int i = 0; i < 5; i++) {
            for (int j = i; j < 5; j++) {
                System.Console.Write("-");
                goto outer;
            }
         
            System.Console.Write("\r\n");
        }
        }
        public static void TeSave2()
        {
            double temp = Math.Round(32.0000d, 2);
            //string temp = string.Format("{0:F2}", 32);
            //string temp = 22.027d.ToString("f2");
            Console.WriteLine(temp);
        }

        #region GUID
        public static void TeGuid()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(Guid.NewGuid().ToString());
            }
        } 
        #endregion

        public static void TeList()
        {
            List<User> userlist = new List<User>();
        }

        public static void TeInterface()
        {
            //IUser context = new UserContext() as IUser;
            //context.SayLoad();

            //User user = new User();
            //user.SayLoad();
        }

        #region 进制转换及其他
        public static void TeDeciaml2x()
        {
            int a = 9;
            string strA = a.ToString("x8");
            Console.WriteLine(strA);
        }
        #endregion

        public static void TestConn()
        {
            string conn = "data source =.;Initial Catalog =dbtest;User ID = sa;Password =123";
            ExecuteSql("insert into TeTime values('123')", conn);
        }

        public static void Testx16()
        {
            int count = 0;
            for (int i = 1; i <= 0x38; i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString, string conn)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        #region 时间类型
        public static void DateTimeToday()
        {
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now.Date);
        }
        public void DateTimeNull()
        {
            testDate.Value.ToString("123");
        }
        public static void TeDateTime2()
        {

            string getTime = "2014";
            DateTime dt = new DateTime();
            bool result = DateTime.TryParse(getTime, out dt);
            if (result) { getTime = dt.ToShortDateString(); }
            Console.WriteLine(getTime);

        }
        public static void TeDefaultDateTime()
        {
            Console.WriteLine(default(DateTime));
        }
        #endregion

        public static Dictionary<string, string> Dic
        {
            get
            {
                var dic = new Dictionary<string, string>();
                dic.Add("a1", "123");
                return dic;
            }
            set { }
        }
        /// <summary>
        /// 方差
        /// </summary>
        public static void Variance()
        {
            //DataTable dt = new DataTable();
            //double num=0;
            //foreach (DataRow row in dt.Rows)
            //{
            //    num += Math.Pow((double)row["a"] - (double)row["avg"], 2);
            //}
            Console.WriteLine(Math.Pow(23, 2));
        }

        public static void NumberOpr()
        {
            int count = 0;
            int number = 4;
            for (int i = 0; i < number - 1; i++)
            {
                for (int j = 1; j <= number - i; j++)
                {
                    for (int k = 1; k <= number; k++)
                    {

                    }
                }
            }

        }

        #region 正则测试
        public static void RegTest()
        {
            string str = "<img style=\"**\" alt=\"**\" src=\"**\"/><img style=\"**\" alt=\"**\" src=\"**\"/>";
            string regex = "(<img.*)src=";

            str = System.Text.RegularExpressions.Regex.Replace(str, @"(<img.*)src=", @"$1 original=");
            Console.WriteLine(str);

        } 
        #endregion

    

        static void TeHashTable()
        {

            Hashtable ht = new Hashtable();

            ht.Add(0, "2");
            //      List < DictionaryEntry> aa= ht.AsQueryable().;
            //   var abc = ((IQueryable<DictionaryEntry>)(ht[0])).
            //  var oo = ((DictionaryEntry)ht[0]).Value;
            Console.WriteLine(ht[0]);

            List<string> a = new List<string>();
            //a.AsQueryable().
            // DictionaryEntry hs = new DictionaryEntry();
            ICollection ab = ht.Values;
            //  a.Select(m=>m+1);


            //   var bba=(IQueryable<string>)ab.AsQueryable();

        }

        #region 多线程
        // static void Main22(string[] args)
        //{
        //    Test(); // 这个方法其实是多余的, 本来可以直接写下面的方法
        //    // await GetName() 
        //    // 但是由于控制台的入口方法不支持async,所有我们在入口方法里面不能 用 await
        //    Console.WriteLine("Current Thread Id :{0}", Thread.CurrentThread.ManagedThreadId);
        //}


        //static async Task Test()
        //{
        //    // 方法打上async关键字，就可以用await调用同样打上async的方法
        //    // await 后面的方法将在另外一个线程中执行
        //    await GetName();
        //}

        //static async Task GetName()
        //{
        //    // Delay 方法来自于.net 4.5
        //    await Task.Delay(1000);  // 返回值前面加 async 之后，方法里面就可以用await了
        //    Console.WriteLine("Current Thread Id :{0}", Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine("In antoher thread.....");
        //}

        //static void Thread2(string[] args)
        //{
        //    new Thread(Go).Start();  // .NET 1.0开始就有的
        //    Task.Factory.StartNew(Go); // .NET 4.0 引入了 TPL
        //    Task.Run(new Action(Go)); // .NET 4.5 新增了一个Run的方法

        //}
        //public static void Go()
        //{
        //    Console.WriteLine("我是另一个线程");
        //}
        //public void ThreadTest()
        //{
        //    Thread thread = new Thread(new ThreadStart(HelloWorld));
        //    thread.Start();
        //}

        public static void TeThread()
        {
            Thread t1 = new Thread(ReduceCount);
            t1.Name = "t1";
            t1.Start();
            Thread t2 = new Thread(ReduceCount);
            t2.Name = "t2";
            t2.Start();
        }

        public static void ReduceCount()
        {
            while (TicketCount > 0)
            {
                lock (sync)
                {
                    TicketCount--;

                    Console.WriteLine("线程名:" + Thread.CurrentThread.Name + " 票数剩余：" + TicketCount);
                }
            }

        }

        public static void TeThreadLocal()
        {
            ThreadLocal<string> threadname = new ThreadLocal<string>(() =>
            {
                return "Thread" + Thread.CurrentThread.ManagedThreadId;
            });
            Action action = () =>
            {
                // If ThreadName.IsValueCreated is true, it means that we are not the
                // first action to run on this thread.
                bool repeat = threadname.IsValueCreated;

                Console.WriteLine("ThreadName = {0} {1}", threadname.Value, repeat ? "(repeat)" : "");
            };
            // Launch eight of them.  On 4 cores or less, you should see some repeat ThreadNames
            Parallel.Invoke(action, action, action, action, action, action, action, action, action);
            // Dispose when you are done
            threadname.Dispose();
        }
        #endregion

        public static void hashcode()
        {
            string a = "11";
            Console.WriteLine(a.GetHashCode());
        }

        #region 字符串操作
        public static void TeConcat()
        {
            string str = string.Concat("2b", "bg2", "world");
            Console.WriteLine(str);
        }
        public static void RemoveSpace()
        {
            string str = "1 2 3";
            Console.WriteLine(str.Replace(" ", null));
        }
        public static void staticasasd()
        {
            string a = "错误：code123";

            string b = a.Substring(a.IndexOf("错误：") + 1);
            Console.WriteLine(b);
        }
        public void KengDie()
        {

            User user = new User() { Uname = "tim", Pwd = null };
            string a = JsonConvert.SerializeObject(user);
            a = a.Replace("null", "\"\"");
            Console.WriteLine(a);
        }
        public static void Xiegang()
        {

            string str = "c\\123";
            str = str.Replace("\\", "\\\\");
            Console.WriteLine(str);
        }
        public void Spchar2()
        {
            string abc = "%%1/\\t2";
            Console.WriteLine("@" + abc);
            Console.WriteLine(double.NegativeInfinity.ToString());
        }
        public void Spchar()
        {
            User usera = new User();
            usera.Uname = "韩";
            Console.WriteLine(usera.Uname);

            string aa = "2|3|";
            string[] list = aa.Split(new char[] { '|' });
            Console.WriteLine(double.PositiveInfinity);

            decimal a = 2.32M;
            Console.WriteLine(a.ToString());
        }

        public void Agent()
        {
            string Name = "12121@126.com";
            Name = Name.Substring(0, Name.IndexOf("@"));

            string temp = "Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Mobile/9B176 MicroMessenger/4.3.2";
            string result = temp.Substring(temp.ToLower().IndexOf("micromessenger") + 15, 1);
            Console.WriteLine(result);
        }
        public static string StringOpr(string str)
        {
            str = str.Substring(str.LastIndexOf(">") + 1);

            return str;
        }
        public void Other()
        {
            string res = GetFileContent("d:/test/122.html");

            //  string tempsp = "@11\\22\\33\\";
            //    string[] stringlist = tempsp.Split(new char[] { '/' });

            // TimeSpan ts = DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            //Console.WriteLine(Convert.ToInt64(ts.TotalSeconds).ToString());  

            string html = "<strong>编号：</strong>L2.673.4.78.3";

            string html2 = StringOpr(html);






            /*
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i % 10 == 0)
                {
                    System.Threading.Thread.Sleep(1000);
                }
            }
             */
        }
        #endregion

        #region Linq
        public void TaLinqExpression()
        {
            User newuser = new User() { Uname = "tom", Pwd = "123" };
            Func<User, bool> exc = m => m.Uname == "tom";
            Predicate<User> exc3 = m => m.Uname == "tom";
            Expression<Func<User, bool>> exc1 = m => m.Uname == "tom";

            List<User> ulist = new List<User>();
            ulist.FindAll(exc3);
        }
        public void TaLinq()
        {
            DataTable dt = new DataTable();
            List<User> userlist = new List<User>();
            var quary = from u in userlist
                        where u.Uname == "a3"
                        select u;
            userlist.Add(new User() { Uname = "12", Pwd = "123" });
            userlist.Add(new User() { Uname = "13", Pwd = "124" });
            userlist.FindAll(m => m.Uname == "12").ForEach(m => m.Pwd = "123456");

        }
        public void Linqtest()
        {
            List<User> userlist = new List<User>();
            userlist.Add(new User() { Pwd = "123", Uname = "aaa" });
            userlist.Add(new User() { Pwd = "123", Uname = "aaa" });
            userlist.Add(new User() { Pwd = "123", Uname = "aaa" });
            userlist.Add(new User() { Pwd = "123", Uname = "aaa" });
            userlist.Add(new User() { Pwd = "124", Uname = "aaa" });

            var templist = from r in userlist select r;

            // var newtemp = templist.DistinctBy(p => new { p.Pwd, p.Uname });
            var newtemp = templist.Select(m => m.Pwd).Distinct();
            foreach (string temp in newtemp)
            {
                Console.WriteLine(temp);
            }
        }
        #endregion
        public void TPro()
        {
            int? dad = null;
            Console.WriteLine(dad.ToString());
        }
        #region 枚举
        public static void TEnum()
        {
            string aa = Enum.GetName(typeof(TestEnum), 1);
            Console.WriteLine(aa);
        } 
        #endregion

        public struct Channel
        {
            public const string Online = "Online";

            public const string H5 = "H5";

            public const string Hybrid = "Hybrid";
        }

        public static void HelloWorld()
        {
            byte[] a = System.Text.Encoding.Default.GetBytes("abc王二");
            Console.WriteLine(System.Text.Encoding.Default.GetBytes("王二").Count());
        }

        public static void Bytes()
        {
            Console.WriteLine(System.Text.Encoding.Default.GetBytes("王二"));
        }

        public static string GetFileContent(string strPath)
        {
            string strContent = "";
            System.IO.FileStream fw = null;
            try
            {
                fw = new System.IO.FileStream(strPath, System.IO.FileMode.Open);
                byte[] b = new byte[fw.Length + 1];
                fw.Read(b, 0, 1 + (int)fw.Length);
                strContent = System.Text.Encoding.Default.GetString(b);
            }
            catch (Exception)
            {
                //
            }
            if (fw != null) fw.Close();
            return strContent;
        }

        #region 日期操作
        public static void TeDate()
        {
            var date = DateTime.Now.ToLongTimeString();
            DateTime a = DateTime.Now;
            DateTime b = DateTime.Now.AddDays(1);
            TimeSpan ts = b - a;
            Console.WriteLine(a.AddMilliseconds(ts.TotalMilliseconds));
        }

        public void TestDate()
        {
            Console.WriteLine(DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"));

            DateTime dt = Convert.ToDateTime("2011-02-03");
            DateTime dt2 = Convert.ToDateTime("2011-02-02");
            TimeSpan sp = dt - dt2;

            Console.WriteLine(sp.TotalSeconds);
        }
        #endregion

        public void Users()
        {
            List<User> userlist = new List<User>();
            User usera = new User()
            {
                Uname = "张三",
                Pwd = "123"
            };
            User userb = new User()
            {
                Uname = "李四",
                Pwd = "234"
            };
            userlist.Add(usera);
            userlist.Add(userb);

            List<User> userlist2 = userlist;


            User vipusera = new VipUser()
            {
                Uname = "王老五",
                Pwd = "233"
            };
            vipusera.Say();

        }

        #region 随机数
        public static void TestRandom()
        {
            Random rd = new Random();
            for (int i = 1; i <= 10; i++)
            {          
                Console.WriteLine(rd.Next(100));
            }
        }

        /// <summary>
        /// 获取随机数种子
        /// </summary>
        /// <returns></returns>
        private static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);

            return BitConverter.ToInt32(bytes, 0);
        }

        public static void TestCrypt()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(GetRandomSeed());
            }
        } 
        #endregion
    }
}
