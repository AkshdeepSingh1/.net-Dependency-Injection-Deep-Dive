using System;
using DIExplained.Interfaces;

namespace DIExplained.Services
{
	public class KeyedServiceA: IKeyedService
    {
        public readonly string variableToReturn;
        public KeyedServiceA()
        {
            variableToReturn = "This is implementation from KeyedServiceA class";
        }
        public string PerformKeyedAction()
        {
            return variableToReturn;
        }
    }
}

