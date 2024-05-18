using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndScript : MonoBehaviour
{
    [SerializeField] public string[] dialogue;
    [SerializeField] public Sprite[] CgImages;

    [SerializeField] private Image player;
    [SerializeField] private Image CG;
    [SerializeField] TextMeshPro dia;

    [SerializeField] private int maxdia;
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {

        }
    }
}
