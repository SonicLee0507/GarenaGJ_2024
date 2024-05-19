using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interact : MonoBehaviour
{
    public Player_Control player_Control;
    public bool[] Colletion;

    public int interact_ID;
    public bool canInteract = true;
    public Boss_Movement boss_Movement;
    // Start is called before the first frame update

    public void PlayerInteract(int objID)
    {
        Debug.Log("Player Interacting" + objID);
            interact_ID = objID;
            Colletion[objID-1] = true;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Interactable")
        {
            Debug.Log("Player Interacting! Press F?");
            if (Input.GetKeyDown(KeyCode.F)& canInteract)
            {
                Debug.Log("Player Interact!");
                interact_ID = other.GetComponent<OBJ_Interactable>().obj_id;
                if (other.GetComponent<OBJ_Interactable>().isTrick)
                {
                 boss_Movement.Process_PonitToMove(other.GetComponent<OBJ_Interactable>().obj_point);
                }
            }
        }
    }

}
