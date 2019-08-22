using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomethingResearchApi.Models
{
    public class ExampleMapping
    {
        private List<ParentModel> parentModels = new List<ParentModel>
        {
            new ParentModel {
                Id = 1,
                Name = "parent1"
            },
            new ParentModel {
                Id = 2,
                Name = "parent2"
            },
            new ParentModel {
                Id = 3,
                Name = "parent3"
            }
        };

        private List<ChlidModel> chlidModels = new List<ChlidModel>
        {
            new ChlidModel {
                Id = 1,
                Name = "child1",
                ParentId = 1
            },
            new ChlidModel {
                Id = 2,
                Name = "child2",
                ParentId = 1
            },
            new ChlidModel {
                Id = 3,
                Name = "child3",
                ParentId = 1
            },
            new ChlidModel {
                Id = 4,
                Name = "child4",
                ParentId = 2
            },
            new ChlidModel {
                Id = 5,
                Name = "child5",
                ParentId = 1
            },
            new ChlidModel {
                Id = 6,
                Name = "child6",
                ParentId = 2
            },
            new ChlidModel {
                Id = 7,
                Name = "child7",
                ParentId = 3
            },
            new ChlidModel {
                Id = 8,
                Name = "child8",
                ParentId = 3
            },
            new ChlidModel {
                Id = 9,
                Name = "child9",
                ParentId = 3
            },
            new ChlidModel {
                Id = 10,
                Name = "child10",
                ParentId = 3
            },
            new ChlidModel {
                Id = 11,
                Name = "child11",
                ParentId = 1
            },
        };

        public List<ParentModel> MapingChildToParent()
        {
            // var query = someList.Select(x => { x.SomeProp = "foo"; return x; })
            var query2 = parentModels.Select(x => { x.ChlidModels = chlidModels.Where(y => y.ParentId == x.Id).ToList(); return x; }).ToList();

            return new List<ParentModel>();
        }
    }

    public class ParentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ChlidModel> ChlidModels { get; set; }
    }

    public class ChlidModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}
