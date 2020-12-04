using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDataAccessLibrary.DataAccess
{
	public class PeopleContext : Microsoft.EntityFrameworkCore.DbContext
	{
		#region Fields/Properties

		public Microsoft.EntityFrameworkCore.DbSet<Models.Address> Addresses { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Models.Email> EmailAddresses { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Models.Person> People { get; set; }

		#endregion

		#region Constructors

		public PeopleContext(Microsoft.EntityFrameworkCore.DbContextOptions a_dbContextOptions)
			: base(a_dbContextOptions)
		{
		}

		#endregion
	}
}
