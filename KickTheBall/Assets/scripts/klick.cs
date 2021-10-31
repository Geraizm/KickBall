using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klick : MonoBehaviour
{
    AudioSource klic;
  
    void Start()
    {
        klic = GetComponent<AudioSource>();//компонент объекта, на котором висит код
    }

    void Update()
    {
       if (Input.GetMouseButtonDown(0))//если зажата левая кнопка мыши или тыкнуть на экран моб.тел
        {
            klic.Play();//звук в студию пжлста
        }   
       
    }
}
