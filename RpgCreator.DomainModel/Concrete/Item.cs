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
    class Item : EntityBase<Item>
    {
        [DataMember(Name = "ItemTypeId")]
        private Guid _itemTypeId;

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Value { get; set; }

        [IgnoreDataMember]
        public ItemType ItemType => ItemType.Items[_itemTypeId];

        public Item(string name, string description, int value, ItemType itemType)
            :this(name, description, value, itemType.Id)
        {
            
        }
        public Item(string name, string description, int value, Guid itemTypeId)
        {
            Name = name;
            Description = description;
            Value = value;
            _itemTypeId = itemTypeId;
        }
    }
}
