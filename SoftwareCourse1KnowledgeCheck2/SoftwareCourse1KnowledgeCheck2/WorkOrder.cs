using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCourse1KnowledgeCheck2
    {
    public class WorkOrder : Vehicle
        {
        public string ClientName { get; set; } = string.Empty;

        public string PresentingIssue { get; set; } = string.Empty;

        }
    }
