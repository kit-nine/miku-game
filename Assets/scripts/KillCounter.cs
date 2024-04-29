/*
just commenting out this whole buggy script for the playtest cause i dont feel like debugging anymore
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCounter : MonoBehaviour
{
    public string killText;
    public string remainingText;

    private int kills;
    private int remainingEnemies;
    void Start()
    {
        kills = 0;
        remainingEnemies = GameObject.FindGameObjectWithTag("Enemy").Length;
            UpdateUI();
    }
    void Update()
    {
        if(Input.GetKeyDown(Keycode.space))
        {
            kills++;
            remainingEnemies--;
            UpdateUI();
            //Check if all enemies are killed
            if (remainingEnemies <= 0)
            {
                Debug.Log("All enemies killed");
                // put win condition here
            }
        }
    }
    void UpdateUI()
    {
        killText = "Kills: " + kills;
        remainingText = "Remaining Enemies: " + remainingEnemies;
    }
}*/