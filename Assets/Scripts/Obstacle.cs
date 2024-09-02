using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{


    [SerializeField] private Vector3 movePosition;

    private void Start()
    {
        Destroy(gameObject, 20);
    }



    void Update()
    {
        transform.position += movePosition * Time.deltaTime;
    }



    


}
