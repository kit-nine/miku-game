using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
    public int sceneBuildIndex;

    // Level move zoned enter, if collider is a player
    // Move game to another scene
    private void OnTriggerEnter2D(Collider2D other) {
        print ("Trigger Entered");

        // Could use other.GetComponent<player>() to see if the game object has a player component
        // Tags work too. Maybe some players have diffrent script components?
        if(other.tag == "Player"){
            // Player entered, so move level
            print("Switching Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
