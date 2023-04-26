using Relaciones;
namespace Relaciones.Models;
public class Musica 
{
  public int idMusica {get; set;}
  public string Nombre {get; set;}
  public List <Album> Albums{get;}= new List<Album>();

}
