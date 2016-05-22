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
    class Enemy : EntityBase<Enemy>
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
        public List<Location> Locations => EnemyLocation.Items.Values.Where(ei => ei.Enemy == this).Select(ei => ei.Location).ToList();
        [IgnoreDataMember]
        public List<Item> EnemyItems => EnemyItem.Items.Values.Where(ei => ei.Enemy == this).Select(ei => ei.Item).ToList();

        public Enemy(string name, string description, int health, CreatureType creatureType)
            :this(name, description, health, creatureType.Id)
        {

        }
        public Enemy(string name, string description, int health, Guid creatureTypeId)
        {
            Name = name;
            Description = description;
            Health = health;
            _creatureTypeId = creatureTypeId;
        }
    }
}
