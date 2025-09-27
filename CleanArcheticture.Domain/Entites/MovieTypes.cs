using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcheticture.Domain.Entites
    {
    public class MovieTypes : EntityBase
        {
        public MovieTypes() { }
        public MovieTypes(int Id,string Name)
            {
            this.Id = Id;
            this.Name = Name;
            }
        public string Name { get; set; } = string.Empty;
        }
    }
