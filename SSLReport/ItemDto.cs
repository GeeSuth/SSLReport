using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLReport
{
    public class ItemDto
    {
        public int? Index { get; set; }

        public string Name { get; set; } = "";
        public string Url { get; set; } = "";
        public bool IsPublic { get; set; }

        public bool ForceWay { get; set; } = false;
        public DateTime? ExpireDate { get; set; }
        public double? ExpireInDays => (this.ExpireDate.GetValueOrDefault() - DateTime.Now).TotalDays;

        public WorkingState WorkingState { get; set; } = WorkingState.None;

        public List<string>? AlternativeNames { get; set; }

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
