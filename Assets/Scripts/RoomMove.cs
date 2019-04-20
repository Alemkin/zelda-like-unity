using UnityEngine;

public class RoomMove : MonoBehaviour
{
    public Vector2 CameraChange;
    public Vector3 PlayerChange;
    private CameraMovement _camera;

    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.CompareTag("Player"))
        {
            _camera.MinPosition += CameraChange;
            _camera.MaxPosition += CameraChange;
            collider.transform.position += PlayerChange;
        }
    }

}
