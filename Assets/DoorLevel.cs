using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class DoorScript : MonoBehaviour
{
    public string sceneToLoad; // ��� �����, �� ������� ����� ��������� ������

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ���������, ��� �������� ������ �����
        {
            SceneManager.LoadScene(sceneToLoad); // ��������� �������������
        }
        AudioManager.instance.PlaySFX("Teleport");
        

    }
}


