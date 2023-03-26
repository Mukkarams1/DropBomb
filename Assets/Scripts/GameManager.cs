using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager reference;
    bool gameOver = false;
    int Score;
    public GameObject ScoreTxT;
    // Start is called before the first frame update
    private void Awake()
    {
        if (reference == null)
        {
            reference = this;
        }
    }
    public void GameOver()
    {
        gameOver = true;
        GameObject.Find("EnemySpawner").GetComponent<Spawner>().StopSpawnSpike();

    }
    public void ScoreIncrease()
    {
        if (gameOver==false)
        {
            Score++;
            ScoreTxT.GetComponent<Text>().text = Score.ToString();
            ScoreUpdater();
        }

    }
    void ScoreUpdater()
    {
        ScoreTxT.GetComponent<Text>().text = Score.ToString();

    }
}
