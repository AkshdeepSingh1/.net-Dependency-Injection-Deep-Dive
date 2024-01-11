using System;
using DIExplained.Interfaces;

namespace DIExplained.Services
{
	public class SingletonGuidService: ISingletonGuidService
    {
        private readonly Guid id;
        public SingletonGuidService()
        {
            id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return id.ToString();
        }
    }
}

