using System;

namespace SomeExamplesNewVirtual
{
    class DerivedClass : BaseClass   //Child Class
    {
        public new virtual void Method()
        {
            Console.WriteLine("Derived - Method1");
        }


        //public override void Method2()
        //{
        //    Console.WriteLine("Derived - Method2");
        //}


        //public new void Method3()
        //{
        //    Console.WriteLine("Derived - Method3");
        //}
    }
}
