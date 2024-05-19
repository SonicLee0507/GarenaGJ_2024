using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndScript : MonoBehaviour
{
    public LoadScene load;
    [SerializeField] public string[] dialogue;
    [SerializeField] public Sprite[] CgImages;

    [SerializeField] private Image player;
    [SerializeField] private Image CG;
    [SerializeField] TextMeshProUGUI dia;

    [SerializeField] private int maxdia;
    [SerializeField] private int currentdia =0;
    [SerializeField] private int currentImage = 0;

    [SerializeField] private int changeImageNum;
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown )
        {
            currentdia += 1;
            dia.text = dialogue[currentdia];
            if (currentdia >= changeImageNum)
            {
                currentImage += 1;
                CG.sprite = CgImages[currentImage];
            }
            if (currentdia == maxdia)
            {
                load.Load("Start");
            }
        }
    }
}
