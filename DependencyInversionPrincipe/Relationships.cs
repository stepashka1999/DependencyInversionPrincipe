using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrincipe
{
    internal partial class Program
    {
        public class Relationships : IRelationshipBrowser
        {
            private IList<(Person, Relationship, Person)> relationships = new List<(Person, Relationship, Person)> ();

            public void AddParentAndChild(Person parent, Person child)
            {
                relationships.Add((parent, Relationship.Parent, child));
                relationships.Add((child, Relationship.Child, parent));
            }

            public IEnumerable<Person> FindAllChildrenOf(string name)
            {
                return relationships.Where(r => r.Item1.Name == name
                                                && r.Item2 == Relationship.Parent)
                                    .Select(r => r.Item3);
            }
        }
    }
}
