using System.ComponentModel.Composition;
using System.IO;
using CuttingEdge.Conditions;

namespace PhoenixVB6.ProjectModel.Exports
{
	[Export(typeof(IProjectItemProvider))]
	public class ProjectItemProvider : IProjectItemProvider
	{
		#region IProjectItemProvider Members

		public virtual bool TryRead(IProjectContext context, LineInfo line, out IProjectItem item)
		{
			item = new ProjectItem
			{
				Line = line,
			};
			return true;
		}

		public virtual void Write(IProjectContext context, StreamWriter writer, IProjectItem item)
		{
			Condition.Requires(writer, "writer").IsNotNull();
			Condition.Requires(item, "item").IsNotNull();

			var projectItem = (ProjectItem)item;
			writer.WriteLine(projectItem.Line.Full);
		}

		#endregion
	}
}