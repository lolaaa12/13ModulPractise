using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ModulHomeWork
{
    public class IdleState : IState
    {
        private TicketMachine _machine;

        public IdleState(TicketMachine machine)
        {
            _machine = machine;
        }

        public void SelectTicket()
        {
            Console.WriteLine("Билет выбран. Ожидание оплаты...");
            _machine.SetState(_machine.WaitingForMoneyState);
        }

        public void InsertMoney(decimal amount)
        {
            Console.WriteLine("Сначала выберите билет.");
        }

        public void DispenseTicket()
        {
            Console.WriteLine("Ошибка: билет не оплачен.");
        }

        public void Cancel()
        {
            Console.WriteLine("Операция уже в начальном состоянии.");
        }
    }

}
