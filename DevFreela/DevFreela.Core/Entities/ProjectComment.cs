using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
	public class ProjectComment : BaseEntity
	{
		public ProjectComment(string content, int idProject, int idUSer)
		{
			Content = content;
			IdProject = idProject;
			IdUSer = idUSer;
		}

		public string Content { get; private set; }
		public int IdProject { get; private set; }
		public int IdUSer { get; private set; }
		public DateTime CreatedAt { get; private set; }
	}
}
