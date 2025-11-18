using UnityEngine;

public class TrapObj : MonoBehaviour
{
    [SerializeField]
    private float _trapDamage = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerStat playerStat = other.GetComponent<PlayerStat>();
            if (playerStat == null || playerStat.CurHP < 1) { return; }
            playerStat.CurHP -= _trapDamage;
        }
    }
}
