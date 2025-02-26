namespace Singleton.Entities._01_Tutorial;

public class DragonBall
{
    private static DragonBall _instance;
    private short ballsCollected;

    private DragonBall()
    {
        this.ballsCollected = 0;
    }

    public static DragonBall GetInstance() 
    {
        if (DragonBall._instance == null) 
        { 
            DragonBall._instance = new DragonBall();
            Console.WriteLine("Dragon balls have been created");
        }
        return DragonBall._instance;
    }

    public void CollectBall() 
    {
        if (this.ballsCollected < 7) 
        {
            this.ballsCollected++;
            Console.WriteLine($"Ball collected. Total balls collected: {this.ballsCollected}");
            return;
        }
        Console.WriteLine("Have already collected 7 Dragon Balls, Invoke Shenlong");
    }

    public void InvokeShenlong() 
    {
        if (this.ballsCollected == 7) 
        {
            Console.WriteLine($"Shenlong has been invoked, ask your wishes");
            this.ballsCollected = 0;
            return;
        }
        Console.Write($"Still missing {7 - this.ballsCollected} to invoke Shenlong");

    }

}
