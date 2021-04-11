public struct Pair
{
    public C Left { private get; set; }
    public C Right { private get; set; }
    public string LeftCurrency
    {
        get
        {
            return getCurrency(Left);
        }
    }

    public string RightCurrency
    {
        get
        {
            return getCurrency(Right);
        }
    }

    string getCurrency(C c)
    {
        switch (c)
        {
            case C.BNB: return Currency.BNB;
            case C.XRP: return Currency.XRP;
            case C.ETH: return Currency.ETH;
            case C.BTC: return Currency.BTC;
            case C.BUSD: return Currency.BUSD;
            case C.EUR: return Currency.EUR;
            default:
                throw new System.Exception("Bad currency");
        }
    }
}