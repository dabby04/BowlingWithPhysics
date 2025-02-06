using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force=1f;
    private bool isBallLaunched;
    [SerializeField] private InputManager inputManager; 
    // What is the difference between serializefield and why do we remove it in page 7?

    private Rigidbody ballRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballRB = GetComponent<Rigidbody>();

        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

    private void LaunchBall(){
        if(isBallLaunched) return;

        isBallLaunched=true;
        ballRB.AddForce(transform.forward*force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
