
using System;


Cliente pessoaJuridica = new Cliente("Oz Ozborne", DateTime.Parse("2001-01-07"), "Técnico em Saneamento", "solteiro", tipoPessoa.JURIDICA);

ContaEmpresarial contaJuridica = new ContaEmpresarial(2304, 1204, pessoaJuridica, 1800, 10, "12312456457897");

contaJuridica.FazerEmprestimo(1350);
contaJuridica.Depositar(350);
contaJuridica.ExibirSaldo();
contaJuridica.PagarEmprestimo();
contaJuridica.ExibirSaldo();

Cliente pessoaFisica = new Cliente("Oz Ozborne", DateTime.Parse("2001-01-07"), "Técnico em Saneamento", "solteiro", tipoPessoa.FISICA);

ContaCorrente contaCorrente = new ContaCorrente(2304, 1204, pessoaFisica);

contaCorrente.Depositar(350);
contaCorrente.Sacar(50);
contaCorrente.ExibirSaldo();

ContaPoupanca contaPoupanca = new ContaPoupanca(2304, 1204, pessoaFisica);

contaPoupanca.Depositar(350);
contaPoupanca.Transferir(contaCorrente, 50);
contaPoupanca.ExibirSaldo();