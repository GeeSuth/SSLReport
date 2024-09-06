using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLReport
{
    public class ItemDto
    {
        public int? Sn { get; set; }

        public string Name { get; set; } = "";
        public string Url { get; set; } = "";
        public bool IsPublic { get; set; }

        public bool ForceWay { get; set; } = false;
        public DateTime? ExpireDate { get; set; }
        public int? ExpireInDays { get; set; }

        public WorkingState WorkingState { get; set; } = WorkingState.None;
        
    }

    public enum WorkingState
    {
        None,
        Running,
        NotUpdate,
        Finish,
        Failed
    }
}
