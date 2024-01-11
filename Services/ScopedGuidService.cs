using System;
using DIExplained.Interfaces;

namespace DIExplained.Services
{
	public class ScopedGuidService: IScopedGuidService
	{
		private readonly Guid id;
		public ScopedGuidService()
		{
			id = Guid.NewGuid();
		}

		public string GetGuid()
		{
			return id.ToString();
		}
	}
}

