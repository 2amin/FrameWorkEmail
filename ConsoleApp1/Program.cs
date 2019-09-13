using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
          
            ClassLibrary1.LifeCycle.Email<string>  email = new ClassLibrary1.LifeCycle.Email<string>( "aminnabavi859@gmail.com", "alifati2", "rezatabayic@gmail.com");
           
            email.Send();
        }
    }
}
