public class ContaEstudante : Conta
{
    private double limiteChequeEspecial;
    private string cpf;
    private string nomeInstituicao;


    public ContaEstudante(int nConta){
    
    }

    public ContaEstudante(int nConta, string agencia, string titular, double saldo, double limiteChequeEspecial, string cpf, string nomeInstituicao)
            :base(nConta, agencia, titular, saldo)
    {
        setLimiteChequeEspecial(limiteChequeEspecial);
        setCPf(cpf);
        setNomeInstituicao(nomeInstituicao);
    }


    public void setLimiteChequeEspecial(double limiteChequeEspecial)
    {
        if (limiteChequeEspecial < 0)
        {
            throw new Exception("Limite de cheque especial não pode ser negativo");
        }
        else
        {
            this.limiteChequeEspecial = limiteChequeEspecial;

        }

    }
    public double getLimiteChequeEspecial()
    {
        return limiteChequeEspecial;
    }
    public void setCPf(string cpf)
    {
        if (cpf.Length != 11)
        {
            throw new Exception("CPF Inválido");
        }
        else
        {
            this.cpf = cpf;
        }
    }
    public string getCpf()
    {
        return cpf;
    }

    public void setNomeInstituicao(string nomeInstituicao)
    {
        if (nomeInstituicao.Length < 3)
        {
            throw new Exception("Nome da instituição deve ter mais de 3 caracteres");
        }
        else
        {
            this.nomeInstituicao = nomeInstituicao;
        }

    }
    public string getNomeInstiuicao()
    {
        return nomeInstituicao;
    }

    public override void Sacar(double valor)
    {
        if (valor > saldo + limiteChequeEspecial)
        {
            throw new Exception("Saldo insuficiente");
        }
        else
        {
            saldo -= valor;
        }
    }


}