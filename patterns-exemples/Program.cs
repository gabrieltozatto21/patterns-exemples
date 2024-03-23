using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace patterns_exemples
{
    class Program
    {
        public class ChaveValor
        {
            [JsonPropertyName("chave")]
            public string Chave { get; set; }
            [JsonPropertyName("valor")]
            public string Valor { get; set; }

        }
        public class EntidadeTeste
        {
            [JsonPropertyName("chave")]
            public string Nome { get; set; }

        }
        static void Main(string[] args)
        {
            string json = "{\"chave\": \"Nome\",\"valor\": \"Gabriel\"}";

            ChaveValor dicionario = JsonSerializer.Deserialize<ChaveValor>(json);

            //EntidadeTeste entidade = new EntidadeTeste();

            Type tipo = Type.GetType("patterns_exemples.Program+EntidadeTeste");

            object instanciaCliente = Activator.CreateInstance(tipo);

            var propriedade = tipo.GetProperty(dicionario.Chave);

            propriedade.SetValue(instanciaCliente, dicionario.Valor);

        }
    }
}
