using API;
using System;
using System.Reflection;

namespace Reflect
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("API");
            Type type = assembly.GetType("API.Account",true,false);
            Account account = (Account)Activator.CreateInstance(type);
            //Account account = (Account)assembly.CreateInstance("API.Account");
            //test
            #region 属性反射
            PropertyInfo property = account.GetType().GetProperty("Username");
            if (property != null)
            {
                Console.WriteLine(property.GetValue(account, null));
            }
            else
            {
                Console.WriteLine("");
            }
            #endregion

            #region 方法反射
            MethodInfo method = type.GetMethod("PrintName");
            object kiba = assembly.CreateInstance("API.Account");
            object[] pmts = new object[] { "lufeiyuan" };
            method.Invoke(kiba, pmts);//执行方法 
            #endregion
        }
    }
}
