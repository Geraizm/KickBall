using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klick : MonoBehaviour
{
    AudioSource klic;
  
    void Start()
    {
        klic = GetComponent<AudioSource>();//��������� �������, �� ������� ����� ���
    }

    void Update()
    {
       if (Input.GetMouseButtonDown(0))//���� ������ ����� ������ ���� ��� ������� �� ����� ���.���
        {
            klic.Play();//���� � ������ ������
        }   
       
    }
}
