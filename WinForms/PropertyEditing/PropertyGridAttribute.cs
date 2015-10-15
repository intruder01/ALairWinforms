using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdamsLair.WinForms.PropertyEditing
{
	[AttributeUsage ( AttributeTargets.All )]
	public class PropertyGridAttribute : System.Attribute
	{
		public bool Ignore { get; set; }
		public PropertyGridAttribute()
		{
			Ignore = false;
		}
	}
}



