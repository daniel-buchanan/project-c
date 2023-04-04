using System;
namespace common
{
	public interface IPage
	{
		int Id { get; set; }

		string Title { get; set; }

		IEnumerable<Elements.LayoutElement> Elements { get; set; }
	}
}

