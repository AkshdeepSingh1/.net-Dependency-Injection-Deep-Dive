using System;
using DIExplained.Interfaces;

namespace DIExplained.Services
{
	public class KeyedServiceB : IKeyedService
    {

        public readonly string variableToReturn;
        public KeyedServiceB()
        {
            variableToReturn = "This is implementation from KeyedServiceB class";
        }
        public string PerformKeyedAction()
        {
            return variableToReturn;
        }
    }
}

