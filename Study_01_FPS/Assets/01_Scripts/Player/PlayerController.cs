using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private InputReader _inputReader;
    [SerializeField]
    private PlayerStat _originStat;

    [SerializeField]
    private PlayerStat _stat;

    private bool _changeType = false;

    private Rigidbody _rb;
    private Transform _tr;

    private PlayerMovement _movement;


    public InputReader GetInputReader() { return _inputReader; }
    public GameObject GetPlayer() { return _player; }
    public PlayerStat GetStat() { return _stat; }

    void Awake()
    {
        _inputReader.Initialize();

        _rb = GetComponent<Rigidbody>();
        _tr = GetComponent<Transform>();

        _movement = new PlayerMovement();
        _movement.Initiate(_rb, _tr, _camera);

        InitPlayerStat();

    }

    void Update()
    {
        _movement.PlayerMove(_inputReader, _stat.MoveSpeed, _changeType);
    }

    private void InitPlayerStat()
    {
        _stat = _originStat;
    }
}
