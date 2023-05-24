using SingletonScopedTransient.BusinessEngine.Interfaces;

namespace SingletonScopedTransient.BusinessEngine.Services
{
    public class MySingletonService : IMySingletonService
    {
        public Guid guidId { get; set; }
        public MySingletonService()
        {
            this.guidId = Guid.NewGuid();
        }
    }
}
