using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple_MVVM.Model;

namespace Simple_MVVM.ViewModel
{
    /// <summary>Клас реальной ViewModel</summary>
    public class MainWindow_VM : MainWindow_VM_DataDesigner
    {
        public MainWindow_VM()
        {
        }

        public override void OnAddСounter(object Value = null) => CountButtonPress = MainWindow_M.AddСounter(CountButtonPress);
    }
}
