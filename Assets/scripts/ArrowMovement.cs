using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowMovement : MonoBehaviour
{
    public List<GameObject> moves = new List<GameObject>();
    public List<GameObject> arrows = new List<GameObject>();
    public List<int> xvalues = new List<int>();
    public AudioManager audiosrc;
    //in editor respawn time needs to equal time it takes in between beats
    //and beatTempo needs to equal bpm
    public float beatTempo = 128f;
    public bool newobject;
    public float respawnTime;
	public bool playerReady = false;
    // Start is called before the first frame update
    
     void Start()
    {
        audiosrc = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        respawnTime = 60f / beatTempo;
        GameObject g = GameObject.Find("arrow_template_down");
        arrows.Add(g);
        xvalues.Add(-20);
        g = GameObject.Find("arrow_template_up");
        arrows.Add(g);
        xvalues.Add(20);
        g = GameObject.Find("arrow_template_right");
        arrows.Add(g);
        xvalues.Add(60);
        g = GameObject.Find("arrow_template_left");
        arrows.Add(g);
        xvalues.Add(-60);
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
                //if(!audiosrc.GetComponent<AudioSource>().isPlaying)
                //{
                    //StopCoroutine(Move());
                    //Debug.Log("song ended");
					//int currSceneIndex = SceneManager.GetActiveScene().buildIndex;
            		//SceneManager.LoadScene(currSceneIndex+1);
				
                //}
				if(playerReady){
					transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
                }
            
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
    
	public void PlayerIsReady()
	{
		playerReady = true;
    }
}
