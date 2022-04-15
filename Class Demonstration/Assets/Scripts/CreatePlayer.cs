using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreatePlayer : MonoBehaviour
{
    
    public string playerClass;
    private GameObject playerCharacter;
    public FighterClass classRef;
    private Vector3 playerPosition = new Vector3(0.0f, 2.5f, 0.0f);
    private Quaternion playerRotation = Quaternion.identity;
    public GameObject Player;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI manaText;
    public TextMeshProUGUI damageText;

    private void Awake()
    {
        playerClass = GameObject.Find("DataManager").GetComponent<DataManager>().playerClass;
        InstantiatePlayer(playerClass, playerPosition, playerRotation);
    }

    private void InstantiatePlayer(string playerClass, Vector3 playerPosition, Quaternion playerRotation)
    {
        playerCharacter = Instantiate(Player, playerPosition, playerRotation) as GameObject;
        switch (playerClass)
        {
            case "Warrior":
                playerCharacter.AddComponent<WarriorClass>();
                healthText.text = "Player Health: " + playerCharacter.GetComponent<WarriorClass>().Health;
                manaText.text = "Player Mana: " + playerCharacter.GetComponent<WarriorClass>().Mana;
                damageText.text = "Player Damage: " + playerCharacter.GetComponent<WarriorClass>().Damage;
                break;
            case "Wizard":
                playerCharacter.AddComponent<WizardClass>();
                healthText.text = "Player Health: " + playerCharacter.GetComponent<WizardClass>().Health;
                manaText.text = "Player Mana: " + playerCharacter.GetComponent<WizardClass>().Mana;
                damageText.text = "Player Damage: " + playerCharacter.GetComponent<WizardClass>().Damage;
                break;
            case "Rogue":
                playerCharacter.AddComponent<RogueClass>();
                healthText.text = "Player Health: " + playerCharacter.GetComponent<RogueClass>().Health;
                manaText.text = "Player Mana: " + playerCharacter.GetComponent<RogueClass>().Mana;
                damageText.text = "Player Damage: " + playerCharacter.GetComponent<RogueClass>().Damage;
                break;
            default:
                break;
        }
    }
}
