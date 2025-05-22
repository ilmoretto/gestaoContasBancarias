ContaEmpresarial c1 = new ContaEmpresarial();
c1.setLimiteEmprestimo(1000);

c1.Sacar(6000);
Console.WriteLine("Saldo: " + c1.getSaldo());
