namespace SideProj
{
    public class StandardClass
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
            var type = GetType();
            UnityEngine.Debug.Log(string.Format("{0}.{1}.{2}", type.Namespace, type.Name, method));
        }
    }
}
