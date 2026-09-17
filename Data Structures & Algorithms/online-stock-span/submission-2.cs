public class StockSpanner {

    private Stack<(int price, int span)> stocks;

    public StockSpanner() {
        stocks = new Stack<(int price, int span)>();
    }
    
    public int Next(int price) {
        int span = 1;
        while(stocks.Count>0 && stocks.Peek().price <= price)
        {
            span += stocks.Pop().span;
        }
        stocks.Push((price,span));
        return span;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */