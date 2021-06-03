using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform playerTransform;
    public float forwardForce = 1000f;
    public float sideForce = 1000f;

    // Update is called once per frame
    void FixedUpdate()
    {
    //add a forward force
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        // to move player to right when "d" is clicked
        if(Input.GetKey("d")){
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);  //improves the side way movements by using ForceMode.VelocityChange
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (playerTransform.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame(); //we can use "GameManager.EndGame();" after defining "public GameManager GameManager;"
        }                                              //at times like deleting current player and creating duplicate this won't work because the reference from the GameManager will not be there in the new player
    }                                                  //we can use this "FindObjectOfType" method for the other referances as well 

}
