using System.Collections;
using UnityEngine;

public class SpawnFrienemy : MonoBehaviour
{
    public GameObject frienemySpecialPrefab;
    public GameObject frienemyPrefab;
    public float spawnT;
    private Vector2 screen;

    public void Start()
    {
        screen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,
            Camera.main.transform.position.z));
        StartCoroutine(frienemyWave());
    }

    private void FixedUpdate()
    {
        spawnT = Random.Range(0.4f, 0.7f);
    }

    private void spawnFrienemy()
    {
        GameObject a = Instantiate(frienemyPrefab);
        a.transform.position = new Vector2(screen.x * 1.5f, Random.Range(-4.4f, 4.4f));
    }

    private IEnumerator frienemyWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnT);
            spawnFrienemy();
        }
    }
}