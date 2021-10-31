using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator : MonoBehaviour
{//перетаскиваем код на объект, где будут появляться клоны 
    public GameObject Obj;//задаем объект для кнонирования 
    public float GreateSec = 2;//время после которого появляется опять клон шара
    //public float DestroySec=5;//время после которого уничтожается объект, для ненагромождения 
    private GameObject NewObj;//сам клон шара
    void Start()
    {}

    private void Awake()
    {
        StartCoroutine(TimerGreateObject(GreateSec));
       
    }
    private IEnumerator TimerGreateObject(float sec)
    {
        yield return new WaitForSeconds(sec);
        GreateObject();

    }

    private void GreateObject()
    {
        NewObj = Instantiate(Obj, transform.position, Quaternion.Euler(0,0,0));
       
        
        StartCoroutine(TimerGreateObject(GreateSec));
       
    }   
    void Update()
    { Destroy(NewObj, 4f);
    }
    
}
