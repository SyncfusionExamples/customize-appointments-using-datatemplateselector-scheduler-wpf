﻿using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SchedulerWPF
{
    /// <summary>
    /// Month cell customization View Model class.
    /// </summary>
    public class SchedulerViewModel : INotifyPropertyChanged
    {

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerViewModel" /> class
        /// </summary>
        public SchedulerViewModel()
        {
            this.AddAppointments();
        }

        #endregion Constructor

        #region Public Properties

        /// <summary>
        /// Property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets appointments
        /// </summary>
        public ScheduleAppointmentCollection Appointments { get; set; }

        #endregion

        #region Property Changed Event

        /// <summary>
        /// Invoke method when property changed
        /// </summary>
        /// <param name="propertyName">property name</param>
        private void RaiseOnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Methods
        /// <summary>
        /// Adding appointments
        /// </summary>
        private void AddAppointments()
        {
            this.Appointments = new ScheduleAppointmentCollection();

            var newEvent = new ScheduleAppointment();
            newEvent.Subject = "Meeting";
            newEvent.StartTime = new DateTime(2021, 05, 11, 10, 0, 0);
            newEvent.EndTime = new DateTime(2021, 05, 11, 11, 0, 0);
            newEvent.AppointmentBackground = Brushes.Pink;

            var newEvent1 = new ScheduleAppointment();
            newEvent1.Subject = "Planning";
            newEvent1.StartTime = new DateTime(2021, 05, 11, 10, 0, 0);
            newEvent1.EndTime = new DateTime(2021, 05, 11, 11, 0, 0);
            newEvent1.AppointmentBackground = Brushes.Green;
            newEvent1.IsAllDay = true;

            this.Appointments.Add(newEvent);
            this.Appointments.Add(newEvent1);
        }
        #endregion
    }
}
