using Dependencies.Interfaces;

namespace Dependencies.Implements {

    public class Animal : IAnimal {

        public string GetSpecie() => GetType().Name;

    }

}