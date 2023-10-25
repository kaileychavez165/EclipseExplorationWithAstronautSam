using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private BoxCollider2D _boxColl;
    private SpriteRenderer _sprite;
    //private Animator _animate;
     private Animator _animate;
    [SerializeField] private LayerMask JumpGround;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
     private enum movementState {idle, running, jumping, falling}
    private float _xDir;
    private float _yDir;

   public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
         _rb = GetComponent<Rigidbody2D>();
        _boxColl = GetComponent<BoxCollider2D>();
        _sprite = GetComponent<SpriteRenderer>();
        _animate = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _xDir = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(_xDir * moveSpeed, _rb.velocity.y);

        //Jump Code
        if (Input.GetButtonDown("Jump") && onGround())
        {
            _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
        }
        charAnimator();
}
void charAnimator()
    {
        _yDir = _rb.velocity.y;
        movementState state;

        switch (_xDir)
        {
            case > 0f:
                state = movementState.running;
                _sprite.flipX = true;
                break;
            case < 0f:
                state = movementState.running;
                _sprite.flipX = false;
                break;
            default:
                state = movementState.idle;
                break;
        }

        switch (_yDir)
        {
            case > .1f:
                state = movementState.jumping;
                break;
            case < -.1f:
                state = movementState.falling;
                break;
        }

        _animate.SetInteger("AnimationState", (int)state);
    }

    bool onGround()
    {
        return Physics2D.BoxCast(_boxColl.bounds.center, _boxColl.bounds.size, 0f, Vector2.down, .1f, JumpGround);
    }
}

    
