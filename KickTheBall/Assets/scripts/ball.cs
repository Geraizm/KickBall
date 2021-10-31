using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    private float velocity = 10.0f;//задаем скорость шара
  
    private Rigidbody Sphere;//компонент шара для физики тела
   
    void Start()
    {
        Sphere = GetComponent<Rigidbody>();//использование компонента физики шара
    } 
    
    void FixedUpdate()
    {
        transform.position += new Vector3( 1*Time.deltaTime * velocity, 0, 0);//движение шара в плоскости х со скоростью 
    }  
   
}

