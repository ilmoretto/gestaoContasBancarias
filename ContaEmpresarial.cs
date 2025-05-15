public class ContaEmpresarial : Conta
{
    private double anuidade;
    private double limiteEmprestimo;
    private double totalEmprestimo;


    public ContaEmpresarial() { }

    public ContaEmpresarial(int nConta, string agencia, string titular, double saldo, double anuidade, double limiteEmprestimo, double totalEmprestimo)
        : base(nConta, agencia, titular, saldo)
    {
        setSaldo(saldo);
        setAnuidade(anuidade);
        setLimiteEmprestimo(limiteEmprestimo);
        setTotalEmprestimo(totalEmprestimo);

    }

    public void setAnuidade(double anuidade)
    {
        if (anuidade < 0)
        {
            throw new Exception("Anuidade não pode ser negativa");
        }
        else
        {
            this.anuidade = anuidade;
        }

    }
    public double getAnuidade()
    {
        return anuidade;
    }
    public void setLimiteEmprestimo(double limiteEmprestimo)
    {
        if (limiteEmprestimo < 0)
        {
            throw new Exception("Limite de empréstimo não pode ser negativo");
        }
        else
        {
            this.limiteEmprestimo = limiteEmprestimo;
        }

    }
    public double getLimiteEmprestimo()
    {
        return limiteEmprestimo;
    }
    public void setTotalEmprestimo(double totalEmprestimo)
    {
        if (totalEmprestimo < 0)
        {
            throw new Exception("Total de empréstimo não pode ser negativo");
        }
        else
        {
            this.totalEmprestimo = totalEmprestimo;
        }
    }
    public double getTotalEmprestimo()
    {
        return totalEmprestimo;
    }

    public override void Sacar(double valor)
    {
        double taxaSaque = 5;
        if (valor > saldo)
        {
            throw new Exception("Saldo insuficiente");
        }
        if (valor > 5000)
        {
            valor -= taxaSaque;
            saldo -= valor;

            Console.WriteLine("Saque realizado!");
        }


    }
    public void FazerEmprestimo(double valor)
    {
        if (valor > limiteEmprestimo)
        {
            throw new Exception("O valor de empréstimo não pode ser concedido.");
        }
        else if (valor <= 0)
        {
            throw new Exception("O valor de empréstimo não pode ser negativo.");
        }
        else
        {
            totalEmprestimo += valor;
            saldo += valor;
            Console.WriteLine("Empréstimo realizado!");
        }

    }


}