using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public static MenuUIHandler Instance;
    public string name;
    public UnityEngine.UI.InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {

        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        if (!inputField.text.Equals("")) {
            name = inputField.text;
        } else {
            name = "Player";
        }

        SceneManager.LoadScene(1);
    }

    public void DeleteScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }

}
