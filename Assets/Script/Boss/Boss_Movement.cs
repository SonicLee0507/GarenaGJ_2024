using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Movement : MonoBehaviour
{
    public BossController bossController;
    public float movespeed;
    public Transform[] movepoints;
    public Transform[] detect_movepoints;
    public Transform[] trick_movepoints;

    [SerializeField]private int currentMovePointIndex = 0;
    private int direction = 1; // 1 for forward, -1 for backward

    public bool canMove = true;
    public bool detecting ;

    public bool atkMove = true;

    public bool processing;
    public Transform[] atkPoint;
    void Start()
    {
        if (movepoints.Length > 1)
        {
            transform.position = movepoints[0].position;
            currentMovePointIndex = 1;
        }
    }

    void Update()
    {
        if (canMove)
        {
          Movement();
          bossController.boss_anim.Play("Moving");
        }
        if (processing)
        {

        }
        if (atkMove)
        {
            Atk_Movement();
        }
    }

    public void Movement()
    {
        if (currentMovePointIndex >= 0 && currentMovePointIndex < movepoints.Length)
        {
            if (!detecting)
            {
                float step = movespeed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position,movepoints[currentMovePointIndex].position, step);

                if (transform.position == movepoints[currentMovePointIndex].position)
                {
                    currentMovePointIndex += direction;

                    if (currentMovePointIndex >= movepoints.Length)
                    {
                        currentMovePointIndex = movepoints.Length - 2;
                        direction = -1;
                    }
                    else if (currentMovePointIndex < 0)
                    {
                        currentMovePointIndex = 1;
                        direction = 1;
                    }
                }
            }
            else
            {
                float step = movespeed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, detect_movepoints[currentMovePointIndex].position, step);

                if (transform.position == detect_movepoints[currentMovePointIndex].position)
                {
                    currentMovePointIndex += direction;

                    if (currentMovePointIndex >= detect_movepoints.Length)
                    {
                        currentMovePointIndex = detect_movepoints.Length - 2;
                        direction = -1;
                    }
                    else if (currentMovePointIndex < 0)
                    {
                        currentMovePointIndex = 1;
                        direction = 1;
                    }
                }
            }
        }
    }

    public void Atk_Movement()
    {
        transform.position = atkPoint[Random.Range(0, atkPoint.Length)].position;
    }
    public void Process_Movement(int process_point, float process_time)
    {
        if (process_point == 1)
        {
            bossController.boss_ProcessTime -= Time.deltaTime; 
        }
        else if (process_point == 2)
        {

        }
        else if (process_point == 3)
        {

        }
        else if (process_point == 4)
        {

        }
        else if (process_point == 5)
        {

        }
        else if (process_point == 6)
        {

        }
        bossController.boss_anim.Play("Processing");
    }
    public void Process_MoveToPoint(int process_point)
    {
        if ()
        {

        }
        bossController.boss_anim.Play("Processing");
    }

}
