using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaDeFase : MonoBehaviour
{
    public string Fase2; // Nome da próxima cena
    private bool podeInteragir = false;

    void Update()
    {
        if (podeInteragir && Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene(Fase2);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            podeInteragir = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            podeInteragir = false;
        }
    }
}
