using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fantastic_finish_script : MonoBehaviour
{
    public float timerStart = 60;//60 единиц времени продержаться для победы 
    public Text timerText;
   public GameObject fantastic;
    
    void Start()
    {
        fantastic.SetActive(false);
    }   
    
    void FixedUpdate()
    {
        timerText.text = timerStart.ToString();//присваиваем тексту на экране значение
        timerStart -= Time.deltaTime;//уменьшение времени по сек и милсек
        if (timerStart < 0)//если время игры, где нужно продержаться минуту, закончилось 
        {
            Time.timeScale = 0;//ставим игру на паузу
            fantastic.SetActive(true);//выводим картинку победы на экран 
            
            GetComponent<AudioSource>().Play();//включаем победную мелодию
            //Destroy(timerText);

        }
       
    }
}
