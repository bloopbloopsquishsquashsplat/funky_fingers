using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    public GameObject okEffect, goodEffect, perfectEffect, missEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress)){
            if(canBePressed){
                gameObject.SetActive(false);
                //DeployArrows.instance.NoteHit();

                if(transform.position.y > 85.3 && transform.position.y < 85.7){
                    Debug.Log("Perfect");
                    DeployArrows.instance.PerfectHit();
                    Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
                }else if(transform.position.y > 85 && transform.position.y < 86){
                    Debug.Log("Good");
                    DeployArrows.instance.GoodHit();
                    Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
                }else if(transform.position.y > 84.7 && transform.position.y < 86.3){
                    Debug.Log("Ok");
                    DeployArrows.instance.NormalHit();
                    Instantiate(okEffect, transform.position, okEffect.transform.rotation);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = false;

            DeployArrows.instance.NoteMissed();
            
        }
    }
}
