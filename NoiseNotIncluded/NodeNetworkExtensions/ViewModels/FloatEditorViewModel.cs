using NodeNetwork.Toolkit.ValueNode;
using NodeNetworkExtensions.Views;
using ReactiveUI;

namespace NodeNetworkExtensions.ViewModels
{
	public class FloatEditorViewModel : ValueEditorViewModel<float?>
	{
		static FloatEditorViewModel()
		{
			Splat.Locator.CurrentMutable.Register(() => new FloatEditorView(), typeof(IViewFor<FloatEditorViewModel>));
		}

		public FloatEditorViewModel()
		{
			Value = 0f;
		}
	}
}
