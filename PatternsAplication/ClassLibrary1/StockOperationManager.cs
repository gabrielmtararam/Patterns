using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary
{
    public class StockOperationManager
    {
        private readonly List<ICommand> _stockOperations = new List<ICommand>();
        private readonly List<ICommand> _redoStockOperations = new List<ICommand>();

        public bool HasPendingOperations
        {
            get { return _stockOperations.Any(x => !x.IsCompleted); }
        }

        public void AddStockOperation(ICommand stockOperation)
        {
            _stockOperations.Add(stockOperation);
            stockOperation.Execute();
            _redoStockOperations.Clear();
        }

        public void ProcessStockOperations()
        {
            // Apply transactions in the order they were added.
            foreach (ICommand stockOperation in _stockOperations.Where(x => !x.IsCompleted))
            {
                stockOperation.Execute();
            }
        }
        public void UndoCommand()
        {
            ICommand lastComand = new StockItemIncrease(null,0);
            if ((_stockOperations.Count - 1)>=0) { 
                 lastComand = _stockOperations[_stockOperations.Count - 1];
                lastComand.Undo();
                _stockOperations.RemoveAt(_stockOperations.Count - 1);

                _redoStockOperations.Add(lastComand);
            }
           
        }

        public void RedoCommand()
        {
            ICommand lastComand = new StockItemIncrease(null, 0);
            Console.WriteLine($"aa {_redoStockOperations.Count}");
            if ((_redoStockOperations.Count ) > 0)
            {
                lastComand = _redoStockOperations[_redoStockOperations.Count - 1];
                _stockOperations.Add(lastComand);
                _redoStockOperations.RemoveAt(_redoStockOperations.Count - 1);

                lastComand.Execute();
            }

        }

    }
}
