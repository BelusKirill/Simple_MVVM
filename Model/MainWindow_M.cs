namespace Simple_MVVM.Model
{
    /// <summary>Статический класс модели данных</summary>
    public class MainWindow_M
    {
        /// <summary> реализация добавление счетчика нажания на кнопку </summary>
        public static int AddСounter(int countButtonPress)
        {
            return countButtonPress + 1;
        }
    }
}
