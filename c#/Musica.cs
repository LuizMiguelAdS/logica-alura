class musica
{
    public string Nome{get;set;};;
    public Banda Artista{get;set;};;
    public int Duracao{get;set;};;
    private bool Disponivel{get;set;};
    public string DescricaoResumida => return $"A Musica {Nome} pertence a banda {Artista}"; //lambda

    // public void escreverDisponivel(bool value){
    //     disponivel = value;
    // }
    // public void lerDisponivel(){
    //     return disponivel;  
    // }

    public void exibirFichaTecnica()
    {
        cosole.WriteLine(musica);
        cosole.WriteLine(musica.Nome);
        cosole.WriteLine(musica.Artista);
        cosole.WriteLine(musica.Duracao);
        cosole.WriteLine(musica.Disponivel);

        if(disponivel){
            Console.WriteLine("disponivel no plano");
        }else{
            Console.WriteLine("Adiquira o plano plus");
        }
    }
}
