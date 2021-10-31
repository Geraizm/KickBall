using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LUH : MonoBehaviour
{
    public float velocity = 300.0f;//задаем скорость объекта
   
    void Start()
    {
    }
    
    void Update()
    
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//задаем луч направленный в точку 
        RaycastHit hit;//данные стокновения луча
        
        if (Input.GetMouseButton(0) )//если нажата левая кнопка мыши или касание экрана моб.тел
        {
            if (Physics.Raycast(ray,out hit))//записываем данные столкновения луча с объектом в hit

            {
                if (hit.collider.tag == "chep"|| hit.collider.tag == "black")//если объекту присвоен тег chep или black
                {
                    hit.collider.GetComponent<Renderer>().material.color=Color.red;//изменение цвета того объекта, который удовлетворяет всем требованиям 
                    hit.collider.transform.position += new Vector3(0, 1 * Time.deltaTime * velocity,0);//придание скорости объекта, изменение траектории 
                    Destroy(hit.collider.transform.gameObject,0.2f);//удаление объекта через время
                    //Debug.Log("вы попали в цель");
                 }   
             }   
         }  
     }      
 }       
   

