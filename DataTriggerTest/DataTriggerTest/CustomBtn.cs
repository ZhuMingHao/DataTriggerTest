using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataTriggerTest
{
   public class CustomBtn : Button
    {public CustomBtn()
        {
            this.Clicked += CustomBtn_Clicked;
        }

        private void CustomBtn_Clicked(object sender, EventArgs e)
        {
            IsSelected = !IsSelected;
        }

        private static readonly BindableProperty IsSelectedProperty = BindableProperty.Create(
      propertyName: "IsSelected",
      returnType: typeof(bool),
      declaringType: typeof(CustomBtn),
      defaultValue: default(bool));

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }
    }
}
