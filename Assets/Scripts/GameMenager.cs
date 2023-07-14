using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenager : MonoBehaviour
{
    float timer;
    public GameObject catcosSpawnPos;
    public GameObject Cactus;
    public float catcosSpawnTime;
    public GameObject gameOverScene;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > catcosSpawnTime)
        {
            Instantiate(Cactus,catcosSpawnPos.transform);
            timer = 0;
            
        }
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverScene.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("lv1");
    }
}
