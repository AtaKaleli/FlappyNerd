using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_ChangeSprite : MonoBehaviour
{

    private Image img;
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private float spriteChangeTime = 0.1f;
    private float spriteChangeTimeCounter;
    private int spriteIndex = 0;


    void Awake()
    {
        img = GetComponent<Image>();
        
    }


    private void Start()
    {
        
       
    }

    private void Update()
    {
        spriteChangeTimeCounter -= Time.deltaTime;

        if(spriteChangeTimeCounter < 0)
        {
            spriteChangeTimeCounter = spriteChangeTime;
            img.sprite = sprites[spriteIndex];
            spriteIndex++;

            if (spriteIndex == 3)
                spriteIndex = 0;

        }




    }


}
