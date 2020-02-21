using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerName : MonoBehaviour
{
    [SerializeField]
    public GameManager gameManager;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        player.Name = gameManager.player.Name;
    }
}
