using TP03;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Cliente tempC = new Cliente(1, "cliente", "somwhre", "xd", 5);
Pedido temp = new Pedido(5, "a", tempC);

Cadeteria.CambiarEstado(temp);