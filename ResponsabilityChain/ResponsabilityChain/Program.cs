using ResponsabilityChain.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsabilityChain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility

            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();
            Approver angelo = new Supervisor();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);
            tammy.SetSuccessor(angelo);

            // Generate and process purchase requests

            Purchase p = new Purchase(2034, 350.00, "Project A");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project B");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project C");
            larry.ProcessRequest(p);

            p = new Purchase(2037, 87500.00, "Project D");
            larry.ProcessRequest(p);

            p = new Purchase(2038, 372100.00, "Project E");
            larry.ProcessRequest(p);

            // Wait for user

            Console.ReadKey();
        }
    }
}
