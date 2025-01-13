using UnityEngine;

public class P1 : MonoBehaviour
{
    public float MoveSpeed;
    bool Paused = false;
    public GameObject pausescreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        bool isPressingUp = Input.GetKey(KeyCode.W);
        bool isPressingDown = Input.GetKey(KeyCode.S);
        bool isPressingSpace = Input.GetKeyDown(KeyCode.Space); 
        if(isPressingUp){
            transform.Translate(Vector2.up *Time.deltaTime * MoveSpeed);
        }
        if(isPressingDown){
            transform.Translate(Vector2.down *Time.deltaTime * MoveSpeed);
        }
        if(isPressingSpace){
            Paused = !Paused;
            Time.timeScale = Paused ? 0 : 1;
            pausescreen.SetActive(!pausescreen.activeSelf);
        }
        if(Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }

    }
}
