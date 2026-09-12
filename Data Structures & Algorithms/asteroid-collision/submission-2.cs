public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> direction = new Stack<int>();
        foreach(int asteroid in asteroids)
        {
            bool survived = true;
            while(direction.Count > 0)
            {
                var curr = direction.Peek();
                if((curr > 0 && asteroid >0) || (curr < 0 && asteroid < 0))
                {
                    direction.Push(asteroid);
                    survived=false;
                    break;
                }
                else 
                {
                    if(curr < 0 && asteroid >0)
                    {
                        direction.Push(asteroid);
                        survived=false;
                        break;
                    }
                    else if(Math.Abs(asteroid) > Math.Abs(curr))
                    {
                        direction.Pop();
                    }
                    else if(Math.Abs(asteroid) == Math.Abs(curr))
                    {
                        direction.Pop();
                        survived = false;
                        break;
                    }
                    else if(Math.Abs(asteroid) < Math.Abs(curr))
                    {
                        survived = false;
                        break;
                    }
                }
            }
            if(survived)
                direction.Push(asteroid);
        }
        var result = new int[direction.Count];
        while(direction.Count>0)
        {
            result[direction.Count-1] = direction.Pop();
        }
        return result;
    }
}