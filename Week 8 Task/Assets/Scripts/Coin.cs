using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int playerScore;
    ScoreKeeper scoreKeeperScript;

    // Start is called before the first frame update
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

