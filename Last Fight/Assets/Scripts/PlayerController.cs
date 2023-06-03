using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Скорость перемещения персонажа")]
    public float speed = 7f;

    private Animator animator;

    private bool isMove;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {

        if (Input.GetKey("w"))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
            isMove = true;
        }
        else if (Input.GetKey("s"))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
            isMove = true;
        }
        else if (Input.GetKey("a"))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
            isMove = true;
        }
        else if (Input.GetKey("d"))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
            isMove = true;
        }
        else isMove = false;
        Move();

    }

    private void Move()
    {
        if (isMove == true) animator.SetFloat("speed", 1);
        if (isMove == false) animator.SetFloat("speed", 0);
    }

}
