using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using RpgCreator.DomainModel.Abstract;
using RpgCreator.DomainModel.Relations;

namespace RpgCreator.DomainModel.Concrete
{
    [DataContract]
    public class NPC : EntityBase<NPC>
    {
        [DataMember(Name = "CreatureTypeId")]
        private Guid _creatureTypeId;

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Health { get; set; }

        [IgnoreDataMember]
        public CreatureType CreatureType => CreatureType.Items[_creatureTypeId];

        public NPC(string name, string description, int health, CreatureType creatureType)
            :this(name, description, health, creatureType.Id)
        {

        }
        public NPC(string name, string description, int health, Guid creatureTypeId)
        {
            Name = name;
            Description = description;
            Health = health;
            _creatureTypeId = creatureTypeId;
        }
    }
}
