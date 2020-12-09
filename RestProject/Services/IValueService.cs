using System.Collections.Generic;

namespace RestProject.Services
{
    public interface IValueService
    {
        IDictionary<string, object> Get();
        bool Post(IDictionary<string, object> value);
        bool Put(IDictionary<string, object> value);
        bool Patch(IDictionary<string, object> value);
    }
}
