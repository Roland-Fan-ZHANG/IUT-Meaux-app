using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public GameObject menu;
    public GameObject retour;
    public GameObject minimap;

    public void VisiteVirtuelle()
    {
        menu.SetActive(false);
        minimap.SetActive(true);
        retour.SetActive(true);

    }

    public void Retour()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
