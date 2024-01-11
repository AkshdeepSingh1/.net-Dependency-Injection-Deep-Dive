using System;
using DIExplained.Interfaces;

namespace DIExplained.Services
{
	public class KeyedServiceFactory: IKeyedServiceFactory
	{
        private readonly Dictionary<string, Func<IKeyedService>> _serviceFactories;

        public KeyedServiceFactory()
        {
            _serviceFactories = new Dictionary<string, Func<IKeyedService>>
        {
            { "KeyA", () => new KeyedServiceA() },
            { "KeyB", () => new KeyedServiceB() }
        };
        }

        public IKeyedService? GetService(string key)
        {
            if (_serviceFactories.TryGetValue(key, out var factory))
            {
                return factory.Invoke();
            }

            // Handle the case when the service with the specified key is not found
            return null;
        }
    }
}

