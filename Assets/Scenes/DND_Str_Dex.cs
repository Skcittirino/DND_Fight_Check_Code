using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DND_Str_Dex : MonoBehaviour
{
    [SerializeField] string playerName;
    [SerializeField] int profBonus;
    [SerializeField] bool finCheck;
    [SerializeField] [Range(-5, 5)] int strStat;
    [SerializeField] [Range(-5, 5)] int dexStat;
    // Start is called before the first frame update
    void Start()
    {
        if (finCheck == true)
        {
            Debug.Log(playerName + "'s Strength is " + strStat);
            Debug.Log(playerName + "'s Dexterity is " + dexStat);
            Debug.Log(playerName + " able to use either their Strength or Dexterity for this weapon.");
        }
        else
        {
            Debug.Log(playerName + "'s Strength is " + strStat + "");
        }

        int foeAC = Random.Range(10, 20 + 1);

        int diceRoll = Random.Range(1, 20 + 1);
        int damageTotal;
        bool winningChecker;

        if (finCheck == true)
        {
            if (strStat < dexStat)
            {
                damageTotal = dexStat + profBonus + diceRoll;
            }
            else
            {
                damageTotal = strStat + profBonus + diceRoll;
            }
        }
        else
        {
            damageTotal = strStat + profBonus + diceRoll;
        }

        if (foeAC < damageTotal)
        {
            winningChecker = true;
        }
        else
        {
            winningChecker = false;
        }

        if (winningChecker == true)
        {
            Debug.Log(playerName + " defeated his foe with a roll of " + diceRoll + "!");
            Debug.Log("The opponent had a armor stat of " + foeAC);
            Debug.Log(playerName + " won the fight, but not the war. Keep pushing onward!");
        }
        else
        {
            Debug.Log("Tragic, your roll was " + diceRoll + "...");
            Debug.Log("The opponent had a " + foeAC + " AC.");
            Debug.Log("Failure is only permanent if you give up!");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
