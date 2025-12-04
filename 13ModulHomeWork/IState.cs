using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ModulHomeWork
{
    public interface IState
    {
        void SelectTicket();
        void InsertMoney(decimal amount);
        void DispenseTicket();
        void Cancel();
    }

}
