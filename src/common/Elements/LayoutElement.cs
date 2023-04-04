using System;
namespace common.Elements
{
	public abstract class LayoutElement
	{
		public bool IsContainer { get; init; }

		public LayoutStyle? Style { get; set; }

		public virtual IEnumerable<LayoutElement>? Children { get; set; }

		public abstract Type RenderType { get; init; }
	}
}

