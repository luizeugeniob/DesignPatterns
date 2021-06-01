namespace DesignPatterns
{
    public class RequestChain
    {
        public void PrintBankAccount(Request request, BankAccount bankAccount)
        {
            var xml = new PrintXml();
            var csv = new PrintCsv();
            var percent = new PrintPercent();

            xml.Next = csv;
            csv.Next = percent;
            percent.Next = new NoPrint();

            xml.Print(request, bankAccount);
        }
    }
}
