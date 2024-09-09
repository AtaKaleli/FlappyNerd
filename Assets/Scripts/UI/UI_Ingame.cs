using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Ingame : MonoBehaviour
{

    public static UI_Ingame instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    
    public GameObject[] inGameScreens;
    private GameManager gameManager;
    private UI_FadeEffect fadeEffect;

    [SerializeField] private UI_Settings sfxController;
    [SerializeField] private UI_Settings bgmController;

    public FlappyNerd bird;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);

        fadeEffect = GetComponentInChildren<UI_FadeEffect>();
        if (fadeEffect == null)
            print(null);
    }

    private void Start()
    {

        sfxController.GetComponent<UI_Settings>().SetUpSFXSlider();
        bgmController.GetComponent<UI_Settings>().SetUpBGMSlider();


        gameManager = GameManager.instance;

        for (int i = 0; i < inGameScreens.Length; i++)
        {
            inGameScreens[i].SetActive(false);
        }

        inGameScreens[0].SetActive(true);
        if(fadeEffect != null)
            fadeEffect.ScreenFade(0, 1.5f);

        
    }


    private void UpdateScoreText()
    {
        scoreText.text = gameManager.score.ToString();
    }

    
    private void Update()
    {
        
        
            
        

        UpdateScoreText();
    }

    public void PauseButton()
    {
        gameManager.isGamePaused = !gameManager.isGamePaused;
        PauseController();
    }

    private void PauseController()
    {
        if (gameManager.isGamePaused)
        {
            Time.timeScale = 0;
            inGameScreens[1].SetActive(true);
        }
        else
        {

            Time.timeScale = 1;
            inGameScreens[1].SetActive(false);
        }
    }

    public void ClearIngameUI(int index = -1)
    {
        for (int i = 0; i < inGameScreens.Length; i++)
        {
            inGameScreens[i].SetActive(false);
        }
        if(index != -1)
            inGameScreens[index].SetActive(true);
    }




    public void SwitchToMainMenu()
    {
        Time.timeScale = 1;
        fadeEffect.ScreenFade(1, 1.5f, LoadMainMenu);
    }

    public void LoadMainMenu()
    {
        
        SceneManager.LoadScene("MainMenu");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        inGameScreens[1].SetActive(false);
    }


    public void SwitchToRestartGame()
    {
        Time.timeScale = 1;
        fadeEffect.ScreenFade(1, 0.5f, RestartGame);
    }

    public void RestartGame()
    {
        GameManager.instance.score = 0;
        GameManager.instance.isBirdDead = false;
        SceneManager.LoadScene("GameScene");
    }

    public void SwitchToSettings()
    {

        inGameScreens[3].SetActive(true);
        inGameScreens[1].SetActive(false);
    }

    public void BackToPauseUI()
    {
        inGameScreens[1].SetActive(true);
        inGameScreens[3].SetActive(false);
    }

}
