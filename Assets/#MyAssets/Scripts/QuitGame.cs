using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    [SerializeField]
    Button quitButton;

    private void Start()
    {
        quitButton.onClick.AddListener(QuitTheGame);
    }

    private void QuitTheGame()
    {
        Application.Quit();
    }
}
