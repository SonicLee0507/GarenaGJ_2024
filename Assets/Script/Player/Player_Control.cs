
using UnityEngine;
using UnityEngine.UI;

public class Player_Control : MonoBehaviour
{
    [SerializeField] public Player_Interact player_Interact;
    [SerializeField] public Player_Movement player_move;
    [SerializeField] public int stage;
    //[SerializeField] public Animator anim;
    public Animator player_anim;

    public Slider player_healthBar;
    public float player_hp;
    public int player_maxhp;

    [SerializeField] private Image player_stage_image;
    [SerializeField] private SpriteRenderer player_sprite;
    [SerializeField] private Sprite[] player_stage_spritelist;



    public GameObject Player;
    public GameObject TocchObj;

    //public GameObject HitEffect;
    void Start()
    {
        //player_healthBar.maxValue = player_maxhp;
    }

    // Update is called once per frame
    void Update()
    {
        //player_healthBar.value = player_hp;

        PlayerSkillSet();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (stage == 2)
            {
                TocchObj.SetActive(true);
                Debug.Log("stage == 2");
                player_sprite.sprite = player_stage_spritelist[2];
                player_move.atking = true;
                player_anim.Play("atk");
            }
            if (stage == 3)
            {
                TocchObj.SetActive(true);
                Debug.Log("stage == 3");
                player_sprite.sprite = player_stage_spritelist[4];
                player_move.atking = true;
                player_anim.Play("atk");
            }
        }
        else if (Input.GetKey(KeyCode.Mouse1) & stage == 1)
        {
            //Debug.Log("Input.GetKey(KeyCode.Mouse1) & stage == 1");
            if (player_move.jumpnumb <= 1)
            {
                Debug.Log("scrollJump.jumpnumb == 0");
            }
        }

    }

    private void PlayerSkillSet()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            stage = 1;
            player_stage_image.sprite = player_stage_spritelist[0];
            player_sprite.sprite = player_stage_spritelist[0];
            player_sprite.sortingOrder = 0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            player_Interact.canInteract = false;
            stage = 2;
            if(player_move.atking == false)
            {
                player_sprite.sprite = player_stage_spritelist[1];
            }
            player_stage_image.sprite = player_stage_spritelist[1];
            player_sprite.sprite = player_stage_spritelist[1];
            player_sprite.sortingOrder = 2;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            stage = 3;
            player_Interact.canInteract = false;
            if (player_move.atking == false)
            {
                player_sprite.sprite = player_stage_spritelist[3];
            }
            player_stage_image.sprite = player_stage_spritelist[3];
            player_sprite.sprite = player_stage_spritelist[3];
            player_sprite.sortingOrder = 2;
        }
        if (stage == 2 & player_move.atking == false)
        {
            player_sprite.sprite = player_stage_spritelist[1];
        }
        else if (stage == 3 & player_move.atking == false)
        {
            player_sprite.sprite = player_stage_spritelist[3];
        }
    }


}
