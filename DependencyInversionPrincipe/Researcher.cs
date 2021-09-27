using System;

namespace DependencyInversionPrincipe
{
    internal partial class Program
    {
        public class Researcher
        {
            private readonly IRelationshipBrowser _browser;
            
            public Researcher(IRelationshipBrowser relationshipBrowser)
            {
                _browser = relationshipBrowser;
            }

            public void PrintAllChildOf(string name)
            {
                foreach (var child in _browser.FindAllChildrenOf(name))
                {
                    Console.WriteLine($"{name} has child called {child.Name}");
                }
            }
        }
    }
}
