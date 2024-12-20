using UnityEngine;
public class PlayButton : MonoBehaviour
{
    public GameObject difficultyMenu;
    public AudioSource Play;
    public AudioClip playSound;

    public void OnPlayButton()
    {
        Play.clip = playSound;
        Play.Play();
        difficultyMenu.SetActive(true);
        
    }

}