using Pri.Oe.WebApi.Music.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.WebApi.Music.Core.Services.Models
{
    public class ItemResultModel<T> where T : BaseEntity
    {
        public IEnumerable<T> Items { get; set; }
        public string Error { get; set; }
    }
}
