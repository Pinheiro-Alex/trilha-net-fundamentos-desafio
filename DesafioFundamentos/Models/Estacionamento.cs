namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTADO
            Console.WriteLine("\nDigite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpper();

            veiculos.Add(placa);

            Console.WriteLine("\nVeículo adicionado com sucesso.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper();
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTADO
            //string placa = "";

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = int.Parse(Console.ReadLine());
                
                // *IMPLEMENTADO
                decimal valorTotal = this.precoInicial + (this.precoPorHora * horas);

                // *IMPLEMENTADO

                veiculos.Remove(placa);

                Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}\n");
            }
            else
            {
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente\n");
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("\nVeículos no estacionamento.\n");
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("\nOs veículos estacionados são:");
                // *IMPLEMENTADO
                
                foreach(var placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.\n");
            }
        }
    }
}
