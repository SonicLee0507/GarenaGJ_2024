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
    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Boss" & !isInteractable)
        {
            Debug.Log("Boss Event" + obj_id);
            other.GetComponent<Boss_Movement>().Process_PonitToMove(obj_id);
        }

        if (other.tag == "Player" & isInteractable)
        {
            Debug.Log("Player Event" + obj_id);
            other.GetComponent<Player_Interact>().PlayerInteract(obj_id);
            isInteractable = false;
            Obj.sprite = afterInteract;
        }

        //if (other.name == "Girl" + obj_id & isInteractable)
        //{
        //}
    }
}
