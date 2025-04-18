using System.Text.Json.Serialization;

namespace WebApiFuncionariosCRUD.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepertamentoEnum
    {
        RH,
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria
    }
}
