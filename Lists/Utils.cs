using ListasExemplos;

public static class Utils
{
    public static void VoltarMenu()
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        Menu.Show();
    }
}
