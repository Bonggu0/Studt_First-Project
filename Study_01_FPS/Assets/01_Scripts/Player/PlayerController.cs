using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;

    public PlayerStat Stat;

    [SerializeField]
    private bool _changeType = false;

    public InputReader InputReader;
    public GameObject Player;

    private Rigidbody _rb;
    private Transform _tr;

    private PlayerMovement _movement;


    void Awake()
    {
        InputReader.Initialize();

        _rb = GetComponent<Rigidbody>();
        _tr = GetComponent<Transform>();

        _movement = new PlayerMovement();
        _movement.Initiate(_rb, _tr, _camera);

    }

    void Update()
    {
        _movement.PlayerMove(InputReader.Dir(), Stat.MoveSpeed, _changeType);
    }
}
