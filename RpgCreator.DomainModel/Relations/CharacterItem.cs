using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCreator.DomainModel.Abstract;
using RpgCreator.DomainModel.Concrete;

namespace RpgCreator.DomainModel.Relations
{
    public class CharacterItem : EntityBase<CharacterItem>
    {
        private Guid _characterId;
        private Guid _itemId;

        public Character Character => Character.Items[_characterId];
        public Item Item => Item.Items[_itemId];

        public CharacterItem(Character character, Item item)
            : this(character.Id, item.Id)
        {

        }
        public CharacterItem(Guid characterId, Guid itemId)
        {
            _characterId = characterId;
            _itemId = itemId;
        }
    }
}
