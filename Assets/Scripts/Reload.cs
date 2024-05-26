using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
  



    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1; // ������������ �����
        ResumeGame(); // ������������ ����
    }

    private void ResumeGame()
    {
        // ��� ��� ��� ������������� ������� ������ ����� ������������ �����
        // ��������, �������������� ������� ��������, ��������� �����������, ������������� �������� ������ � ������ ��������
    }
}


