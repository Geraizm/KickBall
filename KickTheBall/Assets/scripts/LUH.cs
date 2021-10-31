using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LUH : MonoBehaviour
{
    public float velocity = 300.0f;//������ �������� �������
   
    void Start()
    {
    }
    
    void Update()
    
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//������ ��� ������������ � ����� 
        RaycastHit hit;//������ ����������� ����
        
        if (Input.GetMouseButton(0) )//���� ������ ����� ������ ���� ��� ������� ������ ���.���
        {
            if (Physics.Raycast(ray,out hit))//���������� ������ ������������ ���� � �������� � hit

            {
                if (hit.collider.tag == "chep"|| hit.collider.tag == "black")//���� ������� �������� ��� chep ��� black
                {
                    hit.collider.GetComponent<Renderer>().material.color=Color.red;//��������� ����� ���� �������, ������� ������������� ���� ����������� 
                    hit.collider.transform.position += new Vector3(0, 1 * Time.deltaTime * velocity,0);//�������� �������� �������, ��������� ���������� 
                    Destroy(hit.collider.transform.gameObject,0.2f);//�������� ������� ����� �����
                    //Debug.Log("�� ������ � ����");
                 }   
             }   
         }  
     }      
 }       
   

