public class StockSpanner {

    private List<int> stocks;

    public StockSpanner() {
        stocks = new List<int>();
    }
    
    public int Next(int price) {
        int span = 1;
        for(int i = stocks.Count-1; i >=0 ; i--)
        {
            if(stocks[i] > price)
            {
                break;
            }
            span++;
        }
        stocks.Add(price);
        return span;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */