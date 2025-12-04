using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ModulHomeWork
{
    public class WaitingForMoneyState : IState
    {
        private TicketMachine _machine;

        public WaitingForMoneyState(TicketMachine machine)
        {
            _machine = machine;
        }

        public void SelectTicket()
        {
            Console.WriteLine("Билет уже выбран.");
        }

        public void InsertMoney(decimal amount)
        {
            _machine.InsertedMoney += amount;
            Console.WriteLine($"Внесено: {amount} тг");

            if (_machine.InsertedMoney >= _machine.TicketPrice)
            {
                Console.WriteLine("Оплата получена.");
                _machine.SetState(_machine.MoneyReceivedState);
            }
            else
            {
                Console.WriteLine($"Недостаточно средств. Нужно еще {_machine.TicketPrice - _machine.InsertedMoney}");
            }
        }

        public void DispenseTicket()
        {
            Console.WriteLine("Сначала внесите деньги.");
        }

        public void Cancel()
        {
            Console.WriteLine("Транзакция отменена. Деньги возвращены.");
            _machine.InsertedMoney = 0;
            _machine.SetState(_machine.TransactionCanceledState);
        }
    }

}
