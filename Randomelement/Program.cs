string[] snacks = { "pizza", "hamburgur", "sushi", "watermelon", "ramen" };
Random rand = new Random();
int randomindex = rand.Next(snacks.Length);
Console.WriteLine($"Tonight we eatin' {snacks[randomindex]}.");