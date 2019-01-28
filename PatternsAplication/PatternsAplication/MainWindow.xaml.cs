using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using CustomLibrary;

namespace PatternsAplication { 
//Command: Classes that execute an action(perform a function).

//Receiver: Business objects that “receive” the action from the Command.

//Invoker: This class tells the Commands to execute their actions.The Invoker can sometimes be a queue 
//(when it holds commands to be executed later), a pool(when it holds commands that can be executed by different programs/computers), 
//or let you do more things with your commands(retry failed commands, undo commands that were executed, etc.)

//Client: The main program that uses the other parts.
    public partial class MainWindow : Window
    {
        StockOperationManager stockOperationMangar;
        List<StockItemDataModel> stockItens;
        public MainWindow()
        {
            InitializeComponent();
             stockOperationMangar = new StockOperationManager();
            stockItens = new List<StockItemDataModel>();
        }

        private void OnAddNewItemClick(object sender, RoutedEventArgs e)
        {

            stockItens.Add(new StockItemDataModel() { Name = TBName.Text, Quantity = Convert.ToDouble(TBQuantity.Text) });
            MyListBox.Items.Add($"{TBName.Text} quantity: {TBQuantity.Text}");
           // stockOperationMangar.AddStockOperation( newTBName, TBQuantity);
        }

        private void OnIncrementQuantityItemClick(object sender, RoutedEventArgs e)
        {
            int stockListSelectedIndex = MyListBox.SelectedIndex;
            StockItemIncrease stockItemIncrease = new StockItemIncrease(stockItens[stockListSelectedIndex], Convert.ToDouble(TBQuantity.Text));
            Console.WriteLine($"qty {Convert.ToDouble(TBQuantity.Text)}");
            stockOperationMangar.AddStockOperation(stockItemIncrease);

            MyListBox.Items.Clear();
            foreach (StockItemDataModel i in  stockItens)
                MyListBox.Items.Add($"{i.Name} quantity: {i.Quantity}");
        }



        private void OnUndoClick(object sender, RoutedEventArgs e)
        {
            stockOperationMangar.UndoCommand();
            MyListBox.Items.Clear();
            foreach (StockItemDataModel i in stockItens)
                MyListBox.Items.Add($"{i.Name} quantity: {i.Quantity}");
        }


        private void OnRedoClick(object sender, RoutedEventArgs e)
        {
            stockOperationMangar.RedoCommand();
            MyListBox.Items.Clear();
            foreach (StockItemDataModel i in stockItens)
                MyListBox.Items.Add($"{i.Name} quantity: {i.Quantity}");
        }

        private void OnRemoveQuantityItemClick(object sender, RoutedEventArgs e)
        {
            stockOperationMangar.UndoCommand();
        }

    }
}
