using System;

namespace PhoenixVB6.ProjectModel
{
	public struct LineInfo : IEquatable<LineInfo>
	{
		public int Number { get; set; }

		public string Full { get; set; }

		public string Key { get; set; }

		public override int GetHashCode()
		{
			unchecked
			{
				return (Number * 397) ^ (Full ?? String.Empty).GetHashCode();
			}
		}

		#region IEquatable<LineInfo>

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			return obj is LineInfo && Equals((LineInfo)obj);
		}

		public bool Equals(LineInfo other)
		{
			return Number == other.Number && String.Equals(Full, other.Full);
		}

		public static bool operator ==(LineInfo left, LineInfo right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(LineInfo left, LineInfo right)
		{
			return !left.Equals(right);
		}

		#endregion
	}
}