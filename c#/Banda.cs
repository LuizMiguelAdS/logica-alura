class Banda
{
    private List<Album> listaAlbuns = new List<Album>();
    public string Nome { get; set; };

    public void AdicionarAlbum(Album album){
        listaAlbuns.add(album);
    }
    public void ExibirDiscografia(){
        console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in listaAlbuns)
        {
            console.WriteLine($"Album: {album.Nome} ({Album.Duracaototal})")
        }
    }
}