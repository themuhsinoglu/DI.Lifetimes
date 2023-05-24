using SingletonScopedTransient.BusinessEngine.Interfaces;

namespace SingletonScopedTransient.BusinessEngine.Services
{
    public class MyTransientService : IMyTransientService
    {
        public Guid guidId { get; set; }
        public MyTransientService()
        {
            this.guidId = Guid.NewGuid();
        }
    }
}
