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
    public class Location : EntityBase<Location>
    {
        [DataMember(Name = "GameId")]
        private Guid _gameId;

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

        [IgnoreDataMember]
        public Game Game => Game.Items[_gameId];
        [IgnoreDataMember]
        public List<Enemy> Enemies => EnemyLocation.Items.Values.Where(ei => ei.Location == this).Select(ei => ei.Enemy).ToList();

        public Location(string name, string description, Game game)
            :this(name, description, game.Id)
        {
            
        }
        public Location(string name, string description, Guid gameId)
        {
            Name = name;
            Description = description;
            _gameId = gameId;
        }
    }
}
