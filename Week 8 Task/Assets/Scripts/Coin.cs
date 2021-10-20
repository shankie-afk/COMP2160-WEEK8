using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int playerScore;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player1") == true)
        {
            GameObject player1 = GameObject.Find("UIManager");
            UIManager playerScript = player1.GetComponent<UIManager>();
            playerScript.coinsCollectedp1++;
            Destroy(transform.gameObject);
        }

        if (col.gameObject.CompareTag("Player2") == true)
        {
            GameObject player2 = GameObject.Find("UIManager");
            UIManager playerScript = player2.GetComponent<UIManager>();
            playerScript.coinsCollectedp2++;
            Destroy(transform.gameObject);
        }
    }

}

