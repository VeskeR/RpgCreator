using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCreator.DomainModel.Abstract;
using RpgCreator.DomainModel.Concrete;

namespace RpgCreator.DomainModel.Relations
{
    public class CharacterSkill : EntityBase<CharacterSkill>
    {
        private Guid _characterId;
        private Guid _skillId;

        public Character Character => Character.Items[_characterId];
        public Skill Skill => Skill.Items[_skillId];

        public CharacterSkill(Character character, Skill skill)
            : this(character.Id, skill.Id)
        {

        }
        public CharacterSkill(Guid characterId, Guid skillId)
        {
            _characterId = characterId;
            _skillId = skillId;
        }
    }
}
