namespace Test;

public class Light
{
    string state { get; set; }
    string room { get; set; }

    public Light(string state, string room)
    {
        this.state = state;
        this.room = room;
    }

    public string toggle()
    {
        
    }
}