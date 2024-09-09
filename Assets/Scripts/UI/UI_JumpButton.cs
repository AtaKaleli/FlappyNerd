using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_JumpButton : MonoBehaviour, IPointerDownHandler
{
    public FlappyNerd bird;

    private void Awake()
    {
        if (bird == null)
            bird = FindObjectOfType<FlappyNerd>(true);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        GameManager.instance.isSpacePressedForMobile = true;
        if(bird != null)
            bird.Jump();
    }

    
}