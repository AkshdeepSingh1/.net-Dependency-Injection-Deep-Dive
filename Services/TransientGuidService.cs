using System;
using DIExplained.Interfaces;

namespace DIExplained.Services
{
	public class TransientGuidService: ITransientGuidService
    {
        private readonly Guid id;
        public TransientGuidService()
        {
            id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return id.ToString();
        }
    }
}

