using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlatUpDown : MonoBehaviour
{
    public Transform pointOne, pointTwo;
    private Vector2 frozenPointOne, frozenPointTwo;
    public float moveSpeed = 3f;
    public bool _switch = false;

    void Start(){
        if (pointOne.position.x != transform.position.x){
            pointOne.position = new Vector2(transform.position.x, pointOne.position.y);
        }

        if (pointTwo.position.x != transform.position.x){
            pointTwo.position = new Vector2(transform.position.x, pointTwo.transform.position.y);
        }

        frozenPointOne = pointOne.transform.position;
        frozenPointTwo = pointTwo.transform.position;
    }


    void FixedUpdate()
    {
        if (_switch == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, frozenPointOne, moveSpeed * Time.deltaTime);
        }
        else if (_switch == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, frozenPointTwo, moveSpeed * Time.deltaTime);
        }

        if (new Vector2(transform.position.x, transform.position.y) == frozenPointOne)
        {
            _switch = true;
        }
        else if (new Vector2(transform.position.x, transform.position.y) == frozenPointTwo)
        {
            _switch = false;
        }
    }
}
