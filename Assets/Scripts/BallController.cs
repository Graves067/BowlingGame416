using UnityEngine;
using UnityEngine.Events;

 public class BallController : MonoBehaviour{
[SerializeField] private float force = 1f;
    private InputManager inputManager;
    private bool isBallLaunched = false;
    private Rigidbody ballRB;

void Start(){
ballRB = GetComponent<Rigidbody>();

 // Add a listener to the OnSpacePressed event.
// When the space key is pressed the
// LaunchBall method will be called.
inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

private void LaunchBall(){
        if (isBallLaunched) return;
        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
  }
}