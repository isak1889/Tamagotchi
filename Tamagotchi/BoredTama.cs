using System;

public class BoredTama: Tamagotchi
{
    public void tick()
    {
        hunger ++;
        boredom += Random.Shared.Next(1,4);

        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }
}
