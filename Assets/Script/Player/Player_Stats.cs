using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Stats : MonoBehaviour
{
    public LoadScene loadScene;
    public CameraControl cameraControl;
    public Player_Control player_Control;
    public GameControl gameControl;
    public void PlayerTakeDamage(float damageAmount , string cg)
    {
        if (player_Control.stage == 1)
        {
           loadScene.Load(cg);
        }
        cameraControl.PlayerShakeAnimation();

    }
}
