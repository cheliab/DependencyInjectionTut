namespace Tut_06_DI_MethodInjection
{
    public interface IDataAccessDependency
    {
        void SetDependency(ICustomerDataAccess customerDataAccess);
    }
}