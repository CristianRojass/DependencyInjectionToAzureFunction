using Dependencies.Implements;
using Dependencies.Interfaces;
using Azure_Function.ServiceLocator;

namespace Dependencies.Environments {

    public class Development : ServiceLocator {

        public Development() : base () {
            RegisterService<IAnimal,Gato>();
        }

    }

}