namespace DependencyInversionPrincipe
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var relationships = GetRelationships();
            var resercher = new Researcher(relationships);
            resercher.PrintAllChildOf("John");
        }

        private static Relationships GetRelationships()
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Sasha" };
            var child2 = new Person { Name = "Denis" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            return relationships;
        }
    }
}
