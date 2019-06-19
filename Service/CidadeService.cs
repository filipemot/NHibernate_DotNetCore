using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate_DotNetCore.Models;

namespace NHibernate_DotNetCore.Service
{
    public class CidadeService
    {
        private readonly ISession session;

        public CidadeService(ISession session){
            this.session = session;
        }

        public List<Cidade> getCidades(){
            return this.session.Query<Cidade>().ToList();
        }
    }
}