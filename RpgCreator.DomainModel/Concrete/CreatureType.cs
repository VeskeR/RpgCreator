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
    class CreatureType : EntityBase<CreatureType>
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

        public CreatureType(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
