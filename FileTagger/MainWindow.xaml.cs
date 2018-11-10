using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace FileTagger {
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Button_MouseEnter(object sender, MouseEventArgs e) {
			if (sender is Control c)
				c.BorderBrush = SystemColors.MenuHighlightBrush;
		}
		private void Button_MouseLeave(object sender, MouseEventArgs e) {
			if (sender is Control c)
				c.BorderBrush = Brushes.Transparent;
		}
	}
}
