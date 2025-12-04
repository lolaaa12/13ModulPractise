using _13ModulHomeWork;

class Program
{
    static void Main()
    {
        TicketMachine machine = new TicketMachine();

        machine.SelectTicket();        // Idle → WaitingForMoney
        machine.InsertMoney(300);      // недостаточно
        machine.InsertMoney(200);      // MoneyReceived
        machine.DispenseTicket();      // TicketDispensed

        Console.WriteLine("\nНовая покупка:\n");

        machine = new TicketMachine();
        machine.SelectTicket();
        machine.InsertMoney(200);
        machine.Cancel();              // TransactionCanceled
    }
}

