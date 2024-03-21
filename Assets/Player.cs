using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : IHealth
{
    private int health;
    private int maxHealth;


    Player()
    {
        
    }

    public int MaxHealth => maxHealth;
    public int Health => health;
    
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
