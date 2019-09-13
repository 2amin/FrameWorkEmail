using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ClassLibrary1.LifeCycle
{
   public class Email<T> : Framework.Base.EmailBase<T>
    {
        #region [-Ctor-]
        public Email():base()
        {

        }
        public Email(T text, T youremail, T yourpassword, T freindemail) : base(text, youremail, yourpassword, freindemail)
        {
        }
        public Email(T youremail, T yourpassword, T freindemail) : base(youremail, yourpassword, freindemail)
        {
        }
        public Email(T youremail, T yourpassword):base(youremail,yourpassword)
        {
        }
        public Email(T freindemail):base(freindemail)
        {

        }

        #endregion
    }
}
