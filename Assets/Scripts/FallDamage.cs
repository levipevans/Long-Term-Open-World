using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour
{
    [SerializeField] float terminalVelocity = 1f;
    private new Transform transform;
    private float oldYPosition;

    private ThirdPersonMovement objectControlScript; // Maybe make generalize ThirdPersonMovement script with scriptable objects to expand what it to npcs

    // Start is called before the first frame update
    void Start()
    {
        // initialize variables
        objectControlScript = GetComponent<ThirdPersonMovement>(); // assign the ThirdPersonMovement script on this game object

        transform = GetComponent<Transform>();
        oldYPosition = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float currentYPosition = transform.position.y;


        if (oldYPosition - currentYPosition > terminalVelocity) // if velocity > terminal velocity then die
        {
            objectControlScript.shouldDie = true;
        }
        oldYPosition = currentYPosition;
    }
}
