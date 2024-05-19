using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atk : MonoBehaviour
{
    [SerializeField] public Player_Control player_Control;
    [SerializeField] public Player_Movement player_move;
    [SerializeField] public LoadScene loadScene;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Boss"& player_move.atking)
        {
            if (player_Control.stage == 2)
            {
            loadScene.Load("End_4");
            }
            if (player_Control.stage == 3)
            {
                loadScene.Load("End_1");
            }

        }
    }
}
