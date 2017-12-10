using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject[] hazards;
    public Vector3 spawnValues;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public int hazardCount;
	
	public Text ScoreText;
    public Text restartText;
    public Text gameOverText;
	private int score;
    private bool gameover;
    private bool restart;

    private void Start()
    {
        gameover = false;
        restart = false;
		score = 0;
        restartText.text = "";
        gameOverText.text = "";
		UpdateScore();
        StartCoroutine (SpawnWave());
    }
    private void Update()
    {
        if (restart)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
#pragma warning disable CS0618 // Type or member is obsolete
                Application.LoadLevel(Application.loadedLevel);
#pragma warning restore CS0618 // Type or member is obsolete
            }
        }
    }
    IEnumerator SpawnWave()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);

                if (gameover)
                {
                    restartText.text = "Press 'R' to restart the game";
                    restart = true;
                    break;
                }
            }
            
            yield return new WaitForSeconds(waveWait);
            
        }
    }
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore();
	}
	void UpdateScore()
	{
		ScoreText.text = "Score:" + score;
	}

    public void Gameover()
    {
        gameOverText.text = "Game Over!";
        gameover = true;
    }
}

