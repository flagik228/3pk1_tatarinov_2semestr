{
    Adapter adapter = new Adapter();
    Client client = new Client(adapter);
    client.Show();


}
class Original
{
    public void OriginalDouble(double a)
    {
        Console.WriteLine($"Вывод числа double: {a}");
    }
    public void OriginalInt(int b)
    {
        Console.WriteLine($"Вывод числа int: {b}");
    }
    public void OriginalChar(char c)
    {
        Console.WriteLine($"Вывод символа 5 раз: {c}");
    }
}
interface ITarget
{
    void ClientDouble(double a);
    void ClientInt(int b);
    void ClientChar(char c);
}
class Adapter : Original, ITarget
{
    public void ClientDouble(double a)
    {
        OriginalDouble(a);
    }

    public void ClientInt(int b)
    {
        OriginalInt(b * 2);
    }

    public void ClientChar(char c)
    {
        for (int i = 0; i <= 4; i++)
        {
            OriginalChar(c);
        }

    }
}
class Client
{
    private ITarget client;

    public Client(ITarget _client)
    {
        client = _client;
    }
    public void Show()
    {
        client.ClientDouble(12.32);
        client.ClientInt(123);
        client.ClientChar('A');
    }
}