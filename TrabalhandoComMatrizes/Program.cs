/*string [] pedidoFraudeIDs = new string [3];

pedidoFraudeIDs[0] = "A123";
pedidoFraudeIDs[1] = "B456";
pedidoFraudeIDs[2] = "C789";
//pedidoFraudeIDs[3] = "D000";

Console.WriteLine($"Primeiro: {pedidoFraudeIDs[0]}");

pedidoFraudeIDs[0] = "F000";

Console.WriteLine($"Reatribuição do valor: {pedidoFraudeIDs[0]}");*/

string[] pedidosFraudulentosIDs = ["A123", "B456", "C789"];

Console.WriteLine(pedidosFraudulentosIDs [2]);

Console.WriteLine($"Existem {pedidosFraudulentosIDs.Length} pedidos fraudados para processar!");

foreach (string pedido in pedidosFraudulentosIDs){
    Console.WriteLine(pedido);
}