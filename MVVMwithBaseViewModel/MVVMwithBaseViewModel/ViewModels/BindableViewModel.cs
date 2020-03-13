using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMwithBaseViewModel.ViewModels
{
    public class BindableViewModel:BaseViewModel
    {
		private string _entryText;

		public string EntryText
		{
			get { return _entryText; }
			set
			{
				_entryText = value;
				OnPropertyChanged();
			}
		}

	}
}
