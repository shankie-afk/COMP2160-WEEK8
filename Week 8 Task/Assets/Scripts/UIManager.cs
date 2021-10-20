using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject targetPlayer;
    public int coinsCollectedp1;
    public int coinsCollectedp2;
    public int scorePerCoin;
    private int coinScorep1;
    private int coinScorep2;
    public Text scorep1;
    public Text scorep2;
    void Start()
    {
        // coinScore = 0;

    }

    // Update is called once per frame
    void Update()
    {
        coinScorep1 = coinsCollectedp1 * scorePerCoin;
        coinScorep2 = coinsCollectedp2 * scorePerCoin;
        scorep1.text = "P1 Score: " + coinScorep1.ToString();
        scorep2.text = "P2 Score: " + coinScorep2.ToString();

    }
}
