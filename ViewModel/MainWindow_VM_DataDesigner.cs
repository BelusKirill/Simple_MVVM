using System.Windows.Input;

namespace Simple_MVVM.ViewModel
{
    /// <summary>Класс ViewModel for DesignData</summary>
    public class MainWindow_VM_DataDesigner : OnPropertyChangedClass
    {
        #region Свойства для привязки элементов отображения
        /// <summary>Свойство для счетчика нажатий на кнопку</summary>
        public int CountButtonPress { get => _countButtonPress; set { _countButtonPress = value; OnAllPropertyChanged(); } }
        #endregion

        #region Приватные поля
        // Поля для хранения значения свойства
        private int _countButtonPress;
        // Поля для хранения значения команд
        private ICommand _addСounterComm;
        #endregion

        #region Свойства для привязки команд
        /// <summary>Свойство для привязки команды</summary>
        public ICommand AddСounterComm => _addСounterComm ?? (_addСounterComm = new RelayCommand(OnAddСounter));
        #endregion

        #region Методы для команд
        /// <summary>Метод для вызова из команды</summary>
        /// <param name="Value">Значение привязанного параметра</param>
        public virtual void OnAddСounter(object Value = null) { }
        /// <summary>Метод для вызова из команды</summary>
        /// <param name="Value">Значение привязанного параметра</param>
        #endregion
    }
}
