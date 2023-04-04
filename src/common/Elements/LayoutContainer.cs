using System;
namespace common.Elements
{
	public class LayoutContainer : LayoutElement
	{
		public LayoutContainer()
		{
			IsContainer = true;
			RenderType = typeof(common.LayoutContainer);
		}

        public override Type RenderType { get; init; }
    }
}

