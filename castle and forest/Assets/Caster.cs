using UnityEngine;

public class Caster : MonoBehaviour
{

    [SerializeField] private Transform _castPoint;
    [SerializeField] private bool _isAutoCast;
    [SerializeField] private float _castInterval = 0.5f;
    [SerializeField] private float _ballSpeed;
    [SerializeField] private float _ballSize;
    [SerializeField] private float _ballMass;

    private float _castTrigger;


    void Update()
    {
        if ((_isAutoCast && Input.GetMouseButton(0)) || (Input.GetMouseButtonDown(0) && !_isAutoCast))
        {
            if (_castTrigger < Time.time)
            {
                Cast();
                _castTrigger = Time.time + _castInterval;
            }
        }
    }

    private void Cast()
    {
        GameObject ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ball.AddComponent<Rigidbody>();
        ball.transform.position = _castPoint.position;
        ball.transform.localScale *= _ballSize;
        Rigidbody ballRb = ball.GetComponent<Rigidbody>();
        ballRb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        ballRb.AddForce(_castPoint.forward * _ballSpeed, ForceMode.VelocityChange);
        ballRb.mass = _ballMass;
        Destroy(ball, 1);
    }
}
