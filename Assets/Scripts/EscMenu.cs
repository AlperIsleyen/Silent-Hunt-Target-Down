using UnityEngine;

public class EscMenu : MonoBehaviour
{
    public GameObject quitButton;
    public GameObject menuButton;
    public bool check = false;
    public FirstPersonController cameraa;
    public Weapon weapon;
    public AudioSource music;
    public AudioSource ambience;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (check)
            {
                quitButton.SetActive(!check);
                menuButton.SetActive(!check);
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                music.UnPause();
                ambience.UnPause();
                cameraa.enabled = true;
                weapon.enabled = true;
                check = !check;
            }
            else
            {
                quitButton.SetActive(!check);
                menuButton.SetActive(!check);
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                music.Pause();
                ambience.Pause();
                cameraa.enabled = false;
                weapon.enabled = false;
                check = !check;
            }
        }
    }
}

