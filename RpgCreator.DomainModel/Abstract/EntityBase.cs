using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RpgCreator.DomainModel.Abstract
{
	abstract class EntityBase<T> where T : EntityBase<T>
	{
        [IgnoreDataMember]
        public static readonly Dictionary<Guid, T> Items = new Dictionary<Guid, T>();
        [DataMember]
        public Guid Id { get; private set; }
        [DataMember]
        public DateTime CreationTime { get; private set; }

	    protected EntityBase()
        {
            Id = Guid.NewGuid();
            Items.Add(Id, (T)this);
            CreationTime = DateTime.Now;
        }
    }
}
