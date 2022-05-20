using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExample
{
    
    class BPerson 
    {
        
    }
    class AStudent:BPerson
    {
        public  bool Equals(AStudent obj)
        {
            return true;
        }
        public void MyFun() { }
    }
}
