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

    private int process_point;

    public bool canMove = true;
    public bool detecting ;

    public bool atkMove = true;

    public bool processing;
    public bool moveToProcess;
    public Transform[] atkPoint;

    public int process_id;
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
        if (canMove )
        {
          Movement();
          //bossController.boss_anim.Play("Moving");
        }
        if (moveToProcess)
        {
            Process_MoveToPoint();
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

                    Process_Movement(currentMovePointIndex, 1);
                    if (!processing)
                    {
                        bossController.boss_anim.Play("Moving");
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

        Debug.Log("Processing" + process_point);
        processing = true;
        //bossController.boss_ProcessTime = 1;  
        bossController.boss_ui.SetActive(true);
        if (process_point == 1)
        {
            Processing(process_time);
        }
        else if (process_point == 2)
        {
            //bossController.boss_ProcessTime -= Time.deltaTime * process_time;

            //if (bossController.boss_ProcessTime <= 0)
            //{
            //    Debug.Log("EndProcessing");
            //    processing = false;
            //    bossController.boss_ProcessTime = 1;
            //    bossController.boss_ui.SetActive(false);
            //}
            Processing(process_time);
        }
        else if (process_point == 3)
        {
            Processing(process_time);
        }
        else if (process_point == 4)
        {
            Processing(process_time);
        }
        else if (process_point == 5)
        {
            Processing(process_time);
        }
        else if (process_point == 6)
        {
            Processing(process_time);
        }
        else if (process_point == 0)
        {
            Processing(process_time);
        }

    }
    public void Process_PonitToMove(int process_point)
    {
        process_id = process_point;
        moveToProcess = true;

    }
    public void Process_MoveToPoint()
    {
        float step = movespeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, trick_movepoints[process_id].position, step);
        if (transform.position == trick_movepoints[process_id].position)
        {
            moveToProcess = false;
            processing = true;
        }

        bossController.boss_anim.Play("Processing");
    }
    private void Processing(float process_time)
    {
        {
            bossController.boss_anim.Play("Processing");
            bossController.boss_ProcessTime -= Time.deltaTime * process_time;
            bossController.boss.sprite = bossController.boss_sprite[1];
            if (bossController.boss_ProcessTime <= 0)
            {
                Debug.Log("EndProcessing");
                processing = false;
                bossController.boss_ProcessTime = 1;
                bossController.boss.sprite = bossController.boss_sprite[0];
                bossController.boss_ui.SetActive(false);
            }
        }
    }
}
