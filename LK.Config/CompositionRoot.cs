using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LK.BL.BusinessService;
using LK.BL.DataAccsess;
using LK.BL.DomainModel;



namespace LK.Config
{
    public class CompositionRoot
    {
       /* public BusinessService root { get; private set; }
        public void BuildApplication()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SQLDAController>().As<SQLDAController>();
          

            var container = builder.Build();
            root = container.Resolve<IBusinessService>();
        }*/
    }
}
