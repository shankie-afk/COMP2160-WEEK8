using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    ScoreKeeper scoreKeeperScript;
    void Start()
    {
       GameObject scoreKeeper = GameObject.Find("ScoreKeeper");
        scoreKeeperScript = scoreKeeper.GetComponent<ScoreKeeper>();  
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player") == true)
        {
            scoreKeeperScript.OnCoinPickup();
            Destroy(transform.gameObject);
        }
    }

}

