using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnTriggerSceneLoader : MonoBehaviour
{
    public string SceneName; //�������� �����. �� �������� �������� ����� BuildSettings > AddOpenScene
    void OnTriggerEnter(Collider other) //��� 3D - �����������, ����� ����� ������ � ���� ��������
    {
        if (other.gameObject.tag == "Player") //��������� ��� �������
        {
            SceneManager.LoadScene(SceneName); //��������� �����
        }
    }
}