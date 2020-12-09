using System.Collections.Generic;

namespace RestProject.Services
{
    class ValueService : IValueService
    {
        public IDictionary<string, object> Get()
        {
            return Storage.Get();
        }

        public bool Post(IDictionary<string, object> value)
        {
            if (Storage.IsCreated)
            {
                return false;
            }
            Storage.Set(value);

            return true;
        }

        public bool Put(IDictionary<string, object> value)
        {
            if (!Storage.IsCreated)
            {
                return false;
            }
            Storage.Set(value);

            return true;
        }

        public bool Patch(IDictionary<string, object> value)
        {
            if (!Storage.IsCreated)
            {
                return false;
            }
            Storage.Update(value);

            return true;
        }
    }
}
