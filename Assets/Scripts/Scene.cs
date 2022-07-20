using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    [Header("Menu du jeu (actif au lancement)")]
    [Tooltip("On référence l'interface utilisateur du menu")]
    public GameObject menu;
    [Header("Bouton retour (inactif au lancement)")]
    [Tooltip("On référence le bouton retour")]
    public GameObject retour;
    [Header("Mini-carte (inactif au lancement)")]
    [Tooltip("On référence la mini-carte")]
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
