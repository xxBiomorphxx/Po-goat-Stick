using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Character2DController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    public float MovementSpeed = 1 ;
    public float JumpForce = 1;
    private Rigidbody2D _rigidbody;

    int score = 0;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        Vector3 characterScale = transform.localScale;

        if (Input.GetAxis("Horizontal") < 0 )
        {
            characterScale.x = -0.3f;
        }

        if (Input.GetAxis("Horizontal") > 0 )
        {
            characterScale.x = 0.3f;
        }

        transform.localScale = characterScale;
        
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.0001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }

        if (_rigidbody.position.y < -5f)
        {
            SceneManager.LoadScene(2);
        }
    }
    
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "pointTrigger")
        {
            score ++;
            scoreText.text = score.ToString();
        }
    }

}
