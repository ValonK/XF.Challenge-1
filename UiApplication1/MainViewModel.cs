using System.Collections.ObjectModel;

namespace UiApplication1
{
	public class MainViewModel
	{
		public MainViewModel()
		{
			Items = new ObservableCollection<DummyItem>
			{
				new DummyItem { Title = "Orange Living Room ", Description = "4 devices to manage", Temperature = "24 °C" },
				new DummyItem { Title = "Orange Sleeping Room ", Description = "4 devices to manage", Temperature = "24 °C" },
				new DummyItem { Title = "Orange Bathroom", Description = "4 devices to manage", Temperature = "24 °C" }
			};
		}


		public ObservableCollection<DummyItem> Items { get; set; }

	}

	public class DummyItem
	{
		public string Title { get; set; }

		public string Description { get; set; }

		public string Temperature { get; set; }
	}
}
