using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCollections
{
    abstract class ConsoleApp
    {
        public string Name { get; protected set; }

        public abstract void Run();
    }
}
