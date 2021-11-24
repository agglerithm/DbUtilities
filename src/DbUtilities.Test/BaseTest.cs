using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DbUtilities.Test
{
    public abstract class BaseTest
    {
        protected abstract void Arrange();
        protected abstract void Act();
        protected abstract void DoAssert();
    }
}
