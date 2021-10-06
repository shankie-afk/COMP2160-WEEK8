using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int pointsPerPickup = 10;
    private int score;
    public int Score;

    public void OnCoinPickup()
    {
     score += pointsPerPickup;
    }

    public int getScore(){
        Score = score;
        return Score;
    }

}
