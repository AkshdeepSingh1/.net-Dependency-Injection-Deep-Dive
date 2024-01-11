using System;
using DIExplained.Interfaces;

namespace DIExplained.Services
{
	public class ProductionService: IEnvService
    {
		public ProductionService()
		{
		}
        public string getData()
        {
            return "This Service is registered on Production Enviornment";
        }
    }
}

