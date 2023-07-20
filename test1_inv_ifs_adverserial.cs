if (candies.length <= 0) 
{
    Console.WriteLine('No candies');
    return;
}
if (!store.isOpen()) 
{
    Console.WriteLine('No stores to put the candy into');
    return;
}
if (!store.allCandyIsLow()) 
{
     Console.WriteLine('There is still candy in the store');
    return;
}

foreach (string candy in candies) 
{
    store.refill(candy);
}