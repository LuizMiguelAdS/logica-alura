class ContaBancaria
{
    public int id;
    public string titular;
    public double saldo;
    public string senha;


 public exibirSaldo(testSenha, testId){
    if (id == testId && testSenha == senha){
        console.WriteLine("A conta "+titular+" possui "+saldo+" em sua conta");
    }else{
        console.WriteLine("Dados incorretos")
    }

}

}