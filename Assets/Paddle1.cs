using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(Vector2.up * Time.deltaTime * 5f);
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(Vector2.down * Time.deltaTime * 5f);
        }
    }
}
