using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalendarXamarin
{
    internal class CalendarBehavior : Behavior<ContentPage>
    {
        ViewModel viewModel;
        SfCalendar calendar;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            viewModel = bindable.BindingContext as ViewModel;
            calendar = bindable.FindByName<SfCalendar>("calendar");
            calendar.MonthChanged += OnMonthChanged;
        }

        private void OnMonthChanged(object sender, MonthChangedEventArgs e)
        {
            viewModel.SelectedMonth = e.CurrentValue.ToString("Y");
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            calendar.MonthChanged -= OnMonthChanged;
            calendar = null;
        }
    }
}
