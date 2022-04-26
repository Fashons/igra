using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnTriggerSceneLoader : MonoBehaviour
{
    public string SceneName; //Название сцены. Не забываем добавить сцену BuildSettings > AddOpenScene
    void OnTriggerEnter(Collider other) //Для 3D - выполняется, когда Игрок войдет в зону триггера
    {
        if (other.gameObject.tag == "Player") //Проверяем тэг объекта
        {
            SceneManager.LoadScene(SceneName); //Загружаем сцену
        }
    }
}