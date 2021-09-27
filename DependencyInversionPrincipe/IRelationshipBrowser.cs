using System.Collections.Generic;

namespace DependencyInversionPrincipe
{
    internal partial class Program
    {
        public interface IRelationshipBrowser
        {
            IEnumerable<Person> FindAllChildrenOf(string name);
        }
    }
}
