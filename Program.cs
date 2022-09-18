namespace vending
{
  class Program 
  {
    public static void Main(string[] args)
    {
      VendingMachine vm = new VendingMachine();

      Drink drink = vm.buy(500, Drink.DIET_COKE);
      int charge = vm.refund();

      if (drink != null && drink.getKind() == Drink.DIET_COKE)
      {
        Console.WriteLine("コーラを購入しました。");
        Console.WriteLine("お釣りは" + charge + "円です。");
      } else 
      {
        throw new Exception("コーラを買えませんでした。");
      }
    }
  }
}