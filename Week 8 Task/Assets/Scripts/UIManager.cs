using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int coinsCollected;
    public int scorePerCoin;
    private int coinScore;
    public Text score;
    void Start()
    {
        coinScore = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        coinScore = coinsCollected * scorePerCoin;
        score.text = "Score: " + coinScore.ToString();

    }
}
