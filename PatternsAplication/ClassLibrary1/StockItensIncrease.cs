using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary
{
    public class StockItemIncrease : ICommand
    {
      public  bool IsCompleted { get; set; }
        StockItemDataModel _stockItem;
        double _quantity;

       public StockItemIncrease(StockItemDataModel stockItem, double quantity)
        {
            _stockItem = stockItem;
            _quantity = quantity;

            
        }

        public void Execute()
        {
            _stockItem.Quantity += _quantity;
        }

        public void Undo()
        {
            _stockItem.Quantity -= _quantity;
        }

    }
}
