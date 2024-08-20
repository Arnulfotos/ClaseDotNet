public class Enemy
{
    static Random rand = new Random();
    public int HealthPoints { get; set; }
    public int AttackPoints { get; set; }

    public Enemy()
    {
        HealthPoints = rand.Next(80, 200);
        AttackPoints = rand.Next(80, 200);
    }


    public int GetHealth()
    {
        return HealthPoints;
    }


    public int GetAttack()
    {
        return AttackPoints;
    }

    public void setHealth(int points)
    {

        HealthPoints -= points;
    }

}