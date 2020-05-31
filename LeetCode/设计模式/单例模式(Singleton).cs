using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 单例模式(Singleton)
/// </summary>
namespace Algorithym.LeetCode.设计模式
{
    public class Singleton
    {
        private static Singleton instance = null;
        private Singleton()
        { 
        
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
