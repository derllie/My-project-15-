using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Doorsound : MonoBehaviour
{
    public string sceneToLoad; // Имя сцены, на которую нужно перенести игрока

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Проверяем, что касается именно игрок
        {
            SceneManager.LoadScene(sceneToLoad); // Загружаем указаннуюцену
        }
        AudioManager.instance.PlaySFX("Teleport");
        AudioManager.instance.PlaySFX("Win");


    }
}
