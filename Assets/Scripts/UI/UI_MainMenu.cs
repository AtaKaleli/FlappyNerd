using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject[] UIElements;
    private UI_FadeEffect fadeEffect;

    private void Awake()
    {
        fadeEffect = GetComponentInChildren<UI_FadeEffect>();
       
    }

    private void Start()
    {
        for (int i = 0; i < UIElements.Length; i++)
        {
            UIElements[i].SetActive(false);
        }

        UIElements[0].SetActive(true);
        fadeEffect.ScreenFade(0, 1.5f);
        AudioManager.instance.PlayBgm();
    }



    public void SwitchToUI(GameObject currentUI)
    {
        for (int i = 0; i < UIElements.Length; i++)
        {
            UIElements[i].SetActive(false);
        }

        currentUI.SetActive(true);
        AudioManager.instance.PlaySFX(2);
    }

    public void GoBackToMenu(GameObject currentUI)
    {
        AudioManager.instance.PlaySFX(2);
        currentUI.SetActive(false);
        UIElements[0].SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SwitchToCreditsScene()
    {
        AudioManager.instance.PlaySFX(2);
        fadeEffect.ScreenFade(1, 1.5f, LoadCreditsScene);
    }

    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }
    /*
    public void SwitchToGameScene()
    {
        fadeEffect.ScreenFade(1, 1.5f, LoadGameScene);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    */
    

}
