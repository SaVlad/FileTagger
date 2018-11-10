using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace FileTagger {
	public class FileModel : MvcHelper {
		public ImageSource Icon { get; }
		public string FullPath {
			get => GetProp<string>();
			set => SetProp(value);
		}
		public string Filename {
			get => GetProp<string>();
			set => SetProp(value);
		}
		public DateTime LastTimeChanged {
			get => GetProp<DateTime>();
			set => SetProp(value);
		}
		public ObservableCollection<Tag> Tags {
			get => GetProp<ObservableCollection<Tag>>();
			set => SetProp(value);
		}
		public string TagString {
			get => GetProp<string>();
			set => SetProp(value);
		}
		public override string ToString() => FullPath;
	}
	public class Tag : MvcHelper {

	}

	public abstract class MvcHelper : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;
		private Dictionary<string, object> _props = new Dictionary<string, object>();
		protected void Notify([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		protected void SetProp(object value, [CallerMemberName] string prop = "") { _props[prop] = value; Notify(prop); }
		protected T GetProp<T>([CallerMemberName] string prop = "") => _props.TryGetValue(prop, out object value) ? (T)value : default(T);
	}
}
