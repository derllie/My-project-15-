using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Strawberry : MonoBehaviour
{
    private int Coin = 0;


    public TextMeshProUGUI coinText;




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "coin")
        {
            Coin++;
            coinText.text = "    : " + Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);
            AudioManager.instance.PlaySFX("Coin");


        }
    }
}

