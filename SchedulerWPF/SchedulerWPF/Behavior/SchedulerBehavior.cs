using System.Windows;
using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;

namespace WpfScheduler
{
    public class SchedulerBehavior : Behavior<SfScheduler>
    {
        SfScheduler scheduler;
        protected override void OnAttached()
        {
            base.OnAttached();
            scheduler = this.AssociatedObject;
            this.AssociatedObject.CellLongPressed += AssociatedObject_CellLongPressed;
        }
        private void AssociatedObject_CellLongPressed(object sender, CellLongPressedEventArgs e)
        {
            MessageBox.Show("DateCell" + " " + e.DateTime.Day + " " + "has been long pressed", "DateCellHold Response", MessageBoxButton.OK);
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.CellLongPressed -= AssociatedObject_CellLongPressed;
            this.scheduler = null;
        }
    }
}
    

