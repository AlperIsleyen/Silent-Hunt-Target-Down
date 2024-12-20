public class PlayButton : MonoBehaviour
{
    public GameObject difficultyMenu;
    public AudioSource Play;

    public void OnPlayButton()
    {
        difficultyMenu.SetActive(true);
        Play.Play();
    }

}