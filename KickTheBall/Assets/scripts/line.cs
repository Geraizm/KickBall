using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class line : MonoBehaviour
{
    public int damage = 5;


    private float life = 95;//изначаьное количество жизни 
    public Text life_state;
    
    //public Text start;
    //private float st = 5;//таймер до начала появления шариков
    public GameObject myOverlayfinish;
    public GameObject myOver;
   
    void Start()
    {
        print("start life=" + life);
      
        myOverlayfinish.SetActive(false);//отсутствие картинки проигрыша в начале игры
        myOver.SetActive(false);//отсутствие картинки скримера 
       
    }

    void Update()
    {
      /* start.text = st.ToString();
        st -= Time.deltaTime / Time.deltaTime;//уменьшение таймера старта 
        if (st <= 0)
       {
           Destroy(start);//удаление таймера старта
        }
       */
    }
    
    private void OnCollisionEnter(Collision collision)//для взаимодействия с триггером
    {

        
        if (collision.gameObject.tag == "black")//если объект на который закинут скрипт начинает взаимодействовать объкт с тегом, то
        {
            myOver.SetActive(true);//включается картинка скримера
            GetComponent<AudioSource>().Play();//включается звук скримера
           

        }
        else myOver.SetActive(false);


        life_state.text = life.ToString();
        life = life - damage;
        if (life == 0)
        {
            myOverlayfinish.SetActive(true);//включаем картинку пригрыша 

            Destroy(myOver);//удалить скрим


        }
    }

   
   
}
