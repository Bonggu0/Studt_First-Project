using System;
using UnityEngine;

public class TrapObj : MonoBehaviour
{
    [SerializeField]
    private int _trapDamage = 5;

    public static event Action<int> OnHPUpdate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController con = other.gameObject.GetComponent<PlayerController>();
            PlayerStat playerStat = con.GetStat();

            if (playerStat == null || playerStat.CurHP < 1) { return; }
            OnHPUpdate?.Invoke(_trapDamage);
        }
    }
}
