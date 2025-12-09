using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector2.up * Time.deltaTime * 5f);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            transform.Translate(Vector2.down * Time.deltaTime * 5f);
        }

    }
}
