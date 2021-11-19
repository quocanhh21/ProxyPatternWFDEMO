using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPatternWFDEMO
{
    public class Proxy : Subject
    {
        Subject subject;
        public Proxy()
        {
            subject = null;
        }
        public Proxy(Subject subject)
        {
            this.subject = subject;
        }
        public override string DoSomeWork()
        {
            string t = "XIn chao ban";

            if (subject == null)
            {
                subject = new TOan();
            }

            return t + "\n" + subject.DoSomeWork();
        }
    }
}
