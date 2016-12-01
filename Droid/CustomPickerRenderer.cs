using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using JPC.BindablePicker;
using TestApp.Droid;


[assembly: ExportRenderer(typeof(BindablePicker), typeof(BindablePickerRenderer))]

namespace TestApp.Droid
{
	public class BindablePickerRenderer : PickerRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged(e);

			var picker = e.NewElement;
			BindablePicker bp = (BindablePicker)this.Element;
			if (this.Control != null)
			{
				var pickerStyle = new Style(typeof(BindablePicker))
				{
					Setters =
					{
						new Setter { Property = VisualElement.BackgroundColorProperty, Value = Color.Red }

					}
				};
				picker.Style = pickerStyle;
			}
		}
	}
}

