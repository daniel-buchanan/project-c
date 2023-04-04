using System;
namespace common.Elements
{
	public class Input : LayoutElement
	{
		public Input()
		{
			IsContainer = false;
			RenderType = typeof(common.Input);
		}

		public string? Label { get; set; }
		public string? Value { get; set; }
        public override Type RenderType { get; init; }
    }
}

