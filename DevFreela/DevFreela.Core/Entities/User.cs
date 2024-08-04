using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
	internal class User : BaseEntity
	{
		public User() { }

		public User(string fullName, string email, DateTime birthDate)
		{
			FullName = fullName;
			Email = email;
			BirthDate = birthDate;
			CreatedAt = DateTime.Now;
			Active = true;

			Skills = new List<UserSkill>();
			OwendProjects = new List<Project>();
			FreelanceProjects = new List<Project>();
		}

		public string FullName { get; private set; }
		public string Email { get; private set; }
		public DateTime	BirthDate { get; private set; }
		public DateTime CreatedAt { get; private set; }
		public List<UserSkill> Skills { get; private set; }
		public bool Active { get; private set; }

		public List<Project> OwendProjects { get; private set; }
		public List<Project> FreelanceProjects { get; private set; }
	}
}
