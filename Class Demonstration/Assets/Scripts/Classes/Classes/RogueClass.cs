using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class RogueClass : FighterClass
{
    public RogueClass(int health, int mana, int damage) : base(health, mana, damage)
    {
        Damage = 200;
    }

    // POLYMORPHISM
    public override void Special()
    {
        Debug.Log("Rogue");
    }
}
