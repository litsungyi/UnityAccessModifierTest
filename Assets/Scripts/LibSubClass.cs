using SideProj;

namespace MainProj
{
    public class LibSubClass : LibClass
    {
        public void InvokePublicMethod()
        {
            base.PublicMethod();
        }

        public void InvokeProtectedMethod()
        {
            base.ProtectedMethod();
        }

        public void InvokeInternalMethod()
        {
            base.InternalMethod();
        }

        public void InvokeProtectedInternalMethod()
        {
            base.ProtectedInternalMethod();
        }

        //public void InvokePrivateMethod()
        //{
        //    base.PrivateMethod();
        //}
    }
}
