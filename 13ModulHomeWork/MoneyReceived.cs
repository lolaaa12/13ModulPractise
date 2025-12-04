using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ModulHomeWork
{
    public class MoneyReceivedState : IState
    {
        private TicketMachine _machine;

        public MoneyReceivedState(TicketMachine machine)
        {
            _machine = machine;
        }

        public void SelectTicket()
        {
            Console.WriteLine("Билет уже выбран и оплачен.");
        }

        public void InsertMoney(decimal amount)
        {
            Console.WriteLine("Оплата уже произведена.");
        }

        public void DispenseTicket()
        {
            Console.WriteLine("Билет выдан.");
            _machine.SetState(_machine.TicketDispensedState);
        }

        public void Cancel()
        {
            Console.WriteLine("Транзакция отменена. Деньги возвращены.");
            _machine.InsertedMoney = 0;
            _machine.SetState(_machine.TransactionCanceledState);
        }
    }

}
