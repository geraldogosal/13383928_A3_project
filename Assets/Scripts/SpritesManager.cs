using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesManager : MonoBehaviour
{
    [SerializeField] GameObject Pacman = null;
    [SerializeField] GameObject GhostBlue = null;
    [SerializeField] GameObject GhostRed = null;
    [SerializeField] GameObject GhostPurple = null;
    [SerializeField] GameObject GhostOrange = null;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Pacman, new Vector3(1.0f, -1.0f, 0.0f), Quaternion.identity);
        Instantiate(GhostBlue, new Vector3(11.0f, -14.0f, 0.0f), Quaternion.identity);
        Instantiate(GhostRed, new Vector3(12.6f, -14.0f, 0.0f), Quaternion.identity);
        Instantiate(GhostOrange, new Vector3(14.2f, -14.0f, 0.0f), Quaternion.identity);
        Instantiate(GhostPurple, new Vector3(16.0f, -14.0f, 0.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
