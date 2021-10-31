using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator1 : MonoBehaviour
{
    public GameObject Obj;
    public float GreateSec = 1;
    public float DestroySec = 5;
    private GameObject NewObj;

    void Start()
    { }

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
        NewObj = Instantiate(Obj, transform.position, Quaternion.Euler(0, 0, 0));
        StartCoroutine(TimerGreateObject(GreateSec));
    }
    
    void Update()
    { Destroy(NewObj, 4f); }

}
