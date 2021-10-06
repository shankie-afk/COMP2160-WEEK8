using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update

    ScoreKeeper scoreKeeperScript;
    public Text score;
  
    void Start()
    {
 GameObject scoreKeeper = GameObject.Find("ScoreKeeper");
        scoreKeeperScript = scoreKeeper.GetComponent<ScoreKeeper>();          
    }


    void Update()
    {
        score.text = "Score: " + scoreKeeperScript.getScore();
    }
}
