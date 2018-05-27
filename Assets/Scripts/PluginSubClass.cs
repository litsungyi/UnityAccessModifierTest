namespace MainProj
{
    public class PluginSubClass : PluginClass
    {
        public void InvokePublicMethod()
        {
            base.PublicMethod();
        }

        public void InvokeProtectedMethod()
        {
            base.ProtectedMethod();
        }

        //public void InvokeInternalMethod()
        //{
        //    base.InternalMethod();
        //}

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
