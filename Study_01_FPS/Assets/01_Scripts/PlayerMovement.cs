using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private bool _isTranslate = true;
    [SerializeField]
    private bool _isRigidbody = false;
    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private float _force = 5;

    private Rigidbody _rb;
    private Transform _tr;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _tr = GetComponent<Transform>();
    }

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 camFor = _camera.transform.forward;
        camFor = new Vector3(camFor.x, 0, camFor.z);

        Vector3 camRight = _camera.transform.right;
        camRight = new Vector3(camRight.x, 0, camRight.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isTranslate = !_isTranslate;
            _isRigidbody = !_isRigidbody;
        }

        Vector3 dir2 = ver * camFor + hor * camRight;

        if (_isTranslate)
        {
            _tr.Translate(dir2 * _force * Time.deltaTime);
        }

        if (_isRigidbody)
        {
            _rb.AddForce(dir2 * _force);
        }


    }
}
