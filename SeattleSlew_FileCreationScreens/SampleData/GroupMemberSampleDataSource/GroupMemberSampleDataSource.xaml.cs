﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.GroupMemberSampleDataSource
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class Report { }
#else

	public class Report : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public Report()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/SeattleSlew_FileCreation.Screens;component/SampleData/GroupMemberSampleDataSource/GroupMemberSampleDataSource.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private rowCollection _Data = new rowCollection();

		public rowCollection Data
		{
			get
			{
				return this._Data;
			}
		}
	}

	public class rowCollection : System.Collections.ObjectModel.ObservableCollection<row>
	{ 
	}

	public class row : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _MemberCode = string.Empty;

		public string MemberCode
		{
			get
			{
				return this._MemberCode;
			}

			set
			{
				if (this._MemberCode != value)
				{
					this._MemberCode = value;
					this.OnPropertyChanged("MemberCode");
				}
			}
		}

		private string _Name_x0020_1 = string.Empty;

		public string Name_x0020_1
		{
			get
			{
				return this._Name_x0020_1;
			}

			set
			{
				if (this._Name_x0020_1 != value)
				{
					this._Name_x0020_1 = value;
					this.OnPropertyChanged("Name_x0020_1");
				}
			}
		}

		private string _Name_x0020_2 = string.Empty;

		public string Name_x0020_2
		{
			get
			{
				return this._Name_x0020_2;
			}

			set
			{
				if (this._Name_x0020_2 != value)
				{
					this._Name_x0020_2 = value;
					this.OnPropertyChanged("Name_x0020_2");
				}
			}
		}

		private string _Name_x0020_3 = string.Empty;

		public string Name_x0020_3
		{
			get
			{
				return this._Name_x0020_3;
			}

			set
			{
				if (this._Name_x0020_3 != value)
				{
					this._Name_x0020_3 = value;
					this.OnPropertyChanged("Name_x0020_3");
				}
			}
		}

		private string _StartDate = string.Empty;

		public string StartDate
		{
			get
			{
				return this._StartDate;
			}

			set
			{
				if (this._StartDate != value)
				{
					this._StartDate = value;
					this.OnPropertyChanged("StartDate");
				}
			}
		}

		private bool _IsConsolidated = false;

		public bool IsConsolidated
		{
			get
			{
				return this._IsConsolidated;
			}

			set
			{
				if (this._IsConsolidated != value)
				{
					this._IsConsolidated = value;
					this.OnPropertyChanged("IsConsolidated");
				}
			}
		}

		private string _Member_x0020_Type = string.Empty;

		public string Member_x0020_Type
		{
			get
			{
				return this._Member_x0020_Type;
			}

			set
			{
				if (this._Member_x0020_Type != value)
				{
					this._Member_x0020_Type = value;
					this.OnPropertyChanged("Member_x0020_Type");
				}
			}
		}
	}
#endif
}
