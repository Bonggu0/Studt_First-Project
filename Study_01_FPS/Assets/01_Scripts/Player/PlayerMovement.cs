using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement
{
    private Camera _camera;

    private Rigidbody _rb;
    private Transform _tr;

    public void Initiate(Rigidbody rb, Transform tr,Camera camera)
    {
        _rb = rb;
        _tr = tr;
        _camera = camera;
    }

    public void PlayerMove(Vector3 dir,float speed ,bool moveType)
    {
        Vector3 camFor = _camera.transform.forward;
        camFor = new Vector3(camFor.x, 0, camFor.z);

        Vector3 camRight = _camera.transform.right;
        camRight = new Vector3(camRight.x, 0, camRight.z);

        Vector3 dir2 = dir.x * camFor + dir.z * camRight;
       

        if (moveType)
        {
            _tr.Translate(dir2 * speed * Time.deltaTime);
        }
        else
        {
            _rb.AddForce(dir2 * speed);
        }
    }
    public void PlayerJump()
    {

    }
}
