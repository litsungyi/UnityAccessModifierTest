namespace SampleProject
{
    public class SampleSubPluginClass : SamplePluginClass
    {
        public void DoPublicMethod()
        {
            base.PublicMethod();
        }

        public void DoProtectedMethod()
        {
            base.ProtectedMethod();
        }

#if COMPILE_ERROR
        public void DoInternalMethod()
        {
            base.InternalMethod();
        }
#endif

        public void DoProtectedInternalMethod()
        {
            base.ProtectedInternalMethod();
        }

#if COMPILE_ERROR
        public void DoPrivateMethod()
        {
            base.PrivateMethod();
        }
#endif
    }
}
