namespace Azure_Function.ServiceLocator {

    public interface IServiceLocator {
        T GetService<T>();
    }

}