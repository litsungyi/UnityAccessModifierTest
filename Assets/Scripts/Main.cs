using SampleLibProject;
using SampleStandardProject;
using UnityEngine;

namespace SampleProject
{
    public class Main : MonoBehaviour
    {
        public void Start()
        {
            TestSampleClass();
            TestSampleLibClass();
            TestSamplePluginClass();
            TestSampleStandardClass();

            TestSampleSubClass();
            TestSampleSubLibClass();
            TestSampleSubPluginClass();
            TestSampleSubStandardClass();
        }

        private void TestSampleClass()
        {
            var sampleClass = new SampleClass();
            sampleClass.PublicMethod();
#if COMPILE_ERROR
            sampleClass.ProtectedMethod();
#endif
            sampleClass.ProtectedInternalMethod();
            sampleClass.InternalMethod();
#if COMPILE_ERROR
            sampleClass.PrivateMethod();
#endif
        }

        private void TestSampleLibClass()
        {
            var sampleLibClass = new SampleLibClass();
            sampleLibClass.PublicMethod();
#if COMPILE_ERROR
            sampleLibClass.ProtectedMethod();
#endif
            sampleLibClass.ProtectedInternalMethod();
            sampleLibClass.InternalMethod();
#if COMPILE_ERROR
            sampleLibClass.PrivateMethod();
#endif
        }

        private void TestSamplePluginClass()
        {
            var samplePluginClass = new SamplePluginClass();
            samplePluginClass.PublicMethod();
#if COMPILE_ERROR
            samplePluginClass.ProtectedMethod();
            samplePluginClass.ProtectedInternalMethod();
            samplePluginClass.InternalMethod();
            samplePluginClass.PrivateMethod();
#endif
        }

        private void TestSampleStandardClass()
        {
            var sampleStandardClass = new SampleStandardClass();
            sampleStandardClass.PublicMethod();
#if COMPILE_ERROR
            sampleStandardClass.ProtectedMethod();
            sampleStandardClass.ProtectedInternalMethod();
            sampleStandardClass.InternalMethod();
            sampleStandardClass.PrivateMethod();
#endif
        }

        private void TestSampleSubClass()
        {
            var sampleSubClass = new SampleSubClass();
            sampleSubClass.DoPublicMethod();
            sampleSubClass.DoProtectedMethod();
            sampleSubClass.DoProtectedInternalMethod();
            sampleSubClass.DoInternalMethod();
#if COMPILE_ERROR
            sampleSubClass.DoPrivateMethod();
#endif
        }

        private void TestSampleSubLibClass()
        {
            var sampleSubLibClass = new SampleSubLibClass();
            sampleSubLibClass.DoPublicMethod();
            sampleSubLibClass.DoProtectedMethod();
            sampleSubLibClass.DoProtectedInternalMethod();
            sampleSubLibClass.DoInternalMethod();
#if COMPILE_ERROR
            sampleSubLibClass.DoPrivateMethod();
#endif
        }

        private void TestSampleSubPluginClass()
        {
            var sampleSubPluginClass = new SampleSubPluginClass();
            sampleSubPluginClass.DoPublicMethod();
            sampleSubPluginClass.DoProtectedMethod();
            sampleSubPluginClass.DoProtectedInternalMethod();
#if COMPILE_ERROR
            sampleSubPluginClass.DoInternalMethod();
            sampleSubPluginClass.DoPrivateMethod();
#endif
        }

        private void TestSampleSubStandardClass()
        {
            var sampleSubStandardClass = new SampleSubStandardClass();
            sampleSubStandardClass.DoPublicMethod();
            sampleSubStandardClass.DoProtectedMethod();
            sampleSubStandardClass.DoProtectedInternalMethod();
#if COMPILE_ERROR
            sampleSubStandardClass.DoInternalMethod();
            sampleSubStandardClass.DoPrivateMethod();
#endif
        }
    }
}
