using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interact : MonoBehaviour
{
    public Player_Control player_Control;
    public bool[] Colletion;
    public GameObject[] canUseStuff;

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
                if (other.GetComponent<OBJ_Interactable>().obj_id == 3)
                {
                    canUseStuff[1].SetActive(true);
                }
                if (other.GetComponent<OBJ_Interactable>().obj_id == 4)
                {
                    canUseStuff[0].SetActive(true);
                }
                if (other.GetComponent<OBJ_Interactable>().obj_id == 7)
                {
                    canUseStuff[3].SetActive(true);
                }
                if (other.GetComponent<OBJ_Interactable>().obj_id == 8)
                {
                    canUseStuff[4].SetActive(true);
                }
                if (other.GetComponent<OBJ_Interactable>().obj_id == 9)
                {
                    canUseStuff[5].SetActive(true);
                }
                if (other.GetComponent<OBJ_Interactable>().obj_id == 10)
                {
                    canUseStuff[2].SetActive(true);
                }
            }
        }
    }

}
