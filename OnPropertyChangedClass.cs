using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Simple_MVVM
{
    /// <summary>Базовый класс с реализацией INPC </summary>
    public class OnPropertyChangedClass : INotifyPropertyChanged
    {
        /// <summary>Событие для извещения об изменения свойства</summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>Метод для вызова события извещения об изменении списка свойств</summary>
        /// <param name="propList">Последовательность свойств</param>
        public void OnPropertyChanged(IEnumerable<PropertyInfo> propList)
        {
            foreach (PropertyInfo _prp in propList)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_prp.Name));
        }

        /// <summary>Метод для вызова события извещения об изменении всех свойств</summary>
        public void OnAllPropertyChanged() => OnPropertyChanged(GetType().GetProperties());
    }
}
