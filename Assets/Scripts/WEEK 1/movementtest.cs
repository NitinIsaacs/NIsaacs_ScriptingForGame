using UnityEngine;

public class movementtest : MonoBehaviour
{
    public Vector3 startingPosition;
    public Vector3 moveDirection;
    public float speed;

    // Start is called when this object first exists in the scene and the game is loaded
    void Start()
    {
        Debug.Log("Hello World!");

        // In Reference to the object THIS script is on,
        // get reference to the transform's POSITION, 
        // set it to 0,0,0, (=) to Vector3
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += moveDirection * speed * Time.deltaTime;
        // * time.deltatime per 
    }
}
