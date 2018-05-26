﻿using SampleLibProject;

namespace SampleProject
{
    public class SampleSubLibClass : SampleLibClass
    {
        public void DoPublicMethod()
        {
            base.PublicMethod();
        }

        public void DoProtectedMethod()
        {
            base.ProtectedMethod();
        }

        public void DoInternalMethod()
        {
            base.InternalMethod();
        }

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
