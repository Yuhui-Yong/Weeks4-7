using UnityEngine;
using UnityEngine.InputSystem;
public class DamageHazard : MonoBehaviour
{
    public Color damageColour;
    private Color playerColour;

    public Sprite Yuhui;
    public Sprite YuhuiDamage;

    public int damage;
    public Player player;

    private float speed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool leftArrowHeld = Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed;
        bool rightArrowHeld = Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed;
        bool upArrowHeld = Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed;
        bool downArrowHeld = Keyboard.current.downArrowKey.isPressed || Keyboard.current.sKey.isPressed;

        if (leftArrowHeld)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

        if (rightArrowHeld)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        if (upArrowHeld)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }

        if (downArrowHeld)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
    }

    public void ApplyDamage()
    {
        player.TakeDamage(damage);
    }

    public void ChangePlayerColor()
    {
        SpriteRenderer playerRenderer = player.GetComponent<SpriteRenderer>();
        playerColour = playerRenderer.color;
        playerRenderer.color = damageColour;
    }

    public void OriginalPlayerColour()
    {
        SpriteRenderer playerRenderer = player.GetComponent<SpriteRenderer>();
        playerRenderer.color = playerColour;
    }

    public void ChangeYuhuiSprite()
    {
        SpriteRenderer playerRenderer = player.GetComponent<SpriteRenderer>();
        Yuhui = playerRenderer.sprite;
        playerRenderer.sprite = YuhuiDamage;
    }

    public void OriginalYuhuiSprite()
    {
        SpriteRenderer playerRenderer = player.GetComponent<SpriteRenderer>();
        playerRenderer.sprite = Yuhui;
    }

    // To Store the object that spawn everytime players click the UI button, I had to use a "List".

}