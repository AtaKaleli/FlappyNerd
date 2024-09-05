using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Credits : MonoBehaviour
{
    [Header("Rect Information")]
    [SerializeField] private RectTransform rectT;
    [SerializeField] private float speed;
    [SerializeField] private float offScreenposition;

    private UI_FadeEffect fadeEffect;

    private void Awake()
    {
        fadeEffect = GetComponentInChildren<UI_FadeEffect>();
    }

    private void Start()
    {
        fadeEffect.ScreenFade(0, 1.5f);
    }

    private void Update()
    {
        rectT.anchoredPosition += Vector2.up * speed * Time.deltaTime;
        if (rectT.anchoredPosition.y > offScreenposition)
            SwitchToMainMenu();
    }


    public void SwitchToMainMenu()
    {
        fadeEffect.ScreenFade(1, 1.5f,LoadMainMenu);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }

}
