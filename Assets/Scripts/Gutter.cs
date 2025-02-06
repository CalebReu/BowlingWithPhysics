using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {
        if (!triggeredBody.TryGetComponent<Rigidbody>(out Rigidbody ballRigidbody))
        {
            return;
        }

        float velocityMagnitude = ballRigidbody.linearVelocity.magnitude;

        ballRigidbody.linearVelocity = Vector3.zero;
        ballRigidbody.angularVelocity = Vector3.zero;

        ballRigidbody.AddForce(transform.forward * velocityMagnitude, ForceMode.VelocityChange);
    }
}
