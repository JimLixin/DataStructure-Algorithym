using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 工厂方法(Factory Method)
/// </summary>
namespace Algorithym.LeetCode.设计模式
{
    public class ProgrammingLanguage
    {
        public ProgrammingLanguage()
        { 
            
        }

        public string Name { get; set; }
    }

    public class CSharp: ProgrammingLanguage
    {
        public CSharp()
        { 
        
        }
    }

    public class Java: ProgrammingLanguage
    {
        public Java()
        { 
        
        }
    }

    public class Python: ProgrammingLanguage
    {
        public Python()
        { 
        
        }
    }

    public enum LanguageType
    { 
        CSharp,
        Java,
        Python
    }

    public class ProgrammingLanguages
    {
        public static ProgrammingLanguage Create(LanguageType type)
        {
            switch (type)
            {
                default:
                case LanguageType.CSharp:
                    return new CSharp();
                case LanguageType.Java:
                    return new Java();
                case LanguageType.Python:
                    return new Python();
            }
        }
    }
}
