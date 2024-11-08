using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;
using Delegation;
using Penalty;
using Taxation;
using Payments;


namespace ConsoleFeatureApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //compile time binding or static linking
            //Handler.PayGST();
            //Handler.PayProfessionalTax();   


            //registering delegate with delegate instance
            /*Operation opn1 = new Operation(TaxHandler.PayServiceTax);
            Operation opn2 = new Operation(TaxHandler.PayGST);
            Operation opn3 = new Operation(TaxHandler.PayProfessionalTax);

            //broadcasting
            Operation masteroperation = null;
            masteroperation += opn1;
            masteroperation += opn2;
            masteroperation += opn3;

            masteroperation.Invoke(30);

            Console.WriteLine("after detachment");

            masteroperation -= opn3;
            masteroperation.Invoke(90); 
            

            //object creation
            Account acct = new Account(15000);

            //event registration
            acct.underBalance += PenaltyHandler.NotificationPenalty;
            acct.underBalance += PenaltyHandler.ServiceDisconnectionPenalty;
            
            //invocation
            acct.Withdraw(8000);

            acct.overBalance += TaxHandler.PayServiceTax;
            acct.overBalance += TaxHandler.PayProfessionalTax;

            acct.Deposit(300000);
            */


            //Account acct = new Account(15000);
            //acct.rolloutEvent += PaymentsHandler.Rollout;
            //acct.Rollout(5000);

            Console.ReadLine();
        }
    }
}
