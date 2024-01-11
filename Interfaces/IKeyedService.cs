using System;
namespace DIExplained.Interfaces
{
	public interface IKeyedService
	{
        public string PerformKeyedAction();
    }

    public interface IKeyedServiceFactory
    {
        IKeyedService GetService(string key);
    }
}

