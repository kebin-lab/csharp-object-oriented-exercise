using System;

namespace vending
{
  public class Drink
  {
    public static readonly int COKE = 0;
    public static readonly int DIET_COKE = 1;
    public static readonly int TEA = 2;

    private int kind;

    public Drink(int kind)
    {
      this.kind = kind;
    }

    public int getKind()
    {
      return kind;
    }
  }
}