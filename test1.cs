if (candies.length > 0) 
{
    if (store.isOpen()) 
    {
        if (store.allCandyIsLow()) 
        {
            foreach (string candy in candies) 
            {
                store.refill(candy);
            }
            Console.WriteLine('Store ' + store.Name + ' had its candies refilled.');
        } else {
            Console.WriteLine('There is still candy in the store');
        }
    } else 
    {
        Console.WriteLine('No stores to put the candy into');
    }
} else 
{
    Console.WriteLine('No candies');
}