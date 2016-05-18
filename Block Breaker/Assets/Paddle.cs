using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    private Camera mainCamera;

    public void Start()
    {
        myRigidbody = this.GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    public void Update()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mouseScreenPosition);
       
        Vector2 newPosition = new Vector2(mouseWorldPosition.x, myRigidbody.transform.position.y);
        myRigidbody.MovePosition(newPosition);
    }
}
