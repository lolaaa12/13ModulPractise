using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ModulHomeWork
{
    public class TicketDispensedState : IState
    {
        private TicketMachine _machine;

        public TicketDispensedState(TicketMachine machine)
        {
            _machine = machine;
        }

        public void SelectTicket()
        {
            Console.WriteLine("Операция завершена. Начните новую покупку.");
        }

        public void InsertMoney(decimal amount)
        {
            Console.WriteLine("Билет уже выдан.");
        }

        public void DispenseTicket()
        {
            Console.WriteLine("Билет уже выдан.");
        }

        public void Cancel()
        {
            Console.WriteLine("Нельзя отменить — билет уже выдан.");
        }
    }

}
