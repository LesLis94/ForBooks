using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes
{
    public class Comic
    {
        public string Name { get; set; }
        public int Issue { get; set; }

        public override string ToString() => $"{Name} (Issue #{Issue})";

        public static readonly IEnumerable<Comic> Catalog =
            new List<Comic>
            {
                new Comic{Name = "Johny", Issue = 6},
                new Comic {Name = "Rock", Issue = 19 },
                new Comic {Name = "Woman", Issue = 7 }
            };

        public static readonly IReadOnlyDictionary<int, decimal> Prices =
            new Dictionary<int, decimal>
            {
                { 6, 360M },
                { 19, 500M },
                { 7, 13525M }
            };
    }
}
