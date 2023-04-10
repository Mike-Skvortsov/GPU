﻿namespace Entities
{
	public interface IBaseEntity
	{
		int Id { get; set; }
	}
	public class BaseEntity: IBaseEntity
	{
		public int Id { get; set; }
		public DateTime DateTime { get; set; } = DateTime.Now;
	}
}
