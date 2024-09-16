using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public float jumpforce;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(move, 0, 0) * speed*Time.deltaTime;
        
        if(move < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 270);
        }
        if (move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        

        float moveup = Input.GetAxisRaw("Vertical");
        if(moveup >0)
        {
            transform.eulerAngles = new Vector3(0, 0, 180);
        }
        if (moveup < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        transform.position += new Vector3(0, moveup, 0) * speed * Time.deltaTime;


    }
}
