using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    private bool isBallLaunched = false;
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;

    private Rigidbody ballRB;
    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

    private void LaunchBall()
    {
        if (isBallLaunched) return;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
        isBallLaunched = true;
    }
}