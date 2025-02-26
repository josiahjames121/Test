/*using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    public float textureHeight = 1.0f;

    private Vector3 startPosition;
    void Start()
    {
        // Set the initial position to be at the leftmost edge of the screen
        startPosition = transform.position;
    }

    void Update(){
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, textureHeight);
        transform.position = startPosition + Vector3.down * newPosition;
    }

}*/
/*using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.1f; // Speed of the texture scrolling

    private Renderer rendererComponent;

    void Start()
    {
        // Get the Renderer component of the background object
        rendererComponent = GetComponent<Renderer>();
    }

    void Update()
    {
        // Calculate the texture's offset based on time and scroll speed
        float newOffsetY = Time.time * scrollSpeed;
        
        // Apply the offset to the material’s texture
        rendererComponent.material.mainTextureOffset = new Vector2(0, newOffsetY);
    }
}
*/
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    public float scrollSpeed = 1;

    void Update(){
        
        this.transform.Rotate(0, 0, scrollSpeed, Space.World);
    }

}*/
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.1f;  // Adjust speed as needed
    private Renderer renderer;

    void Start(){
        renderer = GetComponent<Renderer>();
    }

    void Update(){
        // Create an offset value that increases over time
        Vector2 offset = new Vector2(Time.time * scrollSpeed, 0); // Scrolls horizontally
        renderer.material.mainTextureOffset = offset;
    }
}*/
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    private Renderer bgRenderer;
    private Vector2 offset;

    void Start()
    {
        bgRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Move the texture offset based on the scroll speed and time
        offset = new Vector2(0, Time.time * scrollSpeed);
        bgRenderer.material.mainTextureOffset = offset;
    }
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f; // Adjust the scroll speed as needed
    public Renderer backgroundRenderer;

    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * scrollSpeed); // Moves the texture vertically
        backgroundRenderer.material.mainTextureOffset = offset;
    }
}


