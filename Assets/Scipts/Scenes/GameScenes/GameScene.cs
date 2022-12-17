using System.Collections.Generic;

public abstract class GameScene : Scene
{
    private List<Player> _players;

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
