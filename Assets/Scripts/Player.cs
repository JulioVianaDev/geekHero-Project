using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
   public float moveSpeed;
    public Rigidbody2D rig2D;
    public float moveX;
    public float moveY;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        Movement();
    }

    void Movement(){
        rig2D.MovePosition(transform.position + new Vector3(moveX, moveY, 0) * Time.deltaTime * moveSpeed);
    }
}
