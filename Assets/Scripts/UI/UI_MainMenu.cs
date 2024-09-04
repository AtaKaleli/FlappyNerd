using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject[] UIElements;



    private void Start()
    {
        for (int i = 0; i < UIElements.Length; i++)
        {
            UIElements[i].SetActive(false);
        }

        UIElements[0].SetActive(true);
    }



    public void SwitchToUI(GameObject currentUI)
    {
        for (int i = 0; i < UIElements.Length; i++)
        {
            UIElements[i].SetActive(false);
        }

        currentUI.SetActive(true);

    }

    public void GoBackToMenu(GameObject currentUI)
    {
        currentUI.SetActive(false);
        UIElements[0].SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
