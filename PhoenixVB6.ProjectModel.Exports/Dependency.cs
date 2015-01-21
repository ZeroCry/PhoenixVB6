namespace PhoenixVB6.ProjectModel.Exports
{
	public abstract class Dependency : IDependency
	{
		protected DependencyType mDependencyType;
		protected string mDisplayName;
		protected string mFilePath;

		#region IDependency Members

		public virtual DependencyType DependencyType
		{
			get { return mDependencyType; }
			set { mDependencyType = value; }
		}

		public virtual string DisplayName
		{
			get { return mDisplayName; }
			set { mDisplayName = value; }
		}

		public virtual string FilePath
		{
			get { return mFilePath; }
			set { mFilePath = value; }
		}

		public virtual void Refresh()
		{
			// nothing
		}

		#endregion
	}
}