#region Copyright Preamble

// 
//    Copyright 2015 Overman Group, LLC.
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

#endregion

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;

namespace PhoenixVB6.ProjectModel.Exports
{
	[Export(typeof(IProject))]
	public class Project : IProject
	{
		private readonly IList<IProjectItem> mItems = new List<IProjectItem>();
		private IEnumerable<IProjectItem> mReadOnlyItems;

		#region IProject Members

		public virtual ProjectType Type { get; set; }

		public virtual string Name { get; set; }

		public virtual string Title { get; set; }

		public virtual string Description { get; set; }

		public virtual string BinaryName { get; set; }

		public virtual IEnumerable<IProjectItem> Items
		{
			get { return mReadOnlyItems ?? (mReadOnlyItems = new ReadOnlyCollection<IProjectItem>(mItems)); }
		}

		public virtual IList<IDependency> Dependencies
		{
			get { throw new System.NotImplementedException(); }
		}

		#endregion
	}

	public class ProjectItemCollectionView<T> : Collection<T>
		where T : IProjectItem
	{
		private readonly IList<IProjectItem> mProjectItems;

		public ProjectItemCollectionView(IList<IProjectItem> projectItems)
			: base(projectItems.OfType<T>().ToList())
		{
			mProjectItems = projectItems;
		}

	}

}