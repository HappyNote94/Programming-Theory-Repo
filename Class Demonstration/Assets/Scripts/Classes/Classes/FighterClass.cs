using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterClass : MonoBehaviour
{
    // ENCAPSULATION
    public int Health { get; set; } = 100;
    public int Mana { get; set; } = 100;
    public int Damage { get; set; } = 100;

    public FighterClass(int health, int mana, int damage)
    {
        Health = health;
        Mana = mana;
        Damage = damage;
    }

    public void Attack()
    {
        Debug.Log(this.Damage);
    }

    public virtual void Special()
    {

    }
}
