using UnityEngine;
using UnityEngine.SceneManagement;

public class TapStart : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        //Invoke("ChangeScene", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}