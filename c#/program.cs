Console.WriteLine("hello word")

Musica musica = new Musica();
musica.Nome = "Oh garrafa";
musica.Artista = "confraria da costa";
musica Duracao = 5;
musica.escreverDisponivel(true);

Musica musica2 = new Musica();
musica2.Nome = "Qualquer um";
musica2.Artista = "confraria da costa";
musica2 Duracao = 5;
musica2.escreverDisponivel(false);


musica.exibirFichaTecnica();
musica2.exibirFichaTecnica();



ContaBancaria contBank = new ContaBancaria();
contBank.id = 1234567865432;
contBank.titular= "Raimundo Nonato";
contBank.saldo = 1254854.01;
contBank.senha = "STx!*#183";
contBank.exibirSaldo("STx!*#183", 1234567865432);

ContaBancaria contBank2 = new ContaBancaria();
contBank.id = 1234567865432;
contBank.titular= "Raimundo Nonato";
contBank.saldo = 1254854.01;
contBank.senha = "STx!*#183";
contBank.exibirSaldo("xTx!*#183", 1234567865432);



// EscolaDoRock filme1 = new EscolaDoRock();
// filme1.Titulo = "Escola do Rock";
// filme1.AnoLancamento = 2003;
// filme1.ExibirInformacoes();

Album AlbumConfrariaDaCosta = new Album();
AlbumConfrariaDaCosta.Nome = "Balada pirata";
AlbumConfrariaDaCosta.AdicionarMusica(musica);
AlbumConfrariaDaCosta.AdicionarMusica(musica2);


Banda banda1 = new Banda();
banda1.Nome = "Confraria da costa";
banda1.AdicionarAlbum(AlbumConfrariaDaCosta);

banda1.ExibirDiscografia
