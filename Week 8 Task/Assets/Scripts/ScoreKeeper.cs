using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int pointsPerPickup = 10;
    private int score;

    public void OnCoinPickup()
    {
     score += pointsPerPickup;
    }

    public int getScore(){
        return score;
    }

}
