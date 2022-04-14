using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    
    public string playerClass;
    public GameObject WarriorClass;
    public GameObject WizardClass;
    public GameObject RogueClass;
    private void Awake()
    {
        playerClass = GameObject.Find("DataManager").GetComponent<DataManager>().playerClass;
        InstantiatePlayer(playerClass);
    }
    private void InstantiatePlayer(string playerClass)
    {
                switch (playerClass)
        {
            case "Warrior":
                Instantiate(WarriorClass);
                break;
            case "Wizard":
                Instantiate(WizardClass);
                break;
            case "Rogue":
                Instantiate(RogueClass);
                break;
        }
    }
}
