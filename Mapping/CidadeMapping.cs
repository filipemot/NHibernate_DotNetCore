using FluentNHibernate.Mapping;
using NHibernate_DotNetCore.Models;

namespace NHibernate_DotNetCore.Mapping
{
    public class CidadeMapping: ClassMap<Cidade>
    {
        public CidadeMapping()
        {
            Id(l => l.Id);
            Map(l => l.Nome);
            Table("Cidades");
        }
    }
}