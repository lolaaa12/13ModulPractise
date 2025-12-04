using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ModulHomeWork
{
    public class TicketMachine
    {
        public IState IdleState { get; }
        public IState WaitingForMoneyState { get; }
        public IState MoneyReceivedState { get; }
        public IState TicketDispensedState { get; }
        public IState TransactionCanceledState { get; }

        public IState CurrentState { get; private set; }

        public decimal TicketPrice { get; } = 500;
        public decimal InsertedMoney { get; set; }

        public TicketMachine()
        {
            IdleState = new IdleState(this);
            WaitingForMoneyState = new WaitingForMoneyState(this);
            MoneyReceivedState = new MoneyReceivedState(this);
            TicketDispensedState = new TicketDispensedState(this);
            TransactionCanceledState = new TransactionCanceledState(this);

            CurrentState = IdleState;
        }

        public void SetState(IState state)
        {
            CurrentState = state;
        }

        public void SelectTicket() => CurrentState.SelectTicket();
        public void InsertMoney(decimal amount) => CurrentState.InsertMoney(amount);
        public void DispenseTicket() => CurrentState.DispenseTicket();
        public void Cancel() => CurrentState.Cancel();
    }

}
