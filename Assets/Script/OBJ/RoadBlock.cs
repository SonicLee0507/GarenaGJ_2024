using UnityEngine;

public class RoadBlock : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float Block_damage;
    [SerializeField] public float block_hp;
    [SerializeField] private Rigidbody rig;
    [SerializeField] private string trapName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("PlayerHit");
            other.GetComponent<Player_Stats>().PlayerTakeDamage(Block_damage, trapName);
        }
    }
}
