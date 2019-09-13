using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Framework.Interface
{
    public interface IEmail<T>
    {
        T Text { get; set; }

        T YourEmail { get; set; }
        T YourPassword { get; set; }
        T FreindEmail { get; set; }
        void Send();

    }
}
