using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interact : MonoBehaviour
{
    public bool[] Colletion;

    public int interact_ID;

    public Boss_Movement boss_Movement;
    // Start is called before the first frame update

    public void PlayerInteract(int objID)
    {
        if (objID == 1)
        { 

        }
        else if(objID == 2)
        {

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Interactable")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                interact_ID = other.GetComponent<OBJ_Interactable>().obj_id;
                boss_Movement.Process_PonitToMove(interact_ID);
            }
        }
    }

}
