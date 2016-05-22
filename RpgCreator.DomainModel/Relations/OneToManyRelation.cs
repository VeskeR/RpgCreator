using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCreator.DomainModel.Abstract;

namespace RpgCreator.DomainModel.Relations
{
    class OneToManyRelation<TOne, TMany>
        where TOne : Base<TOne>
        where TMany : Base<TMany>
    {
    }
}
