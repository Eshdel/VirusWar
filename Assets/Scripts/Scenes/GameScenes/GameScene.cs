using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameScene : Scene
{
    private List<Player> _players;

    [SerializeField] private InputHandler inputHandler;

    public void AddPlayer(Player player) {
        _players.Add(player);
    }

    public void RemovePlayer(Player player)
    {
        _players.Remove(player);
    }

    public void RemovePlayerAt(int index)
    {
        _players.RemoveAt(index);
    }
}
