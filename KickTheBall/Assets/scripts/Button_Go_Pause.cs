using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Button_Go_Pause : MonoBehaviour
{
  
    public void Restart()
    { 
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);//��� ������� �� ������ ���� ���������� �������
    }
    public void Pause()
    {
        if (Time.timeScale != 0) Time.timeScale = 0; else Time.timeScale = 1;//����� ����, ������ � � ������ ����� ������ 
    }
}
