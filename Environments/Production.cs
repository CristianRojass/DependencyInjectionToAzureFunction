using Dependencies.Implements;
using Dependencies.Interfaces;
using Azure_Function.ServiceLocator;

namespace Dependencies.Environments {

    public class Production : ServiceLocator {

        public Production() : base () {
            RegisterService<IAnimal,Perro>();
        }
        
    }

}