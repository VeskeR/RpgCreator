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
    public class ItemType : EntityBase<ItemType>
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

        public ItemType(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
