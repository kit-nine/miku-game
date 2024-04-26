using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCounter : MonoBehaviour
{
    public Text killText;
    public Text remaningText;

    private int kills;
    private int remaningEnemies;

    void Start()
    {
        kills = 0;
        remaningEnemies = GameObject.FindGameObjectWithTag("Enemy").Length;
            UpdateUI();
    }

   
    void Update()
    {
        if(Input.GetKeyDown(Keycode.space))
        {
            kills++;
            remaningEnemies--;
            UpdateUI();

            //Check if all enemies are killed
            if (remaningEnemies <= 0)
            {
                Debug.Log ("All enemies killed");
                // put win condition here
            }
        }
    }
}

{   void UpdateUI();

    killText.text = "Kills: " + kills;
    remaningText.text = "Remaining Enemies: " + remaningEnemies;
}