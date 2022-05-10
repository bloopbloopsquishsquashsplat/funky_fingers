using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployArrows : MonoBehaviour
{
    public List<GameObject> arrows = new List<GameObject>();
    public float xPos;
    public int arrObj = 0;
    public float bpm = 128f;
    public float respawnTime = 2.5f;
    private Vector2 screenBounds;
    //public bool gameStart;
    // Start is called before the first frame update
    void Start()
    {
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
        a.transform.position = new Vector2(xPos, screenBounds.y * -1);
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
}
