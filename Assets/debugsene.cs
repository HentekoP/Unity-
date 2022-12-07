using UnityEngine;
using UnityEngine.SceneManagement;

public class debugsene : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("game");
        }
    }
}