using System.IO;

namespace PhoenixVB6.ProjectModel
{
	public interface IProjectItemProvider
	{
		bool TryRead(IProjectContext context, LineInfo line, out IProjectItem item);

		void Write(IProjectContext context, StreamWriter writer, IProjectItem item);
	}
}