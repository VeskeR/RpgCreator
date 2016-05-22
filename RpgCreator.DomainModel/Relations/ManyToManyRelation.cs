using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCreator.DomainModel.Abstract;

namespace RpgCreator.DomainModel.Relations
{
    class ManyToManyRelation<T, K>
        where T : Base<T>
        where K : Base<K>
    {
    }
}
