using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class Questions : AuditableEntityWithActiveFlag
    {
        public Questions()
        {
            FeedBackQuestion = new HashSet<FeedBackQuestion>();
        }

        public int QuestionsId { get; set; }
        public string QuestionsName { get; set; }

        public virtual ICollection<FeedBackQuestion> FeedBackQuestion { get; set; }
    }
}
