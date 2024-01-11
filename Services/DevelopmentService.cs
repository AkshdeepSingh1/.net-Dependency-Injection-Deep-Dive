using System;
using DIExplained.Interfaces;

namespace DIExplained.Services
{
	public class DevelopmentService: IEnvService
    {
		public DevelopmentService()
		{
		}

		public string getData()
		{
			return "This Service is registered on Development Enviornment";
		}
		//service logic according to the buissness logic
	}
}

