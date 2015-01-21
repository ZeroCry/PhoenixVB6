namespace PhoenixVB6.ProjectModel.Exports
{
	public class ProjectItem : IProjectItem
	{
		protected LineInfo mLine;

		#region IProjectItem Members

		public virtual LineInfo Line
		{
			get { return mLine; }
			set { mLine = value; }
		}

		#endregion
	}
}