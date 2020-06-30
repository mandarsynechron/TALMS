using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class FeedBackQuestion : AuditableEntity
    {
        public int FeedBackQuestionId { get; set; }
        public int? FeedBackId { get; set; }
        public int? QuestionsId { get; set; }
        public int? Score { get; set; }

        public virtual Questions Questions { get; set; }
    }
}
