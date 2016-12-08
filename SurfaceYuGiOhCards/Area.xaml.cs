namespace SurfaceYuGiOhCards
{
	public partial class Area
	{
		AreaViewModel ViewModel;

		public Area()
		{
			InitializeComponent();

			DataContext = ViewModel = new AreaViewModel();
		}
	}


	public class AreaViewModel : ViewModel
	{
		public AreaViewModel()
		{
		}
	}
}
