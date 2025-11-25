using Unity.Hierarchy;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Scriptable Objects/Stat")]
public class PlayerStat : ScriptableObject
{
    public float CurHP = 20;
    public float MaxHP = 20;
    public float MoveSpeed = 5;
}
