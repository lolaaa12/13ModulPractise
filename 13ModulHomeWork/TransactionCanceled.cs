using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ModulHomeWork
{
    public class TransactionCanceledState : IState
    {
        private TicketMachine _machine;

        public TransactionCanceledState(TicketMachine machine)
        {
            _machine = machine;
        }

        public void SelectTicket()
        {
            Console.WriteLine("Начало новой покупки.");
            _machine.SetState(_machine.WaitingForMoneyState);
        }

        public void InsertMoney(decimal amount)
        {
            Console.WriteLine("Сначала выберите билет.");
        }

        public void DispenseTicket()
        {
            Console.WriteLine("Покупка отменена.");
        }

        public void Cancel()
        {
            Console.WriteLine("Операция уже отменена.");
        }
    }

}
