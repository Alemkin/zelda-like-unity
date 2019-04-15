using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform Target;
    public float Smoothing;
    public Vector2 MaxPosition;
    public Vector2 MinPosition;

    // Start is called before the first frame update
    void Start () {
        
    }

    // LateUpdate is called once per frame last
    void LateUpdate () {
        if (transform.position != Target.position) {
            Vector3 targetPosition = new Vector3(Target.position.x, Target.position.y, transform.position.z);
            targetPosition.x = Mathf.Clamp(targetPosition.x, MinPosition.x, MaxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, MinPosition.y, MaxPosition.y);
            transform.position = Vector3.Lerp(transform.position, targetPosition, Smoothing);
        }
    }
}
