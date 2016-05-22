using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCreator.DomainModel.Abstract;
using RpgCreator.DomainModel.Concrete;

namespace RpgCreator.DomainModel.Relations
{
    class EnemyLocation : EntityBase<EnemyLocation>
    {
        private Guid _enemyId;
        private Guid _locationId;

        public Enemy Enemy => Enemy.Items[_enemyId];
        public Location Location => Location.Items[_locationId];

        public EnemyLocation(Enemy enemy, Location location)
            : this(enemy.Id, location.Id)
        {

        }
        public EnemyLocation(Guid enemyId, Guid locationId)
        {
            _enemyId = enemyId;
            _locationId = locationId;
        }
    }
}
