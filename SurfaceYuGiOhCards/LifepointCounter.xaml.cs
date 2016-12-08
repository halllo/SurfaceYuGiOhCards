using System.Windows;
using System.Windows.Controls;
using Microsoft.Surface.Presentation.Controls;

namespace SurfaceYuGiOhCards
{
	public partial class LifepointCounter : UserControl
	{
		public LifepointCounter()
		{
			InitializeComponent();
		}

		private void ChangeLifepoints(object sender, RoutedEventArgs e)
		{
			var button = sender as SurfaceButton;
			var offset = int.Parse(button.Content.ToString());
			var lifepoints = int.Parse(LifepointDisplay.Text);
			LifepointDisplay.Text = (lifepoints + offset).ToString();
		}
	}
}
