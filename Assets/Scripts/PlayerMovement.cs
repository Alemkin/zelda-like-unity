using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D _playerRigidBody;
    private Vector3 _change;
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start () {
        _playerRigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        _change = Vector3.zero;
        _change.x = Input.GetAxisRaw("Horizontal");
        _change.y = Input.GetAxisRaw("Vertical");
        UpdateAnimationAndMove();
    }


    void UpdateAnimationAndMove () {
        if (_change != Vector3.zero)
        {
            MoveCharacter();
            _animator.SetFloat("moveX", _change.x);
            _animator.SetFloat("moveY", _change.y);
            _animator.SetBool("isMoving", true);
        }
        else
        {
            _animator.SetBool("isMoving", false);
        }
    }

    void MoveCharacter () {
        Vector2 newPosition = transform.position + (_change * Speed * Time.deltaTime);
        _playerRigidBody.MovePosition(newPosition);
    }
}
