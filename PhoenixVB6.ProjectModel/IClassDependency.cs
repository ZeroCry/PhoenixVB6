using System;

namespace PhoenixVB6.ProjectModel
{
	public interface IClassDependency : IDependency
	{
		Guid ClassId { get; }

		string ProgId { get; }
	}
}