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

    bool isMoving;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        Movement();
        Animation();
    }

    void Movement(){
        rig2D.MovePosition(transform.position + new Vector3(moveX, moveY, 0) * Time.deltaTime * moveSpeed);
    }
    void Animation(){
        if(moveX == 0 && moveY == 0)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }
        anim.SetBool("isMoving", isMoving);
        anim.SetFloat("Horizontal", moveX);
        anim.SetFloat("Vertical", moveY);
    }
}
