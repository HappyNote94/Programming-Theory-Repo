using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class WizardClass : FighterClass
{
    protected void Awake()
    {
        Mana = 200;
    }
    // POLYMORPHISM
    public override void Special()
    {
        Debug.Log("Wizard");
    }
}

