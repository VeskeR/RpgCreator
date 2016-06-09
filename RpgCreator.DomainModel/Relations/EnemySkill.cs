using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCreator.DomainModel.Abstract;
using RpgCreator.DomainModel.Concrete;

namespace RpgCreator.DomainModel.Relations
{
    public class EnemySkill : EntityBase<EnemySkill>
    {
        private Guid _enemyId;
        private Guid _skillId;

        public Enemy Enemy => Enemy.Items[_enemyId];
        public Skill Skill => Skill.Items[_skillId];

        public EnemySkill(Enemy enemy, Skill skill)
            : this(enemy.Id, skill.Id)
        {

        }
        public EnemySkill(Guid enemyId, Guid skillId)
        {
            _enemyId = enemyId;
            _skillId = skillId;
        }
    }
}
