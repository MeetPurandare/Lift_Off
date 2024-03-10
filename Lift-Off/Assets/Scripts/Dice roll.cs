using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    // Rigidbody of the dice
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for input to roll the dice
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }
    }

    // Roll the dice
    void RollDice()
    {
        // Add a random force to the dice
        rb.AddForce(Random.insideUnitSphere * 300, ForceMode.Impulse);
    }
}