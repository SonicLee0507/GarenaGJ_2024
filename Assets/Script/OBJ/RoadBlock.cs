using UnityEngine;

public class RoadBlock : MonoBehaviour
{
    public GameControl gameControl;
    [SerializeField] private float speed;
    [SerializeField] private float Block_damage;
    [SerializeField] public float block_hp;

    [SerializeField] private Rigidbody rig;

    [SerializeField] private string trapName;
    // Update is called once per frame
    private void Start()
    {
        GameObject gameObject;
        gameObject = GameObject.FindGameObjectWithTag("GameController");

        gameControl = gameObject.GetComponent<GameControl>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("PlayerHit");
            other.GetComponent<Player_Stats>().PlayerTakeDamage(Block_damage, trapName);
        }
    }
}
