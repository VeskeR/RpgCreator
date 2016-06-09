using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using RpgCreator.DomainModel.Abstract;

namespace RpgCreator.DomainModel.Concrete
{
    [DataContract]
    public class Game : EntityBase<Game>
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Author { get; set; }

        [IgnoreDataMember]
        public List<Location> Locations => Location.Items.Values.Where(l => l.Game == this).ToList();

        public Game(string name, string description, string author)
        {
            Name = name;
            Description = description;
            Author = author;
        }
    }
}
