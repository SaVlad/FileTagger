using System.Windows;
using System.Windows.Controls;

namespace FileTagger {
	public partial class WatermarkTextBox : UserControl {
		public static readonly DependencyProperty TextProperty
			= DependencyProperty.Register(nameof(Text), typeof(string), typeof(WatermarkTextBox), new PropertyMetadata(string.Empty, TextChanged));
		public static readonly DependencyProperty WatermarkProperty
			= DependencyProperty.Register(nameof(Watermark), typeof(string), typeof(WatermarkTextBox), new PropertyMetadata(string.Empty));
		private static void TextChanged(DependencyObject depo, DependencyPropertyChangedEventArgs args) {
			if (!(depo is WatermarkTextBox wtb))
				return;
			string nv = args.NewValue as string;
			wtb.textBlock.Visibility = string.IsNullOrEmpty(nv) ? Visibility.Visible : Visibility.Hidden;
		}
		public string Text {
			get => (string)GetValue(TextProperty);
			set => SetValue(TextProperty, value);
		}
		public string Watermark {
			get => (string)GetValue(WatermarkProperty);
			set => SetValue(WatermarkProperty, value);
		}
		public WatermarkTextBox() {
			InitializeComponent();
			DataContext = this;
		}
	}
}
