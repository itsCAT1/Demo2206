using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public string EnemyName;
    public virtual void Attack()
    {
        Debug.Log(EnemyName + " attacks!");
    }
}
public class Goblin : Enemy
{
    public override void Attack()
    {
        Debug.Log(EnemyName + " swings a club!");
    }
    public void Steal()
    {
        Debug.Log(EnemyName + " steals some gold!");
    }
}
public class Dragon : Enemy
{
    public override void Attack()
    {
        Debug.Log(EnemyName + " breathes fire!");
    }
    public void Fly()
    {
        Debug.Log(EnemyName + " flies into the sky!");
    }
}
public class im : MonoBehaviour

{
    void Start()
    {
        Goblin goblin = new Goblin();
        goblin.EnemyName = "Goblin";
        goblin.Attack(); // Overridden method
        goblin.Steal(); // Unique method
        Dragon dragon = new Dragon();
        dragon.EnemyName = "Dragon";
        dragon.Attack(); // Overridden method
        dragon.Fly(); // Unique method
    }
}
