using System;

public class HungryTama: Tamagotchi
{
    public void tick()
    {
        hunger +=Random.Shared.Next(0,4);
        boredom ++;

        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }
}
