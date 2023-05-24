using SingletonScopedTransient.BusinessEngine.Interfaces;

namespace SingletonScopedTransient.BusinessEngine.Services
{
    public class MyScopedService : IMyScopedService
    {
        public Guid guidId { get; set; }
        public MyScopedService()
        {
            this.guidId = Guid.NewGuid();
        }
    }
}
