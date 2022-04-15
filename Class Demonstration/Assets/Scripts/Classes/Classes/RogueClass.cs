using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class RogueClass : FighterClass
{
    protected void Awake()
    {
        Damage = 200;
    }
    // POLYMORPHISM
    public override void Special()
    {
        Debug.Log("Rogue");
    }
}
