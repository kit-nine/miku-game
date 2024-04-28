using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class EndScreen : MonoBehaviour
{   public string End_Menu ="End_Menu";
    string SceneName = SceneManager.GetActiveScene().name;
        public void RestartGame()
        {
            SceneManager.LoadScene(SceneName);
        }

}
