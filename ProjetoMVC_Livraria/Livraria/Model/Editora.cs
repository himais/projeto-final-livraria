//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Livraria.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Editora
    {
        public Editora()
        {
            this.Livro = new HashSet<Livro>();
        }
    
        public int IdEditora { get; set; }
        public string NomeEditora { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<Livro> Livro { get; set; }
    }
}