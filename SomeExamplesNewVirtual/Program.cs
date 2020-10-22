using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeExamplesNewVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass baseClass = new BaseClass();
            //baseClass.Method(); //base

            //DerivedClass derivedClass = new DerivedClass();
            //derivedClass.Method();   // base
            //derivedClass.Method1();  //derived

            //BaseClass baseClass1 = new DerivedClass();
            //baseClass1.Method();  //base

            //BaseClass baseClass = new BaseClass();
            //baseClass.Method2(); //base
            //baseClass.Method3(); //base

            //DerivedClass derivedClass = new DerivedClass();
            //derivedClass.Method2(); //derived
            //derivedClass.Method3(); //derived

            //BaseClass baseClass1 = new DerivedClass();
            //baseClass1.Method2(); //derived
            //baseClass1.Method3(); //base

            BaseClass baseClass = new BaseClass();
            baseClass.Method();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();

            DerivedClass2 derivedClass2 = new DerivedClass2();
            derivedClass2.Method();

            BaseClass baseClass1 = new DerivedClass();
            baseClass1.Method();

            DerivedClass derivedClass1 = new DerivedClass2();
            derivedClass1.Method();


        }
    }
}
