using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPatternWFDEMO
{
    public class Van : Subject
    {
        public override string DoSomeWork()
        {
            return "Toi dang lam van";
        }
    }
}
