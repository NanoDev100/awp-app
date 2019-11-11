using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace De.HsFlensburg.LernkartenApp060.Ui.Desktop
{
	/// <summary>
	/// Interaktionslogik für StartWindow.xaml
	/// </summary>
	public partial class StartWindow : Window
	{
		public StartWindow()
		{
			InitializeComponent();
		}

		private void OpenCardCollection(object sender, RoutedEventArgs e)
		{
			CardCollectionWindow myCCol = new CardCollectionWindow();
			myCCol.Show();
		}

		private void OpenCategories(object sender, RoutedEventArgs e)
		{
			CategoriesWindow myCats = new CategoriesWindow();
			myCats.Show();
		}

		private void OpenLevels(object sender, RoutedEventArgs e)
		{
			
		}

		private void OpenLearning(object sender, RoutedEventArgs e)
		{
			
		}

		private void OpenStatistics(object sender, RoutedEventArgs e)
		{
			StatisticsWindow myStats = new StatisticsWindow();
			myStats.Show();
		}
	}
}
