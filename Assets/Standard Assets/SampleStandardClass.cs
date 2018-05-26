namespace SampleStandardProject
{
    public class SampleStandardClass
    {
        public void PublicMethod()
        {
            ShowLog("PublicMethod");
        }

        protected void ProtectedMethod()
        {
            ShowLog("ProtectedMethod");
        }

        internal void InternalMethod()
        {
            ShowLog("InternalMethod");
        }

        protected internal void ProtectedInternalMethod()
        {
            ShowLog("ProtectedInternalMethod");
        }

        private void PrivateMethod()
        {
            ShowLog("PrivateMethod");
        }

        [System.Diagnostics.Conditional("ENABLE_LOG")]
        private void ShowLog(string method)
        {
            UnityEngine.Debug.Log(this.GetType().Name + "." + method);
        }
    }
}
