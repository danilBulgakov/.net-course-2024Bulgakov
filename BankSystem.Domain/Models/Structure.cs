public struct Currency
{
    public string Code { get; set; }
    public decimal ExchangeRate { get; set; }

    public Currency(string code, decimal exchangeRate)
    {
        Code = code;
        ExchangeRate = exchangeRate;
    }

    public void DisplayCurrencyInfo()
    {
        Console.WriteLine($"Currency Code: {Code}, Exchange Rate: {ExchangeRate}"); //выводит код валюты и курс обмена
    }
}