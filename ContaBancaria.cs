using System.ComponentModel;

public class Conta
{
    private int nConta;
    private string agencia;
    private string titular;
    protected double saldo;


    public Conta() { }

    public Conta(int nConta, string agencia, string titular)
    {
        setAgencia(agencia);
        setNConta(nConta);
        setTitular(titular);
    }

    public void setNConta(int nConta)
    {
        this.nConta = nConta;
    }
    public int getNconta()
    {
        return nConta;
    }
    public void setAgencia(string agencia)
    {
        this.agencia = agencia;
    }
    public string getAgencia()
    {
        return agencia;
    }
    public void setTitular(string titular)
    {
        if (titular.Length < 3)
        {
            throw new Exception("Nome do titular deve ter mais de 3 caracteres");
        }

        this.titular = titular;
    }
    public string getTitular()
    {
        return titular;
    }

    public double getSaldo()
    {
        return saldo;
    }

    public virtual void Sacar(double valor) //método para sacar
    {
        if (valor > saldo)
        {
            throw new Exception("Saldo insuficiente");
        }
        else if (valor < 0)
        {
            throw new Exception("O valor do saque não pode ser negativo");
        }
        else
        {
            saldo -= valor;
        }
    }

    public virtual void Depositar(double valor) //método para depositar
    {
        if (valor < 0)
        {
            throw new Exception("Valor inválido!");
        }
        else
        {
            saldo += valor;
        }

    }
}