using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCreator.DomainModel.Abstract
{
    class ManyToManyResolver<T, K>
        where T : Base<T>
        where K : Base<K>
    {
    }
}
