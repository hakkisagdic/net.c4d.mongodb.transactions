using System;

namespace Net.C4D.Mongodb.Transactions.Commands
{
    public interface ICommand
    {
        Guid TransactionId { get; set; }
    }
}