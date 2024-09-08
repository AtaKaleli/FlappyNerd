using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_PauseScreen : MonoBehaviour
{




    public void ResumeGame()
    {
        Time.timeScale = 1;
        UI_Ingame.instance.inGameScreens[1].SetActive(false);
    }

    
  
}
