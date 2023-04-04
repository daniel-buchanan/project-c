using System;
namespace common
{
	public sealed class LayoutStyle
	{
        public bool IsFullWidth { get; set; }

        public int? MinWidth { get; set; }

        public int? MaxWidth { get; set; }

        public int? Width { get; set; }

        public int? MinHeight { get; set; }

        public int? MaxHeight { get; set; }

        public int? Height { get; set; }

        public string? Class { get; set; }
    }
}

