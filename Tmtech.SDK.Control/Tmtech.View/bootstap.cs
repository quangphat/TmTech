using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmtech.Business;

namespace Tmtech.View
{
    public class Bootstap
    {
        public ContainerBuilder container;
        public IContainer icontainer;
        public Bootstap()
        {
            container = new ContainerBuilder();
            new Resolve(container);
            icontainer = container.Build();
       
        }
        private static Bootstap _bootstrap;
        public static IContainer Regiter
        {
            get
            {
                if (_bootstrap == null)
                {
                    _bootstrap = new Bootstap();
                    return _bootstrap.icontainer;
                }
                else
                {
                    return _bootstrap.icontainer;
                }
            }
        }
    }
}
