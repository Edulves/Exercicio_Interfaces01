using System.Globalization;
using Entities;
using Services;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.Write("Contract value: ");
double cValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int installments = int.Parse(Console.ReadLine());

Contract contract = new Contract(number, date, cValue);

ContractService contractService = new ContractService(new PaypalService());

contractService.ProcessContract(contract, installments);

Console.WriteLine("Installments: ");
int count = contract.installments.Count();
for (int i = 0; i < count; i++) {
    Console.WriteLine(contract.installments[i]);
}