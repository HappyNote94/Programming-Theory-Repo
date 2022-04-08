using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class WarriorClass : FighterClass
{
    public WarriorClass(int health, int mana, int damage) : base(health, mana, damage)
    {
        Health = 200;
    }

    // POLYMORPHISM
    public override void Special()
    {
        Debug.Log("Warrior");
    }
}
