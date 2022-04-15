using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class WarriorClass : FighterClass
{
    protected void Awake()
    {
        Health = 200;
    }
    // POLYMORPHISM
    public override void Special()
    {
        Debug.Log("Warrior");
    }
}
