using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCreator.DomainModel.Abstract;
using RpgCreator.DomainModel.Concrete;

namespace RpgCreator.DomainModel.Relations
{
    class EnemyItem : EntityBase<EnemyItem>
    {
        private Guid _enemyId;
        private Guid _itemId;

        public Enemy Enemy => Enemy.Items[_enemyId];
        public Item Item => Item.Items[_itemId];

        public EnemyItem(Enemy enemy, Item item)
            : this(enemy.Id, item.Id)
        {

        }
        public EnemyItem(Guid enemyId, Guid itemId)
        {
            _enemyId = enemyId;
            _itemId = itemId;
        }
    }
}
