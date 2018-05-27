using SideProj;
using UnityEngine;

namespace MainProj
{
    public class Main : MonoBehaviour
    {
        public void Start()
        {
            TestMainClass();
            TestLibClass();
            TestPluginClass();
            TestStandardClass();

            TestSubClass();
            TestLibSubClass();
            TestPluginSubClass();
            TestStandardSubClass();
        }

        private void TestMainClass()
        {
            var instance = new MainClass();
            instance.PublicMethod();
#warning Cannot call protected method from not derived class in same namespace and same assembly
            //instance.ProtectedMethod();
            instance.InternalMethod();
            instance.ProtectedInternalMethod();
#warning Cannot call private method from any class in same namespace and same assembly
            //instance.PrivateMethod();
        }

        private void TestLibClass()
        {
            var instance = new LibClass();
            instance.PublicMethod();
#warning Cannot call protected method from not derived class in different namespace but same assembly
            //instance.ProtectedMethod();
            instance.InternalMethod();
            instance.ProtectedInternalMethod();
#warning Cannot call private method from any class in different namespace but same assembly
            //instance.PrivateMethod();
        }

        private void TestPluginClass()
        {
            var instance = new PluginClass();
            instance.PublicMethod();
#warning Cannot call protected method from not derived class in same namespace but different assembly
            //instance.ProtectedMethod();
#warning Cannot call internal method from any class in same namespace but different assembly
            //instance.InternalMethod();
#warning Cannot call protected internal method from not derived class in same namespace but different assembly
            //instance.ProtectedInternalMethod();
#warning Cannot call private method from any class in same namespace but different assembly
            //instance.PrivateMethod();
        }

        private void TestStandardClass()
        {
            var instance = new StandardClass();
            instance.PublicMethod();
#warning Cannot call protected method from not derived class in different namespace and different assembly
            //instance.ProtectedMethod();
#warning Cannot call internal method from any class in different namespace and different assembly
            //instance.InternalMethod();
#warning Cannot call protected internal method from not derived class in different namespace and different assembly
            //instance.ProtectedInternalMethod();
#warning Cannot call private method from any class in different namespace and different assembly
            //instance.PrivateMethod();
        }

        private void TestSubClass()
        {
            var instance = new MainSubClass();
            instance.InvokePublicMethod();
            instance.InvokeProtectedMethod();
            instance.InvokeInternalMethod();
            instance.InvokeProtectedInternalMethod();
#warning Cannot call private method from any class in different namespace and different assembly
            //instance.InvokePrivateMethod();
        }

        private void TestLibSubClass()
        {
            var instance = new LibSubClass();
            instance.InvokePublicMethod();
            instance.InvokeProtectedMethod();
            instance.InvokeInternalMethod();
            instance.InvokeProtectedInternalMethod();
#warning Cannot call private method from any class in different namespace and different assembly
            //instance.InvokePrivateMethod();
        }

        private void TestPluginSubClass()
        {
            var instance = new PluginSubClass();
            instance.InvokePublicMethod();
            instance.InvokeProtectedMethod();
#warning Cannot call internal method from any class in different namespace and different assembly
            //instance.InvokeInternalMethod();
            instance.InvokeProtectedInternalMethod();
#warning Cannot call private method from any class in different namespace and different assembly
            //instance.InvokePrivateMethod();
        }

        private void TestStandardSubClass()
        {
            var instance = new StandardSubClass();
            instance.InvokePublicMethod();
            instance.InvokeProtectedMethod();
#warning Cannot call internal method from any class in different namespace and different assembly
            //instance.InvokeInternalMethod();
            instance.InvokeProtectedInternalMethod();
#warning Cannot call private method from any class in different namespace and different assembly
            //instance.InvokePrivateMethod();
        }
    }
}
