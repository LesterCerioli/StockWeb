using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock.Web.Models.Domain
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public virtual List<PerfilModel> PerfilModels { get; set; }
    }
}