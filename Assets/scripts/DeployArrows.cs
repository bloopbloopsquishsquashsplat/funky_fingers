using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeployArrows : MonoBehaviour
{
    public static DeployArrows instance;
    public List<GameObject> arrows = new List<GameObject>();
    public float xPos;
    public int arrObj = 0;
    public float bpm = 128f;
    public float respawnTime = 2.5f;
    private Vector2 screenBounds;
    public int currentScore;

    public int scorePerNote = 100;
    public int scorePerGoodNote = 125;
    public int scorePerPerfectNote = 150;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;

    public Text scoreText;
    public Text multiText;
    //public bool gameStart;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        scoreText.text = "Score: 0";
        currentMultiplier = 1;
        //respawnTime = 60f / bpm;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }
    private void spawn(){
        GameObject a = Instantiate(arrows[arrObj]) as GameObject;
        if(arrObj == 0){
            xPos = -65.41f;
        }
        if(arrObj == 1){
            xPos = -54.47f;
        }
        if(arrObj == 2){
            xPos = -43.62f;
        }
        if(arrObj == 3){
            xPos = -32.43f;
        }
        a.transform.position = new Vector2(xPos, screenBounds.y -35);
        arrObj = Random.Range(0,4);
            
    }
    public void playarrows(){
        StartCoroutine(wave());
    }

    IEnumerator wave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawn();
        }
    }
    public void NoteHit(){
        Debug.Log("Hit On Time");

        if(currentMultiplier - 1 < multiplierThresholds.Length){

            multiplierTracker++;
            if(multiplierThresholds[currentMultiplier - 1] <= multiplierTracker){
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }
        multiText.text = "Multiplier: x" + currentMultiplier;

        currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score: " + currentScore;
    }

    public void NormalHit(){
        currentScore += scorePerNote * currentMultiplier;
        NoteHit();
    }

    public void GoodHit(){
        currentScore += scorePerGoodNote * currentMultiplier;
        NoteHit();
    }

    public void PerfectHit(){
        currentScore += scorePerPerfectNote * currentMultiplier;
        NoteHit();
    }

    public void NoteMissed(){
        Debug.Log("Note Missed");

        currentMultiplier = 1;
        multiplierTracker = 0;
    }
}
