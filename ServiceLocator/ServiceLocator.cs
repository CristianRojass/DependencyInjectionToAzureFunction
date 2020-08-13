using System;
using System.Collections.Generic;

namespace Azure_Function.ServiceLocator {

    public class ServiceLocator : IServiceLocator{

        public Dictionary<object, object> serviceContainer = null;

        public ServiceLocator() {
            serviceContainer = new Dictionary<object, object>();
        }

        public T GetService<T>() {
            try {
                return (T)serviceContainer[typeof(T)];
            }
            catch (Exception) {
                throw new NotImplementedException("Servicio no disponible.");
            }
        }

        public void RegisterService<Interface, Implementation>() {
            serviceContainer.Add(typeof(Interface), (Implementation)Activator.CreateInstance(typeof(Implementation)));
        }

    }

}