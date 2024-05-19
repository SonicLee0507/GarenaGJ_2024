
using UnityEngine;
using UnityEngine.UI;

public class BossController : MonoBehaviour
{
    public Boss_Movement boss_Movement;
    [SerializeField] private int stage;
    public float movespeed;
    //[SerializeField] public Animator anim;
    [SerializeField] public Animator boss_anim;
    [SerializeField] public GameObject boss_ui;
    [SerializeField] public Slider boss_TimeBar;
    [SerializeField] public float boss_ProcessTime;
    [SerializeField] public int boss_MaxProcessTime;

    public SpriteRenderer boss;
    public Sprite[] boss_sprite;
    // Start is called before the first frame update
    void Start()
    {
        boss_ProcessTime = boss_MaxProcessTime;
    }

    // Update is called once per frame
    void Update()
    {
        boss_TimeBar.value = boss_ProcessTime;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            boss_Movement.detecting = true;
        }
        else if (Input.GetKeyDown(KeyCode.X) & boss_Movement.detecting)
        {
            boss_anim.Play("ATK");
            boss.sprite = boss_sprite[3];
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
        }

    }


}
