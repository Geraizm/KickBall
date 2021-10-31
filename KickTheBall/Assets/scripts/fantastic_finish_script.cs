using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fantastic_finish_script : MonoBehaviour
{
    public float timerStart = 60;//60 ������ ������� ������������ ��� ������ 
    public Text timerText;
   public GameObject fantastic;
    
    void Start()
    {
        fantastic.SetActive(false);
    }   
    
    void FixedUpdate()
    {
        timerText.text = timerStart.ToString();//����������� ������ �� ������ ��������
        timerStart -= Time.deltaTime;//���������� ������� �� ��� � ������
        if (timerStart < 0)//���� ����� ����, ��� ����� ������������ ������, ����������� 
        {
            Time.timeScale = 0;//������ ���� �� �����
            fantastic.SetActive(true);//������� �������� ������ �� ����� 
            
            GetComponent<AudioSource>().Play();//�������� �������� �������
            //Destroy(timerText);

        }
       
    }
}
