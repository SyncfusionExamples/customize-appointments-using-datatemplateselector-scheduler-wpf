using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SchedulerWPF
{
    public class AppointmentTemplateSelector : DataTemplateSelector
    {
        public AppointmentTemplateSelector()
        {
            var mainWindow = App.Current.MainWindow as Window;
            this.AppointmentTemplate = mainWindow.Resources["appointmentTemplate"] as DataTemplate;
        }

        /// <summary>
        /// Gets or sets Month Appointment Template.
        /// </summary>
        public DataTemplate AppointmentTemplate { get; set; }

        /// <summary>
        /// Template selection method
        /// </summary>
        /// <param name="item">return the object</param>
        /// <param name="container">return the bindable object</param>
        /// <returns>return the template</returns>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            return AppointmentTemplate;
        }
    }
}
