using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SchedulerWPF.Model
{
    /// <summary>   
    /// Represents custom data properties.   
    /// </summary> 
    public class Events : INotifyPropertyChanged
    {
        #region Private Properties

        private string eventName;
        private DateTime from;
        private DateTime to;
        private Brush background;
        private bool isAllDay;

        #endregion

        #region Public Properties

        public string EventName
        {
            get { return eventName; }
            set
            {
                eventName = value;
                this.RaiseOnPropertyChanged("EventName");
            }
        }

        public DateTime From
        {
            get { return from; }
            set
            {
                from = value;
                this.RaiseOnPropertyChanged("From");
            }
        }

        public DateTime To
        {
            get { return to; }
            set
            {
                to = value;
                this.RaiseOnPropertyChanged("To");
            }
        }

        public Brush Background
        {
            get { return background; }
            set
            {
                background = value;
                this.RaiseOnPropertyChanged("Background");
            }
        }

        public bool IsAllDay
        {
            get { return isAllDay; }
            set
            {
                isAllDay = value;
                this.RaiseOnPropertyChanged("IsAllDay");
            }
        }

        #endregion

        #region Property Changed Event

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke method when property changed
        /// </summary>
        /// <param name="propertyName">property name</param>
        private void RaiseOnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
