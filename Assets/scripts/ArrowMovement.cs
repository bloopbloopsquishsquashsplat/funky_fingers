using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //aa

public class ArrowMovement : MonoBehaviour
{
    public static ArrowMovement instance; //aa

    public List<GameObject> moves = new List<GameObject>();
    public List<GameObject> arrows = new List<GameObject>();
    public List<int> xvalues = new List<int>();
    public AudioManager audiosrc;
    //in editor respawn time needs to equal time it takes in between beats
    //and beatTempo needs to equal bpm
    public float beatTempo = 128f;
    public bool newobject;
    public float respawnTime;
    public int currentScore; //aa
    public int scorePerNote = 100; //aa
    public int scorePerGoodNote = 125; //aa
    public int scorePerPerfectNote = 150; //aa
    public int currentMultiplier; //aa
    public int multiplierTracker; //aa
    public int[] multiplierThresholds; //aa
    public Text scoreText; //aa
    public Text multiText; //aa
    // Start is called before the first frame update
    
     void Start()
    {
        audiosrc = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        respawnTime = 60f / beatTempo;
        GameObject g = GameObject.Find("down_arrow");
        arrows.Add(g);
        xvalues.Add(-20);
        g = GameObject.Find("up_arrow");
        arrows.Add(g);
        xvalues.Add(20);
        g = GameObject.Find("right_arrow");
        arrows.Add(g);
        xvalues.Add(60);
        g = GameObject.Find("left_arrow");
        arrows.Add(g);
        xvalues.Add(-60);
        StartCoroutine(Move());

        instance = this; //aa

        scoreText.text = "Score: 0"; //aa
        currentMultiplier = 1; //aa
    }

    // Update is called once per frame
    void Update()
    {
                if(!audiosrc.GetComponent<AudioSource>().isPlaying)
                {
                    StopCoroutine(Move());
                    Debug.Log("end");
                }
                transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
                
            
        //2nd iteration
        //GameObject newgo = Instantiate(this);
        //for every beatTempo*Time.deltaTime generate random choice of arrow
    }
    IEnumerator Move()
    {
        
       
        while(true)
        {
            
            yield return new WaitForSeconds(respawnTime);
            int rand = Random.Range(0,4);
            GameObject curr = arrows[rand];
            
            //GameObject newgo = Instantiate(curr);
            //curr.transform.position = new Vector2(xvalues[rand], 50);
            if(curr.transform.position.y > -200)
            {
                continue;
            }
            else{
                curr.transform.position = new Vector2(xvalues[rand], 50);
            }
                
             
            
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

        //currentScore += scorePerNote * currentMultiplier;
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
    }

    
    
}
