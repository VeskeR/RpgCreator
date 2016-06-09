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
    public class Character : EntityBase<Character>
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
        [IgnoreDataMember]
        public List<Item> CharacterItems => CharacterItem.Items.Values.Where(ei => ei.Character == this).Select(ei => ei.Item).ToList();
        [IgnoreDataMember]
        public List<Skill> CharacterSkills => CharacterSkill.Items.Values.Where(ei => ei.Character == this).Select(ei => ei.Skill).ToList();

        public Character(string name, string description, int health, CreatureType creatureType)
            :this(name, description, health, creatureType.Id)
        {

        }
        public Character(string name, string description, int health, Guid creatureTypeId)
        {
            Name = name;
            Description = description;
            Health = health;
            _creatureTypeId = creatureTypeId;
        }
    }
}
