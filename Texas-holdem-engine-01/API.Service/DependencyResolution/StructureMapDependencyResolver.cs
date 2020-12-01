using System;
using System.Web.Http.Dependencies;
using StructureMap;

namespace API.Service.DependencyResolution
{
    public class StructureMapDependencyResolver : StructureMapApiScope, IDependencyResolver
    {
        private readonly IContainer _container;
        public StructureMapDependencyResolver(IContainer container) : base(container)
        {
            _container = container ??
                         throw new ArgumentException(nameof(container));
        }
        public IDependencyScope BeginScope()
        {
            var childContainer = _container.GetNestedContainer();
            return new StructureMapApiScope(childContainer);
        }
    }
}