﻿using NodeNetwork.Toolkit.ValueNode;
using NodeNetworkExtensions.Views;
using ReactiveUI;

namespace NodeNetworkExtensions.ViewModels
{
	public class IntegerEditorViewModel : ValueEditorViewModel<int?>
	{
		static IntegerEditorViewModel()
		{
			Splat.Locator.CurrentMutable.Register(() => new IntegerEditorView(), typeof(IViewFor<IntegerEditorViewModel>));
		}

		public IntegerEditorViewModel()
		{
			Value = 0;
		}
	}
}
