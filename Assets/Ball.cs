using UnityEngine;


public class Ball : MonoBehaviour
{
    public Rigidbody2D RB; 
    public int StartingSpeed;
    public Transform ResetPosition; // A transform object to set the reset position
  
    
    // Start is called before the first frame update
    void Start()
    {
        LaunchBall();
    }

    void LaunchBall()
    {
        float randomAngle;
        int direction = Random.Range(0,2);
        if(direction == 0){
            randomAngle = UnityEngine.Random.Range(-30f, 30f);
        }
        else{
            randomAngle = UnityEngine.Random.Range(150f,210f);
        }

        // Convert the angle to radians
        float angleInRadians = randomAngle * Mathf.Deg2Rad;

        // Calculate the velocity based on the random angle
        float xVelocity = Mathf.Cos(angleInRadians);
        float yVelocity = Mathf.Sin(angleInRadians);

        // Scale by the starting speed
        RB.linearVelocity = new Vector2(xVelocity * StartingSpeed, yVelocity * StartingSpeed);
    }

    // This function is called when the ball collides with the end walls
void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("LeftWall"))
    {
        scorecontrol.instance.addP2(); // add score
        ResetBall(); // reset potition

    }
    if (collision.gameObject.CompareTag("RightWall"))
    {
        scorecontrol.instance.addP1();
        ResetBall();
        

    }
}

    void ResetBall()
    {
        // Reset the ball's position to the center
        transform.position = ResetPosition.position;

        // Stop any existing velocity
        RB.linearVelocity = Vector2.zero;

        // Relaunch the ball
        LaunchBall();
    }
}
