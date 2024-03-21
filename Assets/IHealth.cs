using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    public int Health { get; }
    public void TakeDamage(int damage);
}
