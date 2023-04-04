using System;
namespace common.Elements
{
	public class Label : LayoutElement
	{
		public Label()
		{
			IsContainer = false;
			RenderType = typeof(common.Label);
		}

		public string? Value { get; set; }
        public override Type RenderType { get; init; }
    }
}

