using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrrows : MonoBehaviour
{
    public float bpm = 128f;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        speed = bpm / 10;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.y > screenBounds.y * 2){
            Destroy(this.gameObject);
        }
        
    }
}
