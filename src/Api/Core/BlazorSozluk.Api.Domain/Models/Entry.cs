using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Api.Domain.Models
{
    public class Entry : BaseEntity
    {
        public string Subject { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual ICollection<EntryComment> EntryComments { get; set; }
       
    }
}
