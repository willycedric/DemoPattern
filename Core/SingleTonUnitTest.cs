using NUnit.Framework;
using FluentAssertions;
using System;

namespace FluentPageObjectPattern.Core
{
    [TestFixture]
    class SingleTonUnitTest
    {
        [TestCase]
        public void IsInstanceAreTheSame()
        {
            ThreadSafeNestedContructorsBaseSingleton<PoliCy>.Instance.Should().BeSameAs(ThreadSafeNestedContructorsBaseSingleton<PoliCy>.Instance);
        }
    }

    class PoliCy
    {

        public PoliCy()
        {
            Console.WriteLine("A new Policy is created.");
        }
    }
}
