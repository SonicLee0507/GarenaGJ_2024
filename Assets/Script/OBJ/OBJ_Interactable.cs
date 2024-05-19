using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJ_Interactable : MonoBehaviour
{
    public int obj_id;
    public int obj_point;
    public float processtime;
    public bool isInteractable;
    public bool isTrick;

    public SpriteRenderer Obj;
    public Sprite beforeInteract;
    public Sprite afterInteract;

    public Transform afterInteractPos;
    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Boss" & !isInteractable)
        {
            Debug.Log("Boss Event" + obj_id);

            if (obj_id ==5 & other.GetComponent<Boss_Movement>().processing)
            {
                Debug.Log("Boss Event" + 5555555555);
                Obj.sprite = afterInteract;
            }
            else if (obj_id == 4 & other.GetComponent<Boss_Movement>().processing)
            {
                Debug.Log("Boss Event" + 4444444444);
                Obj.sprite = afterInteract;
            }
        }

        if (other.tag == "Player" & isInteractable)
        {
            Debug.Log("Player Event" + obj_id);
            other.GetComponent<Player_Interact>().PlayerInteract(obj_id);
            if (Input.GetKeyDown(KeyCode.F) & other.GetComponent<Player_Interact>().canInteract)
            {
            Obj.sprite = afterInteract;
                transform.position = afterInteractPos.position;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Boss" & !isInteractable)
        {
            Debug.Log("Boss Event" + obj_id);

            if (obj_id == 5 )
            {
                Debug.Log("Boss Event" + 5555555555);
                Obj.sprite = beforeInteract;
            }
            else if (obj_id == 4)
            {
                Debug.Log("Boss Event" + 4444444444);
                Obj.sprite = beforeInteract;
            }
        }

    }
}
