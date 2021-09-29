using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int playerScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player") == true)
        {
            GameObject thePlayer = GameObject.Find("UIManager");
            UIManager playerScript = thePlayer.GetComponent<UIManager>();
            playerScript.coinsCollected++;
            Destroy(transform.gameObject);
        }
    }

}

