using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using RpgCreator.DomainModel.Abstract;
using RpgCreator.DomainModel.Relations;

namespace RpgCreator.DomainModel.Concrete
{
    [DataContract]
    public class Skill : EntityBase<Skill>
    {
        [DataMember(Name = "SkillTypeId")]
        private Guid _skillTypeId;

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Cost { get; set; }

        [IgnoreDataMember]
        public SkillType SkillType => SkillType.Items[_skillTypeId];
        [IgnoreDataMember]
        public List<Enemy> Enemies => EnemySkill.Items.Values.Where(ei => ei.Skill == this).Select(ei => ei.Enemy).ToList();

        public Skill(string name, string description, int cost, SkillType skillType)
            :this(name, description, cost, skillType.Id)
        {

        }
        public Skill(string name, string description, int cost, Guid skillType)
        {
            Name = name;
            Description = description;
            Cost = cost;
            _skillTypeId = skillType;
        }
    }
}
