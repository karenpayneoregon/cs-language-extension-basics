using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionsTestProject.Classes
{
    public class BaseClass
    {
        protected TestContext TestContextInstance;
        public TestContext TestContext
        {
            get => TestContextInstance;
            set => TestContextInstance = value;
        }
    }
}