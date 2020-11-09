using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DClass
{
    class Account
    {
        string accName;
        string accid;
        double balance;
        float ammount;

        Account() { }
        Account(string n, string i, double b, float amn)
        {
            this.accName = n;
            this.accid = i;
            this.balance = b;
            this.ammount = amn;
        }
        public void Withdraw(float ammount )
        {

            if (ammount < balance)
            { balance -= ammount;
            }
            else
                Console.WriteLine("Insuf balance");

            {
                void Received (int ammount)
                {
                    {
                        balance += ammount;
                    }
                }
            }
        }
}
