using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCreator.DomainModel.Abstract
{
	abstract class Base<T> where T : Base<T>
	{
		public Guid Id { get; }

	    protected Base()
		{
			Id = Guid.NewGuid();
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			return GetHashCode() == obj.GetHashCode();
		}
	}
}
