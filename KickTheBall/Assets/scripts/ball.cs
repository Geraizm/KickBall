using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    private float velocity = 10.0f;//������ �������� ����
  
    private Rigidbody Sphere;//��������� ���� ��� ������ ����
   
    void Start()
    {
        Sphere = GetComponent<Rigidbody>();//������������� ���������� ������ ����
    } 
    
    void FixedUpdate()
    {
        transform.position += new Vector3( 1*Time.deltaTime * velocity, 0, 0);//�������� ���� � ��������� � �� ��������� 
    }  
   
}

