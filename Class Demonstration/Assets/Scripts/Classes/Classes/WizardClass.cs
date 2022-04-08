using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class WizardClass : FighterClass
{
    public WizardClass(int health, int mana, int damage) : base(health, mana, damage)
    {
        Mana = 200;
    }

    // POLYMORPHISM
    public override void Special()
    {
        Debug.Log("Wizard");
    }
}

