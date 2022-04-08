using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterClass : MonoBehaviour
{
    private int health = 100;
    private int mana = 100;
    private int damage = 100;

    public int Health { get; set; }
    public int Mana { get; set; }
    public int Damage { get; set; }

    public int Attack()
        {
            return damage;
        }

    public virtual void Special()
    {

    }
}
