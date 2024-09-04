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



    private void Update()
    {
        rectT.anchoredPosition += Vector2.up * speed * Time.deltaTime;
        if (rectT.anchoredPosition.y > offScreenposition)
            SwitchToMainMenu();
    }


    public void SwitchToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
