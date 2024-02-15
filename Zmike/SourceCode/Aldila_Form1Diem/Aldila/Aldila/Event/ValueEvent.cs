using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldila.Event
{
    public class ValueEvent 
    {
        private double valueChange;
        public double ValueChange
        {
            get => valueChange;
            set
            {
                valueChange = value;
                OnNameChanged(value);
            }
        }


        private event EventHandler<ValueChangedEventArgs> _ValueChanged;
        public event EventHandler<ValueChangedEventArgs> ValueChanged
        {
            add
            {
                _ValueChanged += value;
            }
            remove
            {
                _ValueChanged -= value;
            }
        }

        void OnNameChanged(double valueChange)
        {
            if (_ValueChanged != null)
            {
                _ValueChanged?.Invoke(this, new ValueChangedEventArgs(valueChange));
            }
        }
    }

    public class ValueChangedEventArgs : EventArgs
    {
        public double valueChange { get; set; }
        
        public ValueChangedEventArgs(double value)
        {
            valueChange = value;
        }

        
    }
}
