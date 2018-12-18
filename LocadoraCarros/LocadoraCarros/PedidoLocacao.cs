using System;

namespace BethesdaCarRental1
{
    [Serializable]
    public class PedidoLocacao
    {
        public string NumeroEmpregado;
        // A seguinte flag permite atualiza/saber se
        // * O carro esta sendo usado pelo cliente
        // * O cliente devolveu o veiculo locado
        public string StatusPedido;
        // Cada carro possui um n�mero de registro
        // e esse n�mero n�o muda
        // durante o tempo de vida do veiculo
        public string NumeroCarro;
        // O cliente ser� identificado pelo numero da CNH e o nome na sua CNH
        public string NumeroCNHCliente;
        public string NomeCliente;
        // Embora o numero da CNH do cliente n�o mude
        // O seu endere�o pode mudar durante as loca��es que ele pode fazer
        // Por isso, embora seja retornado o endere�o dalista de clientes
        // � permitido ao empregado alterar esta informa��o no pedido de loca��o
        // Assim o mesmo cliente pode ter endere�o diferente em loca�oes feitas
        // Por isso, cada pedido de loca��o tera sua propria informa��o sobre o cliente
        public string EnderecoCliente;
        public string CidadeCliente;
        public string EstadoCliente;
        public string CepCliente;
        public string EstadoDoVeiculo;
        public string NivelTanque;
        // Informa��o registrada quando do inicio da loca��o do veiculo
        public int MilhagemInicial;
        // Informa��o registrada quando o ve�culo � retornado pelo cliente
        public int MilhagemFinal;
        // Informa��o registrada quando do inicio da loca��o do veiculo
        public DateTime DataInicio;
        // Informa��o registrada quando o ve�culo � retornado pelo cliente
        public DateTime DataFinal;
        public int Dias;
        // Informa��o registrada quando do inicio da loca��o do veiculo
        public double TaxaAplicada;
        // O calculo ser� feito quando o carro � trazido de volta pelo cliente
        public double SubTotal;
        public double TaxaImposto;
        public double ValorImposto;
        public double ValorTotal;

        public PedidoLocacao()
        {
        }
    }
}
