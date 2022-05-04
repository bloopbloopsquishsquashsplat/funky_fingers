using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public List<GameObject> arrows = new List<GameObject>();
    public List<int> xvalues = new List<int>();
    //in editor respawn time needs to equal time it takes in between beats
    //and beatTempo needs to equal bpm
    public float beatTempo;
    public float respawnTime = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
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
        transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        
        
        //for every beatTempo*Time.deltaTime generate random choice of arrow
    }
    IEnumerator Move()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            int rand = Random.Range(0,4);
            GameObject curr = arrows[rand];
            curr.transform.position = new Vector2(xvalues[rand], 50);
        }
    }
}
