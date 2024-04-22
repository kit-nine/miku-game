using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class EndScreen : MonoBehaviour
{   public string End_Menu ="End_Menu";
        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene);
        }

}
