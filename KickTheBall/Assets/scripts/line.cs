using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class line : MonoBehaviour
{
    public int damage = 5;


    private float life = 95;//���������� ���������� ����� 
    public Text life_state;
    
    //public Text start;
    //private float st = 5;//������ �� ������ ��������� �������
    public GameObject myOverlayfinish;
    public GameObject myOver;
   
    void Start()
    {
        print("start life=" + life);
      
        myOverlayfinish.SetActive(false);//���������� �������� ��������� � ������ ����
        myOver.SetActive(false);//���������� �������� �������� 
       
    }

    void Update()
    {
      /* start.text = st.ToString();
        st -= Time.deltaTime / Time.deltaTime;//���������� ������� ������ 
        if (st <= 0)
       {
           Destroy(start);//�������� ������� ������
        }
       */
    }
    
    private void OnCollisionEnter(Collision collision)//��� �������������� � ���������
    {

        
        if (collision.gameObject.tag == "black")//���� ������ �� ������� ������� ������ �������� ����������������� ����� � �����, ��
        {
            myOver.SetActive(true);//���������� �������� ��������
            GetComponent<AudioSource>().Play();//���������� ���� ��������
           

        }
        else myOver.SetActive(false);


        life_state.text = life.ToString();
        life = life - damage;
        if (life == 0)
        {
            myOverlayfinish.SetActive(true);//�������� �������� �������� 

            Destroy(myOver);//������� �����


        }
    }

   
   
}
