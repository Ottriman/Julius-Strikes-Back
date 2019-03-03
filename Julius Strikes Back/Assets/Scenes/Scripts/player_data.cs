
[System.Serializable]
public class player_data {

    public int level;
    public int crosses_smashed;
    public int ceasars;
    public string file_name;

    public player_data(player player_chosen)
    {
        level = player_chosen.level;
        crosses_smashed = player_chosen.crosses;
        ceasars = player_chosen.num_players;
        file_name = player_chosen.file_name;
    }
}
