using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript2 : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
      public GameObject helpPanel;

    public void GameStart()
    {
        SceneManager.LoadScene("PlayScene_Door1");
    }

    public void GameEXIT()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }

    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }
}
