using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DotNetConsoleDiExample.Entities
{
    public class EventoModel
    {
        [Key]
        public int EventoId { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInclusao { get; set; }
        public bool Avisar { get; set; }
    }
}
