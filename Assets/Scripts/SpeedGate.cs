using UnityEngine;

public class SpeedGate : MonoBehaviour
{

    public PlayerController controller;

    public float speed = 20f;
    public float increaseSpeed = 1.2f;
    public int currentLap = 0;


    // Update is called once per frame
    void Update()
    {
        controller._moveSpeed = speed;
    }

    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.CompareTag("Player"))
        {
            speed *= increaseSpeed;
            
            currentLap++;

            Debug.Log("player passed gate");
        }
    }
}
