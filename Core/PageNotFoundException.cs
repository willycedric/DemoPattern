using System;
using System.Runtime.Serialization;

namespace DemoPattern.Core
{
    [Serializable]
    internal class PageObjectNotFoundException : Exception
    {
       

        public PageObjectNotFoundException(string message) : base(message)
        {
        }

       
    }
}