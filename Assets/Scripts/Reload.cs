using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
  



    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1; // Возобновляем время
        ResumeGame(); // Возобновляем игру
    }

    private void ResumeGame()
    {
        // Ваш код для возобновления игровой логики после перезагрузки сцены
        // Например, восстановление позиций объектов, активация коллайдеров, возобновление движения игрока и других объектов
    }
}


