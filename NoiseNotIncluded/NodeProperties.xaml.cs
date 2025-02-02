using System.Windows;

namespace NoiseNotIncluded
{
	/// <summary>
	/// Interaction logic for NodeProperties.xaml
	/// </summary>
	public partial class NodeProperties : Window
	{
		public NodeProperties()
		{
			InitializeComponent();
		}

		private void OK_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = true;
			Close();
		}
	}
}
